using FnafBattle.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FnafBattle.Forms
{
    public partial class BattleForm : Form
    {
        private BattleManager battle;
        private Random random = new Random();

        public BattleForm(Character personaje)
        {
            InitializeComponent();
            battle = new BattleManager(personaje);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            PrepararBatalla();
        }

        private void BattleForm_Load(object sender, EventArgs e)
        {
        }

        private void PrepararBatalla()
        {
            Size = new Size(1200, 700);
            StartPosition = FormStartPosition.CenterScreen;

            BackgroundImage = Image.FromFile("Resources/battle_background.png");
            BackgroundImageLayout = ImageLayout.Stretch;

            picPlayer.Image = Image.FromFile(battle.Player.ImagePath);
            picBoss.Image = Image.FromFile(battle.Boss.ImagePath);

            picPlayer.SizeMode = PictureBoxSizeMode.Zoom;
            picBoss.SizeMode = PictureBoxSizeMode.Zoom;

            pbPlayerHealth.Minimum = 0;
            pbPlayerHealth.Maximum = battle.Player.MaxHealth;

            pbBossHealth.Minimum = 0;
            pbBossHealth.Maximum = battle.Boss.MaxHealth;

            rtbMessages.Clear();
            rtbMessages.BackColor = Color.Black;
            rtbMessages.ForeColor = Color.White;
            rtbMessages.Font = new Font("Consolas", 14, FontStyle.Bold);
            rtbMessages.ReadOnly = true;
            rtbMessages.BringToFront();

            btnFight.Click -= btnFight_Click;
            btnFight.Click += btnFight_Click;

            btnSkill.Click -= btnSkill_Click;
            btnSkill.Click += btnSkill_Click;

            rtbMessages.AppendText($"{battle.Player.Name} entra al combate.\n");
            rtbMessages.AppendText("Springtrap aparece como jefe final.\n");

            ActualizarPantalla();
        }

        private void btnFight_Click(object sender, EventArgs e)
        {
            AtacarNormal();
        }

        private void btnFight_Click_1(object sender, EventArgs e)
        {
            AtacarNormal();
        }

        private void btnSkill_Click(object sender, EventArgs e)
        {
            UsarHabilidad();
        }

        private void btnSkill_Click_1(object sender, EventArgs e)
        {
            UsarHabilidad();
        }

        private void AtacarNormal()
        {
            int damage = battle.PlayerAttack();

            battle.Boss.ReceiveDamage(damage);

            rtbMessages.AppendText($"\n{battle.Player.Name} atacó.\n");
            rtbMessages.AppendText($"Springtrap recibió {damage} de daño.\n");

            MoverPersonaje(picPlayer, 15);

            if (RevisarFinal())
                return;

            TurnoSpringtrap();
        }

        private void UsarHabilidad()
        {
            if (battle.Player.Name == "Chica")
            {
                battle.Player.Heal(150);

                rtbMessages.AppendText("\nChica usó Pizza Heal.\n");
                rtbMessages.AppendText("Chica recuperó 150 de vida.\n");
            }
            else
            {
                int damage = battle.PlayerSpecial();

                battle.Boss.ReceiveDamage(damage);

                rtbMessages.AppendText($"\n{battle.Player.Name} usó {battle.Player.SpecialName}.\n");
                rtbMessages.AppendText($"Springtrap recibió {damage} de daño.\n");
            }

            MoverPersonaje(picPlayer, 15);

            if (RevisarFinal())
                return;

            TurnoSpringtrap();
        }

        private void TurnoSpringtrap()
        {
            int damage;

            if (random.Next(0, 100) < 25)
            {
                damage = battle.BossSpecial();
                rtbMessages.AppendText("\nSpringtrap usó Jumpscare Supremo.\n");
            }
            else
            {
                damage = battle.BossAttack();
                rtbMessages.AppendText("\nSpringtrap atacó.\n");
            }

            battle.Player.ReceiveDamage(damage);

            rtbMessages.AppendText($"{battle.Player.Name} recibió {damage} de daño.\n");

            MoverPersonaje(picBoss, -15);

            battle.Turn++;

            ActualizarPantalla();
            RevisarFinal();
        }

        private void ActualizarPantalla()
        {
            lblPlayerName.Text = battle.Player.Name.ToUpper();
            lblBossName.Text = "SPRINGTRAP";

            lblPlayerHealth.Text = $"{battle.Player.Health} / {battle.Player.MaxHealth}";
            lblBossHealth.Text = $"{battle.Boss.Health} / {battle.Boss.MaxHealth}";

            lblTurn.Text = $"TURNO {battle.Turn}";

            pbPlayerHealth.Value = Math.Max(pbPlayerHealth.Minimum, Math.Min(pbPlayerHealth.Maximum, battle.Player.Health));
            pbBossHealth.Value = Math.Max(pbBossHealth.Minimum, Math.Min(pbBossHealth.Maximum, battle.Boss.Health));

            rtbMessages.SelectionStart = rtbMessages.Text.Length;
            rtbMessages.ScrollToCaret();
        }

        private bool RevisarFinal()
        {
            ActualizarPantalla();

            if (battle.Boss.IsDead())
            {
                ResultForm result = new ResultForm(true);
                result.Show();
                Hide();
                return true;
            }

            if (battle.Player.IsDead())
            {
                ResultForm result = new ResultForm(false);
                result.Show();
                Hide();
                return true;
            }

            return false;
        }

        private void MoverPersonaje(PictureBox pictureBox, int distancia)
        {
            int original = pictureBox.Left;

            pictureBox.Left += distancia;
            pictureBox.Refresh();

            Application.DoEvents();
            System.Threading.Thread.Sleep(80);

            pictureBox.Left = original;
            pictureBox.Refresh();
        }
    }
}