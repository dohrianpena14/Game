using System;
using System.Drawing;
using System.Windows.Forms;

namespace FnafBattle.Forms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.BackgroundImage = Image.FromFile("Resources/start_background.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            CharacterSelectForm form = new CharacterSelectForm();
            form.Show();
            this.Hide();
        }
    }
}