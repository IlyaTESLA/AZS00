
namespace AZS
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ilya123DataSet = new AZS.Ilya123DataSet();
            this.carFillingStationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_Filling_StationTableAdapter = new AZS.Ilya123DataSetTableAdapters.Car_Filling_StationTableAdapter();
            this.listAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listStationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listdataNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listdataPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listdataAmountOfFuelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilya123DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carFillingStationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.listAddressDataGridViewTextBoxColumn,
            this.listStationIDDataGridViewTextBoxColumn,
            this.listdataNameDataGridViewTextBoxColumn,
            this.listdataPriceDataGridViewTextBoxColumn,
            this.listdataAmountOfFuelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carFillingStationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(421, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(647, 297);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(797, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вывести";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(421, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(354, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сохранить изменения";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ilya123DataSet
            // 
            this.ilya123DataSet.DataSetName = "Ilya123DataSet";
            this.ilya123DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carFillingStationBindingSource
            // 
            this.carFillingStationBindingSource.DataMember = "Car_Filling_Station";
            this.carFillingStationBindingSource.DataSource = this.ilya123DataSet;
            // 
            // car_Filling_StationTableAdapter
            // 
            this.car_Filling_StationTableAdapter.ClearBeforeFill = true;
            // 
            // listAddressDataGridViewTextBoxColumn
            // 
            this.listAddressDataGridViewTextBoxColumn.DataPropertyName = "list_Address";
            this.listAddressDataGridViewTextBoxColumn.HeaderText = "list_Address";
            this.listAddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.listAddressDataGridViewTextBoxColumn.Name = "listAddressDataGridViewTextBoxColumn";
            this.listAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // listStationIDDataGridViewTextBoxColumn
            // 
            this.listStationIDDataGridViewTextBoxColumn.DataPropertyName = "list_Station_ID";
            this.listStationIDDataGridViewTextBoxColumn.HeaderText = "list_Station_ID";
            this.listStationIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.listStationIDDataGridViewTextBoxColumn.Name = "listStationIDDataGridViewTextBoxColumn";
            this.listStationIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // listdataNameDataGridViewTextBoxColumn
            // 
            this.listdataNameDataGridViewTextBoxColumn.DataPropertyName = "list_data_Name";
            this.listdataNameDataGridViewTextBoxColumn.HeaderText = "list_data_Name";
            this.listdataNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.listdataNameDataGridViewTextBoxColumn.Name = "listdataNameDataGridViewTextBoxColumn";
            this.listdataNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // listdataPriceDataGridViewTextBoxColumn
            // 
            this.listdataPriceDataGridViewTextBoxColumn.DataPropertyName = "list_data_Price";
            this.listdataPriceDataGridViewTextBoxColumn.HeaderText = "list_data_Price";
            this.listdataPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.listdataPriceDataGridViewTextBoxColumn.Name = "listdataPriceDataGridViewTextBoxColumn";
            this.listdataPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // listdataAmountOfFuelDataGridViewTextBoxColumn
            // 
            this.listdataAmountOfFuelDataGridViewTextBoxColumn.DataPropertyName = "list_data_AmountOfFuel";
            this.listdataAmountOfFuelDataGridViewTextBoxColumn.HeaderText = "list_data_AmountOfFuel";
            this.listdataAmountOfFuelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.listdataAmountOfFuelDataGridViewTextBoxColumn.Name = "listdataAmountOfFuelDataGridViewTextBoxColumn";
            this.listdataAmountOfFuelDataGridViewTextBoxColumn.Width = 150;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(109, 178);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(109, 246);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(109, 314);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(109, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(109, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Номер станции";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(109, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Название топлива";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(109, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(109, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Остаток топлива ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1080, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilya123DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carFillingStationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Ilya123DataSet ilya123DataSet;
        private System.Windows.Forms.BindingSource carFillingStationBindingSource;
        private Ilya123DataSetTableAdapters.Car_Filling_StationTableAdapter car_Filling_StationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn listAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listStationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listdataNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listdataPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listdataAmountOfFuelDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

