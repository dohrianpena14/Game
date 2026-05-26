namespace FnafBattle.Forms
{
    partial class ResultForm
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Impact", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(453, 73);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(282, 68);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "RESULTADO";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(450, 430);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(300, 70);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "MENU PRINCIPAL";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.ResultForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnMenu;
    }
}