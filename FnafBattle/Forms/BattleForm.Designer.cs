namespace FnafBattle.Forms
{
    partial class BattleForm
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
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.pbPlayerHealth = new System.Windows.Forms.ProgressBar();
            this.lblBossName = new System.Windows.Forms.Label();
            this.lblBossHealth = new System.Windows.Forms.Label();
            this.pbBossHealth = new System.Windows.Forms.ProgressBar();
            this.lblTurn = new System.Windows.Forms.Label();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picBoss = new System.Windows.Forms.PictureBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.btnFight = new System.Windows.Forms.Button();
            this.btnSkill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoss)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.Black;
            this.lblPlayerName.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.White;
            this.lblPlayerName.Location = new System.Drawing.Point(25, 20);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(101, 36);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "FREDDY";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.AutoSize = true;
            this.lblPlayerHealth.BackColor = System.Drawing.Color.Black;
            this.lblPlayerHealth.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealth.ForeColor = System.Drawing.Color.White;
            this.lblPlayerHealth.Location = new System.Drawing.Point(25, 55);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(120, 22);
            this.lblPlayerHealth.TabIndex = 1;
            this.lblPlayerHealth.Text = "1000 / 1000";
            this.lblPlayerHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPlayerHealth
            // 
            this.pbPlayerHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pbPlayerHealth.Location = new System.Drawing.Point(25, 90);
            this.pbPlayerHealth.Maximum = 1000;
            this.pbPlayerHealth.Name = "pbPlayerHealth";
            this.pbPlayerHealth.Size = new System.Drawing.Size(260, 25);
            this.pbPlayerHealth.TabIndex = 2;
            this.pbPlayerHealth.Value = 1000;
            // 
            // lblBossName
            // 
            this.lblBossName.AutoSize = true;
            this.lblBossName.BackColor = System.Drawing.Color.Black;
            this.lblBossName.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBossName.ForeColor = System.Drawing.Color.White;
            this.lblBossName.Location = new System.Drawing.Point(998, 20);
            this.lblBossName.Name = "lblBossName";
            this.lblBossName.Size = new System.Drawing.Size(159, 36);
            this.lblBossName.TabIndex = 3;
            this.lblBossName.Text = "SPRINGTRAP";
            this.lblBossName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBossHealth
            // 
            this.lblBossHealth.AutoSize = true;
            this.lblBossHealth.BackColor = System.Drawing.Color.Black;
            this.lblBossHealth.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBossHealth.ForeColor = System.Drawing.Color.White;
            this.lblBossHealth.Location = new System.Drawing.Point(1019, 56);
            this.lblBossHealth.Name = "lblBossHealth";
            this.lblBossHealth.Size = new System.Drawing.Size(120, 22);
            this.lblBossHealth.TabIndex = 4;
            this.lblBossHealth.Text = "1000 / 1000";
            this.lblBossHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbBossHealth
            // 
            this.pbBossHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pbBossHealth.Location = new System.Drawing.Point(897, 90);
            this.pbBossHealth.Maximum = 1000;
            this.pbBossHealth.Name = "pbBossHealth";
            this.pbBossHealth.Size = new System.Drawing.Size(260, 25);
            this.pbBossHealth.TabIndex = 5;
            this.pbBossHealth.Value = 1000;
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn.Font = new System.Drawing.Font("Impact", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.White;
            this.lblTurn.Location = new System.Drawing.Point(480, 25);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(160, 53);
            this.lblTurn.TabIndex = 6;
            this.lblTurn.Text = "TURNO 1";
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.Location = new System.Drawing.Point(100, 190);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(350, 420);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer.TabIndex = 7;
            this.picPlayer.TabStop = false;
            // 
            // picBoss
            // 
            this.picBoss.BackColor = System.Drawing.Color.Transparent;
            this.picBoss.BackgroundImage = global::FnafBattle.Properties.Resources.Springtrap;
            this.picBoss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoss.Location = new System.Drawing.Point(762, 190);
            this.picBoss.Name = "picBoss";
            this.picBoss.Size = new System.Drawing.Size(350, 420);
            this.picBoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoss.TabIndex = 8;
            this.picBoss.TabStop = false;
            // 
            // rtbMessages
            // 
            this.rtbMessages.BackColor = System.Drawing.Color.Black;
            this.rtbMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMessages.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMessages.ForeColor = System.Drawing.Color.White;
            this.rtbMessages.Location = new System.Drawing.Point(456, 471);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(300, 115);
            this.rtbMessages.TabIndex = 9;
            this.rtbMessages.Text = "";
            // 
            // btnFight
            // 
            this.btnFight.BackColor = System.Drawing.Color.Black;
            this.btnFight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFight.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFight.ForeColor = System.Drawing.Color.White;
            this.btnFight.Location = new System.Drawing.Point(425, 616);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(158, 44);
            this.btnFight.TabIndex = 10;
            this.btnFight.Text = "LUCHAR";
            this.btnFight.UseVisualStyleBackColor = false;
            this.btnFight.Click += new System.EventHandler(this.btnFight_Click_1);
            // 
            // btnSkill
            // 
            this.btnSkill.BackColor = System.Drawing.Color.Black;
            this.btnSkill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkill.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkill.ForeColor = System.Drawing.Color.White;
            this.btnSkill.Location = new System.Drawing.Point(221, 616);
            this.btnSkill.Name = "btnSkill";
            this.btnSkill.Size = new System.Drawing.Size(158, 44);
            this.btnSkill.TabIndex = 11;
            this.btnSkill.Text = "HABILIDAD";
            this.btnSkill.UseVisualStyleBackColor = false;
            this.btnSkill.Click += new System.EventHandler(this.btnSkill_Click_1);
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FnafBattle.Properties.Resources.battle_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.btnSkill);
            this.Controls.Add(this.btnFight);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.picBoss);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.pbBossHealth);
            this.Controls.Add(this.lblBossHealth);
            this.Controls.Add(this.lblBossName);
            this.Controls.Add(this.pbPlayerHealth);
            this.Controls.Add(this.lblPlayerHealth);
            this.Controls.Add(this.lblPlayerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BattleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BattleForm";
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPlayerHealth;
        private System.Windows.Forms.ProgressBar pbPlayerHealth;
        private System.Windows.Forms.Label lblBossName;
        private System.Windows.Forms.Label lblBossHealth;
        private System.Windows.Forms.ProgressBar pbBossHealth;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picBoss;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.Button btnFight;
        private System.Windows.Forms.Button btnSkill;
    }
}