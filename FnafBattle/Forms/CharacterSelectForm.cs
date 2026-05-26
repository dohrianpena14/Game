using FnafBattle.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FnafBattle.Forms
{
    public partial class CharacterSelectForm : Form
    {
        public CharacterSelectForm()
        {
            InitializeComponent();
        }

        private void CharacterSelectForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            picFreddy.Image = Image.FromFile("Resources/Freddy.png");
            picChica.Image = Image.FromFile("Resources/Chica.png");
            picFoxy.Image = Image.FromFile("Resources/Foxy.png");
            picBonnie.Image = Image.FromFile("Resources/Bonnie.png");

            picFreddy.SizeMode = PictureBoxSizeMode.Zoom;
            picChica.SizeMode = PictureBoxSizeMode.Zoom;
            picFoxy.SizeMode = PictureBoxSizeMode.Zoom;
            picBonnie.SizeMode = PictureBoxSizeMode.Zoom;

            EstiloBoton(btnFreddy);
            EstiloBoton(btnChica);
            EstiloBoton(btnFoxy);
            EstiloBoton(btnBonnie);
        }

        private void btnFreddy_Click(object sender, EventArgs e)
        {
            Character freddy = new Character(
                "Freddy",
                1000,
                20,
                100,
                180,
                "Mic Drop",
                "Resources/Freddy.png"
            );

            AbrirLoading(freddy);
        }

        private void btnChica_Click(object sender, EventArgs e)
        {
            Character chica = new Character(
                "Chica",
                1000,
                15,
                90,
                0,
                "Pizza Heal",
                "Resources/Chica.png"
            );

            AbrirLoading(chica);
        }

        private void btnFoxy_Click(object sender, EventArgs e)
        {
            Character foxy = new Character(
                "Foxy",
                1000,
                30,
                130,
                220,
                "Pirate Rush",
                "Resources/Foxy.png"
            );

            AbrirLoading(foxy);
        }

        private void btnBonnie_Click(object sender, EventArgs e)
        {
            Character bonnie = new Character(
                "Bonnie",
                1000,
                25,
                120,
                200,
                "Guitar Smash",
                "Resources/Bonnie.png"
            );

            AbrirLoading(bonnie);
        }

        private void AbrirLoading(Character personaje)
        {
            LoadingForm loadingForm = new LoadingForm(personaje);
            loadingForm.Show();

            this.Hide();
        }

        private void EstiloBoton(Button boton)
        {
            boton.BackColor = Color.Black;
            boton.ForeColor = Color.White;
            boton.Font = new Font("Impact", 24, FontStyle.Regular);
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderColor = Color.White;
            boton.FlatAppearance.BorderSize = 2;
        }
    }
}