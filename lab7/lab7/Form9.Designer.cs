namespace lab7
{
    partial class Form9
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодМагазинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.магазинDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.доходЗаДеньDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.магазиныBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.магазинDataSet = new lab7.МагазинDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодМагазинаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОПокупателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерБанкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерЛицевогоСчетаПокупателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.покупателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.магазиныTableAdapter = new lab7.МагазинDataSetTableAdapters.МагазиныTableAdapter();
            this.покупателиTableAdapter = new lab7.МагазинDataSetTableAdapters.ПокупателиTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.магазиныBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.магазинDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупателиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодМагазинаDataGridViewTextBoxColumn,
            this.магазинDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.доходЗаДеньDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.магазиныBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(375, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодМагазинаDataGridViewTextBoxColumn
            // 
            this.кодМагазинаDataGridViewTextBoxColumn.DataPropertyName = "Код магазина";
            this.кодМагазинаDataGridViewTextBoxColumn.HeaderText = "Код магазина";
            this.кодМагазинаDataGridViewTextBoxColumn.Name = "кодМагазинаDataGridViewTextBoxColumn";
            // 
            // магазинDataGridViewTextBoxColumn
            // 
            this.магазинDataGridViewTextBoxColumn.DataPropertyName = "Магазин";
            this.магазинDataGridViewTextBoxColumn.HeaderText = "Магазин";
            this.магазинDataGridViewTextBoxColumn.Name = "магазинDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // доходЗаДеньDataGridViewTextBoxColumn
            // 
            this.доходЗаДеньDataGridViewTextBoxColumn.DataPropertyName = "Доход за день";
            this.доходЗаДеньDataGridViewTextBoxColumn.HeaderText = "Доход за день";
            this.доходЗаДеньDataGridViewTextBoxColumn.Name = "доходЗаДеньDataGridViewTextBoxColumn";
            // 
            // магазиныBindingSource
            // 
            this.магазиныBindingSource.DataMember = "Магазины";
            this.магазиныBindingSource.DataSource = this.магазинDataSet;
            // 
            // магазинDataSet
            // 
            this.магазинDataSet.DataSetName = "МагазинDataSet";
            this.магазинDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодМагазинаDataGridViewTextBoxColumn1,
            this.фИОПокупателяDataGridViewTextBoxColumn,
            this.номерБанкаDataGridViewTextBoxColumn,
            this.номерЛицевогоСчетаПокупателяDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.покупателиBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 222);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(521, 214);
            this.dataGridView2.TabIndex = 1;
            // 
            // кодМагазинаDataGridViewTextBoxColumn1
            // 
            this.кодМагазинаDataGridViewTextBoxColumn1.DataPropertyName = "Код магазина";
            this.кодМагазинаDataGridViewTextBoxColumn1.HeaderText = "Код магазина";
            this.кодМагазинаDataGridViewTextBoxColumn1.Name = "кодМагазинаDataGridViewTextBoxColumn1";
            // 
            // фИОПокупателяDataGridViewTextBoxColumn
            // 
            this.фИОПокупателяDataGridViewTextBoxColumn.DataPropertyName = "ФИО покупателя";
            this.фИОПокупателяDataGridViewTextBoxColumn.HeaderText = "ФИО покупателя";
            this.фИОПокупателяDataGridViewTextBoxColumn.Name = "фИОПокупателяDataGridViewTextBoxColumn";
            // 
            // номерБанкаDataGridViewTextBoxColumn
            // 
            this.номерБанкаDataGridViewTextBoxColumn.DataPropertyName = "Номер банка";
            this.номерБанкаDataGridViewTextBoxColumn.HeaderText = "Номер банка";
            this.номерБанкаDataGridViewTextBoxColumn.Name = "номерБанкаDataGridViewTextBoxColumn";
            // 
            // номерЛицевогоСчетаПокупателяDataGridViewTextBoxColumn
            // 
            this.номерЛицевогоСчетаПокупателяDataGridViewTextBoxColumn.DataPropertyName = "Номер лицевого счета покупателя";
            this.номерЛицевогоСчетаПокупателяDataGridViewTextBoxColumn.HeaderText = "Номер лицевого счета покупателя";
            this.номерЛицевогоСчетаПокупателяDataGridViewTextBoxColumn.Name = "номерЛицевогоСчетаПокупателяDataGridViewTextBoxColumn";
            // 
            // покупателиBindingSource
            // 
            this.покупателиBindingSource.DataMember = "Покупатели";
            this.покупателиBindingSource.DataSource = this.магазинDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(551, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(550, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Магазин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(550, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // магазиныTableAdapter
            // 
            this.магазиныTableAdapter.ClearBeforeFill = true;
            // 
            // покупателиTableAdapter
            // 
            this.покупателиTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Выручка за этот день";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(567, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "Список покупателей в банке";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(567, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 56);
            this.button3.TabIndex = 12;
            this.button3.Text = "Перекрестная таблица по полям: магазин, ФИО покупателя, номер банка";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 442);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.магазиныBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.магазинDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупателиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private МагазинDataSet магазинDataSet;
        private System.Windows.Forms.BindingSource магазиныBindingSource;
        private МагазинDataSetTableAdapters.МагазиныTableAdapter магазиныTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодМагазинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn магазинDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn доходЗаДеньDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource покупателиBindingSource;
        private МагазинDataSetTableAdapters.ПокупателиTableAdapter покупателиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодМагазинаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОПокупателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерБанкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЛицевогоСчетаПокупателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}