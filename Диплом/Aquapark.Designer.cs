
namespace Диплом
{
    partial class Aquapark
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
            this.aquaparkDataGridView = new System.Windows.Forms.DataGridView();
            this.номерГоркиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеГоркиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видГоркиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возрастноеОграничениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаЗаЧасDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.абонементDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.старшийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.аквапаркBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.центрОРDataSet = new Диплом.ЦентрОРDataSet();
            this.аквапаркTableAdapter = new Диплом.ЦентрОРDataSetTableAdapters.АквапаркTableAdapter();
            this.iBtnDel = new FontAwesome.Sharp.IconButton();
            this.iBtnChange = new FontAwesome.Sharp.IconButton();
            this.iBtnAdd = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.aquaparkDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аквапаркBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.центрОРDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // aquaparkDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.aquaparkDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.aquaparkDataGridView.AutoGenerateColumns = false;
            this.aquaparkDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aquaparkDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            this.aquaparkDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aquaparkDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.aquaparkDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.aquaparkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aquaparkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерГоркиDataGridViewTextBoxColumn,
            this.названиеГоркиDataGridViewTextBoxColumn,
            this.видГоркиDataGridViewTextBoxColumn,
            this.возрастноеОграничениеDataGridViewTextBoxColumn,
            this.ценаЗаЧасDataGridViewTextBoxColumn,
            this.абонементDataGridViewTextBoxColumn,
            this.старшийDataGridViewTextBoxColumn});
            this.aquaparkDataGridView.DataSource = this.аквапаркBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.aquaparkDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.aquaparkDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.aquaparkDataGridView.Location = new System.Drawing.Point(38, 24);
            this.aquaparkDataGridView.Name = "aquaparkDataGridView";
            this.aquaparkDataGridView.RowHeadersVisible = false;
            this.aquaparkDataGridView.Size = new System.Drawing.Size(820, 220);
            this.aquaparkDataGridView.TabIndex = 2;
            // 
            // номерГоркиDataGridViewTextBoxColumn
            // 
            this.номерГоркиDataGridViewTextBoxColumn.DataPropertyName = "НомерГорки";
            this.номерГоркиDataGridViewTextBoxColumn.HeaderText = "Номер горки";
            this.номерГоркиDataGridViewTextBoxColumn.Name = "номерГоркиDataGridViewTextBoxColumn";
            // 
            // названиеГоркиDataGridViewTextBoxColumn
            // 
            this.названиеГоркиDataGridViewTextBoxColumn.DataPropertyName = "НазваниеГорки";
            this.названиеГоркиDataGridViewTextBoxColumn.HeaderText = "Название горки";
            this.названиеГоркиDataGridViewTextBoxColumn.Name = "названиеГоркиDataGridViewTextBoxColumn";
            // 
            // видГоркиDataGridViewTextBoxColumn
            // 
            this.видГоркиDataGridViewTextBoxColumn.DataPropertyName = "ВидГорки";
            this.видГоркиDataGridViewTextBoxColumn.HeaderText = "Вид горки";
            this.видГоркиDataGridViewTextBoxColumn.Name = "видГоркиDataGridViewTextBoxColumn";
            // 
            // возрастноеОграничениеDataGridViewTextBoxColumn
            // 
            this.возрастноеОграничениеDataGridViewTextBoxColumn.DataPropertyName = "ВозрастноеОграничение";
            this.возрастноеОграничениеDataGridViewTextBoxColumn.HeaderText = "Возрастное ограничение";
            this.возрастноеОграничениеDataGridViewTextBoxColumn.Name = "возрастноеОграничениеDataGridViewTextBoxColumn";
            // 
            // ценаЗаЧасDataGridViewTextBoxColumn
            // 
            this.ценаЗаЧасDataGridViewTextBoxColumn.DataPropertyName = "ЦенаЗаЧас";
            this.ценаЗаЧасDataGridViewTextBoxColumn.HeaderText = "Цена за час";
            this.ценаЗаЧасDataGridViewTextBoxColumn.Name = "ценаЗаЧасDataGridViewTextBoxColumn";
            // 
            // абонементDataGridViewTextBoxColumn
            // 
            this.абонементDataGridViewTextBoxColumn.DataPropertyName = "Абонемент";
            this.абонементDataGridViewTextBoxColumn.HeaderText = "Абонемент";
            this.абонементDataGridViewTextBoxColumn.Name = "абонементDataGridViewTextBoxColumn";
            // 
            // старшийDataGridViewTextBoxColumn
            // 
            this.старшийDataGridViewTextBoxColumn.DataPropertyName = "Старший";
            this.старшийDataGridViewTextBoxColumn.HeaderText = "Старший";
            this.старшийDataGridViewTextBoxColumn.Name = "старшийDataGridViewTextBoxColumn";
            // 
            // аквапаркBindingSource
            // 
            this.аквапаркBindingSource.DataMember = "Аквапарк";
            this.аквапаркBindingSource.DataSource = this.центрОРDataSet;
            // 
            // центрОРDataSet
            // 
            this.центрОРDataSet.DataSetName = "ЦентрОРDataSet";
            this.центрОРDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // аквапаркTableAdapter
            // 
            this.аквапаркTableAdapter.ClearBeforeFill = true;
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
            this.iBtnDel.Location = new System.Drawing.Point(725, 261);
            this.iBtnDel.Name = "iBtnDel";
            this.iBtnDel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iBtnDel.Size = new System.Drawing.Size(133, 39);
            this.iBtnDel.TabIndex = 14;
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
            this.iBtnChange.Location = new System.Drawing.Point(186, 261);
            this.iBtnChange.Name = "iBtnChange";
            this.iBtnChange.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iBtnChange.Size = new System.Drawing.Size(133, 39);
            this.iBtnChange.TabIndex = 13;
            this.iBtnChange.Text = "Изменить";
            this.iBtnChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnChange.UseVisualStyleBackColor = false;
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
            this.iBtnAdd.Location = new System.Drawing.Point(38, 261);
            this.iBtnAdd.Name = "iBtnAdd";
            this.iBtnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iBtnAdd.Size = new System.Drawing.Size(133, 39);
            this.iBtnAdd.TabIndex = 12;
            this.iBtnAdd.Text = "Добавить";
            this.iBtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnAdd.UseVisualStyleBackColor = false;
            // 
            // Aquapark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(881, 429);
            this.Controls.Add(this.iBtnDel);
            this.Controls.Add(this.iBtnChange);
            this.Controls.Add(this.iBtnAdd);
            this.Controls.Add(this.aquaparkDataGridView);
            this.Name = "Aquapark";
            this.Text = "Аквапарк";
            this.Load += new System.EventHandler(this.Aquapark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aquaparkDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аквапаркBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.центрОРDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView aquaparkDataGridView;
        private ЦентрОРDataSet центрОРDataSet;
        private System.Windows.Forms.BindingSource аквапаркBindingSource;
        private ЦентрОРDataSetTableAdapters.АквапаркTableAdapter аквапаркTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерГоркиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеГоркиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видГоркиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn возрастноеОграничениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаЗаЧасDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn абонементDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn старшийDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton iBtnDel;
        private FontAwesome.Sharp.IconButton iBtnChange;
        private FontAwesome.Sharp.IconButton iBtnAdd;
    }
}