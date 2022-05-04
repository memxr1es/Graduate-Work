
namespace Диплом
{
    partial class FormAddRestaraunt
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
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label17;
            this.pnlAddDish = new System.Windows.Forms.Panel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.менюРесторанаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.центрОРDataSet = new Диплом.ЦентрОРDataSet();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlAddDeals = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.заказыВРесторанеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.номерСтолаComboBox = new System.Windows.Forms.ComboBox();
            this.btnAddDeal = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlAddTable = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.залРесторанаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.менюРесторанаTableAdapter = new Диплом.ЦентрОРDataSetTableAdapters.МенюРесторанаTableAdapter();
            this.заказыВРесторанеTableAdapter = new Диплом.ЦентрОРDataSetTableAdapters.ЗаказыВРесторанеTableAdapter();
            this.tableAdapterManager = new Диплом.ЦентрОРDataSetTableAdapters.TableAdapterManager();
            this.залРесторанаTableAdapter = new Диплом.ЦентрОРDataSetTableAdapters.ЗалРесторанаTableAdapter();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            this.pnlAddDish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.менюРесторанаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.центрОРDataSet)).BeginInit();
            this.pnlAddDeals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказыВРесторанеBindingSource)).BeginInit();
            this.pnlAddTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.залРесторанаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label9.ForeColor = System.Drawing.SystemColors.Control;
            label9.Location = new System.Drawing.Point(12, 259);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(55, 18);
            label9.TabIndex = 14;
            label9.Text = "Грамм :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label8.ForeColor = System.Drawing.SystemColors.Control;
            label8.Location = new System.Drawing.Point(12, 134);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(119, 18);
            label8.TabIndex = 12;
            label8.Text = "Название блюда :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(12, 215);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(105, 18);
            label3.TabIndex = 9;
            label3.Text = "Калорийность :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.ForeColor = System.Drawing.SystemColors.Control;
            label4.Location = new System.Drawing.Point(12, 174);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(100, 18);
            label4.TabIndex = 3;
            label4.Text = "Ингредиенты :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label6.ForeColor = System.Drawing.SystemColors.Control;
            label6.Location = new System.Drawing.Point(12, 89);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(102, 18);
            label6.TabIndex = 1;
            label6.Text = "Номер блюда :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(12, 217);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 18);
            label1.TabIndex = 14;
            label1.Text = "Состояние заказа :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(12, 132);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(154, 18);
            label2.TabIndex = 12;
            label2.Text = "Наименование блюда :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.ForeColor = System.Drawing.SystemColors.Control;
            label5.Location = new System.Drawing.Point(12, 176);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(88, 18);
            label5.TabIndex = 9;
            label5.Text = "Количество :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label11.ForeColor = System.Drawing.SystemColors.Control;
            label11.Location = new System.Drawing.Point(12, 89);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(95, 18);
            label11.TabIndex = 1;
            label11.Text = "Номер стола :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label14.ForeColor = System.Drawing.SystemColors.Control;
            label14.Location = new System.Drawing.Point(12, 134);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(97, 18);
            label14.TabIndex = 12;
            label14.Text = "Вместимость :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label17.ForeColor = System.Drawing.SystemColors.Control;
            label17.Location = new System.Drawing.Point(12, 89);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(95, 18);
            label17.TabIndex = 1;
            label17.Text = "Номер стола :";
            // 
            // pnlAddDish
            // 
            this.pnlAddDish.Controls.Add(this.textBox9);
            this.pnlAddDish.Controls.Add(this.textBox8);
            this.pnlAddDish.Controls.Add(this.textBox7);
            this.pnlAddDish.Controls.Add(label9);
            this.pnlAddDish.Controls.Add(this.textBox5);
            this.pnlAddDish.Controls.Add(label8);
            this.pnlAddDish.Controls.Add(this.textBox4);
            this.pnlAddDish.Controls.Add(label3);
            this.pnlAddDish.Controls.Add(this.btnAddDish);
            this.pnlAddDish.Controls.Add(label4);
            this.pnlAddDish.Controls.Add(label6);
            this.pnlAddDish.Controls.Add(this.label7);
            this.pnlAddDish.Location = new System.Drawing.Point(23, 30);
            this.pnlAddDish.Name = "pnlAddDish";
            this.pnlAddDish.Size = new System.Drawing.Size(264, 374);
            this.pnlAddDish.TabIndex = 13;
            this.pnlAddDish.Visible = false;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.менюРесторанаBindingSource, "Грамм", true));
            this.textBox9.Location = new System.Drawing.Point(151, 257);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 17;
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
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.менюРесторанаBindingSource, "Калорийность", true));
            this.textBox8.Location = new System.Drawing.Point(151, 215);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.менюРесторанаBindingSource, "Ингредиенты", true));
            this.textBox7.Location = new System.Drawing.Point(151, 174);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.менюРесторанаBindingSource, "НазваниеБлюда", true));
            this.textBox5.Location = new System.Drawing.Point(151, 132);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.менюРесторанаBindingSource, "НомерБлюда", true));
            this.textBox4.Location = new System.Drawing.Point(151, 89);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            // 
            // btnAddDish
            // 
            this.btnAddDish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.btnAddDish.FlatAppearance.BorderSize = 0;
            this.btnAddDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDish.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddDish.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddDish.Location = new System.Drawing.Point(52, 304);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(156, 38);
            this.btnAddDish.TabIndex = 8;
            this.btnAddDish.Text = "Сохранить";
            this.btnAddDish.UseVisualStyleBackColor = false;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Carlito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(48, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Добавление блюда";
            // 
            // pnlAddDeals
            // 
            this.pnlAddDeals.Controls.Add(this.comboBox2);
            this.pnlAddDeals.Controls.Add(this.textBox1);
            this.pnlAddDeals.Controls.Add(this.comboBox1);
            this.pnlAddDeals.Controls.Add(this.номерСтолаComboBox);
            this.pnlAddDeals.Controls.Add(label1);
            this.pnlAddDeals.Controls.Add(label2);
            this.pnlAddDeals.Controls.Add(label5);
            this.pnlAddDeals.Controls.Add(this.btnAddDeal);
            this.pnlAddDeals.Controls.Add(label11);
            this.pnlAddDeals.Controls.Add(this.label12);
            this.pnlAddDeals.Location = new System.Drawing.Point(329, 30);
            this.pnlAddDeals.Name = "pnlAddDeals";
            this.pnlAddDeals.Size = new System.Drawing.Size(284, 324);
            this.pnlAddDeals.TabIndex = 17;
            this.pnlAddDeals.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыВРесторанеBindingSource, "СостояниеЗаказа", true));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Принят к исполнению",
            "Готов к выдаче",
            "Выдан"});
            this.comboBox2.Location = new System.Drawing.Point(165, 215);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(107, 21);
            this.comboBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыВРесторанеBindingSource, "Количество", true));
            this.textBox1.Location = new System.Drawing.Point(165, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 18;
            // 
            // заказыВРесторанеBindingSource
            // 
            this.заказыВРесторанеBindingSource.DataMember = "ЗаказыВРесторане";
            this.заказыВРесторанеBindingSource.DataSource = this.центрОРDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.заказыВРесторанеBindingSource, "НаименованиеБлюда", true));
            this.comboBox1.DataSource = this.менюРесторанаBindingSource;
            this.comboBox1.DisplayMember = "НазваниеБлюда";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(165, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.ValueMember = "НомерБлюда";
            // 
            // номерСтолаComboBox
            // 
            this.номерСтолаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыВРесторанеBindingSource, "НомерСтола", true));
            this.номерСтолаComboBox.DataSource = this.залРесторанаBindingSource;
            this.номерСтолаComboBox.DisplayMember = "НомерСтола";
            this.номерСтолаComboBox.FormattingEnabled = true;
            this.номерСтолаComboBox.Location = new System.Drawing.Point(165, 86);
            this.номерСтолаComboBox.Name = "номерСтолаComboBox";
            this.номерСтолаComboBox.Size = new System.Drawing.Size(107, 21);
            this.номерСтолаComboBox.TabIndex = 18;
            // 
            // btnAddDeal
            // 
            this.btnAddDeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.btnAddDeal.FlatAppearance.BorderSize = 0;
            this.btnAddDeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDeal.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddDeal.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddDeal.Location = new System.Drawing.Point(68, 261);
            this.btnAddDeal.Name = "btnAddDeal";
            this.btnAddDeal.Size = new System.Drawing.Size(156, 38);
            this.btnAddDeal.TabIndex = 8;
            this.btnAddDeal.Text = "Сохранить";
            this.btnAddDeal.UseVisualStyleBackColor = false;
            this.btnAddDeal.Click += new System.EventHandler(this.btnAddDeal_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Carlito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(56, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Добавление заказа";
            // 
            // pnlAddTable
            // 
            this.pnlAddTable.Controls.Add(this.textBox3);
            this.pnlAddTable.Controls.Add(label14);
            this.pnlAddTable.Controls.Add(this.textBox6);
            this.pnlAddTable.Controls.Add(this.btnAddTable);
            this.pnlAddTable.Controls.Add(label17);
            this.pnlAddTable.Controls.Add(this.label18);
            this.pnlAddTable.Location = new System.Drawing.Point(638, 30);
            this.pnlAddTable.Name = "pnlAddTable";
            this.pnlAddTable.Size = new System.Drawing.Size(264, 244);
            this.pnlAddTable.TabIndex = 17;
            this.pnlAddTable.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.залРесторанаBindingSource, "Вместимость", true));
            this.textBox3.Location = new System.Drawing.Point(151, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // залРесторанаBindingSource
            // 
            this.залРесторанаBindingSource.DataMember = "ЗалРесторана";
            this.залРесторанаBindingSource.DataSource = this.центрОРDataSet;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.залРесторанаBindingSource, "НомерСтола", true));
            this.textBox6.Location = new System.Drawing.Point(151, 89);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 10;
            // 
            // btnAddTable
            // 
            this.btnAddTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.btnAddTable.FlatAppearance.BorderSize = 0;
            this.btnAddTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTable.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTable.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddTable.Location = new System.Drawing.Point(51, 176);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(156, 38);
            this.btnAddTable.TabIndex = 8;
            this.btnAddTable.Text = "Сохранить";
            this.btnAddTable.UseVisualStyleBackColor = false;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Carlito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(23, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(214, 23);
            this.label18.TabIndex = 0;
            this.label18.Text = "Добавление стола в зале";
            // 
            // менюРесторанаTableAdapter
            // 
            this.менюРесторанаTableAdapter.ClearBeforeFill = true;
            // 
            // заказыВРесторанеTableAdapter
            // 
            this.заказыВРесторанеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Диплом.ЦентрОРDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АквапаркTableAdapter = null;
            this.tableAdapterManager.БильярдTableAdapter = null;
            this.tableAdapterManager.БоулингTableAdapter = null;
            this.tableAdapterManager.БроньБильярдTableAdapter = null;
            this.tableAdapterManager.БроньБоулингTableAdapter = null;
            this.tableAdapterManager.БроньКараокеTableAdapter = null;
            this.tableAdapterManager.БроньНомераTableAdapter = null;
            this.tableAdapterManager.ЗаказыВРесторанеTableAdapter = this.заказыВРесторанеTableAdapter;
            this.tableAdapterManager.ЗалРесторанаTableAdapter = this.залРесторанаTableAdapter;
            this.tableAdapterManager.ЗоопаркTableAdapter = null;
            this.tableAdapterManager.КараокеTableAdapter = null;
            this.tableAdapterManager.МенюРесторанаTableAdapter = this.менюРесторанаTableAdapter;
            this.tableAdapterManager.ОтельTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.СпаСалонTableAdapter = null;
            // 
            // залРесторанаTableAdapter
            // 
            this.залРесторанаTableAdapter.ClearBeforeFill = true;
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
            this.btnMinimize.Location = new System.Drawing.Point(866, -3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 23);
            this.btnMinimize.TabIndex = 19;
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
            this.btnExit.Location = new System.Drawing.Point(899, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 20);
            this.btnExit.TabIndex = 18;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormAddRestaraunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(923, 512);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlAddTable);
            this.Controls.Add(this.pnlAddDeals);
            this.Controls.Add(this.pnlAddDish);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddRestaraunt";
            this.Text = "FormAddRestaraunt";
            this.Load += new System.EventHandler(this.FormAddRestaraunt_Load);
            this.pnlAddDish.ResumeLayout(false);
            this.pnlAddDish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.менюРесторанаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.центрОРDataSet)).EndInit();
            this.pnlAddDeals.ResumeLayout(false);
            this.pnlAddDeals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказыВРесторанеBindingSource)).EndInit();
            this.pnlAddTable.ResumeLayout(false);
            this.pnlAddTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.залРесторанаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddDish;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlAddDeals;
        private System.Windows.Forms.Button btnAddDeal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlAddTable;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Label label18;
        private ЦентрОРDataSet центрОРDataSet;
        private System.Windows.Forms.BindingSource менюРесторанаBindingSource;
        private ЦентрОРDataSetTableAdapters.МенюРесторанаTableAdapter менюРесторанаTableAdapter;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.BindingSource заказыВРесторанеBindingSource;
        private ЦентрОРDataSetTableAdapters.ЗаказыВРесторанеTableAdapter заказыВРесторанеTableAdapter;
        private ЦентрОРDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox номерСтолаComboBox;
        private ЦентрОРDataSetTableAdapters.ЗалРесторанаTableAdapter залРесторанаTableAdapter;
        private System.Windows.Forms.BindingSource залРесторанаBindingSource;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnExit;
    }
}