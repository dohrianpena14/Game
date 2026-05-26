using System;
using System.Drawing;
using System.Windows.Forms;

namespace FnafBattle.Forms
{
    public partial class ResultForm : Form
    {
        private bool jugadorGano;

        public ResultForm(bool gano)
        {
            InitializeComponent();

            jugadorGano = gano;

            MostrarResultado();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            MostrarResultado();
        }

        private void ResultForm_Load_1(object sender, EventArgs e)
        {
            MostrarResultado();
        }

        private void MostrarResultado()
        {
            Size = new Size(1200, 700);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.Black;

            lblResult.Visible = true;
            lblResult.BringToFront();
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.Font = new Font("Impact", 42, FontStyle.Bold);
            lblResult.Location = new Point(200, 160);
            lblResult.Size = new Size(800, 230);

            btnMenu.Visible = true;
            btnMenu.BringToFront();
            btnMenu.Text = "MENÚ PRINCIPAL";
            btnMenu.Location = new Point(450, 450);
            btnMenu.Size = new Size(300, 70);
            btnMenu.Font = new Font("Consolas", 20, FontStyle.Bold);
            btnMenu.BackColor = Color.Black;
            btnMenu.ForeColor = Color.White;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.FlatAppearance.BorderColor = Color.White;
            btnMenu.FlatAppearance.BorderSize = 2;

            if (jugadorGano)
            {
                Text = "Victoria";
                lblResult.Text = "¡GANASTE!\nDERROTASTE A SPRINGTRAP";
                lblResult.ForeColor = Color.Lime;
            }
            else
            {
                Text = "Derrota";
                lblResult.Text = "GAME OVER\nSPRINGTRAP TE VENCIÓ";
                lblResult.ForeColor = Color.Red;
            }

            btnMenu.Click -= btnMenu_Click;
            btnMenu.Click += btnMenu_Click;

            btnMenu.Click -= btnMenu_Click_1;
            btnMenu.Click += btnMenu_Click_1;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            AbrirMenu();
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            AbrirMenu();
        }

        private void AbrirMenu()
        {
            StartForm menu = new StartForm();
            menu.Show();

            this.Hide();
        }
    }
}