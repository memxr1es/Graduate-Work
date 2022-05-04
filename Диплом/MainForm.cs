using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Диплом
{
    public partial class MainForm : Form
    {
        private Form currentChildForm;
        private Panel TopBorderBtn;
        private static IconButton currentBtn;
        private static IconButton tempB = null;
        private EventHandler funcB = null;
        private static Color colorTopBtn = Color.FromArgb(128, 0, 128);

        public MainForm()
        {
            InitializeComponent();

            TopBorderBtn = new Panel();
            TopBorderBtn.Size = new Size(112, 7);
            pnlTopBar.Controls.Add(TopBorderBtn);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ssMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ActivateButton(object senderBtn, EventHandler func)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(25, 25, 83);
                currentBtn.Click -= func;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;

                TopBorderBtn.BackColor = colorTopBtn;
                TopBorderBtn.Location = new Point(currentBtn.Location.X, 0);
                TopBorderBtn.Visible = true;
                TopBorderBtn.BringToFront();


                tempB = currentBtn;
                funcB = func;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                if (tempB != null)
                {
                    tempB.Click += funcB;
                }

                currentBtn.BackColor = Color.FromArgb(25, 25, 100);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;

            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            toolStripLabel1.Text = $"Текущая форма : {childForm.Text}";

            currentChildForm = childForm;
            childForm.MouseDown += ssMenu_MouseDown;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        #region WorkWithButtons

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, btnHome_Click);
            OpenChildForm(new Home());
        }

        private void btnRestaraunt_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, btnRestaraunt_Click);
            OpenChildForm(new Restaraunt());
            this.Size = new Size(897, 468);
        }

        private void btnAquapark_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, btnAquapark_Click);
            OpenChildForm(new Aquapark());

            this.Size = new Size(897, 468);
        }

        private void btnSpa_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, btnSpa_Click);
            OpenChildForm(new Spa());

            this.Size = new Size(897, 468);
        }

        private void btnZoo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, btnZoo_Click);
            OpenChildForm(new Zoopark());

            this.Size = new Size(897, 468);
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, btnGame_Click);
            OpenChildForm(new Games());

            this.Size = new Size(897, 468);
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, btnPersonal_Click);
            OpenChildForm(new Employee());

            this.Size = new Size(897, 468);
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, btnHotel_Click);
            OpenChildForm(new Hotel());

            this.Size = new Size(897, 468);
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            ActivateButton(btnHome, btnHome_Click);
            OpenChildForm(new Home());

            toolStripLabel2.Text = "Текущий пользователь : ";
            timer1.Start();

            toolStripLabel7.Text = "Текущая дата : " + DateTime.Now.ToString("d MMMM yyyy г.", CultureInfo.GetCultureInfo("ru-ru")) + ", время : " + DateTime.Now.ToShortTimeString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel7.Text = "Текущая дата : " + DateTime.Now.ToString("d MMMM yyyy г.", CultureInfo.GetCultureInfo("ru-ru")) + ", время : " + DateTime.Now.ToShortTimeString();
        }
    }
}
