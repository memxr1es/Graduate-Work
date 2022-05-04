
namespace Диплом
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnHotel = new FontAwesome.Sharp.IconButton();
            this.btnPersonal = new FontAwesome.Sharp.IconButton();
            this.btnGame = new FontAwesome.Sharp.IconButton();
            this.btnZoo = new FontAwesome.Sharp.IconButton();
            this.btnSpa = new FontAwesome.Sharp.IconButton();
            this.btnAquapark = new FontAwesome.Sharp.IconButton();
            this.btnRestaraunt = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.pnlTopBar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(100)))));
            this.pnlTopBar.Controls.Add(this.btnHotel);
            this.pnlTopBar.Controls.Add(this.btnPersonal);
            this.pnlTopBar.Controls.Add(this.btnGame);
            this.pnlTopBar.Controls.Add(this.btnZoo);
            this.pnlTopBar.Controls.Add(this.btnSpa);
            this.pnlTopBar.Controls.Add(this.btnAquapark);
            this.pnlTopBar.Controls.Add(this.btnRestaraunt);
            this.pnlTopBar.Controls.Add(this.btnHome);
            this.pnlTopBar.Location = new System.Drawing.Point(0, 25);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(897, 77);
            this.pnlTopBar.TabIndex = 0;
            // 
            // btnHotel
            // 
            this.btnHotel.BackColor = System.Drawing.Color.Transparent;
            this.btnHotel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHotel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnHotel.FlatAppearance.BorderSize = 0;
            this.btnHotel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(130)))));
            this.btnHotel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotel.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.btnHotel.IconColor = System.Drawing.SystemColors.Control;
            this.btnHotel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHotel.Location = new System.Drawing.Point(784, 0);
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.Size = new System.Drawing.Size(113, 77);
            this.btnHotel.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnHotel, "Отель");
            this.btnHotel.UseVisualStyleBackColor = false;
            this.btnHotel.Click += new System.EventHandler(this.btnHotel_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonal.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPersonal.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnPersonal.FlatAppearance.BorderSize = 0;
            this.btnPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(130)))));
            this.btnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.IconChar = FontAwesome.Sharp.IconChar.Male;
            this.btnPersonal.IconColor = System.Drawing.SystemColors.Control;
            this.btnPersonal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPersonal.Location = new System.Drawing.Point(672, 0);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(112, 77);
            this.btnPersonal.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnPersonal, "Персонал");
            this.btnPersonal.UseVisualStyleBackColor = false;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.Transparent;
            this.btnGame.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGame.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnGame.FlatAppearance.BorderSize = 0;
            this.btnGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(130)))));
            this.btnGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGame.IconChar = FontAwesome.Sharp.IconChar.PuzzlePiece;
            this.btnGame.IconColor = System.Drawing.SystemColors.Control;
            this.btnGame.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGame.Location = new System.Drawing.Point(560, 0);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(112, 77);
            this.btnGame.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnGame, "Развлечения");
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnZoo
            // 
            this.btnZoo.BackColor = System.Drawing.Color.Transparent;
            this.btnZoo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnZoo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnZoo.FlatAppearance.BorderSize = 0;
            this.btnZoo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(130)))));
            this.btnZoo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnZoo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoo.IconChar = FontAwesome.Sharp.IconChar.Hippo;
            this.btnZoo.IconColor = System.Drawing.SystemColors.Control;
            this.btnZoo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnZoo.Location = new System.Drawing.Point(448, 0);
            this.btnZoo.Name = "btnZoo";
            this.btnZoo.Size = new System.Drawing.Size(112, 77);
            this.btnZoo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnZoo, "Зоопарк");
            this.btnZoo.UseVisualStyleBackColor = false;
            this.btnZoo.Click += new System.EventHandler(this.btnZoo_Click);
            // 
            // btnSpa
            // 
            this.btnSpa.BackColor = System.Drawing.Color.Transparent;
            this.btnSpa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSpa.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSpa.FlatAppearance.BorderSize = 0;
            this.btnSpa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(130)))));
            this.btnSpa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnSpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpa.IconChar = FontAwesome.Sharp.IconChar.Spa;
            this.btnSpa.IconColor = System.Drawing.SystemColors.Control;
            this.btnSpa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSpa.Location = new System.Drawing.Point(336, 0);
            this.btnSpa.Name = "btnSpa";
            this.btnSpa.Size = new System.Drawing.Size(112, 77);
            this.btnSpa.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnSpa, "Спа-салон");
            this.btnSpa.UseVisualStyleBackColor = false;
            this.btnSpa.Click += new System.EventHandler(this.btnSpa_Click);
            // 
            // btnAquapark
            // 
            this.btnAquapark.BackColor = System.Drawing.Color.Transparent;
            this.btnAquapark.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAquapark.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAquapark.FlatAppearance.BorderSize = 0;
            this.btnAquapark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(130)))));
            this.btnAquapark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnAquapark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAquapark.IconChar = FontAwesome.Sharp.IconChar.Bacon;
            this.btnAquapark.IconColor = System.Drawing.SystemColors.Control;
            this.btnAquapark.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAquapark.Location = new System.Drawing.Point(224, 0);
            this.btnAquapark.Name = "btnAquapark";
            this.btnAquapark.Size = new System.Drawing.Size(112, 77);
            this.btnAquapark.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnAquapark, "Аквапарк");
            this.btnAquapark.UseVisualStyleBackColor = false;
            this.btnAquapark.Click += new System.EventHandler(this.btnAquapark_Click);
            // 
            // btnRestaraunt
            // 
            this.btnRestaraunt.BackColor = System.Drawing.Color.Transparent;
            this.btnRestaraunt.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRestaraunt.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnRestaraunt.FlatAppearance.BorderSize = 0;
            this.btnRestaraunt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(130)))));
            this.btnRestaraunt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnRestaraunt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaraunt.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.btnRestaraunt.IconColor = System.Drawing.SystemColors.Control;
            this.btnRestaraunt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestaraunt.Location = new System.Drawing.Point(112, 0);
            this.btnRestaraunt.Name = "btnRestaraunt";
            this.btnRestaraunt.Size = new System.Drawing.Size(112, 77);
            this.btnRestaraunt.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnRestaraunt, "Ресторан");
            this.btnRestaraunt.UseVisualStyleBackColor = false;
            this.btnRestaraunt.Click += new System.EventHandler(this.btnRestaraunt_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(130)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.SystemColors.Control;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(112, 77);
            this.btnHome.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnHome, "Домой");
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMain.Location = new System.Drawing.Point(0, 103);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(897, 365);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseDown);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnMinimize);
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.tsMain);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(897, 24);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(840, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 23);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 20;
            this.btnExit.Location = new System.Drawing.Point(873, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 20);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(99, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(99, 22);
            this.toolStripLabel2.Text = "toolStripLabel2";
            // 
            // iconToolStripButton1
            // 
            this.iconToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.iconToolStripButton1.IconColor = System.Drawing.SystemColors.Control;
            this.iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconToolStripButton1.IconSize = 100;
            this.iconToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconToolStripButton1.Name = "iconToolStripButton1";
            this.iconToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.iconToolStripButton1.Text = "iconToolStripButton1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel4.Text = "toolStripLabel3";
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel7.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(99, 22);
            this.toolStripLabel7.Text = "toolStripLabel7";
            // 
            // tsMain
            // 
            this.tsMain.BackColor = System.Drawing.Color.Transparent;
            this.tsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.iconToolStripButton1,
            this.toolStripSeparator2,
            this.toolStripLabel4,
            this.toolStripLabel7});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsMain.Size = new System.Drawing.Size(897, 24);
            this.tsMain.TabIndex = 6;
            this.tsMain.Text = "toolStrip2";
            this.tsMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ssMenu_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(897, 468);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel pnlMain;
        private FontAwesome.Sharp.IconButton btnHotel;
        private FontAwesome.Sharp.IconButton btnPersonal;
        private FontAwesome.Sharp.IconButton btnGame;
        private FontAwesome.Sharp.IconButton btnZoo;
        private FontAwesome.Sharp.IconButton btnSpa;
        private FontAwesome.Sharp.IconButton btnAquapark;
        private FontAwesome.Sharp.IconButton btnRestaraunt;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.ToolTip toolTip1;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
    }
}

