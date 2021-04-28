namespace Blackjack
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlDealer = new System.Windows.Forms.Panel();
            this.lblDealerSum = new System.Windows.Forms.Label();
            this.lblDealer = new System.Windows.Forms.Label();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblPlayerSum = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tmDelay = new System.Windows.Forms.Timer(this.components);
            this.lblpPayerName = new System.Windows.Forms.Label();
            this.pnlDealer.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDealer
            // 
            this.pnlDealer.Controls.Add(this.lblDealerSum);
            this.pnlDealer.Controls.Add(this.lblDealer);
            this.pnlDealer.Location = new System.Drawing.Point(13, 59);
            this.pnlDealer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDealer.Name = "pnlDealer";
            this.pnlDealer.Size = new System.Drawing.Size(1035, 208);
            this.pnlDealer.TabIndex = 0;
            // 
            // lblDealerSum
            // 
            this.lblDealerSum.AutoSize = true;
            this.lblDealerSum.Location = new System.Drawing.Point(224, 90);
            this.lblDealerSum.Name = "lblDealerSum";
            this.lblDealerSum.Size = new System.Drawing.Size(0, 17);
            this.lblDealerSum.TabIndex = 2;
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Location = new System.Drawing.Point(473, 90);
            this.lblDealer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(0, 17);
            this.lblDealer.TabIndex = 0;
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.lblPlayerSum);
            this.pnlUser.Controls.Add(this.lblUser);
            this.pnlUser.Location = new System.Drawing.Point(13, 375);
            this.pnlUser.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(1035, 208);
            this.pnlUser.TabIndex = 1;
            // 
            // lblPlayerSum
            // 
            this.lblPlayerSum.AutoSize = true;
            this.lblPlayerSum.Location = new System.Drawing.Point(224, 101);
            this.lblPlayerSum.Name = "lblPlayerSum";
            this.lblPlayerSum.Size = new System.Drawing.Size(0, 17);
            this.lblPlayerSum.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(473, 101);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 17);
            this.lblUser.TabIndex = 1;
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.Honeydew;
            this.btnHit.Location = new System.Drawing.Point(184, 299);
            this.btnHit.Margin = new System.Windows.Forms.Padding(4);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(137, 47);
            this.btnHit.TabIndex = 2;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Click += new System.EventHandler(this.BtnHit_Click);
            // 
            // btnStay
            // 
            this.btnStay.BackColor = System.Drawing.Color.Honeydew;
            this.btnStay.Location = new System.Drawing.Point(468, 299);
            this.btnStay.Margin = new System.Windows.Forms.Padding(4);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(137, 47);
            this.btnStay.TabIndex = 3;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = false;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Honeydew;
            this.btnReset.Location = new System.Drawing.Point(732, 299);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(137, 47);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset Game";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // tmDelay
            // 
            this.tmDelay.Tick += new System.EventHandler(this.tmDelay_Tick);
            // 
            // lblpPayerName
            // 
            this.lblpPayerName.AutoSize = true;
            this.lblpPayerName.Font = new System.Drawing.Font("Castellar", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpPayerName.Location = new System.Drawing.Point(483, 21);
            this.lblpPayerName.Name = "lblpPayerName";
            this.lblpPayerName.Size = new System.Drawing.Size(0, 34);
            this.lblpPayerName.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1076, 610);
            this.Controls.Add(this.lblpPayerName);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.pnlDealer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlDealer.ResumeLayout(false);
            this.pnlDealer.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDealer;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblPlayerSum;
        private System.Windows.Forms.Label lblDealerSum;
        private System.Windows.Forms.Timer tmDelay;
        private System.Windows.Forms.Label lblpPayerName;
    }
}

