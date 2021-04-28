        /*
         *      Elif Esra Eker
         *      ekerelifesra@gmail.com
         */

using Blackjack.Models;
using Blackjack.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        Deck currentDeck;
        Player player;
        Dealer dealer;
        Runner runner;
        private string name;
        private int delayTime;
        private int temp;
        public Form1(string name, int delayTime)
        {
            InitializeComponent();
            this.name = name;
            this.delayTime = delayTime;
            lblpPayerName.Text = name;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            currentDeck = DeckCreator.CreateDecks();
            player = new Player(name);
            dealer = new Dealer();
            runner = new Runner(player.Name, delayTime);
            runner.Start(currentDeck, dealer,player, lblUser, lblDealer, lblPlayerSum);
        }
        private void BtnHit_Click(object sender, EventArgs e)
        {
            bool isValid = runner.Hit(currentDeck,player,lblUser,lblPlayerSum);
            
            if (!isValid)
            {
                ResetGame();
            }
        }

        private void ResetGame()
        {
            lblUser.Text = "";
            lblDealer.Text = "";
            lblPlayerSum.Text = "";
            lblDealerSum.Text = "";
            
            player.CardList.Clear();
            dealer.CardList.Clear();

            tmDelay.Interval = 1000;
            temp = delayTime;       //delayTime, tmDelay_Tick fonksiyonunda kullanilmak uzere temp degerine atanır.
            tmDelay.Start();
            btnHit.Enabled = false;
            btnReset.Enabled = false;
            btnStay.Enabled = false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            /*
             * Oyun resetlendigi icin yeni bir deste olusturulur.
             */

            currentDeck = DeckCreator.CreateDecks();
            ResetGame();
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            bool isValid = runner.Stay(currentDeck, dealer, lblDealer, lblDealerSum,player);

            if (!isValid)
            {
                ResetGame();
            }
        }

        private void tmDelay_Tick(object sender, EventArgs e)
        {
            temp--;
            this.Text = temp.ToString();

            if (temp==-1)
            {
                this.Text = "New Game!";
                tmDelay.Stop();
                btnHit.Enabled = true;
                btnReset.Enabled = true;
                btnStay.Enabled = true;
                runner.Start(currentDeck, dealer, player, lblUser, lblDealer, lblPlayerSum);
            }
        }
    }
}
