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
    public partial class Spa : Form
    {
        public Spa()
        {
            InitializeComponent();
        }

        private void Spa_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.СпаСалон". При необходимости она может быть перемещена или удалена.
            this.спаСалонTableAdapter.Fill(this.центрОРDataSet.СпаСалон);

        }
    }
}
