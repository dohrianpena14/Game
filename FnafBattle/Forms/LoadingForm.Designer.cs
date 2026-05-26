namespace FnafBattle.Forms
{
    partial class LoadingForm
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
            this.lblLoading = new System.Windows.Forms.Label();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.lblPercent = new System.Windows.Forms.Label();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.picLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.White;
            this.lblLoading.Location = new System.Drawing.Point(329, 9);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(504, 60);
            this.lblLoading.TabIndex = 0;
            this.lblLoading.Text = "PREPARANDO COMBATE...";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLoading
            // 
            this.pbLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pbLoading.Location = new System.Drawing.Point(300, 600);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(600, 30);
            this.pbLoading.TabIndex = 2;
            this.pbLoading.Click += new System.EventHandler(this.timerLoading_Tick);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.ForeColor = System.Drawing.Color.White;
            this.lblPercent.Location = new System.Drawing.Point(581, 633);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(43, 29);
            this.lblPercent.TabIndex = 3;
            this.lblPercent.Text = "0%";
            this.lblPercent.Click += new System.EventHandler(this.timerLoading_Tick);
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 50;
            // 
            // picLoading
            // 
            this.picLoading.BackgroundImage = global::FnafBattle.Properties.Resources.loading_vs;
            this.picLoading.Location = new System.Drawing.Point(0, 90);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(1200, 470);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoading.TabIndex = 1;
            this.picLoading.TabStop = false;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.lblLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingForm";
            this.Load += new System.EventHandler(this.LoadingForm_Load_1);
            this.Click += new System.EventHandler(this.timerLoading_Tick);
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.ProgressBar pbLoading;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Timer timerLoading;
    }
}