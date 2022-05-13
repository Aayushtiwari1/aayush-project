
namespace sign_up
{
    partial class edit_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_form));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submitdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeedataDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_dataDataSet4 = new sign_up.Employee_dataDataSet4();
            this.expense_TableTableAdapter = new sign_up.Employee_dataDataSet4TableAdapters.Expense_TableTableAdapter();
            this.bill_date_picker = new System.Windows.Forms.DateTimePicker();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_discription = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_bill_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeedataDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dataDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.refIdDataGridViewTextBoxColumn,
            this.billnameDataGridViewTextBoxColumn,
            this.billCategoryDataGridViewTextBoxColumn,
            this.billdateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.submitdateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.expenseTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(824, 294);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // refIdDataGridViewTextBoxColumn
            // 
            this.refIdDataGridViewTextBoxColumn.DataPropertyName = "Ref_Id";
            this.refIdDataGridViewTextBoxColumn.HeaderText = "Ref_Id";
            this.refIdDataGridViewTextBoxColumn.Name = "refIdDataGridViewTextBoxColumn";
            this.refIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billnameDataGridViewTextBoxColumn
            // 
            this.billnameDataGridViewTextBoxColumn.DataPropertyName = "bill_name";
            this.billnameDataGridViewTextBoxColumn.HeaderText = "bill_name";
            this.billnameDataGridViewTextBoxColumn.Name = "billnameDataGridViewTextBoxColumn";
            // 
            // billCategoryDataGridViewTextBoxColumn
            // 
            this.billCategoryDataGridViewTextBoxColumn.DataPropertyName = "bill_Category";
            this.billCategoryDataGridViewTextBoxColumn.HeaderText = "bill_Category";
            this.billCategoryDataGridViewTextBoxColumn.Name = "billCategoryDataGridViewTextBoxColumn";
            // 
            // billdateDataGridViewTextBoxColumn
            // 
            this.billdateDataGridViewTextBoxColumn.DataPropertyName = "bill_date";
            this.billdateDataGridViewTextBoxColumn.HeaderText = "bill_date";
            this.billdateDataGridViewTextBoxColumn.Name = "billdateDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // submitdateDataGridViewTextBoxColumn
            // 
            this.submitdateDataGridViewTextBoxColumn.DataPropertyName = "submit_date";
            this.submitdateDataGridViewTextBoxColumn.HeaderText = "submit_date";
            this.submitdateDataGridViewTextBoxColumn.Name = "submitdateDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // expenseTableBindingSource
            // 
            this.expenseTableBindingSource.DataMember = "Expense_Table";
            this.expenseTableBindingSource.DataSource = this.employeedataDataSet4BindingSource;
            // 
            // employeedataDataSet4BindingSource
            // 
            this.employeedataDataSet4BindingSource.DataSource = this.employee_dataDataSet4;
            this.employeedataDataSet4BindingSource.Position = 0;
            // 
            // employee_dataDataSet4
            // 
            this.employee_dataDataSet4.DataSetName = "Employee_dataDataSet4";
            this.employee_dataDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expense_TableTableAdapter
            // 
            this.expense_TableTableAdapter.ClearBeforeFill = true;
            // 
            // bill_date_picker
            // 
            this.bill_date_picker.CustomFormat = "yyyy-MM-dd";
            this.bill_date_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bill_date_picker.Location = new System.Drawing.Point(118, 111);
            this.bill_date_picker.Name = "bill_date_picker";
            this.bill_date_picker.Size = new System.Drawing.Size(252, 22);
            this.bill_date_picker.TabIndex = 54;
            // 
            // comboBox_category
            // 
            this.comboBox_category.AutoCompleteCustomSource.AddRange(new string[] {
            "Travel",
            "Medical",
            "Internet",
            "Acommadation",
            "Food",
            "others"});
            this.comboBox_category.BackColor = System.Drawing.Color.White;
            this.comboBox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_category.ForeColor = System.Drawing.Color.Black;
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Items.AddRange(new object[] {
            "TRAVEL",
            "MEDICAL",
            "ACCOMADATION",
            "INTERNET",
            "FOOD",
            "OTHERS"});
            this.comboBox_category.Location = new System.Drawing.Point(530, 66);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(252, 31);
            this.comboBox_category.TabIndex = 53;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(428, 149);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(354, 1);
            this.panel7.TabIndex = 52;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(428, 99);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(354, 1);
            this.panel6.TabIndex = 51;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(16, 215);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(354, 1);
            this.panel5.TabIndex = 50;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(16, 137);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(354, 1);
            this.panel4.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(16, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 1);
            this.panel3.TabIndex = 48;
            // 
            // txt_discription
            // 
            this.txt_discription.BackColor = System.Drawing.Color.White;
            this.txt_discription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_discription.Font = new System.Drawing.Font("Sitka Text", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discription.Location = new System.Drawing.Point(129, 144);
            this.txt_discription.Multiline = true;
            this.txt_discription.Name = "txt_discription";
            this.txt_discription.Size = new System.Drawing.Size(241, 65);
            this.txt_discription.TabIndex = 47;
            // 
            // txt_amount
            // 
            this.txt_amount.BackColor = System.Drawing.Color.White;
            this.txt_amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_amount.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(530, 115);
            this.txt_amount.Multiline = true;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(249, 23);
            this.txt_amount.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 44;
            this.label5.Text = "DISCRIPTION :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(424, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 43;
            this.label7.Text = "Amount :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(424, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 23);
            this.label6.TabIndex = 42;
            this.label6.Text = "Category :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "Bill Date :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_bill_name
            // 
            this.txt_bill_name.BackColor = System.Drawing.Color.White;
            this.txt_bill_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_bill_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_bill_name.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bill_name.Location = new System.Drawing.Point(118, 61);
            this.txt_bill_name.Multiline = true;
            this.txt_bill_name.Name = "txt_bill_name";
            this.txt_bill_name.Size = new System.Drawing.Size(249, 23);
            this.txt_bill_name.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Bill Name :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(573, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 36);
            this.button1.TabIndex = 55;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(696, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 36);
            this.button2.TabIndex = 56;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "label1";
            // 
            // edit_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bill_date_picker);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_discription);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_bill_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "edit_form";
            this.Text = "edit_form";
            this.Load += new System.EventHandler(this.edit_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeedataDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dataDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource employeedataDataSet4BindingSource;
        private Employee_dataDataSet4 employee_dataDataSet4;
        private System.Windows.Forms.BindingSource expenseTableBindingSource;
        private Employee_dataDataSet4TableAdapters.Expense_TableTableAdapter expense_TableTableAdapter;
        private System.Windows.Forms.DateTimePicker bill_date_picker;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_discription;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_bill_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn refIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn submitdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}