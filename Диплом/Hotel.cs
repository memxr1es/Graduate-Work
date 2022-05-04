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
    public partial class Hotel : Form
    {
        public Hotel()
        {
            InitializeComponent();
        }

        private void отельBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.отельBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.центрОРDataSet);

        }

        private void Hotel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.Отель". При необходимости она может быть перемещена или удалена.
            this.отельTableAdapter.Fill(this.центрОРDataSet.Отель);

        }
    }
}
