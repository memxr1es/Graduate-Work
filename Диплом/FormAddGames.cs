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
