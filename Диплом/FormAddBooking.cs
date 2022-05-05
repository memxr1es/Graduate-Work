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
        private static bool checkDate = false;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.БроньНомера". При необходимости она может быть перемещена или удалена.
            this.броньНомераTableAdapter.Fill(this.центрОРDataSet.БроньНомера);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.Караоке". При необходимости она может быть перемещена или удалена.
            this.караокеTableAdapter.Fill(this.центрОРDataSet.Караоке);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.Боулинг". При необходимости она может быть перемещена или удалена.
            this.боулингTableAdapter.Fill(this.центрОРDataSet.Боулинг);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.Бильярд". При необходимости она может быть перемещена или удалена.
            this.бильярдTableAdapter.Fill(this.центрОРDataSet.Бильярд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.БроньКараоке". При необходимости она может быть перемещена или удалена.
            this.броньКараокеTableAdapter.Fill(this.центрОРDataSet.БроньКараоке);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.БроньБоулинг". При необходимости она может быть перемещена или удалена.
            this.броньБоулингTableAdapter.Fill(this.центрОРDataSet.БроньБоулинг);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.БроньБильярд". При необходимости она может быть перемещена или удалена.
            this.броньБильярдTableAdapter.Fill(this.центрОРDataSet.БроньБильярд);

            switch (Variables.pnlNumber)
            {
                case 1:

                    this.Size = new Size(263, 332);

                    pnlBookingBilliards.Visible = true;
                    pnlBookingBilliards.Location = new Point(0, 0);

                    if (Variables.choiceAction == 1)
                    {
                        броньБильярдBindingSource.AddNew();
                    }
                    else if (Variables.choiceAction == 2)
                    {
                        броньБильярдBindingSource.Position = броньБильярдBindingSource.Find("НомерСтолика", Variables.codeOfTable);
                        dateBookBil.Enabled = false;
                    }

                    break;

                case 2:

                    this.Size = new Size(264, 337);

                    pnlBookingBowling.Visible = true;
                    pnlBookingBowling.Location = new Point(0, 0);

                    if (Variables.choiceAction == 1)
                    {
                        броньБоулингBindingSource.AddNew();
                    }
                    else if (Variables.choiceAction == 2)
                    {
                        броньБоулингBindingSource.Position = броньБоулингBindingSource.Find("НомерДорожки", Variables.codeOfTable);
                        dateBookBow.Enabled = false;
                    }

                    break;

                case 3:

                    this.Size = new Size(264, 339);
                    
                    pnlBookingKaraoke.Visible = true;
                    pnlBookingKaraoke.Location = new Point(0, 0);

                    if (Variables.choiceAction == 1)
                    {
                        броньКараокеBindingSource.AddNew();
                    }
                    else if (Variables.choiceAction == 2)
                    {
                        броньКараокеBindingSource.Position = броньКараокеBindingSource.Find("НомерСтола", Variables.codeOfTable);
                        dateBookKar.Enabled = false;
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


        private void btnBilliards_Click(object sender, EventArgs e)
        {
            if (checkDate == false)
            {
                Variables.checkForFillingCmb(pnlBookingBilliards);
                Variables.checkForFillingTxb(pnlBookingBilliards);

                if (Variables.choiceAction == 1)
                {
                    MessageBox.Show("Столик успешно забронирован.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Variables.choiceAction == 2)
                {
                    MessageBox.Show("Информация о бронирование успешно изменена.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Validate();
                this.броньБильярдBindingSource.EndEdit();
                this.броньБильярдTableAdapter.Update(this.центрОРDataSet.БроньБильярд);

                this.Close();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (номерСтоликаComboBox.Text != "")
            {
                бильярдBindingSource.Position = бильярдBindingSource.Find("НомерСтолика", номерСтоликаComboBox.Text);

                lblFinalSumBil.Text = (Convert.ToInt32(txbHourBilliard.Text) * Convert.ToInt32(бильярдDataGridView.CurrentRow.Cells[2].Value)).ToString();
            }

            var txb = (TextBox)sender;

            if (txb.Text == "")
            {
                txb.Text = "0";
            }
        }

        private void txbDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar)) return;
            e.Handled = true;
        }

        private void btnBowling_Click(object sender, EventArgs e)
        {
            if (checkDate == false)
            {
                Variables.checkForFillingCmb(pnlBookingBowling);
                Variables.checkForFillingTxb(pnlBookingBowling);

                if (Variables.choiceAction == 1)
                {
                    MessageBox.Show("Дорожка успешно забронирована.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Variables.choiceAction == 2)
                {
                    MessageBox.Show("Информация о бронирование успешно изменена.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Validate();
                this.броньБоулингBindingSource.EndEdit();
                this.броньБоулингTableAdapter.Update(this.центрОРDataSet.БроньБоулинг);

                this.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (numberOfRoad.Text != "")
            {
                боулингBindingSource.Position = боулингBindingSource.Find("НомерДорожки", numberOfRoad.Text);

                lblFinalSumBow.Text = (Convert.ToInt32(txbHourBow.Text) * Convert.ToInt32(боулингDataGridView.CurrentRow.Cells[2].Value)).ToString();
            }

            var txb = (TextBox)sender;

            if (txb.Text == "")
            {
                txb.Text = "0";
            }
        }

        private void btnKaraoke_Click(object sender, EventArgs e)
        {
            if (checkDate == false)
            {
                Variables.checkForFillingCmb(pnlBookingKaraoke);
                Variables.checkForFillingTxb(pnlBookingKaraoke);

                if (Variables.choiceAction == 1)
                {
                    MessageBox.Show("Столик успешно забронирован.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Variables.choiceAction == 2)
                {
                    MessageBox.Show("Информация о бронирование успешно изменена.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Validate();
                this.броньКараокеBindingSource.EndEdit();
                this.броньКараокеTableAdapter.Update(this.центрОРDataSet.БроньКараоке);

                this.Close();
            }
        }

        private void txbHourKar_TextChanged(object sender, EventArgs e)
        {
            if (txbHourKar.Text != "")
            {
                караокеBindingSource.Position = караокеBindingSource.Find("НомерСтола", cmbNumberOfTable.Text);

                lblFinalSumKar.Text = (Convert.ToInt32(txbHourKar.Text) * Convert.ToInt32(караокеDataGridView.CurrentRow.Cells[2].Value)).ToString();
            }

            var txb = (TextBox)sender;

            if (txb.Text == "")
            {
                txb.Text = "0";
            }
        }

        private void датаБрониMaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (Variables.choiceAction == 1)
            {
                for (int i = 0; i < броньБильярдDataGridView.RowCount - 1; i++)
                {
                    if (броньБильярдDataGridView[0, i].Value.ToString() == номерСтоликаComboBox.Text && броньБильярдDataGridView[3, i].Value.ToString() == dateBookBil.Text)
                    {
                        MessageBox.Show("На выбранный Вами день столик уже забронирован.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        checkDate = true;
                        break;
                    }
                    else
                        checkDate = false;
                }
            }
        }

        private void номерСтоликаComboBox_Leave(object sender, EventArgs e)
        {
            if (номерСтоликаComboBox.Text != "")
            {
                бильярдBindingSource.Position = бильярдBindingSource.Find("НомерСтолика", номерСтоликаComboBox.Text);

                lblFinalSumBil.Text = (Convert.ToInt32(txbHourBilliard.Text) * Convert.ToInt32(бильярдDataGridView.CurrentRow.Cells[2].Value)).ToString();
            }
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            if (Variables.choiceAction == 1)
            {
                for (int i = 0; i < броньБоулингDataGridView.RowCount - 1; i++)
                {
                    if (броньБоулингDataGridView[0, i].Value.ToString() == numberOfRoad.Text && броньБоулингDataGridView[3, i].Value.ToString() == dateBookBow.Text)
                    {
                        MessageBox.Show("На выбранный Вами день дорожка уже забронирована.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        checkDate = true;
                        break;
                    }
                    else
                        checkDate = false;

                }
            }
        }

        private void numberOfRoad_Leave(object sender, EventArgs e)
        {
            if (numberOfRoad.Text != "")
            {
                боулингBindingSource.Position = боулингBindingSource.Find("НомерДорожки", numberOfRoad.Text);

                lblFinalSumBow.Text = (Convert.ToInt32(txbHourBow.Text) * Convert.ToInt32(боулингDataGridView.CurrentRow.Cells[2].Value)).ToString();
            }
        }

        private void txbHourKar_Leave(object sender, EventArgs e)
        {
            if (txbHourKar.Text != "")
            {
                караокеBindingSource.Position = караокеBindingSource.Find("НомерСтола", cmbNumberOfTable.Text);

                lblFinalSumKar.Text = (Convert.ToInt32(txbHourKar.Text) * Convert.ToInt32(караокеDataGridView.CurrentRow.Cells[2].Value)).ToString();
            }
        }

        private void maskedTextBox2_Leave(object sender, EventArgs e)
        {
            if (Variables.choiceAction == 1)
            {
                for (int i = 0; i < броньКараокеDataGridView.RowCount - 1; i++)
                {
                    if (броньКараокеDataGridView[0, i].Value.ToString() == cmbNumberOfTable.Text && броньКараокеDataGridView[3, i].Value.ToString() == dateBookKar.Text)
                    {
                        MessageBox.Show("На выбранный Вами день стол уже забронирован.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        checkDate = true;
                        break;
                    }
                    else
                        checkDate = false;

                }
            }
        }

    }
}
