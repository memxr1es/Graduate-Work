using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Диплом
{
    public partial class Games : Form
    {
        private Form currentChildForm;
        public Games()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Games_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.Караоке". При необходимости она может быть перемещена или удалена.
            this.караокеTableAdapter.Fill(this.центрОРDataSet.Караоке);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.Боулинг". При необходимости она может быть перемещена или удалена.
            this.боулингTableAdapter.Fill(this.центрОРDataSet.Боулинг);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.Бильярд". При необходимости она может быть перемещена или удалена.
            this.бильярдTableAdapter.Fill(this.центрОРDataSet.Бильярд);

            this.Size = new Size(897, 365);
            iBtnBackB.Location = new Point(0, 0);
            pnlChoice.Location = new Point(33, 105);
        }

        private void btnBowling_Click(object sender, EventArgs e)
        {
            iBtnBackB.Visible = true;
            pnlChoice.Visible = false;

            pnlBilliards.Location = new Point(20, 0);
            pnlBilliards.Visible = true;
        }

        private void btnBilliards_Click(object sender, EventArgs e)
        {
            iBtnBackB.Visible = true;
            pnlChoice.Visible = false;

            pnlBowling.Location = new Point(20, 0);
            pnlBowling.Visible = true;
        }

        private void btnKaraoke_Click(object sender, EventArgs e)
        {
            iBtnBackB.Visible = true;
            pnlChoice.Visible = false;

            pnlKaraoke.Location = new Point(20, 0);
            pnlKaraoke.Visible = true;
        }

        private void iBtnBackB_Click(object sender, EventArgs e)
        {
            iBtnBackB.Visible = false;
            pnlBilliards.Visible = false;
            pnlBowling.Visible = false;
            pnlKaraoke.Visible = false;

            pnlChoice.Visible = true;
        }

        private void iBtnBooking_Click(object sender, EventArgs e)
        {
            Variables.nameOfBooking = "Billiards";

            timer1.Start();
            timer1.Enabled = true;

            pnlChildForm.BringToFront();
            OpenChildForm(new Booking());
        }

        private void iBtnBookingBo_Click(object sender, EventArgs e)
        {
            Variables.nameOfBooking = "Bowling";

            timer1.Start();
            timer1.Enabled = true;

            pnlChildForm.BringToFront();
            OpenChildForm(new Booking());
        }

        private void iBtnBookingKa_Click(object sender, EventArgs e)
        {
            Variables.nameOfBooking = "Karaoke";

            timer1.Start();
            timer1.Enabled = true;

            pnlChildForm.BringToFront();
            OpenChildForm(new Booking());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Variables.checkReturn == true)
            {
                Variables.checkReturn = !Variables.checkReturn;
                pnlChildForm.SendToBack();

                timer1.Stop();
                timer1.Enabled = false;
            }
        }

        private void iBtnAdd_Click(object sender, EventArgs e)
        {
            Variables.choiceAction = 1;
            Variables.pnlNumber = 1;

            DialogResult dialog = new FormAddGames().ShowDialog();

            if (dialog == DialogResult.Cancel)
            {
                this.бильярдTableAdapter.Fill(this.центрОРDataSet.Бильярд);
            }
        }

        private void iBtnChange_Click(object sender, EventArgs e)
        {
            Variables.choiceAction = 2;
            Variables.pnlNumber = 1;

            DialogResult dialog = new FormAddGames().ShowDialog();

            if (dialog == DialogResult.Cancel)
            {
                this.бильярдTableAdapter.Fill(this.центрОРDataSet.Бильярд);
            }
        }

        private void iBtnAddBo_Click(object sender, EventArgs e)
        {
            Variables.choiceAction = 1;
            Variables.pnlNumber = 2;

            DialogResult dialog = new FormAddGames().ShowDialog();

            if (dialog == DialogResult.Cancel)
            {
                this.боулингTableAdapter.Fill(this.центрОРDataSet.Боулинг);
            }
        }

        private void iBtnChangeBo_Click(object sender, EventArgs e)
        {
            Variables.choiceAction = 2;
            Variables.pnlNumber = 2;

            DialogResult dialog = new FormAddGames().ShowDialog();

            if (dialog == DialogResult.Cancel)
            {
                this.боулингTableAdapter.Fill(this.центрОРDataSet.Боулинг);
            }
        }

        private void iBtnAddKa_Click(object sender, EventArgs e)
        {
            Variables.choiceAction = 1;
            Variables.pnlNumber = 3;

            DialogResult dialog = new FormAddGames().ShowDialog();

            if (dialog == DialogResult.Cancel)
            {
                this.караокеTableAdapter.Fill(this.центрОРDataSet.Караоке);
            }
        }

        private void iBtnChangeKa_Click(object sender, EventArgs e)
        {
            Variables.choiceAction = 2;
            Variables.pnlNumber = 3;

            DialogResult dialog = new FormAddGames().ShowDialog();

            if (dialog == DialogResult.Cancel)
            {
                this.караокеTableAdapter.Fill(this.центрОРDataSet.Караоке);
            }
        }
    }
}
