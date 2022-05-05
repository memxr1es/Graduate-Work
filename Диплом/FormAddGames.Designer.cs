
namespace Диплом
{
    partial class FormAddGames
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label номерСтоликаLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label14;
            this.pnlAddBilliards = new System.Windows.Forms.Panel();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.бильярдBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.центрОРDataSet = new Диплом.ЦентрОРDataSet();
            this.барCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAddBilliards = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.бильярдTableAdapter = new Диплом.ЦентрОРDataSetTableAdapters.БильярдTableAdapter();
            this.tableAdapterManager = new Диплом.ЦентрОРDataSetTableAdapters.TableAdapterManager();
            this.боулингTableAdapter = new Диплом.ЦентрОРDataSetTableAdapters.БоулингTableAdapter();
            this.караокеTableAdapter = new Диплом.ЦентрОРDataSetTableAdapters.КараокеTableAdapter();
            this.pnlAddBowling = new System.Windows.Forms.Panel();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.боулингBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.счастливыеЧасыMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnAddBowling = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlAddKaraoke = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.караокеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnAddKaraoke = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            номерСтоликаLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            this.pnlAddBilliards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.бильярдBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.центрОРDataSet)).BeginInit();
            this.pnlAddBowling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.боулингBindingSource)).BeginInit();
            this.pnlAddKaraoke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.караокеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.ForeColor = System.Drawing.SystemColors.Control;
            label5.Location = new System.Drawing.Point(12, 180);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(86, 18);
            label5.TabIndex = 9;
            label5.Text = "Цена за час :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(12, 134);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 18);
            label2.TabIndex = 3;
            label2.Text = "Бар :";
            // 
            // номерСтоликаLabel
            // 
            номерСтоликаLabel.AutoSize = true;
            номерСтоликаLabel.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номерСтоликаLabel.ForeColor = System.Drawing.SystemColors.Control;
            номерСтоликаLabel.Location = new System.Drawing.Point(12, 89);
            номерСтоликаLabel.Name = "номерСтоликаLabel";
            номерСтоликаLabel.Size = new System.Drawing.Size(110, 18);
            номерСтоликаLabel.TabIndex = 1;
            номерСтоликаLabel.Text = "Номер cтолика :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(12, 215);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(86, 18);
            label3.TabIndex = 9;
            label3.Text = "Цена за час :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.ForeColor = System.Drawing.SystemColors.Control;
            label4.Location = new System.Drawing.Point(12, 174);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 18);
            label4.TabIndex = 3;
            label4.Text = "Бар :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label6.ForeColor = System.Drawing.SystemColors.Control;
            label6.Location = new System.Drawing.Point(12, 89);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(117, 18);
            label6.TabIndex = 1;
            label6.Text = "Номер дорожки :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label8.ForeColor = System.Drawing.SystemColors.Control;
            label8.Location = new System.Drawing.Point(12, 134);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(133, 18);
            label8.TabIndex = 12;
            label8.Text = "Количество людей :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label9.ForeColor = System.Drawing.SystemColors.Control;
            label9.Location = new System.Drawing.Point(12, 261);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(121, 18);
            label9.TabIndex = 14;
            label9.Text = "Счастливые часы :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label11.ForeColor = System.Drawing.SystemColors.Control;
            label11.Location = new System.Drawing.Point(12, 134);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(122, 18);
            label11.TabIndex = 12;
            label11.Text = "Максимум песен :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label12.ForeColor = System.Drawing.SystemColors.Control;
            label12.Location = new System.Drawing.Point(12, 215);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(86, 18);
            label12.TabIndex = 9;
            label12.Text = "Цена за час :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label13.ForeColor = System.Drawing.SystemColors.Control;
            label13.Location = new System.Drawing.Point(12, 174);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(38, 18);
            label13.TabIndex = 3;
            label13.Text = "Бар :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label14.ForeColor = System.Drawing.SystemColors.Control;
            label14.Location = new System.Drawing.Point(12, 89);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(95, 18);
            label14.TabIndex = 1;
            label14.Text = "Номер стола :";
            // 
            // pnlAddBilliards
            // 
            this.pnlAddBilliards.Controls.Add(this.maskedTextBox3);
            this.pnlAddBilliards.Controls.Add(this.барCheckBox);
            this.pnlAddBilliards.Controls.Add(this.textBox2);
            this.pnlAddBilliards.Controls.Add(label5);
            this.pnlAddBilliards.Controls.Add(this.btnAddBilliards);
            this.pnlAddBilliards.Controls.Add(label2);
            this.pnlAddBilliards.Controls.Add(номерСтоликаLabel);
            this.pnlAddBilliards.Controls.Add(this.label1);
            this.pnlAddBilliards.Location = new System.Drawing.Point(12, 31);
            this.pnlAddBilliards.Name = "pnlAddBilliards";
            this.pnlAddBilliards.Size = new System.Drawing.Size(264, 296);
            this.pnlAddBilliards.TabIndex = 1;
            this.pnlAddBilliards.Visible = false;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.бильярдBindingSource, "ЦенаЗаЧас", true));
            this.maskedTextBox3.Location = new System.Drawing.Point(144, 178);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox3.TabIndex = 16;
            // 
            // бильярдBindingSource
            // 
            this.бильярдBindingSource.DataMember = "Бильярд";
            this.бильярдBindingSource.DataSource = this.центрОРDataSet;
            // 
            // центрОРDataSet
            // 
            this.центрОРDataSet.DataSetName = "ЦентрОРDataSet";
            this.центрОРDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // барCheckBox
            // 
            this.барCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.бильярдBindingSource, "Бар", true));
            this.барCheckBox.Location = new System.Drawing.Point(184, 134);
            this.барCheckBox.Name = "барCheckBox";
            this.барCheckBox.Size = new System.Drawing.Size(14, 24);
            this.барCheckBox.TabIndex = 2;
            this.барCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.бильярдBindingSource, "НомерСтолика", true));
            this.textBox2.Location = new System.Drawing.Point(144, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // btnAddBilliards
            // 
            this.btnAddBilliards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.btnAddBilliards.FlatAppearance.BorderSize = 0;
            this.btnAddBilliards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBilliards.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddBilliards.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddBilliards.Location = new System.Drawing.Point(51, 228);
            this.btnAddBilliards.Name = "btnAddBilliards";
            this.btnAddBilliards.Size = new System.Drawing.Size(156, 38);
            this.btnAddBilliards.TabIndex = 8;
            this.btnAddBilliards.Text = "Сохранить";
            this.btnAddBilliards.UseVisualStyleBackColor = false;
            this.btnAddBilliards.Click += new System.EventHandler(this.btnAddBilliards_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Carlito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление столика";
            // 
            // бильярдTableAdapter
            // 
            this.бильярдTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Диплом.ЦентрОРDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АквапаркTableAdapter = null;
            this.tableAdapterManager.БильярдTableAdapter = this.бильярдTableAdapter;
            this.tableAdapterManager.БоулингTableAdapter = this.боулингTableAdapter;
            this.tableAdapterManager.БроньБильярдTableAdapter = null;
            this.tableAdapterManager.БроньБоулингTableAdapter = null;
            this.tableAdapterManager.БроньКараокеTableAdapter = null;
            this.tableAdapterManager.БроньНомераTableAdapter = null;
            this.tableAdapterManager.ЗаказыВРесторанеTableAdapter = null;
            this.tableAdapterManager.ЗалРесторанаTableAdapter = null;
            this.tableAdapterManager.ЗоопаркTableAdapter = null;
            this.tableAdapterManager.КараокеTableAdapter = this.караокеTableAdapter;
            this.tableAdapterManager.МенюРесторанаTableAdapter = null;
            this.tableAdapterManager.ОтельTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.СпаСалонTableAdapter = null;
            // 
            // боулингTableAdapter
            // 
            this.боулингTableAdapter.ClearBeforeFill = true;
            // 
            // караокеTableAdapter
            // 
            this.караокеTableAdapter.ClearBeforeFill = true;
            // 
            // pnlAddBowling
            // 
            this.pnlAddBowling.Controls.Add(this.maskedTextBox2);
            this.pnlAddBowling.Controls.Add(label9);
            this.pnlAddBowling.Controls.Add(this.счастливыеЧасыMaskedTextBox);
            this.pnlAddBowling.Controls.Add(this.textBox5);
            this.pnlAddBowling.Controls.Add(label8);
            this.pnlAddBowling.Controls.Add(this.checkBox1);
            this.pnlAddBowling.Controls.Add(this.textBox4);
            this.pnlAddBowling.Controls.Add(label3);
            this.pnlAddBowling.Controls.Add(this.btnAddBowling);
            this.pnlAddBowling.Controls.Add(label4);
            this.pnlAddBowling.Controls.Add(label6);
            this.pnlAddBowling.Controls.Add(this.label7);
            this.pnlAddBowling.Location = new System.Drawing.Point(312, 31);
            this.pnlAddBowling.Name = "pnlAddBowling";
            this.pnlAddBowling.Size = new System.Drawing.Size(264, 374);
            this.pnlAddBowling.TabIndex = 12;
            this.pnlAddBowling.Visible = false;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.боулингBindingSource, "ЦенаЗаЧас", true));
            this.maskedTextBox2.Location = new System.Drawing.Point(151, 213);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 16;
            // 
            // боулингBindingSource
            // 
            this.боулингBindingSource.DataMember = "Боулинг";
            this.боулингBindingSource.DataSource = this.центрОРDataSet;
            // 
            // счастливыеЧасыMaskedTextBox
            // 
            this.счастливыеЧасыMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.боулингBindingSource, "СчастливыеЧасы", true));
            this.счастливыеЧасыMaskedTextBox.Location = new System.Drawing.Point(151, 259);
            this.счастливыеЧасыMaskedTextBox.Mask = "с 00:00 до 00:00";
            this.счастливыеЧасыMaskedTextBox.Name = "счастливыеЧасыMaskedTextBox";
            this.счастливыеЧасыMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.счастливыеЧасыMaskedTextBox.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.боулингBindingSource, "КоличествоЛюдей", true));
            this.textBox5.Location = new System.Drawing.Point(151, 134);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            // 
            // checkBox1
            // 
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.боулингBindingSource, "Бар", true));
            this.checkBox1.Location = new System.Drawing.Point(193, 168);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(14, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.боулингBindingSource, "НомерДорожки", true));
            this.textBox4.Location = new System.Drawing.Point(151, 89);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            // 
            // btnAddBowling
            // 
            this.btnAddBowling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.btnAddBowling.FlatAppearance.BorderSize = 0;
            this.btnAddBowling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBowling.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddBowling.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddBowling.Location = new System.Drawing.Point(51, 314);
            this.btnAddBowling.Name = "btnAddBowling";
            this.btnAddBowling.Size = new System.Drawing.Size(156, 38);
            this.btnAddBowling.TabIndex = 8;
            this.btnAddBowling.Text = "Сохранить";
            this.btnAddBowling.UseVisualStyleBackColor = false;
            this.btnAddBowling.Click += new System.EventHandler(this.btnAddBowling_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Carlito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(38, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Добавление дорожки";
            // 
            // pnlAddKaraoke
            // 
            this.pnlAddKaraoke.Controls.Add(this.maskedTextBox1);
            this.pnlAddKaraoke.Controls.Add(this.textBox6);
            this.pnlAddKaraoke.Controls.Add(label11);
            this.pnlAddKaraoke.Controls.Add(this.checkBox2);
            this.pnlAddKaraoke.Controls.Add(this.textBox8);
            this.pnlAddKaraoke.Controls.Add(label12);
            this.pnlAddKaraoke.Controls.Add(this.btnAddKaraoke);
            this.pnlAddKaraoke.Controls.Add(label13);
            this.pnlAddKaraoke.Controls.Add(label14);
            this.pnlAddKaraoke.Controls.Add(this.label15);
            this.pnlAddKaraoke.Location = new System.Drawing.Point(619, 31);
            this.pnlAddKaraoke.Name = "pnlAddKaraoke";
            this.pnlAddKaraoke.Size = new System.Drawing.Size(264, 338);
            this.pnlAddKaraoke.TabIndex = 15;
            this.pnlAddKaraoke.Visible = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.караокеBindingSource, "ЦенаЗаЧас", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(151, 213);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 15;
            // 
            // караокеBindingSource
            // 
            this.караокеBindingSource.DataMember = "Караоке";
            this.караокеBindingSource.DataSource = this.центрОРDataSet;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.караокеBindingSource, "МаксимумПесен", true));
            this.textBox6.Location = new System.Drawing.Point(151, 134);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 13;
            // 
            // checkBox2
            // 
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.бильярдBindingSource, "Бар", true));
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.караокеBindingSource, "Бар", true));
            this.checkBox2.Location = new System.Drawing.Point(193, 168);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(14, 24);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.караокеBindingSource, "НомерСтола", true));
            this.textBox8.Location = new System.Drawing.Point(151, 89);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 10;
            // 
            // btnAddKaraoke
            // 
            this.btnAddKaraoke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.btnAddKaraoke.FlatAppearance.BorderSize = 0;
            this.btnAddKaraoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddKaraoke.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddKaraoke.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddKaraoke.Location = new System.Drawing.Point(51, 271);
            this.btnAddKaraoke.Name = "btnAddKaraoke";
            this.btnAddKaraoke.Size = new System.Drawing.Size(156, 38);
            this.btnAddKaraoke.TabIndex = 8;
            this.btnAddKaraoke.Text = "Сохранить";
            this.btnAddKaraoke.UseVisualStyleBackColor = false;
            this.btnAddKaraoke.Click += new System.EventHandler(this.btnAddKaraoke_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Carlito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(47, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 23);
            this.label15.TabIndex = 0;
            this.label15.Text = "Добавление стола";
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
            this.btnMinimize.Location = new System.Drawing.Point(854, -1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 23);
            this.btnMinimize.TabIndex = 17;
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
            this.btnExit.Location = new System.Drawing.Point(887, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 20);
            this.btnExit.TabIndex = 16;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormAddGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlAddKaraoke);
            this.Controls.Add(this.pnlAddBowling);
            this.Controls.Add(this.pnlAddBilliards);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddGames";
            this.Text = "FormAddGames";
            this.Load += new System.EventHandler(this.FormAddGames_Load);
            this.pnlAddBilliards.ResumeLayout(false);
            this.pnlAddBilliards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.бильярдBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.центрОРDataSet)).EndInit();
            this.pnlAddBowling.ResumeLayout(false);
            this.pnlAddBowling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.боулингBindingSource)).EndInit();
            this.pnlAddKaraoke.ResumeLayout(false);
            this.pnlAddKaraoke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.караокеBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddBilliards;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAddBilliards;
        private System.Windows.Forms.Label label1;
        private ЦентрОРDataSet центрОРDataSet;
        private System.Windows.Forms.BindingSource бильярдBindingSource;
        private ЦентрОРDataSetTableAdapters.БильярдTableAdapter бильярдTableAdapter;
        private System.Windows.Forms.CheckBox барCheckBox;
        private ЦентрОРDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ЦентрОРDataSetTableAdapters.БоулингTableAdapter боулингTableAdapter;
        private System.Windows.Forms.Panel pnlAddBowling;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnAddBowling;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource боулингBindingSource;
        private System.Windows.Forms.MaskedTextBox счастливыеЧасыMaskedTextBox;
        private System.Windows.Forms.Panel pnlAddKaraoke;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btnAddKaraoke;
        private System.Windows.Forms.Label label15;
        private ЦентрОРDataSetTableAdapters.КараокеTableAdapter караокеTableAdapter;
        private System.Windows.Forms.BindingSource караокеBindingSource;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnExit;
    }
}