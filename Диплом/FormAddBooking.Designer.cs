
namespace Диплом
{
    partial class FormAddBooking
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
            System.Windows.Forms.Label номерСтоликаLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label lblFinalSumBil;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label lblFinalSumBow;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label lblFinalSumKar;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label16;
            this.броньБильярдBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.центрОРDataSet = new Диплом.ЦентрОРDataSet();
            this.броньБоулингBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.броньКараокеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlBookingBilliards = new System.Windows.Forms.Panel();
            this.датаБрониMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.btnBilliards = new System.Windows.Forms.Button();
            this.номерСтоликаComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBowling = new System.Windows.Forms.Button();
            this.броньБильярдTableAdapter = new Диплом.ЦентрОРDataSetTableAdapters.БроньБильярдTableAdapter();
            this.tableAdapterManager = new Диплом.ЦентрОРDataSetTableAdapters.TableAdapterManager();
            this.pnlBookingBowling = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlBookingKaraoke = new System.Windows.Forms.Panel();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.btnKaraoke = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.броньБоулингTableAdapter = new Диплом.ЦентрОРDataSetTableAdapters.БроньБоулингTableAdapter();
            this.броньКараокеTableAdapter = new Диплом.ЦентрОРDataSetTableAdapters.БроньКараокеTableAdapter();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            номерСтоликаLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lblFinalSumBil = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            lblFinalSumBow = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            lblFinalSumKar = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.броньБильярдBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.центрОРDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.броньБоулингBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.броньКараокеBindingSource)).BeginInit();
            this.pnlBookingBilliards.SuspendLayout();
            this.pnlBookingBowling.SuspendLayout();
            this.pnlBookingKaraoke.SuspendLayout();
            this.SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(12, 134);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(126, 18);
            label2.TabIndex = 3;
            label2.Text = "Количество часов :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(12, 226);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 18);
            label3.TabIndex = 5;
            label3.Text = "К оплате :";
            // 
            // lblFinalSumBil
            // 
            lblFinalSumBil.AutoSize = true;
            lblFinalSumBil.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.броньБильярдBindingSource, "КОплате", true));
            lblFinalSumBil.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lblFinalSumBil.ForeColor = System.Drawing.SystemColors.Control;
            lblFinalSumBil.Location = new System.Drawing.Point(167, 226);
            lblFinalSumBil.Name = "lblFinalSumBil";
            lblFinalSumBil.Size = new System.Drawing.Size(48, 18);
            lblFinalSumBil.TabIndex = 6;
            lblFinalSumBil.Text = "<sum>";
            // 
            // броньБильярдBindingSource
            // 
            this.броньБильярдBindingSource.DataMember = "БроньБильярд";
            this.броньБильярдBindingSource.DataSource = this.центрОРDataSet;
            // 
            // центрОРDataSet
            // 
            this.центрОРDataSet.DataSetName = "ЦентрОРDataSet";
            this.центрОРDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.ForeColor = System.Drawing.SystemColors.Control;
            label5.Location = new System.Drawing.Point(12, 180);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(88, 18);
            label5.TabIndex = 9;
            label5.Text = "Дата брони :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label6.ForeColor = System.Drawing.SystemColors.Control;
            label6.Location = new System.Drawing.Point(12, 180);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(88, 18);
            label6.TabIndex = 9;
            label6.Text = "Дата брони :";
            // 
            // lblFinalSumBow
            // 
            lblFinalSumBow.AutoSize = true;
            lblFinalSumBow.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.броньБоулингBindingSource, "КОплате", true));
            lblFinalSumBow.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lblFinalSumBow.ForeColor = System.Drawing.SystemColors.Control;
            lblFinalSumBow.Location = new System.Drawing.Point(167, 226);
            lblFinalSumBow.Name = "lblFinalSumBow";
            lblFinalSumBow.Size = new System.Drawing.Size(48, 18);
            lblFinalSumBow.TabIndex = 6;
            lblFinalSumBow.Text = "<sum>";
            // 
            // броньБоулингBindingSource
            // 
            this.броньБоулингBindingSource.DataMember = "БроньБоулинг";
            this.броньБоулингBindingSource.DataSource = this.центрОРDataSet;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label8.ForeColor = System.Drawing.SystemColors.Control;
            label8.Location = new System.Drawing.Point(12, 226);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(70, 18);
            label8.TabIndex = 5;
            label8.Text = "К оплате :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label9.ForeColor = System.Drawing.SystemColors.Control;
            label9.Location = new System.Drawing.Point(12, 134);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(126, 18);
            label9.TabIndex = 3;
            label9.Text = "Количество часов :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label10.ForeColor = System.Drawing.SystemColors.Control;
            label10.Location = new System.Drawing.Point(12, 89);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(117, 18);
            label10.TabIndex = 1;
            label10.Text = "Номер дорожки :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label12.ForeColor = System.Drawing.SystemColors.Control;
            label12.Location = new System.Drawing.Point(12, 180);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(88, 18);
            label12.TabIndex = 9;
            label12.Text = "Дата брони :";
            // 
            // lblFinalSumKar
            // 
            lblFinalSumKar.AutoSize = true;
            lblFinalSumKar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.броньКараокеBindingSource, "КОплате", true));
            lblFinalSumKar.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lblFinalSumKar.ForeColor = System.Drawing.SystemColors.Control;
            lblFinalSumKar.Location = new System.Drawing.Point(167, 226);
            lblFinalSumKar.Name = "lblFinalSumKar";
            lblFinalSumKar.Size = new System.Drawing.Size(48, 18);
            lblFinalSumKar.TabIndex = 6;
            lblFinalSumKar.Text = "<sum>";
            // 
            // броньКараокеBindingSource
            // 
            this.броньКараокеBindingSource.DataMember = "БроньКараоке";
            this.броньКараокеBindingSource.DataSource = this.центрОРDataSet;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label14.ForeColor = System.Drawing.SystemColors.Control;
            label14.Location = new System.Drawing.Point(12, 226);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(70, 18);
            label14.TabIndex = 5;
            label14.Text = "К оплате :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label15.ForeColor = System.Drawing.SystemColors.Control;
            label15.Location = new System.Drawing.Point(12, 134);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(126, 18);
            label15.TabIndex = 3;
            label15.Text = "Количество часов :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label16.ForeColor = System.Drawing.SystemColors.Control;
            label16.Location = new System.Drawing.Point(12, 89);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(95, 18);
            label16.TabIndex = 1;
            label16.Text = "Номер cтола :";
            // 
            // pnlBookingBilliards
            // 
            this.pnlBookingBilliards.Controls.Add(label5);
            this.pnlBookingBilliards.Controls.Add(this.датаБрониMaskedTextBox);
            this.pnlBookingBilliards.Controls.Add(this.btnBilliards);
            this.pnlBookingBilliards.Controls.Add(this.номерСтоликаComboBox);
            this.pnlBookingBilliards.Controls.Add(lblFinalSumBil);
            this.pnlBookingBilliards.Controls.Add(label3);
            this.pnlBookingBilliards.Controls.Add(label2);
            this.pnlBookingBilliards.Controls.Add(this.textBox1);
            this.pnlBookingBilliards.Controls.Add(номерСтоликаLabel);
            this.pnlBookingBilliards.Controls.Add(this.label1);
            this.pnlBookingBilliards.Location = new System.Drawing.Point(12, 29);
            this.pnlBookingBilliards.Name = "pnlBookingBilliards";
            this.pnlBookingBilliards.Size = new System.Drawing.Size(264, 336);
            this.pnlBookingBilliards.TabIndex = 0;
            this.pnlBookingBilliards.Visible = false;
            // 
            // датаБрониMaskedTextBox
            // 
            this.датаБрониMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.броньБильярдBindingSource, "ДатаБрони", true));
            this.датаБрониMaskedTextBox.Location = new System.Drawing.Point(144, 180);
            this.датаБрониMaskedTextBox.Mask = "00/00/0000";
            this.датаБрониMaskedTextBox.Name = "датаБрониMaskedTextBox";
            this.датаБрониMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.датаБрониMaskedTextBox.TabIndex = 2;
            this.датаБрониMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // btnBilliards
            // 
            this.btnBilliards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.btnBilliards.FlatAppearance.BorderSize = 0;
            this.btnBilliards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilliards.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBilliards.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBilliards.Location = new System.Drawing.Point(42, 276);
            this.btnBilliards.Name = "btnBilliards";
            this.btnBilliards.Size = new System.Drawing.Size(156, 38);
            this.btnBilliards.TabIndex = 8;
            this.btnBilliards.Text = "Забронировать";
            this.btnBilliards.UseVisualStyleBackColor = false;
            // 
            // номерСтоликаComboBox
            // 
            this.номерСтоликаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.броньБильярдBindingSource, "НомерСтолика", true));
            this.номерСтоликаComboBox.FormattingEnabled = true;
            this.номерСтоликаComboBox.Location = new System.Drawing.Point(144, 89);
            this.номерСтоликаComboBox.Name = "номерСтоликаComboBox";
            this.номерСтоликаComboBox.Size = new System.Drawing.Size(100, 21);
            this.номерСтоликаComboBox.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.броньБильярдBindingSource, "КоличествоЧасов", true));
            this.textBox1.Location = new System.Drawing.Point(144, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Carlito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бронь бильярда";
            // 
            // btnBowling
            // 
            this.btnBowling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.btnBowling.FlatAppearance.BorderSize = 0;
            this.btnBowling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBowling.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBowling.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBowling.Location = new System.Drawing.Point(59, 276);
            this.btnBowling.Name = "btnBowling";
            this.btnBowling.Size = new System.Drawing.Size(156, 38);
            this.btnBowling.TabIndex = 8;
            this.btnBowling.Text = "Забронировать";
            this.btnBowling.UseVisualStyleBackColor = false;
            // 
            // броньБильярдTableAdapter
            // 
            this.броньБильярдTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Диплом.ЦентрОРDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АквапаркTableAdapter = null;
            this.tableAdapterManager.БильярдTableAdapter = null;
            this.tableAdapterManager.БоулингTableAdapter = null;
            this.tableAdapterManager.БроньБильярдTableAdapter = this.броньБильярдTableAdapter;
            this.tableAdapterManager.БроньБоулингTableAdapter = null;
            this.tableAdapterManager.БроньКараокеTableAdapter = null;
            this.tableAdapterManager.БроньНомераTableAdapter = null;
            this.tableAdapterManager.ЗаказыВРесторанеTableAdapter = null;
            this.tableAdapterManager.ЗалРесторанаTableAdapter = null;
            this.tableAdapterManager.ЗоопаркTableAdapter = null;
            this.tableAdapterManager.КараокеTableAdapter = null;
            this.tableAdapterManager.МенюРесторанаTableAdapter = null;
            this.tableAdapterManager.ОтельTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.СпаСалонTableAdapter = null;
            // 
            // pnlBookingBowling
            // 
            this.pnlBookingBowling.Controls.Add(label6);
            this.pnlBookingBowling.Controls.Add(this.maskedTextBox1);
            this.pnlBookingBowling.Controls.Add(this.btnBowling);
            this.pnlBookingBowling.Controls.Add(this.comboBox1);
            this.pnlBookingBowling.Controls.Add(lblFinalSumBow);
            this.pnlBookingBowling.Controls.Add(label8);
            this.pnlBookingBowling.Controls.Add(label9);
            this.pnlBookingBowling.Controls.Add(this.textBox2);
            this.pnlBookingBowling.Controls.Add(label10);
            this.pnlBookingBowling.Controls.Add(this.label11);
            this.pnlBookingBowling.Location = new System.Drawing.Point(318, 29);
            this.pnlBookingBowling.Name = "pnlBookingBowling";
            this.pnlBookingBowling.Size = new System.Drawing.Size(264, 336);
            this.pnlBookingBowling.TabIndex = 10;
            this.pnlBookingBowling.Visible = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.броньБоулингBindingSource, "ДатаБрони", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(144, 180);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.броньБоулингBindingSource, "НомерДорожки", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.броньБоулингBindingSource, "КоличествоЧасов", true));
            this.textBox2.Location = new System.Drawing.Point(144, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Carlito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(66, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Бронь боулинга";
            // 
            // pnlBookingKaraoke
            // 
            this.pnlBookingKaraoke.Controls.Add(label12);
            this.pnlBookingKaraoke.Controls.Add(this.maskedTextBox2);
            this.pnlBookingKaraoke.Controls.Add(this.btnKaraoke);
            this.pnlBookingKaraoke.Controls.Add(this.comboBox2);
            this.pnlBookingKaraoke.Controls.Add(lblFinalSumKar);
            this.pnlBookingKaraoke.Controls.Add(label14);
            this.pnlBookingKaraoke.Controls.Add(label15);
            this.pnlBookingKaraoke.Controls.Add(this.textBox3);
            this.pnlBookingKaraoke.Controls.Add(label16);
            this.pnlBookingKaraoke.Controls.Add(this.label17);
            this.pnlBookingKaraoke.Location = new System.Drawing.Point(614, 29);
            this.pnlBookingKaraoke.Name = "pnlBookingKaraoke";
            this.pnlBookingKaraoke.Size = new System.Drawing.Size(264, 336);
            this.pnlBookingKaraoke.TabIndex = 11;
            this.pnlBookingKaraoke.Visible = false;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.броньКараокеBindingSource, "ДатаБрони", true));
            this.maskedTextBox2.Location = new System.Drawing.Point(144, 180);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 2;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // btnKaraoke
            // 
            this.btnKaraoke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.btnKaraoke.FlatAppearance.BorderSize = 0;
            this.btnKaraoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaraoke.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKaraoke.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKaraoke.Location = new System.Drawing.Point(59, 276);
            this.btnKaraoke.Name = "btnKaraoke";
            this.btnKaraoke.Size = new System.Drawing.Size(156, 38);
            this.btnKaraoke.TabIndex = 8;
            this.btnKaraoke.Text = "Забронировать";
            this.btnKaraoke.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.броньКараокеBindingSource, "НомерСтола", true));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(144, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.броньКараокеBindingSource, "КоличествоЧасов", true));
            this.textBox3.Location = new System.Drawing.Point(144, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Carlito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(67, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 23);
            this.label17.TabIndex = 0;
            this.label17.Text = "Бронь караоке";
            // 
            // броньБоулингTableAdapter
            // 
            this.броньБоулингTableAdapter.ClearBeforeFill = true;
            // 
            // броньКараокеTableAdapter
            // 
            this.броньКараокеTableAdapter.ClearBeforeFill = true;
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
            this.btnMinimize.Location = new System.Drawing.Point(857, -2);
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
            this.btnExit.Location = new System.Drawing.Point(890, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 20);
            this.btnExit.TabIndex = 18;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormAddBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlBookingKaraoke);
            this.Controls.Add(this.pnlBookingBowling);
            this.Controls.Add(this.pnlBookingBilliards);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddBooking";
            this.Text = "FormAddBooking";
            this.Load += new System.EventHandler(this.FormAddBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.броньБильярдBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.центрОРDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.броньБоулингBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.броньКараокеBindingSource)).EndInit();
            this.pnlBookingBilliards.ResumeLayout(false);
            this.pnlBookingBilliards.PerformLayout();
            this.pnlBookingBowling.ResumeLayout(false);
            this.pnlBookingBowling.PerformLayout();
            this.pnlBookingKaraoke.ResumeLayout(false);
            this.pnlBookingKaraoke.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBookingBilliards;
        private System.Windows.Forms.Label label1;
        private ЦентрОРDataSet центрОРDataSet;
        private System.Windows.Forms.BindingSource броньБильярдBindingSource;
        private ЦентрОРDataSetTableAdapters.БроньБильярдTableAdapter броньБильярдTableAdapter;
        private ЦентрОРDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox номерСтоликаComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBowling;
        private System.Windows.Forms.MaskedTextBox датаБрониMaskedTextBox;
        private System.Windows.Forms.Button btnBilliards;
        private System.Windows.Forms.Panel pnlBookingBowling;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlBookingKaraoke;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button btnKaraoke;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.BindingSource броньБоулингBindingSource;
        private ЦентрОРDataSetTableAdapters.БроньБоулингTableAdapter броньБоулингTableAdapter;
        private System.Windows.Forms.BindingSource броньКараокеBindingSource;
        private ЦентрОРDataSetTableAdapters.БроньКараокеTableAdapter броньКараокеTableAdapter;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnExit;
    }
}