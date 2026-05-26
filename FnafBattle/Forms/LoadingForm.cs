using FnafBattle.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FnafBattle.Forms
{
    public partial class LoadingForm : Form
    {
        private Character personaje;
        private int progreso = 0;

        public LoadingForm(Character personajeSeleccionado)
        {
            InitializeComponent();
            personaje = personajeSeleccionado;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            IniciarCarga();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
        }

        private void LoadingForm_Load_1(object sender, EventArgs e)
        {
        }

        private void IniciarCarga()
        {
            Size = new Size(1200, 700);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.Black;

            picLoading.Image = Image.FromFile("Resources/loading_vs.png");
            picLoading.SizeMode = PictureBoxSizeMode.StretchImage;

            progreso = 0;

            pbLoading.Minimum = 0;
            pbLoading.Maximum = 100;
            pbLoading.Value = 0;

            lblPercent.Text = "0%";

            timerLoading.Stop();
            timerLoading.Interval = 50;
            timerLoading.Tick -= timerLoading_Tick;
            timerLoading.Tick += timerLoading_Tick;
            timerLoading.Start();
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            progreso += 2;

            if (progreso > 100)
                progreso = 100;

            pbLoading.Value = progreso;
            lblPercent.Text = progreso + "%";

            if (progreso >= 100)
            {
                timerLoading.Stop();

                BattleForm form = new BattleForm(personaje);
                form.Show();

                Hide();
            }
        }
    }
}