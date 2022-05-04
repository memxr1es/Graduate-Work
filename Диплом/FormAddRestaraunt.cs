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
    public partial class FormAddRestaraunt : Form
    {
        public FormAddRestaraunt()
        {
            InitializeComponent();
        }

        private void FormAddRestaraunt_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.ЗалРесторана". При необходимости она может быть перемещена или удалена.
            this.залРесторанаTableAdapter.Fill(this.центрОРDataSet.ЗалРесторана);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.ЗаказыВРесторане". При необходимости она может быть перемещена или удалена.
            this.заказыВРесторанеTableAdapter.Fill(this.центрОРDataSet.ЗаказыВРесторане);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.МенюРесторана". При необходимости она может быть перемещена или удалена.
            this.менюРесторанаTableAdapter.Fill(this.центрОРDataSet.МенюРесторана);


            switch(Variables.pnlNumber)
            {
                case 1:

                    this.Size = new Size(267, 375);

                    pnlAddDish.Visible = true;
                    pnlAddDish.Location = new Point(0, 0);

                    if (Variables.choiceAction == 1)
                    {
                        менюРесторанаBindingSource.AddNew();
                    }
                    else if(Variables.choiceAction == 2)
                    {
                        менюРесторанаBindingSource.Position = менюРесторанаBindingSource.Find("НомерБлюда", Variables.codeOfTable);
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


        private void btnAddDish_Click(object sender, EventArgs e)
        {
            Variables.checkForFillingCmb(pnlAddDish);
            Variables.checkForFillingTxb(pnlAddDish);

            if (Variables.choiceAction == 1)
            {
                MessageBox.Show("Блюдо успешно добавлено в базу данных.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(Variables.choiceAction == 2)
            {
                MessageBox.Show("Блюдо успешно изменено в базе данных.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Validate();
            this.менюРесторанаBindingSource.EndEdit();
            this.менюРесторанаTableAdapter.Update(this.центрОРDataSet.МенюРесторана);

            this.Close();
        }

        private void btnAddDeal_Click(object sender, EventArgs e)
        {
            Variables.checkForFillingCmb(pnlAddDeals);
            Variables.checkForFillingTxb(pnlAddDeals);

            if (Variables.choiceAction == 1)
            {
                MessageBox.Show("Заказ успешно добавлен в базу данных.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Variables.choiceAction == 2)
            {
                MessageBox.Show("Заказ успешно изменен в базе данных.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Validate();
            this.заказыВРесторанеBindingSource.EndEdit();
            this.заказыВРесторанеTableAdapter.Update(this.центрОРDataSet.ЗаказыВРесторане);

            this.Close();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            checkForFillingCmb(pnlAddTable);
            checkForFillingTxb(pnlAddTable);

            if (Variables.choiceAction == 1)
            {
                MessageBox.Show("Столик успешно добавлен в базу данных.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Variables.choiceAction == 2)
            {
                MessageBox.Show("Столик успешно изменен в базе данных.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Validate();
            this.залРесторанаBindingSource.EndEdit();
            this.залРесторанаTableAdapter.Update(this.центрОРDataSet.ЗалРесторана);

            this.Close();
        }
    }
}
