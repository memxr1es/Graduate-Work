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
    public partial class FormAddGames : Form
    {
        public FormAddGames()
        {
            InitializeComponent();
        }

        private void FormAddGames_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.Караоке". При необходимости она может быть перемещена или удалена.
            this.караокеTableAdapter.Fill(this.центрОРDataSet.Караоке);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.Боулинг". При необходимости она может быть перемещена или удалена.
            this.боулингTableAdapter.Fill(this.центрОРDataSet.Боулинг);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.Бильярд". При необходимости она может быть перемещена или удалена.
            this.бильярдTableAdapter.Fill(this.центрОРDataSet.Бильярд);

            switch (Variables.pnlNumber)
            {
                case 1:

                    this.Size = new Size(263, 297);

                    pnlAddBilliards.Visible = true;
                    pnlAddBilliards.Location = new Point(0, 0);

                    if (Variables.choiceAction == 1)
                    {
                        бильярдBindingSource.AddNew();
                    }
                    else if (Variables.choiceAction == 2)
                    {
                        бильярдBindingSource.Position = бильярдBindingSource.Find("НомерСтолика", Variables.codeOfTable);
                    }

                    break;

                case 2:

                    this.Size = new Size(267, 378);

                    pnlAddBowling.Visible = true;
                    pnlAddBowling.Location = new Point(0, 0);

                    if (Variables.choiceAction == 1)
                    {
                        боулингBindingSource.AddNew();
                    }
                    else if (Variables.choiceAction == 2)
                    {
                        боулингBindingSource.Position = боулингBindingSource.Find("НомерДорожки", Variables.codeOfTable);
                    }

                    break;

                case 3:

                    this.Size = new Size(264, 338);

                    pnlAddKaraoke.Visible = true;
                    pnlAddKaraoke.Location = new Point(0, 0);

                    if (Variables.choiceAction == 1)
                    {
                        караокеBindingSource.AddNew();
                    }
                    else if (Variables.choiceAction == 2)
                    {
                        караокеBindingSource.Position = караокеBindingSource.Find("НомерСтола", Variables.codeOfTable);
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

        private void btnAddBilliards_Click(object sender, EventArgs e)
        {
            Variables.checkForFillingCmb(pnlAddBilliards);
            Variables.checkForFillingTxb(pnlAddBilliards);

            if (Variables.choiceAction == 1)
            {
                MessageBox.Show("Бильярдный столик успешно добавлен в базу данных.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Variables.choiceAction == 2)
            {
                MessageBox.Show("Информация успешно изменена в базе данных.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Validate();
            this.бильярдBindingSource.EndEdit();
            this.бильярдTableAdapter.Update(this.центрОРDataSet.Бильярд);

            this.Close();
        }

        private void btnAddBowling_Click(object sender, EventArgs e)
        {
            Variables.checkForFillingCmb(pnlAddBowling);
            Variables.checkForFillingTxb(pnlAddBowling);

            if (Variables.choiceAction == 1)
            {
                MessageBox.Show("Дорожка для боулинга успешно добавлена в базу данных.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Variables.choiceAction == 2)
            {
                MessageBox.Show("Информация успешно изменена в базе данных.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Validate();
            this.боулингBindingSource.EndEdit();
            this.боулингTableAdapter.Update(this.центрОРDataSet.Боулинг);

            this.Close();
        }

        private void btnAddKaraoke_Click(object sender, EventArgs e)
        {
            Variables.checkForFillingCmb(pnlAddBowling);
            Variables.checkForFillingTxb(pnlAddBowling);

            if (Variables.choiceAction == 1)
            {
                MessageBox.Show("Столик караоке успешно добавлен в базу данных.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Variables.choiceAction == 2)
            {
                MessageBox.Show("Информация успешно изменена в базе данных.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Validate();
            this.караокеBindingSource.EndEdit();
            this.караокеTableAdapter.Update(this.центрОРDataSet.Караоке);

            this.Close();
        }
    }
}
