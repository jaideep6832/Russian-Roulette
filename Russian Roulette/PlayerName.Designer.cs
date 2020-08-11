namespace Russian_Roulette
{
    partial class PlayerName
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
            this.btnCreatePlayer = new System.Windows.Forms.Button();
            this.tbxPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreatePlayer
            // 
            this.btnCreatePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCreatePlayer.Enabled = false;
            this.btnCreatePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePlayer.Location = new System.Drawing.Point(292, 195);
            this.btnCreatePlayer.Name = "btnCreatePlayer";
            this.btnCreatePlayer.Size = new System.Drawing.Size(150, 58);
            this.btnCreatePlayer.TabIndex = 0;
            this.btnCreatePlayer.Text = "Create Player";
            this.btnCreatePlayer.UseVisualStyleBackColor = false;
            this.btnCreatePlayer.Click += new System.EventHandler(this.btnCreatePlayer_Click);
            // 
            // tbxPlayerName
            // 
            this.tbxPlayerName.Location = new System.Drawing.Point(159, 127);
            this.tbxPlayerName.Name = "tbxPlayerName";
            this.tbxPlayerName.Size = new System.Drawing.Size(434, 22);
            this.tbxPlayerName.TabIndex = 1;
            this.tbxPlayerName.TextChanged += new System.EventHandler(this.tbxPlayerName_TextChanged);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(218, 47);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(303, 32);
            this.lblPlayerName.TabIndex = 2;
            this.lblPlayerName.Text = "Enter in Player Name";
            // 
            // PlayerName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.tbxPlayerName);
            this.Controls.Add(this.btnCreatePlayer);
            this.Name = "PlayerName";
            this.Text = "PlayerName";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayerName_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreatePlayer;
        private System.Windows.Forms.TextBox tbxPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
    }
}