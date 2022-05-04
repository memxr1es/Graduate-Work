
namespace Диплом
{
    partial class Restaraunt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlChoice = new System.Windows.Forms.Panel();
            this.btnHall = new System.Windows.Forms.Button();
            this.btnDeals = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.iBtnDel = new FontAwesome.Sharp.IconButton();
            this.iBtnChange = new FontAwesome.Sharp.IconButton();
            this.iBtnAdd = new FontAwesome.Sharp.IconButton();
            this.menuDataGridView = new System.Windows.Forms.DataGridView();
            this.номерБлюдаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеБлюдаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ингредиентыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.калорийностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.граммDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.менюРесторанаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.центрОРDataSet = new Диплом.ЦентрОРDataSet();
            this.iBtnBack = new FontAwesome.Sharp.IconButton();
            this.pnlDeals = new System.Windows.Forms.Panel();
            this.iBtnDelD = new FontAwesome.Sharp.IconButton();
            this.iBtnChangeD = new FontAwesome.Sharp.IconButton();
            this.iBtnAddD = new FontAwesome.Sharp.IconButton();
            this.dealsDataGridView = new System.Windows.Forms.DataGridView();
            this.заказыВРесторанеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlHall = new System.Windows.Forms.Panel();
            this.iBtnDelH = new FontAwesome.Sharp.IconButton();
            this.iBtnChangeH = new FontAwesome.Sharp.IconButton();
            this.iBtnAddH = new FontAwesome.Sharp.IconButton();
            this.hallDataGridView = new System.Windows.Forms.DataGridView();
            this.номерСтолаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вместимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.залРесторанаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.менюРесторанаTableAdapter = new Диплом.ЦентрОРDataSetTableAdapters.МенюРесторанаTableAdapter();
            this.заказыВРесторанеTableAdapter = new Диплом.ЦентрОРDataSetTableAdapters.ЗаказыВРесторанеTableAdapter();
            this.залРесторанаTableAdapter = new Диплом.ЦентрОРDataSetTableAdapters.ЗалРесторанаTableAdapter();
            this.номерСтолаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеБлюдаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.состояниеЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlChoice.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.менюРесторанаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.центрОРDataSet)).BeginInit();
            this.pnlDeals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыВРесторанеBindingSource)).BeginInit();
            this.pnlHall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hallDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.залРесторанаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChoice
            // 
            this.pnlChoice.Controls.Add(this.btnHall);
            this.pnlChoice.Controls.Add(this.btnDeals);
            this.pnlChoice.Controls.Add(this.btnMenu);
            this.pnlChoice.Location = new System.Drawing.Point(12, 22);
            this.pnlChoice.Name = "pnlChoice";
            this.pnlChoice.Size = new System.Drawing.Size(857, 103);
            this.pnlChoice.TabIndex = 0;
            // 
            // btnHall
            // 
            this.btnHall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.btnHall.FlatAppearance.BorderSize = 0;
            this.btnHall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHall.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHall.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHall.Location = new System.Drawing.Point(611, 28);
            this.btnHall.Name = "btnHall";
            this.btnHall.Size = new System.Drawing.Size(156, 42);
            this.btnHall.TabIndex = 2;
            this.btnHall.Text = "Зал";
            this.btnHall.UseVisualStyleBackColor = false;
            this.btnHall.Click += new System.EventHandler(this.btnHall_Click);
            // 
            // btnDeals
            // 
            this.btnDeals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.btnDeals.FlatAppearance.BorderSize = 0;
            this.btnDeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeals.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeals.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeals.Location = new System.Drawing.Point(337, 28);
            this.btnDeals.Name = "btnDeals";
            this.btnDeals.Size = new System.Drawing.Size(156, 42);
            this.btnDeals.TabIndex = 1;
            this.btnDeals.Text = "Заказы";
            this.btnDeals.UseVisualStyleBackColor = false;
            this.btnDeals.Click += new System.EventHandler(this.btnDeals_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenu.Location = new System.Drawing.Point(51, 28);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(156, 42);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Меню";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.iBtnDel);
            this.pnlMenu.Controls.Add(this.iBtnChange);
            this.pnlMenu.Controls.Add(this.iBtnAdd);
            this.pnlMenu.Controls.Add(this.menuDataGridView);
            this.pnlMenu.Location = new System.Drawing.Point(12, 131);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(856, 344);
            this.pnlMenu.TabIndex = 1;
            this.pnlMenu.Visible = false;
            // 
            // iBtnDel
            // 
            this.iBtnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.iBtnDel.FlatAppearance.BorderSize = 0;
            this.iBtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDel.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iBtnDel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iBtnDel.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iBtnDel.IconColor = System.Drawing.Color.Gainsboro;
            this.iBtnDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDel.IconSize = 24;
            this.iBtnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDel.Location = new System.Drawing.Point(675, 276);
            this.iBtnDel.Name = "iBtnDel";
            this.iBtnDel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iBtnDel.Size = new System.Drawing.Size(133, 39);
            this.iBtnDel.TabIndex = 11;
            this.iBtnDel.Text = "Удалить";
            this.iBtnDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDel.UseVisualStyleBackColor = false;
            // 
            // iBtnChange
            // 
            this.iBtnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.iBtnChange.FlatAppearance.BorderSize = 0;
            this.iBtnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnChange.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iBtnChange.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iBtnChange.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iBtnChange.IconColor = System.Drawing.Color.Gainsboro;
            this.iBtnChange.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnChange.IconSize = 24;
            this.iBtnChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnChange.Location = new System.Drawing.Point(201, 276);
            this.iBtnChange.Name = "iBtnChange";
            this.iBtnChange.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iBtnChange.Size = new System.Drawing.Size(133, 39);
            this.iBtnChange.TabIndex = 10;
            this.iBtnChange.Text = "Изменить";
            this.iBtnChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnChange.UseVisualStyleBackColor = false;
            this.iBtnChange.Click += new System.EventHandler(this.iBtnChange_Click);
            // 
            // iBtnAdd
            // 
            this.iBtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.iBtnAdd.FlatAppearance.BorderSize = 0;
            this.iBtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnAdd.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iBtnAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iBtnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iBtnAdd.IconColor = System.Drawing.Color.Gainsboro;
            this.iBtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnAdd.IconSize = 24;
            this.iBtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAdd.Location = new System.Drawing.Point(51, 276);
            this.iBtnAdd.Name = "iBtnAdd";
            this.iBtnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iBtnAdd.Size = new System.Drawing.Size(133, 39);
            this.iBtnAdd.TabIndex = 9;
            this.iBtnAdd.Text = "Добавить";
            this.iBtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnAdd.UseVisualStyleBackColor = false;
            this.iBtnAdd.Click += new System.EventHandler(this.iBtnAdd_Click);
            // 
            // menuDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.menuDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.menuDataGridView.AutoGenerateColumns = false;
            this.menuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.menuDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            this.menuDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.menuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерБлюдаDataGridViewTextBoxColumn,
            this.названиеБлюдаDataGridViewTextBoxColumn,
            this.ингредиентыDataGridViewTextBoxColumn,
            this.калорийностьDataGridViewTextBoxColumn,
            this.граммDataGridViewTextBoxColumn});
            this.menuDataGridView.DataSource = this.менюРесторанаBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.menuDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.menuDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.menuDataGridView.Location = new System.Drawing.Point(50, 32);
            this.menuDataGridView.Name = "menuDataGridView";
            this.menuDataGridView.ReadOnly = true;
            this.menuDataGridView.RowHeadersVisible = false;
            this.menuDataGridView.Size = new System.Drawing.Size(758, 220);
            this.menuDataGridView.TabIndex = 3;
            // 
            // номерБлюдаDataGridViewTextBoxColumn
            // 
            this.номерБлюдаDataGridViewTextBoxColumn.DataPropertyName = "НомерБлюда";
            this.номерБлюдаDataGridViewTextBoxColumn.HeaderText = "Номер блюда";
            this.номерБлюдаDataGridViewTextBoxColumn.Name = "номерБлюдаDataGridViewTextBoxColumn";
            this.номерБлюдаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеБлюдаDataGridViewTextBoxColumn
            // 
            this.названиеБлюдаDataGridViewTextBoxColumn.DataPropertyName = "НазваниеБлюда";
            this.названиеБлюдаDataGridViewTextBoxColumn.HeaderText = "Название блюда";
            this.названиеБлюдаDataGridViewTextBoxColumn.Name = "названиеБлюдаDataGridViewTextBoxColumn";
            this.названиеБлюдаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ингредиентыDataGridViewTextBoxColumn
            // 
            this.ингредиентыDataGridViewTextBoxColumn.DataPropertyName = "Ингредиенты";
            this.ингредиентыDataGridViewTextBoxColumn.HeaderText = "Ингредиенты";
            this.ингредиентыDataGridViewTextBoxColumn.Name = "ингредиентыDataGridViewTextBoxColumn";
            this.ингредиентыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // калорийностьDataGridViewTextBoxColumn
            // 
            this.калорийностьDataGridViewTextBoxColumn.DataPropertyName = "Калорийность";
            this.калорийностьDataGridViewTextBoxColumn.HeaderText = "Калорийность";
            this.калорийностьDataGridViewTextBoxColumn.Name = "калорийностьDataGridViewTextBoxColumn";
            this.калорийностьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // граммDataGridViewTextBoxColumn
            // 
            this.граммDataGridViewTextBoxColumn.DataPropertyName = "Грамм";
            this.граммDataGridViewTextBoxColumn.HeaderText = "Грамм";
            this.граммDataGridViewTextBoxColumn.Name = "граммDataGridViewTextBoxColumn";
            this.граммDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // менюРесторанаBindingSource
            // 
            this.менюРесторанаBindingSource.DataMember = "МенюРесторана";
            this.менюРесторанаBindingSource.DataSource = this.центрОРDataSet;
            // 
            // центрОРDataSet
            // 
            this.центрОРDataSet.DataSetName = "ЦентрОРDataSet";
            this.центрОРDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iBtnBack
            // 
            this.iBtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iBtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iBtnBack.FlatAppearance.BorderSize = 0;
            this.iBtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iBtnBack.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.iBtnBack.IconColor = System.Drawing.Color.Gainsboro;
            this.iBtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnBack.IconSize = 25;
            this.iBtnBack.Location = new System.Drawing.Point(-1, 0);
            this.iBtnBack.Name = "iBtnBack";
            this.iBtnBack.Size = new System.Drawing.Size(24, 20);
            this.iBtnBack.TabIndex = 12;
            this.iBtnBack.UseVisualStyleBackColor = true;
            this.iBtnBack.Visible = false;
            this.iBtnBack.Click += new System.EventHandler(this.iBtnBack_Click);
            // 
            // pnlDeals
            // 
            this.pnlDeals.Controls.Add(this.iBtnDelD);
            this.pnlDeals.Controls.Add(this.iBtnChangeD);
            this.pnlDeals.Controls.Add(this.iBtnAddD);
            this.pnlDeals.Controls.Add(this.dealsDataGridView);
            this.pnlDeals.Location = new System.Drawing.Point(13, 491);
            this.pnlDeals.Name = "pnlDeals";
            this.pnlDeals.Size = new System.Drawing.Size(856, 344);
            this.pnlDeals.TabIndex = 12;
            this.pnlDeals.Visible = false;
            // 
            // iBtnDelD
            // 
            this.iBtnDelD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.iBtnDelD.FlatAppearance.BorderSize = 0;
            this.iBtnDelD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDelD.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iBtnDelD.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iBtnDelD.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iBtnDelD.IconColor = System.Drawing.Color.Gainsboro;
            this.iBtnDelD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDelD.IconSize = 24;
            this.iBtnDelD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDelD.Location = new System.Drawing.Point(675, 276);
            this.iBtnDelD.Name = "iBtnDelD";
            this.iBtnDelD.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iBtnDelD.Size = new System.Drawing.Size(133, 39);
            this.iBtnDelD.TabIndex = 11;
            this.iBtnDelD.Text = "Удалить";
            this.iBtnDelD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDelD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDelD.UseVisualStyleBackColor = false;
            // 
            // iBtnChangeD
            // 
            this.iBtnChangeD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.iBtnChangeD.FlatAppearance.BorderSize = 0;
            this.iBtnChangeD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnChangeD.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iBtnChangeD.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iBtnChangeD.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iBtnChangeD.IconColor = System.Drawing.Color.Gainsboro;
            this.iBtnChangeD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnChangeD.IconSize = 24;
            this.iBtnChangeD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnChangeD.Location = new System.Drawing.Point(201, 276);
            this.iBtnChangeD.Name = "iBtnChangeD";
            this.iBtnChangeD.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iBtnChangeD.Size = new System.Drawing.Size(133, 39);
            this.iBtnChangeD.TabIndex = 10;
            this.iBtnChangeD.Text = "Изменить";
            this.iBtnChangeD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnChangeD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnChangeD.UseVisualStyleBackColor = false;
            this.iBtnChangeD.Click += new System.EventHandler(this.iBtnChangeD_Click);
            // 
            // iBtnAddD
            // 
            this.iBtnAddD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.iBtnAddD.FlatAppearance.BorderSize = 0;
            this.iBtnAddD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnAddD.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iBtnAddD.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iBtnAddD.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iBtnAddD.IconColor = System.Drawing.Color.Gainsboro;
            this.iBtnAddD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnAddD.IconSize = 24;
            this.iBtnAddD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAddD.Location = new System.Drawing.Point(51, 276);
            this.iBtnAddD.Name = "iBtnAddD";
            this.iBtnAddD.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iBtnAddD.Size = new System.Drawing.Size(133, 39);
            this.iBtnAddD.TabIndex = 9;
            this.iBtnAddD.Text = "Добавить";
            this.iBtnAddD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAddD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnAddD.UseVisualStyleBackColor = false;
            this.iBtnAddD.Click += new System.EventHandler(this.iBtnAddD_Click);
            // 
            // dealsDataGridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.dealsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dealsDataGridView.AutoGenerateColumns = false;
            this.dealsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dealsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            this.dealsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dealsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dealsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dealsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dealsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерСтолаDataGridViewTextBoxColumn,
            this.наименованиеБлюдаDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.состояниеЗаказаDataGridViewTextBoxColumn});
            this.dealsDataGridView.DataSource = this.заказыВРесторанеBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dealsDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.dealsDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.dealsDataGridView.Location = new System.Drawing.Point(50, 32);
            this.dealsDataGridView.Name = "dealsDataGridView";
            this.dealsDataGridView.RowHeadersVisible = false;
            this.dealsDataGridView.Size = new System.Drawing.Size(758, 220);
            this.dealsDataGridView.TabIndex = 3;
            // 
            // заказыВРесторанеBindingSource
            // 
            this.заказыВРесторанеBindingSource.DataMember = "ЗаказыВРесторане";
            this.заказыВРесторанеBindingSource.DataSource = this.центрОРDataSet;
            // 
            // pnlHall
            // 
            this.pnlHall.Controls.Add(this.iBtnDelH);
            this.pnlHall.Controls.Add(this.iBtnChangeH);
            this.pnlHall.Controls.Add(this.iBtnAddH);
            this.pnlHall.Controls.Add(this.hallDataGridView);
            this.pnlHall.Location = new System.Drawing.Point(893, 491);
            this.pnlHall.Name = "pnlHall";
            this.pnlHall.Size = new System.Drawing.Size(856, 344);
            this.pnlHall.TabIndex = 13;
            this.pnlHall.Visible = false;
            // 
            // iBtnDelH
            // 
            this.iBtnDelH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.iBtnDelH.FlatAppearance.BorderSize = 0;
            this.iBtnDelH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDelH.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iBtnDelH.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iBtnDelH.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iBtnDelH.IconColor = System.Drawing.Color.Gainsboro;
            this.iBtnDelH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDelH.IconSize = 24;
            this.iBtnDelH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDelH.Location = new System.Drawing.Point(675, 276);
            this.iBtnDelH.Name = "iBtnDelH";
            this.iBtnDelH.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iBtnDelH.Size = new System.Drawing.Size(133, 39);
            this.iBtnDelH.TabIndex = 11;
            this.iBtnDelH.Text = "Удалить";
            this.iBtnDelH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDelH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDelH.UseVisualStyleBackColor = false;
            // 
            // iBtnChangeH
            // 
            this.iBtnChangeH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.iBtnChangeH.FlatAppearance.BorderSize = 0;
            this.iBtnChangeH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnChangeH.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iBtnChangeH.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iBtnChangeH.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iBtnChangeH.IconColor = System.Drawing.Color.Gainsboro;
            this.iBtnChangeH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnChangeH.IconSize = 24;
            this.iBtnChangeH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnChangeH.Location = new System.Drawing.Point(201, 276);
            this.iBtnChangeH.Name = "iBtnChangeH";
            this.iBtnChangeH.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iBtnChangeH.Size = new System.Drawing.Size(133, 39);
            this.iBtnChangeH.TabIndex = 10;
            this.iBtnChangeH.Text = "Изменить";
            this.iBtnChangeH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnChangeH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnChangeH.UseVisualStyleBackColor = false;
            this.iBtnChangeH.Click += new System.EventHandler(this.iBtnChangeH_Click);
            // 
            // iBtnAddH
            // 
            this.iBtnAddH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.iBtnAddH.FlatAppearance.BorderSize = 0;
            this.iBtnAddH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnAddH.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iBtnAddH.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iBtnAddH.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iBtnAddH.IconColor = System.Drawing.Color.Gainsboro;
            this.iBtnAddH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnAddH.IconSize = 24;
            this.iBtnAddH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAddH.Location = new System.Drawing.Point(51, 276);
            this.iBtnAddH.Name = "iBtnAddH";
            this.iBtnAddH.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iBtnAddH.Size = new System.Drawing.Size(133, 39);
            this.iBtnAddH.TabIndex = 9;
            this.iBtnAddH.Text = "Добавить";
            this.iBtnAddH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAddH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnAddH.UseVisualStyleBackColor = false;
            this.iBtnAddH.Click += new System.EventHandler(this.iBtnAddH_Click);
            // 
            // hallDataGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.hallDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.hallDataGridView.AutoGenerateColumns = false;
            this.hallDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hallDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            this.hallDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hallDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hallDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.hallDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hallDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерСтолаDataGridViewTextBoxColumn1,
            this.вместимостьDataGridViewTextBoxColumn});
            this.hallDataGridView.DataSource = this.залРесторанаBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.hallDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.hallDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.hallDataGridView.Location = new System.Drawing.Point(50, 32);
            this.hallDataGridView.Name = "hallDataGridView";
            this.hallDataGridView.RowHeadersVisible = false;
            this.hallDataGridView.Size = new System.Drawing.Size(758, 220);
            this.hallDataGridView.TabIndex = 3;
            // 
            // номерСтолаDataGridViewTextBoxColumn1
            // 
            this.номерСтолаDataGridViewTextBoxColumn1.DataPropertyName = "НомерСтола";
            this.номерСтолаDataGridViewTextBoxColumn1.HeaderText = "Номер стола";
            this.номерСтолаDataGridViewTextBoxColumn1.Name = "номерСтолаDataGridViewTextBoxColumn1";
            // 
            // вместимостьDataGridViewTextBoxColumn
            // 
            this.вместимостьDataGridViewTextBoxColumn.DataPropertyName = "Вместимость";
            this.вместимостьDataGridViewTextBoxColumn.HeaderText = "Вместимость";
            this.вместимостьDataGridViewTextBoxColumn.Name = "вместимостьDataGridViewTextBoxColumn";
            // 
            // залРесторанаBindingSource
            // 
            this.залРесторанаBindingSource.DataMember = "ЗалРесторана";
            this.залРесторанаBindingSource.DataSource = this.центрОРDataSet;
            // 
            // менюРесторанаTableAdapter
            // 
            this.менюРесторанаTableAdapter.ClearBeforeFill = true;
            // 
            // заказыВРесторанеTableAdapter
            // 
            this.заказыВРесторанеTableAdapter.ClearBeforeFill = true;
            // 
            // залРесторанаTableAdapter
            // 
            this.залРесторанаTableAdapter.ClearBeforeFill = true;
            // 
            // номерСтолаDataGridViewTextBoxColumn
            // 
            this.номерСтолаDataGridViewTextBoxColumn.DataPropertyName = "НомерСтола";
            this.номерСтолаDataGridViewTextBoxColumn.HeaderText = "Номер стола";
            this.номерСтолаDataGridViewTextBoxColumn.Name = "номерСтолаDataGridViewTextBoxColumn";
            // 
            // наименованиеБлюдаDataGridViewTextBoxColumn
            // 
            this.наименованиеБлюдаDataGridViewTextBoxColumn.DataPropertyName = "НаименованиеБлюда";
            this.наименованиеБлюдаDataGridViewTextBoxColumn.DataSource = this.менюРесторанаBindingSource;
            this.наименованиеБлюдаDataGridViewTextBoxColumn.DisplayMember = "НазваниеБлюда";
            this.наименованиеБлюдаDataGridViewTextBoxColumn.HeaderText = "Наименование блюда";
            this.наименованиеБлюдаDataGridViewTextBoxColumn.Name = "наименованиеБлюдаDataGridViewTextBoxColumn";
            this.наименованиеБлюдаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.наименованиеБлюдаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.наименованиеБлюдаDataGridViewTextBoxColumn.ValueMember = "НомерБлюда";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // состояниеЗаказаDataGridViewTextBoxColumn
            // 
            this.состояниеЗаказаDataGridViewTextBoxColumn.DataPropertyName = "СостояниеЗаказа";
            this.состояниеЗаказаDataGridViewTextBoxColumn.HeaderText = "Состояние заказа";
            this.состояниеЗаказаDataGridViewTextBoxColumn.Name = "состояниеЗаказаDataGridViewTextBoxColumn";
            // 
            // Restaraunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1767, 855);
            this.Controls.Add(this.iBtnBack);
            this.Controls.Add(this.pnlHall);
            this.Controls.Add(this.pnlDeals);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlChoice);
            this.Name = "Restaraunt";
            this.Text = "Ресторан";
            this.Load += new System.EventHandler(this.Restaraunt_Load);
            this.pnlChoice.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.менюРесторанаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.центрОРDataSet)).EndInit();
            this.pnlDeals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dealsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыВРесторанеBindingSource)).EndInit();
            this.pnlHall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hallDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.залРесторанаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChoice;
        private System.Windows.Forms.Button btnHall;
        private System.Windows.Forms.Button btnDeals;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.DataGridView menuDataGridView;
        private ЦентрОРDataSet центрОРDataSet;
        private FontAwesome.Sharp.IconButton iBtnDel;
        private FontAwesome.Sharp.IconButton iBtnChange;
        private FontAwesome.Sharp.IconButton iBtnAdd;
        private System.Windows.Forms.Panel pnlDeals;
        private FontAwesome.Sharp.IconButton iBtnDelD;
        private FontAwesome.Sharp.IconButton iBtnChangeD;
        private FontAwesome.Sharp.IconButton iBtnAddD;
        private System.Windows.Forms.DataGridView dealsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton iBtnBack;
        private System.Windows.Forms.Panel pnlHall;
        private FontAwesome.Sharp.IconButton iBtnDelH;
        private FontAwesome.Sharp.IconButton iBtnChangeH;
        private FontAwesome.Sharp.IconButton iBtnAddH;
        private System.Windows.Forms.DataGridView hallDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn1;
        private ЦентрОРDataSetTableAdapters.МенюРесторанаTableAdapter менюРесторанаTableAdapter;
        private System.Windows.Forms.BindingSource заказыВРесторанеBindingSource;
        private ЦентрОРDataSetTableAdapters.ЗаказыВРесторанеTableAdapter заказыВРесторанеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерБлюдаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеБлюдаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ингредиентыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn калорийностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn граммDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource менюРесторанаBindingSource;
        private System.Windows.Forms.BindingSource залРесторанаBindingSource;
        private ЦентрОРDataSetTableAdapters.ЗалРесторанаTableAdapter залРесторанаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерСтолаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn вместимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерСтолаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn наименованиеБлюдаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn состояниеЗаказаDataGridViewTextBoxColumn;
    }
}