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
    }
}
