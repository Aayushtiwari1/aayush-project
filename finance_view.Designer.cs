
namespace sign_up
{
    partial class finance_view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(finance_view));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.bill_name = new System.Windows.Forms.Label();
            this.bill_date = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.sub_date = new System.Windows.Forms.Label();
            this.ref_id = new System.Windows.Forms.Label();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.usernameDataGridViewTextBoxColumn,
            this.billnameDataGridViewTextBoxColumn,
            this.billCategoryDataGridViewTextBoxColumn,
            this.billdateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.submitdateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.expenseTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1038, 268);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // refIdDataGridViewTextBoxColumn
            // 
            this.refIdDataGridViewTextBoxColumn.DataPropertyName = "Ref_Id";
            this.refIdDataGridViewTextBoxColumn.HeaderText = "Ref_Id";
            this.refIdDataGridViewTextBoxColumn.Name = "refIdDataGridViewTextBoxColumn";
            this.refIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
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
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(16, 225);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(354, 1);
            this.panel5.TabIndex = 56;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(16, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(354, 1);
            this.panel4.TabIndex = 55;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(16, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 1);
            this.panel3.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 53;
            this.label5.Text = "DECRIPTION :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 52;
            this.label4.Text = "Bill Date :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 51;
            this.label3.Text = "Bill Name :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(429, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 1);
            this.panel1.TabIndex = 62;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(429, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 1);
            this.panel2.TabIndex = 61;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(16, 279);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(354, 1);
            this.panel6.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(405, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 59;
            this.label1.Text = "Amount :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(425, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 58;
            this.label2.Text = "Username :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 57;
            this.label6.Text = "Category :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(429, 225);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(354, 1);
            this.panel7.TabIndex = 66;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(429, 182);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(354, 1);
            this.panel8.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(405, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 23);
            this.label7.TabIndex = 64;
            this.label7.Text = "ID :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(411, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 23);
            this.label8.TabIndex = 63;
            this.label8.Text = "Submit date :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(429, 265);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(354, 1);
            this.panel9.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(425, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 67;
            this.label9.Text = "STATUS :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bill_name
            // 
            this.bill_name.AutoSize = true;
            this.bill_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_name.Location = new System.Drawing.Point(109, 79);
            this.bill_name.Name = "bill_name";
            this.bill_name.Size = new System.Drawing.Size(0, 16);
            this.bill_name.TabIndex = 69;
            // 
            // bill_date
            // 
            this.bill_date.AutoSize = true;
            this.bill_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_date.Location = new System.Drawing.Point(109, 123);
            this.bill_date.Name = "bill_date";
            this.bill_date.Size = new System.Drawing.Size(0, 16);
            this.bill_date.TabIndex = 70;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(127, 184);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(0, 16);
            this.description.TabIndex = 71;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(109, 257);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(0, 16);
            this.category.TabIndex = 72;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(520, 76);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 16);
            this.username.TabIndex = 73;
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(520, 120);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(0, 16);
            this.amount.TabIndex = 74;
            // 
            // sub_date
            // 
            this.sub_date.AutoSize = true;
            this.sub_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_date.Location = new System.Drawing.Point(520, 161);
            this.sub_date.Name = "sub_date";
            this.sub_date.Size = new System.Drawing.Size(0, 16);
            this.sub_date.TabIndex = 75;
            // 
            // ref_id
            // 
            this.ref_id.AutoSize = true;
            this.ref_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ref_id.Location = new System.Drawing.Point(520, 204);
            this.ref_id.Name = "ref_id";
            this.ref_id.Size = new System.Drawing.Size(0, 16);
            this.ref_id.TabIndex = 76;
            // 
            // comboBox_status
            // 
            this.comboBox_status.AutoCompleteCustomSource.AddRange(new string[] {
            "APPROVED",
            "NOT APPROVED",
            "IN PROGRESS"});
            this.comboBox_status.BackColor = System.Drawing.Color.White;
            this.comboBox_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_status.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_status.ForeColor = System.Drawing.Color.Black;
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Items.AddRange(new object[] {
            "SUBMITTED",
            "IN PROGRESS",
            "APPROVED",
            "NOT APPROVED"});
            this.comboBox_status.Location = new System.Drawing.Point(512, 232);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(252, 31);
            this.comboBox_status.TabIndex = 77;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(874, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 36);
            this.button1.TabIndex = 78;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // finance_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1041, 565);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_status);
            this.Controls.Add(this.ref_id);
            this.Controls.Add(this.sub_date);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.username);
            this.Controls.Add(this.category);
            this.Controls.Add(this.description);
            this.Controls.Add(this.bill_date);
            this.Controls.Add(this.bill_name);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "finance_view";
            this.Text = "finance_view";
            this.Load += new System.EventHandler(this.finance_view_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn refIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn submitdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label bill_name;
        private System.Windows.Forms.Label bill_date;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label sub_date;
        private System.Windows.Forms.Label ref_id;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.Button button1;
    }
}