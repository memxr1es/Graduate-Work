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
    public partial class Restaraunt : Form
    {
        public Restaraunt()
        {
            InitializeComponent();
        }

        private void Restaraunt_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.ЗалРесторана". При необходимости она может быть перемещена или удалена.
            this.залРесторанаTableAdapter.Fill(this.центрОРDataSet.ЗалРесторана);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.ЗаказыВРесторане". При необходимости она может быть перемещена или удалена.
            this.заказыВРесторанеTableAdapter.Fill(this.центрОРDataSet.ЗаказыВРесторане);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.МенюРесторана". При необходимости она может быть перемещена или удалена.
            this.менюРесторанаTableAdapter.Fill(this.центрОРDataSet.МенюРесторана);



            this.Size = new Size(897, 365);
            iBtnBack.Location = new Point(0, 0);
            pnlChoice.Location = new Point(33, 105);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            iBtnBack.Visible = true;
            pnlChoice.Visible = false;

            pnlMenu.Location = new Point(20, 0);
            pnlMenu.Visible = true;
        }

        private void btnDeals_Click(object sender, EventArgs e)
        {
            iBtnBack.Visible = true;
            pnlChoice.Visible = false;

            pnlDeals.Location = new Point(20, 0);
            pnlDeals.Visible = true;
        }

        private void btnHall_Click(object sender, EventArgs e)
        {
            iBtnBack.Visible = true;
            pnlChoice.Visible = false;

            pnlHall.Location = new Point(20, 0);
            pnlHall.Visible = true;
        }

        private void iBtnBack_Click(object sender, EventArgs e)
        {
            iBtnBack.Visible = false;
            pnlMenu.Visible = false;
            pnlDeals.Visible = false;
            pnlHall.Visible = false;

            pnlChoice.Visible = true;
        }

        private void iBtnAdd_Click(object sender, EventArgs e)
        {
            Variables.choiceAction = 1;
            Variables.pnlNumber = 1;

            DialogResult dialog = new FormAddRestaraunt().ShowDialog();

            if (dialog == DialogResult.Cancel)
            {
                this.менюРесторанаTableAdapter.Fill(this.центрОРDataSet.МенюРесторана);
            }
        }
        private void iBtnChange_Click(object sender, EventArgs e)
        {
            Variables.choiceAction = 2;
            Variables.pnlNumber = 1;
            Variables.codeOfTable = Convert.ToInt32(menuDataGridView.CurrentRow.Cells[0].Value);

            DialogResult dialog = new FormAddRestaraunt().ShowDialog();

            if(dialog == DialogResult.Cancel)
            {
                this.менюРесторанаTableAdapter.Fill(this.центрОРDataSet.МенюРесторана);
            }
        }

        private void iBtnAddD_Click(object sender, EventArgs e)
        {
            Variables.choiceAction = 1;
            Variables.pnlNumber = 2;

            DialogResult dialog = new FormAddRestaraunt().ShowDialog();

            if (dialog == DialogResult.Cancel)
            {
                this.заказыВРесторанеTableAdapter.Fill(this.центрОРDataSet.ЗаказыВРесторане);
            }
        }

        private void iBtnChangeD_Click(object sender, EventArgs e)
        {
            Variables.choiceAction = 2;
            Variables.pnlNumber = 2;
            Variables.codeOfTable = Convert.ToInt32(dealsDataGridView.CurrentRow.Cells[0].Value);

            DialogResult dialog = new FormAddRestaraunt().ShowDialog();

            if (dialog == DialogResult.Cancel)
            {
                this.заказыВРесторанеTableAdapter.Fill(this.центрОРDataSet.ЗаказыВРесторане);
            }
        }

        private void iBtnAddH_Click(object sender, EventArgs e)
        {
            Variables.choiceAction = 1;
            Variables.pnlNumber = 3;

            DialogResult dialog = new FormAddRestaraunt().ShowDialog();

            if (dialog == DialogResult.Cancel)
            {
                this.залРесторанаTableAdapter.Fill(this.центрОРDataSet.ЗалРесторана);
            }
        }

        private void iBtnChangeH_Click(object sender, EventArgs e)
        {
            Variables.choiceAction = 2;
            Variables.pnlNumber = 3;
            Variables.codeOfTable = Convert.ToInt32(hallDataGridView.CurrentRow.Cells[0].Value);

            DialogResult dialog = new FormAddRestaraunt().ShowDialog();

            if (dialog == DialogResult.Cancel)
            {
                this.залРесторанаTableAdapter.Fill(this.центрОРDataSet.ЗалРесторана);
            }
        }
    }
}
