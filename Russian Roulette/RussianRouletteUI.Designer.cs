namespace Russian_Roulette
{
    partial class RussianRouletteUI
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
            this.btnFire = new System.Windows.Forms.Button();
            this.lblShotsLeft = new System.Windows.Forms.Label();
            this.lblDucksLeft = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.tbxShotsLeftDisplay = new System.Windows.Forms.TextBox();
            this.tbxDucksLeftDisplay = new System.Windows.Forms.TextBox();
            this.tbxWinsDisplay = new System.Windows.Forms.TextBox();
            this.tbxLossesDisplay = new System.Windows.Forms.TextBox();
            this.rbtnPointAtHead = new System.Windows.Forms.RadioButton();
            this.rbtnDuck = new System.Windows.Forms.RadioButton();
            this.lblDisplayPlayerName = new System.Windows.Forms.Label();
            this.btnLoadBullet = new System.Windows.Forms.Button();
            this.btnSpinChambers = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.lblDispalyResults = new System.Windows.Forms.Label();
            this.pbxPlayerAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayerAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.Location = new System.Drawing.Point(350, 482);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(292, 76);
            this.btnFire.TabIndex = 0;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // lblShotsLeft
            // 
            this.lblShotsLeft.AutoSize = true;
            this.lblShotsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShotsLeft.Location = new System.Drawing.Point(12, 7);
            this.lblShotsLeft.Name = "lblShotsLeft";
            this.lblShotsLeft.Size = new System.Drawing.Size(107, 24);
            this.lblShotsLeft.TabIndex = 1;
            this.lblShotsLeft.Text = "Shots Left:";
            // 
            // lblDucksLeft
            // 
            this.lblDucksLeft.AutoSize = true;
            this.lblDucksLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDucksLeft.Location = new System.Drawing.Point(270, 7);
            this.lblDucksLeft.Name = "lblDucksLeft";
            this.lblDucksLeft.Size = new System.Drawing.Size(112, 24);
            this.lblDucksLeft.TabIndex = 3;
            this.lblDucksLeft.Text = "Ducks Left:";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.Location = new System.Drawing.Point(530, 9);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(62, 24);
            this.lblWins.TabIndex = 8;
            this.lblWins.Text = "Wins:";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLosses.Location = new System.Drawing.Point(750, 5);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(81, 24);
            this.lblLosses.TabIndex = 6;
            this.lblLosses.Text = "Losses:";
            // 
            // tbxShotsLeftDisplay
            // 
            this.tbxShotsLeftDisplay.Enabled = false;
            this.tbxShotsLeftDisplay.Location = new System.Drawing.Point(125, 7);
            this.tbxShotsLeftDisplay.Name = "tbxShotsLeftDisplay";
            this.tbxShotsLeftDisplay.Size = new System.Drawing.Size(100, 22);
            this.tbxShotsLeftDisplay.TabIndex = 9;
            this.tbxShotsLeftDisplay.Text = "0";
            // 
            // tbxDucksLeftDisplay
            // 
            this.tbxDucksLeftDisplay.Enabled = false;
            this.tbxDucksLeftDisplay.Location = new System.Drawing.Point(388, 9);
            this.tbxDucksLeftDisplay.Name = "tbxDucksLeftDisplay";
            this.tbxDucksLeftDisplay.Size = new System.Drawing.Size(100, 22);
            this.tbxDucksLeftDisplay.TabIndex = 10;
            this.tbxDucksLeftDisplay.Text = "0";
            // 
            // tbxWinsDisplay
            // 
            this.tbxWinsDisplay.Enabled = false;
            this.tbxWinsDisplay.Location = new System.Drawing.Point(598, 7);
            this.tbxWinsDisplay.Name = "tbxWinsDisplay";
            this.tbxWinsDisplay.Size = new System.Drawing.Size(100, 22);
            this.tbxWinsDisplay.TabIndex = 11;
            this.tbxWinsDisplay.Text = "0";
            // 
            // tbxLossesDisplay
            // 
            this.tbxLossesDisplay.Enabled = false;
            this.tbxLossesDisplay.Location = new System.Drawing.Point(837, 9);
            this.tbxLossesDisplay.Name = "tbxLossesDisplay";
            this.tbxLossesDisplay.Size = new System.Drawing.Size(100, 22);
            this.tbxLossesDisplay.TabIndex = 12;
            this.tbxLossesDisplay.Text = "0";
            // 
            // rbtnPointAtHead
            // 
            this.rbtnPointAtHead.AutoSize = true;
            this.rbtnPointAtHead.Location = new System.Drawing.Point(754, 66);
            this.rbtnPointAtHead.Name = "rbtnPointAtHead";
            this.rbtnPointAtHead.Size = new System.Drawing.Size(116, 21);
            this.rbtnPointAtHead.TabIndex = 13;
            this.rbtnPointAtHead.TabStop = true;
            this.rbtnPointAtHead.Text = "Point At Head";
            this.rbtnPointAtHead.UseVisualStyleBackColor = true;
            this.rbtnPointAtHead.CheckedChanged += new System.EventHandler(this.rbtnPointAtHead_CheckedChanged);
            // 
            // rbtnDuck
            // 
            this.rbtnDuck.AutoSize = true;
            this.rbtnDuck.Location = new System.Drawing.Point(754, 108);
            this.rbtnDuck.Name = "rbtnDuck";
            this.rbtnDuck.Size = new System.Drawing.Size(61, 21);
            this.rbtnDuck.TabIndex = 14;
            this.rbtnDuck.TabStop = true;
            this.rbtnDuck.Text = "Duck";
            this.rbtnDuck.UseVisualStyleBackColor = true;
            this.rbtnDuck.CheckedChanged += new System.EventHandler(this.rbtnDuck_CheckedChanged);
            // 
            // lblDisplayPlayerName
            // 
            this.lblDisplayPlayerName.AutoSize = true;
            this.lblDisplayPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayPlayerName.Location = new System.Drawing.Point(750, 141);
            this.lblDisplayPlayerName.Name = "lblDisplayPlayerName";
            this.lblDisplayPlayerName.Size = new System.Drawing.Size(116, 20);
            this.lblDisplayPlayerName.TabIndex = 15;
            this.lblDisplayPlayerName.Text = "Player Name";
            // 
            // btnLoadBullet
            // 
            this.btnLoadBullet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLoadBullet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadBullet.Location = new System.Drawing.Point(754, 177);
            this.btnLoadBullet.Name = "btnLoadBullet";
            this.btnLoadBullet.Size = new System.Drawing.Size(141, 71);
            this.btnLoadBullet.TabIndex = 16;
            this.btnLoadBullet.Text = "Load Bullet";
            this.btnLoadBullet.UseVisualStyleBackColor = false;
            this.btnLoadBullet.Click += new System.EventHandler(this.btnLoadBullet_Click);
            // 
            // btnSpinChambers
            // 
            this.btnSpinChambers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSpinChambers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpinChambers.Location = new System.Drawing.Point(754, 254);
            this.btnSpinChambers.Name = "btnSpinChambers";
            this.btnSpinChambers.Size = new System.Drawing.Size(141, 73);
            this.btnSpinChambers.TabIndex = 17;
            this.btnSpinChambers.Text = "Spin Chambers";
            this.btnSpinChambers.UseVisualStyleBackColor = false;
            this.btnSpinChambers.Click += new System.EventHandler(this.btnSpinChambers_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(754, 333);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(141, 72);
            this.btnReload.TabIndex = 18;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lblDispalyResults
            // 
            this.lblDispalyResults.AutoSize = true;
            this.lblDispalyResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispalyResults.Location = new System.Drawing.Point(12, 440);
            this.lblDispalyResults.Name = "lblDispalyResults";
            this.lblDispalyResults.Size = new System.Drawing.Size(134, 38);
            this.lblDispalyResults.TabIndex = 19;
            this.lblDispalyResults.Text = "Results";
            // 
            // pbxPlayerAvatar
            // 
            this.pbxPlayerAvatar.Image = global::Russian_Roulette.GamesResources.myImage;
            this.pbxPlayerAvatar.Location = new System.Drawing.Point(210, 49);
            this.pbxPlayerAvatar.Name = "pbxPlayerAvatar";
            this.pbxPlayerAvatar.Size = new System.Drawing.Size(432, 375);
            this.pbxPlayerAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPlayerAvatar.TabIndex = 20;
            this.pbxPlayerAvatar.TabStop = false;
            // 
            // RussianRouletteUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(970, 570);
            this.Controls.Add(this.pbxPlayerAvatar);
            this.Controls.Add(this.lblDispalyResults);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSpinChambers);
            this.Controls.Add(this.btnLoadBullet);
            this.Controls.Add(this.lblDisplayPlayerName);
            this.Controls.Add(this.rbtnDuck);
            this.Controls.Add(this.rbtnPointAtHead);
            this.Controls.Add(this.tbxLossesDisplay);
            this.Controls.Add(this.tbxWinsDisplay);
            this.Controls.Add(this.tbxDucksLeftDisplay);
            this.Controls.Add(this.tbxShotsLeftDisplay);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.lblLosses);
            this.Controls.Add(this.lblDucksLeft);
            this.Controls.Add(this.lblShotsLeft);
            this.Controls.Add(this.btnFire);
            this.Name = "RussianRouletteUI";
            this.Text = "Russian Roulette";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RussianRoulette_FormClosing);
            this.Load += new System.EventHandler(this.RussianRoulette_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayerAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Label lblShotsLeft;
        private System.Windows.Forms.Label lblDucksLeft;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.TextBox tbxShotsLeftDisplay;
        private System.Windows.Forms.TextBox tbxDucksLeftDisplay;
        private System.Windows.Forms.TextBox tbxWinsDisplay;
        private System.Windows.Forms.TextBox tbxLossesDisplay;
        private System.Windows.Forms.RadioButton rbtnPointAtHead;
        private System.Windows.Forms.RadioButton rbtnDuck;
        private System.Windows.Forms.Label lblDisplayPlayerName;
        private System.Windows.Forms.Button btnLoadBullet;
        private System.Windows.Forms.Button btnSpinChambers;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label lblDispalyResults;
        private System.Windows.Forms.PictureBox pbxPlayerAvatar;
    }
}