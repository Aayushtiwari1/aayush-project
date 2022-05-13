
namespace sign_up
{
    partial class show_emp_expense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(show_emp_expense));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submitdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.employee_dataDataSet4 = new sign_up.Employee_dataDataSet4();
            this.expenseTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employee_dataDataSet2 = new sign_up.Employee_dataDataSet2();
            this.employee_dataDataSet1 = new sign_up.Employee_dataDataSet1();
            this.employeedataDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expenseTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expense_TableTableAdapter = new sign_up.Employee_dataDataSet1TableAdapters.Expense_TableTableAdapter();
            this.employee_dataDataSet = new sign_up.Employee_dataDataSet();
            this.employeedataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expense_TableTableAdapter1 = new sign_up.Employee_dataDataSet2TableAdapters.Expense_TableTableAdapter();
            this.expense_TableTableAdapter2 = new sign_up.Employee_dataDataSet4TableAdapters.Expense_TableTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dataDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dataDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeedataDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeedataDataSetBindingSource)).BeginInit();
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
            this.dataGridView1.DataSource = this.expenseTableBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(2, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 312);
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
            // expenseTableBindingSource2
            // 
            this.expenseTableBindingSource2.DataMember = "Expense_Table";
            this.expenseTableBindingSource2.DataSource = this.employee_dataDataSet4;
            // 
            // employee_dataDataSet4
            // 
            this.employee_dataDataSet4.DataSetName = "Employee_dataDataSet4";
            this.employee_dataDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expenseTableBindingSource1
            // 
            this.expenseTableBindingSource1.DataMember = "Expense_Table";
            this.expenseTableBindingSource1.DataSource = this.employee_dataDataSet2;
            // 
            // employee_dataDataSet2
            // 
            this.employee_dataDataSet2.DataSetName = "Employee_dataDataSet2";
            this.employee_dataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee_dataDataSet1
            // 
            this.employee_dataDataSet1.DataSetName = "Employee_dataDataSet1";
            this.employee_dataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeedataDataSet1BindingSource
            // 
            this.employeedataDataSet1BindingSource.DataSource = this.employee_dataDataSet1;
            this.employeedataDataSet1BindingSource.Position = 0;
            // 
            // expenseTableBindingSource
            // 
            this.expenseTableBindingSource.DataMember = "Expense_Table";
            this.expenseTableBindingSource.DataSource = this.employeedataDataSet1BindingSource;
            // 
            // expense_TableTableAdapter
            // 
            this.expense_TableTableAdapter.ClearBeforeFill = true;
            // 
            // employee_dataDataSet
            // 
            this.employee_dataDataSet.DataSetName = "Employee_dataDataSet";
            this.employee_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeedataDataSetBindingSource
            // 
            this.employeedataDataSetBindingSource.DataSource = this.employee_dataDataSet;
            this.employeedataDataSetBindingSource.Position = 0;
            // 
            // expense_TableTableAdapter1
            // 
            this.expense_TableTableAdapter1.ClearBeforeFill = true;
            // 
            // expense_TableTableAdapter2
            // 
            this.expense_TableTableAdapter2.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // show_emp_expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "show_emp_expense";
            this.Text = "show_emp_expense";
            this.Load += new System.EventHandler(this.show_emp_expense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dataDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dataDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeedataDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeedataDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource employeedataDataSet1BindingSource;
        private Employee_dataDataSet1 employee_dataDataSet1;
        private System.Windows.Forms.BindingSource expenseTableBindingSource;
        private Employee_dataDataSet1TableAdapters.Expense_TableTableAdapter expense_TableTableAdapter;
        private Employee_dataDataSet employee_dataDataSet;
        private System.Windows.Forms.BindingSource employeedataDataSetBindingSource;
        private Employee_dataDataSet2 employee_dataDataSet2;
        private System.Windows.Forms.BindingSource expenseTableBindingSource1;
        private Employee_dataDataSet2TableAdapters.Expense_TableTableAdapter expense_TableTableAdapter1;
        private Employee_dataDataSet4 employee_dataDataSet4;
        private System.Windows.Forms.BindingSource expenseTableBindingSource2;
        private Employee_dataDataSet4TableAdapters.Expense_TableTableAdapter expense_TableTableAdapter2;
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