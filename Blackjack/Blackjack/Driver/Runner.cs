using Blackjack.Models;
using Blackjack.Util;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Blackjack
{
    public class Runner
    {
        public string PlayerName { get; set; }
        public int Delay { get; set; }
        public int cardSum = 0;
        public Runner(string PlayerName, int Delay)
        {
            this.PlayerName = PlayerName;
            this.Delay = Delay;
        }
        public bool Start(Deck currentDeck, Dealer dealer, Player player, Label lblUser, Label lblDealer, Label lblPlayerSum)
        {
            if (currentDeck.CardStack.Count() < 10)     //Kullanilan destede yeterli sayida kart yok ise deste yenilenmelidir.
            {
                MessageBox.Show("The deck is refreshing...");
                currentDeck = DeckCreator.CreateDecks();
            }

            /*
             * Dealer icin ilk kart eklenir.
             */

            #region Dealer_First_Hand
            AddCartToDealer(currentDeck, dealer, true);
            #endregion Dealer_First_Hand

            /*
             * Player icin ilk kart eklenir.
             */

            #region Player_First_Hand
            AddCartToPlayer(currentDeck, player);
            #endregion Player_First_Hand

            /*
             * Dealer icin ikinci kart eklenir.
             */

            #region Dealer_Second_Hand
            AddCartToDealer(currentDeck, dealer);
            #endregion Dealer_Second_Hand

            /*
             * Player icin ikinci kart eklenir.
             */

            #region Dealer_Second_Hand
            AddCartToPlayer(currentDeck, player);
            #endregion Dealer_Second_Hand

            string DealerText = String.Empty;
            cardSum = 0;
            if (dealer.CardList.Where(x => x.Hidden).FirstOrDefault() != null)
            {
                DealerText = "?-";      //Dealerin ilk karti player tarafindan bilinmemeli.
            }

            /*
             * Dealer ve playerin kartlari kendi kart listelerine eklenir.
             */

            DealerText += String.Join("-", dealer.CardList.Where(x => !x.Hidden).Select(x => x.Name).ToList());
            lblDealer.Text = DealerText;
            lblUser.Text = String.Join("-", player.CardList.Select(x => x.Name).ToList());

            /*
             * Oyun onceligi playerda oldugu icin playerin kartlarinin degerleri kontrol edilmek icin toplanır.
             */
            lblPlayerSum.Text = player.CardList.Select(x => x.Value).Sum().ToString();

            return IsWonOrLose(player);     // Oyunun devami icin kontrol yapilir.
        }

        public bool Hit(Deck currentDeck, Player player, Label lblPlayer, Label lblPlayerSum)
        {
            /*
             * Player yeni bir kart ceker ve kart listesine eklenir.
             * Kartlarinin degerleri toplanir ve player icin ekrana yazdirilir.
             * Oyunun devami icin kontrol yapilir.
             */

            Card HitCard = AddCartToPlayer(currentDeck, player);
            lblPlayer.Text += ("-" + HitCard.Name);
            lblPlayerSum.Text = SumGamerCards(player).ToString();
            return IsWonOrLose(player);
        }
        public bool Stay(Deck currentDeck, Dealer dealer, Label lblDealer, Label lblDealerSum, Player player)
        {
            /*
            * Oyun sirasi dealera gecer, ? ile gösterilen kart ismi yerine acik ismi ekrana yazdirilir.
            * Kart degerleri toplamı 17'den kucuk olana kadar kart ceker ve kart listesine eklenir.
            * Kartlarinin degerleri toplanir ve ekrana yazdirilir.
            * Oyunun devami icin kontrol yapilir.
            */

            lblDealer.Text = lblDealer.Text.Replace("?", dealer.CardList.Where(x => x.Hidden).Select(x => x.Name).First().ToString());

            while (SumGamerCards(dealer) < 17)
            {
                Card HitCard = AddCartToDealer(currentDeck, dealer);
                lblDealer.Text += ("-" + HitCard.Name);
            }

            lblDealerSum.Text = SumGamerCards(dealer).ToString();

            return IsWonOrLose(dealer, player);
        }

        private Card AddCartToPlayer(Deck currentDeck, Player player)
        {
            /*
             * Deste icerisinde kart kalıp kalmadigi kontrol edilir, kalmadiysa yonlendirme yapilir.
             * Destede kart var ise stackten cikarilip playerin kart listesine eklenir.
             */

            Card card = new Card();
            if (currentDeck.CardStack.Count() != 0)
            {
                card = currentDeck.CardStack.Pop();
                player.CardList.Add(card);
            }
            else
            {
                MessageBox.Show("Reset Game!\nDeck is empty.");
            }
            return card;
        }

        private Card AddCartToDealer(Deck currentDeck, Dealer dealer, bool hidden = false)
        {
            /*
             * Deste icerisinde kart kalıp kalmadigi kontrol edilir, kalmadiysa yonlendirme yapilir.
             * Destede kart var ise stackten cikarilip dealerin kart listesine eklenir.
             */

            Card card = new Card();
            if (currentDeck.CardStack.Count() != 0)
            {
                card = currentDeck.CardStack.Pop();
                if (hidden)
                {
                    card.Hidden = true;
                }
                dealer.CardList.Add(card);
            }
            else
            {
                MessageBox.Show("Reset Game!\nDeck is empty.");
            }
            
            return card;
        }

        private bool IsWonOrLose(Gamer gamer)
        {
            /*
             * Burada oyun kontorlu yapilir.
             * Gamer icin kart listesindeki kartlarin degerleri toplanir.
             * Toplami eger 21den buyukse oyunu player kaybeder.
             * Toplam 21e esit ise player oyunu kazanir, degerler gosterilir.
             * Toplam 21den kucuk ise oyun devam eder.
             */

            int Sum = SumGamerCards(gamer); 
            if (Sum > 21)
            {
                MessageBox.Show(" Player lose!\n", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }
            else if (Sum == 21)
            {
                MessageBox.Show(" Player won!\n", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show(String.Join("-", gamer.CardList.Select(x => x.Name).ToArray()), "Winner Hands");
                return false;
            }

            return true;
        }

        private bool IsWonOrLose(Dealer dealer, Player player)
        {
          /*
           * Bu fonksiyon oyun sirasi dealera gectiginde kullanilir.(Stay)
           * Burada oyun kontorlu yapilir.
           * Dealer ve player icin kart listesindeki kartlarin degerleri toplanir.
           * Dealerin toplami eger 21den buyukse oyunu player kazanir.
           * Dealerin toplami 21e esit ise player oyunu kaybeder, degerler gosterilir.
           * Dealer ve playerin toplamlari esit ise oyun berabere 
           * Toplam 21den kucuk ise oyun devam eder.
           */

            int dealerSum = SumGamerCards(dealer);
            int playerSum = SumGamerCards(player);
            if (dealerSum > 21)
            {
                MessageBox.Show("Player won!\n", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show(String.Join("-", player.CardList.Select(x => x.Name).ToArray()), "Winner Hands");
                return false;
            }
            else if (dealerSum == 21)
            {
                MessageBox.Show("Player lose!\n", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show(String.Join("-", dealer.CardList.Select(x => x.Name).ToArray()), "Winner Hands");
                return false;
            }
            else if (Math.Abs((dealerSum - 21)) < (Math.Abs((playerSum - 21))))
            {
                MessageBox.Show("Player lose!\n", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show(String.Join("-", dealer.CardList.Select(x => x.Name).ToArray()), "Winner Hands");
                return false;
            }
            else if (Math.Abs((dealerSum - 21)) > (Math.Abs((playerSum - 21))))
            {
                MessageBox.Show("Player won!\n", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show(String.Join("-", player.CardList.Select(x => x.Name).ToArray()), "Winner Hands");
                return false;
            }
            else if (Math.Abs((dealerSum - 21)) == (Math.Abs((playerSum - 21))))
            {
                MessageBox.Show("Game draws!\n", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private int SumGamerCards(Gamer gamer)
        {
          /*
           * Gamerlar icin kart listelerindeki degerler toplanir.
           * Kart toplaminin 21den buyuk olmasina gore kart listesi kontrol edilir.
           * Toplami 21den buyuk ve destede degeri 11 olan (Ace) kart var ise degeri 1 sayilir. 
           */
            cardSum = gamer.CardList.Select(x => x.Value).Sum();

            if (cardSum > 21)
            {
                foreach (Card c in gamer.CardList)
                {
                    if (c.Value == 11)
                    {
                        cardSum -= 10;
                        if (cardSum <= 21)
                        {
                            break;
                        }
                    }
                }
            }
            return cardSum;
        }
    }
}