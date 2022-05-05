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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.БроньКараоке". При необходимости она может быть перемещена или удалена.
            this.броньКараокеTableAdapter.Fill(this.центрОРDataSet.БроньКараоке);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.БроньБоулинг". При необходимости она может быть перемещена или удалена.
            this.броньБоулингTableAdapter.Fill(this.центрОРDataSet.БроньБоулинг);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.БроньБильярд". При необходимости она может быть перемещена или удалена.
            this.броньБильярдTableAdapter.Fill(this.центрОРDataSet.БроньБильярд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.БроньКараоке". При необходимости она может быть перемещена или удалена.
            this.броньКараокеTableAdapter.Fill(this.центрОРDataSet.БроньКараоке);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.БроньБоулинг". При необходимости она может быть перемещена или удалена.
            this.броньБоулингTableAdapter.Fill(this.центрОРDataSet.БроньБоулинг);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.БроньБильярд". При необходимости она может быть перемещена или удалена.
            this.броньБильярдTableAdapter.Fill(this.центрОРDataSet.БроньБильярд);

            this.Size = new Size(897, 365);
            iBtnBackB.Location = new Point(0, 0);

            switch(Variables.nameOfBooking)
            {
                case "Billiards":

                    pnlBookingBilliard.Location = new Point(20, 0);
                    pnlBookingBilliard.Visible = true;

                    break;

                case "Bowling":

                    pnlBookingBowling.Location = new Point(20, 0);
                    pnlBookingBowling.Visible = true;

                    break;

                case "Karaoke":

                    pnlBookingKaraoke.Location = new Point(20, 0);
                    pnlBookingKaraoke.Visible = true;

                    break;
            }
        }

        private void iBtnBackB_Click(object sender, EventArgs e)
        {
            Variables.checkReturn = true;
            this.Close();
        }

        private void iBtnAdd_Click(object sender, EventArgs e)
        {
            Variables.choiceAction = 1;
            Variables.pnlNumber = 1;

            DialogResult dialog = new FormAddBooking().ShowDialog();

            if (dialog == DialogResult.Cancel)
            {
                this.броньБильярдTableAdapter.Fill(this.центрОРDataSet.БроньБильярд);
            }
        }

        private void iBtnChange_Click(object sender, EventArgs e)
        {
            Variables.choiceAction = 2;
            Variables.pnlNumber = 1;

            DialogResult dialog = new FormAddBooking().ShowDialog();

            if (dialog == DialogResult.Cancel)
            {
                this.броньБильярдTableAdapter.Fill(this.центрОРDataSet.БроньБильярд);
            }
        }

        private void iBtnAddBookBow_Click(object sender, EventArgs e)
        {
            Variables.choiceAction = 1;
            Variables.pnlNumber = 2;

            DialogResult dialog = new FormAddBooking().ShowDialog();

            if (dialog == DialogResult.Cancel)
            {
                this.броньБоулингTableAdapter.Fill(this.центрОРDataSet.БроньБоулинг);
            }
        }

        private void iBtnChangeBookBow_Click(object sender, EventArgs e)
        {
            Variables.choiceAction = 2;
            Variables.pnlNumber = 2;

            DialogResult dialog = new FormAddBooking().ShowDialog();

            if (dialog == DialogResult.Cancel)
            {
                this.броньБоулингTableAdapter.Fill(this.центрОРDataSet.БроньБоулинг);
            }
        }

        private void iBtnAddBookKar_Click(object sender, EventArgs e)
        {
            Variables.choiceAction = 1;
            Variables.pnlNumber = 3;

            DialogResult dialog = new FormAddBooking().ShowDialog();

            if (dialog == DialogResult.Cancel)
            {
                this.броньКараокеTableAdapter.Fill(this.центрОРDataSet.БроньКараоке);
            }
        }

        private void iBtnChangeBookKar_Click(object sender, EventArgs e)
        {
            Variables.choiceAction = 2;
            Variables.pnlNumber = 3;

            DialogResult dialog = new FormAddBooking().ShowDialog();

            if (dialog == DialogResult.Cancel)
            {
                this.броньКараокеTableAdapter.Fill(this.центрОРDataSet.БроньКараоке);
            }
        }
    }
}
