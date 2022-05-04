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
    public partial class FormAddBooking : Form
    {
        public FormAddBooking()
        {
            InitializeComponent();
        }

        private void броньБильярдBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.броньБильярдBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.центрОРDataSet);

        }

        private void броньБильярдBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.броньБильярдBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.центрОРDataSet);

        }

        private void FormAddBooking_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.БроньКараоке". При необходимости она может быть перемещена или удалена.
            this.броньКараокеTableAdapter.Fill(this.центрОРDataSet.БроньКараоке);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.БроньБоулинг". При необходимости она может быть перемещена или удалена.
            this.броньБоулингTableAdapter.Fill(this.центрОРDataSet.БроньБоулинг);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.БроньБильярд". При необходимости она может быть перемещена или удалена.
            this.броньБильярдTableAdapter.Fill(this.центрОРDataSet.БроньБильярд);

            switch (Variables.pnlNumber)
            {
                case 1:

                    this.Size = new Size(267, 375);

                    pnlBookingBilliards.Visible = true;
                    pnlBookingBilliards.Location = new Point(0, 0);

                    if (Variables.choiceAction == 1)
                    {
                        броньБильярдBindingSource.AddNew();
                    }
                    else if (Variables.choiceAction == 2)
                    {
                        броньБильярдBindingSource.Position = броньБильярдBindingSource.Find("НомерСтолика", Variables.codeOfTable);
                    }

                    break;

                case 2:

                    this.Size = new Size(286, 316);

                    pnlAddDeals.Visible = true;
                    pnlAddDeals.Location = new Point(0, 0);

                    if (Variables.choiceAction == 1)
                    {
                        заказыВРесторанеBindingSource.AddNew();
                    }
                    else if (Variables.choiceAction == 2)
                    {
                        заказыВРесторанеBindingSource.Position = заказыВРесторанеBindingSource.Find("НомерСтола", Variables.codeOfTable);
                    }

                    break;

                case 3:

                    this.Size = new Size(264, 243);

                    pnlAddTable.Visible = true;
                    pnlAddTable.Location = new Point(0, 0);

                    if (Variables.choiceAction == 1)
                    {
                        залРесторанаBindingSource.AddNew();
                    }
                    else if (Variables.choiceAction == 2)
                    {
                        залРесторанаBindingSource.Position = залРесторанаBindingSource.Find("НомерСтола", Variables.codeOfTable);
                    }

                    break;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
