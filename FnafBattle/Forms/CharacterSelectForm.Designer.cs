namespace FnafBattle.Forms
{
    partial class CharacterSelectForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFreddy = new System.Windows.Forms.Label();
            this.btnFreddy = new System.Windows.Forms.Button();
            this.lblChica = new System.Windows.Forms.Label();
            this.lblFoxy = new System.Windows.Forms.Label();
            this.lblBonnie = new System.Windows.Forms.Label();
            this.btnChica = new System.Windows.Forms.Button();
            this.btnFoxy = new System.Windows.Forms.Button();
            this.btnBonnie = new System.Windows.Forms.Button();
            this.picBonnie = new System.Windows.Forms.PictureBox();
            this.picFoxy = new System.Windows.Forms.PictureBox();
            this.picChica = new System.Windows.Forms.PictureBox();
            this.picFreddy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBonnie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoxy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFreddy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(350, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ELIGE TU PERSONAJE";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFreddy
            // 
            this.lblFreddy.Font = new System.Drawing.Font("Impact", 22F);
            this.lblFreddy.ForeColor = System.Drawing.Color.White;
            this.lblFreddy.Location = new System.Drawing.Point(50, 90);
            this.lblFreddy.Name = "lblFreddy";
            this.lblFreddy.Size = new System.Drawing.Size(250, 40);
            this.lblFreddy.TabIndex = 1;
            this.lblFreddy.Text = "FREDDY";
            this.lblFreddy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFreddy
            // 
            this.btnFreddy.Font = new System.Drawing.Font("Impact", 26.25F);
            this.btnFreddy.Location = new System.Drawing.Point(75, 526);
            this.btnFreddy.Name = "btnFreddy";
            this.btnFreddy.Size = new System.Drawing.Size(200, 55);
            this.btnFreddy.TabIndex = 3;
            this.btnFreddy.Text = "SELECT";
            this.btnFreddy.UseVisualStyleBackColor = true;
            this.btnFreddy.Click += new System.EventHandler(this.btnFreddy_Click);
            // 
            // lblChica
            // 
            this.lblChica.Font = new System.Drawing.Font("Impact", 22F);
            this.lblChica.ForeColor = System.Drawing.Color.White;
            this.lblChica.Location = new System.Drawing.Point(337, 90);
            this.lblChica.Name = "lblChica";
            this.lblChica.Size = new System.Drawing.Size(250, 40);
            this.lblChica.TabIndex = 4;
            this.lblChica.Text = "CHICA";
            this.lblChica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFoxy
            // 
            this.lblFoxy.Font = new System.Drawing.Font("Impact", 22F);
            this.lblFoxy.ForeColor = System.Drawing.Color.White;
            this.lblFoxy.Location = new System.Drawing.Point(619, 90);
            this.lblFoxy.Name = "lblFoxy";
            this.lblFoxy.Size = new System.Drawing.Size(250, 40);
            this.lblFoxy.TabIndex = 7;
            this.lblFoxy.Text = "FOXY";
            this.lblFoxy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBonnie
            // 
            this.lblBonnie.Font = new System.Drawing.Font("Impact", 22F);
            this.lblBonnie.ForeColor = System.Drawing.Color.White;
            this.lblBonnie.Location = new System.Drawing.Point(900, 90);
            this.lblBonnie.Name = "lblBonnie";
            this.lblBonnie.Size = new System.Drawing.Size(250, 40);
            this.lblBonnie.TabIndex = 10;
            this.lblBonnie.Text = "BONNIE";
            this.lblBonnie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChica
            // 
            this.btnChica.Font = new System.Drawing.Font("Impact", 26.25F);
            this.btnChica.Location = new System.Drawing.Point(362, 526);
            this.btnChica.Name = "btnChica";
            this.btnChica.Size = new System.Drawing.Size(200, 55);
            this.btnChica.TabIndex = 6;
            this.btnChica.Text = "SELECT";
            this.btnChica.UseVisualStyleBackColor = true;
            this.btnChica.Click += new System.EventHandler(this.btnChica_Click);
            // 
            // btnFoxy
            // 
            this.btnFoxy.Font = new System.Drawing.Font("Impact", 26.25F);
            this.btnFoxy.Location = new System.Drawing.Point(644, 526);
            this.btnFoxy.Name = "btnFoxy";
            this.btnFoxy.Size = new System.Drawing.Size(200, 55);
            this.btnFoxy.TabIndex = 9;
            this.btnFoxy.Text = "SELECT";
            this.btnFoxy.UseVisualStyleBackColor = true;
            this.btnFoxy.Click += new System.EventHandler(this.btnFoxy_Click);
            // 
            // btnBonnie
            // 
            this.btnBonnie.Font = new System.Drawing.Font("Impact", 26.25F);
            this.btnBonnie.Location = new System.Drawing.Point(925, 526);
            this.btnBonnie.Name = "btnBonnie";
            this.btnBonnie.Size = new System.Drawing.Size(200, 55);
            this.btnBonnie.TabIndex = 12;
            this.btnBonnie.Text = "SELECT";
            this.btnBonnie.UseVisualStyleBackColor = true;
            this.btnBonnie.Click += new System.EventHandler(this.btnBonnie_Click);
            // 
            // picBonnie
            // 
            this.picBonnie.BackColor = System.Drawing.Color.Black;
            this.picBonnie.BackgroundImage = global::FnafBattle.Properties.Resources.Bonnie;
            this.picBonnie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBonnie.Location = new System.Drawing.Point(900, 130);
            this.picBonnie.Name = "picBonnie";
            this.picBonnie.Size = new System.Drawing.Size(250, 390);
            this.picBonnie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBonnie.TabIndex = 11;
            this.picBonnie.TabStop = false;
            // 
            // picFoxy
            // 
            this.picFoxy.BackColor = System.Drawing.Color.Black;
            this.picFoxy.BackgroundImage = global::FnafBattle.Properties.Resources.Foxy;
            this.picFoxy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFoxy.Location = new System.Drawing.Point(619, 130);
            this.picFoxy.Name = "picFoxy";
            this.picFoxy.Size = new System.Drawing.Size(250, 390);
            this.picFoxy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoxy.TabIndex = 8;
            this.picFoxy.TabStop = false;
            // 
            // picChica
            // 
            this.picChica.BackColor = System.Drawing.Color.Black;
            this.picChica.BackgroundImage = global::FnafBattle.Properties.Resources.Chica;
            this.picChica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picChica.Location = new System.Drawing.Point(337, 130);
            this.picChica.Name = "picChica";
            this.picChica.Size = new System.Drawing.Size(250, 390);
            this.picChica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChica.TabIndex = 5;
            this.picChica.TabStop = false;
            // 
            // picFreddy
            // 
            this.picFreddy.BackColor = System.Drawing.Color.Black;
            this.picFreddy.BackgroundImage = global::FnafBattle.Properties.Resources.Freddy;
            this.picFreddy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFreddy.Location = new System.Drawing.Point(50, 130);
            this.picFreddy.Name = "picFreddy";
            this.picFreddy.Size = new System.Drawing.Size(250, 390);
            this.picFreddy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFreddy.TabIndex = 2;
            this.picFreddy.TabStop = false;
            // 
            // CharacterSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.btnBonnie);
            this.Controls.Add(this.picBonnie);
            this.Controls.Add(this.lblBonnie);
            this.Controls.Add(this.btnFoxy);
            this.Controls.Add(this.picFoxy);
            this.Controls.Add(this.lblFoxy);
            this.Controls.Add(this.btnChica);
            this.Controls.Add(this.picChica);
            this.Controls.Add(this.lblChica);
            this.Controls.Add(this.btnFreddy);
            this.Controls.Add(this.picFreddy);
            this.Controls.Add(this.lblFreddy);
            this.Controls.Add(this.lblTitle);
            this.Name = "CharacterSelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion de personaje";
            this.Load += new System.EventHandler(this.CharacterSelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBonnie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoxy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFreddy)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFreddy;
        private System.Windows.Forms.PictureBox picFreddy;
        private System.Windows.Forms.Button btnFreddy;
        private System.Windows.Forms.Label lblChica;
        private System.Windows.Forms.Label lblFoxy;
        private System.Windows.Forms.Label lblBonnie;
        private System.Windows.Forms.PictureBox picChica;
        private System.Windows.Forms.PictureBox picFoxy;
        private System.Windows.Forms.PictureBox picBonnie;
        private System.Windows.Forms.Button btnChica;
        private System.Windows.Forms.Button btnFoxy;
        private System.Windows.Forms.Button btnBonnie;
    }
}