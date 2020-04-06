namespace TYAPlr789
{
    partial class Form4
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
            this.lab9DataSet = new TYAPlr789.Lab9DataSet();
            this.таблица1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.таблица1TableAdapter = new TYAPlr789.Lab9DataSetTableAdapters.Таблица1TableAdapter();
            this.назвваниеПредприятияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодРемонтногоПредприятияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.объемРаботDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.таблица2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.таблица2TableAdapter = new TYAPlr789.Lab9DataSetTableAdapters.Таблица2TableAdapter();
            this.кодРемонтногоПредприятияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ремонтнаяОрганизацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.средняяСтоимостьРемонтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab9DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.назвваниеПредприятияDataGridViewTextBoxColumn,
            this.номерДоговораDataGridViewTextBoxColumn,
            this.кодРемонтногоПредприятияDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.объемРаботDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.таблица1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(787, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // lab9DataSet
            // 
            this.lab9DataSet.DataSetName = "Lab9DataSet";
            this.lab9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // таблица1BindingSource
            // 
            this.таблица1BindingSource.DataMember = "Таблица1";
            this.таблица1BindingSource.DataSource = this.lab9DataSet;
            // 
            // таблица1TableAdapter
            // 
            this.таблица1TableAdapter.ClearBeforeFill = true;
            // 
            // назвваниеПредприятияDataGridViewTextBoxColumn
            // 
            this.назвваниеПредприятияDataGridViewTextBoxColumn.DataPropertyName = "Назввание предприятия";
            this.назвваниеПредприятияDataGridViewTextBoxColumn.HeaderText = "Назввание предприятия";
            this.назвваниеПредприятияDataGridViewTextBoxColumn.Name = "назвваниеПредприятияDataGridViewTextBoxColumn";
            // 
            // номерДоговораDataGridViewTextBoxColumn
            // 
            this.номерДоговораDataGridViewTextBoxColumn.DataPropertyName = "Номер договора";
            this.номерДоговораDataGridViewTextBoxColumn.HeaderText = "Номер договора";
            this.номерДоговораDataGridViewTextBoxColumn.Name = "номерДоговораDataGridViewTextBoxColumn";
            // 
            // кодРемонтногоПредприятияDataGridViewTextBoxColumn
            // 
            this.кодРемонтногоПредприятияDataGridViewTextBoxColumn.DataPropertyName = "Код ремонтного предприятия";
            this.кодРемонтногоПредприятияDataGridViewTextBoxColumn.HeaderText = "Код ремонтного предприятия";
            this.кодРемонтногоПредприятияDataGridViewTextBoxColumn.Name = "кодРемонтногоПредприятияDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // объемРаботDataGridViewTextBoxColumn
            // 
            this.объемРаботDataGridViewTextBoxColumn.DataPropertyName = "Объем работ";
            this.объемРаботDataGridViewTextBoxColumn.HeaderText = "Объем работ";
            this.объемРаботDataGridViewTextBoxColumn.Name = "объемРаботDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодРемонтногоПредприятияDataGridViewTextBoxColumn1,
            this.ремонтнаяОрганизацияDataGridViewTextBoxColumn,
            this.средняяСтоимостьРемонтаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.таблица2BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(22, 303);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(620, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // таблица2BindingSource
            // 
            this.таблица2BindingSource.DataMember = "Таблица2";
            this.таблица2BindingSource.DataSource = this.lab9DataSet;
            // 
            // таблица2TableAdapter
            // 
            this.таблица2TableAdapter.ClearBeforeFill = true;
            // 
            // кодРемонтногоПредприятияDataGridViewTextBoxColumn1
            // 
            this.кодРемонтногоПредприятияDataGridViewTextBoxColumn1.DataPropertyName = "Код ремонтного предприятия";
            this.кодРемонтногоПредприятияDataGridViewTextBoxColumn1.HeaderText = "Код ремонтного предприятия";
            this.кодРемонтногоПредприятияDataGridViewTextBoxColumn1.Name = "кодРемонтногоПредприятияDataGridViewTextBoxColumn1";
            // 
            // ремонтнаяОрганизацияDataGridViewTextBoxColumn
            // 
            this.ремонтнаяОрганизацияDataGridViewTextBoxColumn.DataPropertyName = "Ремонтная организация";
            this.ремонтнаяОрганизацияDataGridViewTextBoxColumn.HeaderText = "Ремонтная организация";
            this.ремонтнаяОрганизацияDataGridViewTextBoxColumn.Name = "ремонтнаяОрганизацияDataGridViewTextBoxColumn";
            // 
            // средняяСтоимостьРемонтаDataGridViewTextBoxColumn
            // 
            this.средняяСтоимостьРемонтаDataGridViewTextBoxColumn.DataPropertyName = "Средняя стоимость ремонта";
            this.средняяСтоимостьРемонтаDataGridViewTextBoxColumn.HeaderText = "Средняя стоимость ремонта";
            this.средняяСтоимостьРемонтаDataGridViewTextBoxColumn.Name = "средняяСтоимостьРемонтаDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(806, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(449, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cписок по предприятиям общей стоимости ремонтных работ.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(648, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 95);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cписок ремонтных организаций  и затрат на капитальный ремонт.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(648, 421);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 22);
            this.textBox1.TabIndex = 4;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 598);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab9DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Lab9DataSet lab9DataSet;
        private System.Windows.Forms.BindingSource таблица1BindingSource;
        private Lab9DataSetTableAdapters.Таблица1TableAdapter таблица1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn назвваниеПредприятияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодРемонтногоПредприятияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn объемРаботDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource таблица2BindingSource;
        private Lab9DataSetTableAdapters.Таблица2TableAdapter таблица2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодРемонтногоПредприятияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ремонтнаяОрганизацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn средняяСтоимостьРемонтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}