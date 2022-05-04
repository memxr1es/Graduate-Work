
namespace Диплом
{
    partial class Employee
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
            this.отельDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вБракеDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.высшееОбразованиеDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.адресПроживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ставкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стажDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.центрОРDataSet = new Диплом.ЦентрОРDataSet();
            this.сотрудникиTableAdapter = new Диплом.ЦентрОРDataSetTableAdapters.СотрудникиTableAdapter();
            this.iBtnDel = new FontAwesome.Sharp.IconButton();
            this.iBtnChange = new FontAwesome.Sharp.IconButton();
            this.iBtnAdd = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.отельDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.центрОРDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // отельDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            this.отельDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.отельDataGridView.AutoGenerateColumns = false;
            this.отельDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.отельDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            this.отельDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.отельDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.отельDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.отельDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.отельDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.вБракеDataGridViewCheckBoxColumn,
            this.высшееОбразованиеDataGridViewCheckBoxColumn,
            this.адресПроживанияDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.ставкаDataGridViewTextBoxColumn,
            this.стажDataGridViewTextBoxColumn});
            this.отельDataGridView.DataSource = this.сотрудникиBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.отельDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.отельDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.отельDataGridView.Location = new System.Drawing.Point(9, 26);
            this.отельDataGridView.Name = "отельDataGridView";
            this.отельDataGridView.RowHeadersVisible = false;
            this.отельDataGridView.Size = new System.Drawing.Size(876, 220);
            this.отельDataGridView.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "ДатаРождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            // 
            // вБракеDataGridViewCheckBoxColumn
            // 
            this.вБракеDataGridViewCheckBoxColumn.DataPropertyName = "ВБраке";
            this.вБракеDataGridViewCheckBoxColumn.HeaderText = "В браке";
            this.вБракеDataGridViewCheckBoxColumn.Name = "вБракеDataGridViewCheckBoxColumn";
            // 
            // высшееОбразованиеDataGridViewCheckBoxColumn
            // 
            this.высшееОбразованиеDataGridViewCheckBoxColumn.DataPropertyName = "ВысшееОбразование";
            this.высшееОбразованиеDataGridViewCheckBoxColumn.HeaderText = "Высшее образование";
            this.высшееОбразованиеDataGridViewCheckBoxColumn.Name = "высшееОбразованиеDataGridViewCheckBoxColumn";
            // 
            // адресПроживанияDataGridViewTextBoxColumn
            // 
            this.адресПроживанияDataGridViewTextBoxColumn.DataPropertyName = "АдресПроживания";
            this.адресПроживанияDataGridViewTextBoxColumn.HeaderText = "Адрес проживания";
            this.адресПроживанияDataGridViewTextBoxColumn.Name = "адресПроживанияDataGridViewTextBoxColumn";
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // ставкаDataGridViewTextBoxColumn
            // 
            this.ставкаDataGridViewTextBoxColumn.DataPropertyName = "Ставка";
            this.ставкаDataGridViewTextBoxColumn.HeaderText = "Ставка";
            this.ставкаDataGridViewTextBoxColumn.Name = "ставкаDataGridViewTextBoxColumn";
            // 
            // стажDataGridViewTextBoxColumn
            // 
            this.стажDataGridViewTextBoxColumn.DataPropertyName = "Стаж";
            this.стажDataGridViewTextBoxColumn.HeaderText = "Стаж";
            this.стажDataGridViewTextBoxColumn.Name = "стажDataGridViewTextBoxColumn";
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.центрОРDataSet;
            // 
            // центрОРDataSet
            // 
            this.центрОРDataSet.DataSetName = "ЦентрОРDataSet";
            this.центрОРDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
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
            this.iBtnDel.Location = new System.Drawing.Point(743, 251);
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
            this.iBtnChange.Location = new System.Drawing.Point(166, 252);
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
            this.iBtnAdd.Location = new System.Drawing.Point(9, 252);
            this.iBtnAdd.Name = "iBtnAdd";
            this.iBtnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iBtnAdd.Size = new System.Drawing.Size(133, 39);
            this.iBtnAdd.TabIndex = 12;
            this.iBtnAdd.Text = "Добавить";
            this.iBtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnAdd.UseVisualStyleBackColor = false;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(881, 429);
            this.Controls.Add(this.iBtnDel);
            this.Controls.Add(this.iBtnChange);
            this.Controls.Add(this.iBtnAdd);
            this.Controls.Add(this.отельDataGridView);
            this.Name = "Employee";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.отельDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.центрОРDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView отельDataGridView;
        private ЦентрОРDataSet центрОРDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private ЦентрОРDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn вБракеDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn высшееОбразованиеDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресПроживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ставкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стажDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton iBtnDel;
        private FontAwesome.Sharp.IconButton iBtnChange;
        private FontAwesome.Sharp.IconButton iBtnAdd;
    }
}