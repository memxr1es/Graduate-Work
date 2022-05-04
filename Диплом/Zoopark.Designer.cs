
namespace Диплом
{
    partial class Zoopark
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
            this.zooparkDataGridView = new System.Windows.Forms.DataGridView();
            this.номерПропускаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видыЖивотныхDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.экскурсияDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.фотосессияDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зоопаркBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.центрОРDataSet = new Диплом.ЦентрОРDataSet();
            this.зоопаркTableAdapter = new Диплом.ЦентрОРDataSetTableAdapters.ЗоопаркTableAdapter();
            this.iBtnDel = new FontAwesome.Sharp.IconButton();
            this.iBtnChange = new FontAwesome.Sharp.IconButton();
            this.iBtnAdd = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.zooparkDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.зоопаркBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.центрОРDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // zooparkDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.zooparkDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.zooparkDataGridView.AutoGenerateColumns = false;
            this.zooparkDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.zooparkDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            this.zooparkDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zooparkDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.zooparkDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.zooparkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zooparkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерПропускаDataGridViewTextBoxColumn,
            this.видыЖивотныхDataGridViewTextBoxColumn,
            this.экскурсияDataGridViewCheckBoxColumn,
            this.фотосессияDataGridViewCheckBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.zooparkDataGridView.DataSource = this.зоопаркBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.zooparkDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.zooparkDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.zooparkDataGridView.Location = new System.Drawing.Point(38, 28);
            this.zooparkDataGridView.Name = "zooparkDataGridView";
            this.zooparkDataGridView.RowHeadersVisible = false;
            this.zooparkDataGridView.Size = new System.Drawing.Size(820, 220);
            this.zooparkDataGridView.TabIndex = 3;
            // 
            // номерПропускаDataGridViewTextBoxColumn
            // 
            this.номерПропускаDataGridViewTextBoxColumn.DataPropertyName = "НомерПропуска";
            this.номерПропускаDataGridViewTextBoxColumn.HeaderText = "Номер пропуска";
            this.номерПропускаDataGridViewTextBoxColumn.Name = "номерПропускаDataGridViewTextBoxColumn";
            // 
            // видыЖивотныхDataGridViewTextBoxColumn
            // 
            this.видыЖивотныхDataGridViewTextBoxColumn.DataPropertyName = "ВидыЖивотных";
            this.видыЖивотныхDataGridViewTextBoxColumn.HeaderText = "Виды животных";
            this.видыЖивотныхDataGridViewTextBoxColumn.Name = "видыЖивотныхDataGridViewTextBoxColumn";
            // 
            // экскурсияDataGridViewCheckBoxColumn
            // 
            this.экскурсияDataGridViewCheckBoxColumn.DataPropertyName = "Экскурсия";
            this.экскурсияDataGridViewCheckBoxColumn.HeaderText = "Экскурсия";
            this.экскурсияDataGridViewCheckBoxColumn.Name = "экскурсияDataGridViewCheckBoxColumn";
            // 
            // фотосессияDataGridViewCheckBoxColumn
            // 
            this.фотосессияDataGridViewCheckBoxColumn.DataPropertyName = "Фотосессия";
            this.фотосессияDataGridViewCheckBoxColumn.HeaderText = "Фотосессия";
            this.фотосессияDataGridViewCheckBoxColumn.Name = "фотосессияDataGridViewCheckBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // зоопаркBindingSource
            // 
            this.зоопаркBindingSource.DataMember = "Зоопарк";
            this.зоопаркBindingSource.DataSource = this.центрОРDataSet;
            // 
            // центрОРDataSet
            // 
            this.центрОРDataSet.DataSetName = "ЦентрОРDataSet";
            this.центрОРDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // зоопаркTableAdapter
            // 
            this.зоопаркTableAdapter.ClearBeforeFill = true;
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
            this.iBtnDel.Location = new System.Drawing.Point(725, 268);
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
            this.iBtnChange.Location = new System.Drawing.Point(195, 268);
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
            this.iBtnAdd.Location = new System.Drawing.Point(38, 268);
            this.iBtnAdd.Name = "iBtnAdd";
            this.iBtnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iBtnAdd.Size = new System.Drawing.Size(133, 39);
            this.iBtnAdd.TabIndex = 12;
            this.iBtnAdd.Text = "Добавить";
            this.iBtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnAdd.UseVisualStyleBackColor = false;
            // 
            // Zoopark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(881, 429);
            this.Controls.Add(this.iBtnDel);
            this.Controls.Add(this.iBtnChange);
            this.Controls.Add(this.iBtnAdd);
            this.Controls.Add(this.zooparkDataGridView);
            this.Name = "Zoopark";
            this.Text = "Zoopark";
            this.Load += new System.EventHandler(this.Zoopark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zooparkDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.зоопаркBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.центрОРDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView zooparkDataGridView;
        private ЦентрОРDataSet центрОРDataSet;
        private System.Windows.Forms.BindingSource зоопаркBindingSource;
        private ЦентрОРDataSetTableAdapters.ЗоопаркTableAdapter зоопаркTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПропускаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видыЖивотныхDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn экскурсияDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn фотосессияDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton iBtnDel;
        private FontAwesome.Sharp.IconButton iBtnChange;
        private FontAwesome.Sharp.IconButton iBtnAdd;
    }
}