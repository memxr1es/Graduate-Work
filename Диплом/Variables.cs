using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Диплом
{
    public static class Variables
    {
        public static string nameOfBooking;
        public static bool checkReturn;
        public static int choiceAction;
        public static int pnlNumber;

        public static int codeOfTable;

        public static void checkForFillingTxb(System.Windows.Forms.Panel pnl)
        {
            foreach (var txb in pnl.Controls.OfType<System.Windows.Forms.TextBox>())
            {
                if (txb.Text == "")
                {
                    MessageBox.Show("Все поля обязательны к заполнению!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        public static void checkForFillingCmb(System.Windows.Forms.Panel pnl)
        {
            foreach (var cmb in pnl.Controls.OfType<System.Windows.Forms.ComboBox>())
            {
                if (cmb.Text == "")
                {
                    MessageBox.Show("Выберите элемент из списка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
