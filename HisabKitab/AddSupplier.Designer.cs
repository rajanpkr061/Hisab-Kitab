namespace HisabKitab
{
    partial class AddSupplier
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.Button();
            this.txtEdit = new System.Windows.Forms.Button();
            this.AddSupplierForm = new System.Windows.Forms.GroupBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hisabKitabDBDataSet1 = new HisabKitab.HisabKitabDBDataSet1();
            this.hisabKitabDBDataSet = new HisabKitab.HisabKitabDBDataSet();
            this.hisabKitabDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new HisabKitab.HisabKitabDBDataSet1TableAdapters.SupplierTableAdapter();
            this.supplierDataGridView = new System.Windows.Forms.DataGridView();
            this.supplierBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnViewSupplier = new System.Windows.Forms.Button();
            this.supplier_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliercontactpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliercontactnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisabKitabDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisabKitabDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisabKitabDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(131, 185);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 29);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(131, 147);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(185, 20);
            this.txtContactNo.TabIndex = 12;
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Location = new System.Drawing.Point(131, 106);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(185, 20);
            this.txtContactPerson.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Contact Person";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Contact No.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(249, 185);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 29);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.txtDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelete.Location = new System.Drawing.Point(249, 229);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(67, 29);
            this.txtDelete.TabIndex = 20;
            this.txtDelete.Text = "Delete";
            this.txtDelete.UseVisualStyleBackColor = false;
            this.txtDelete.Click += new System.EventHandler(this.txtDelete_Click);
            // 
            // txtEdit
            // 
            this.txtEdit.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.txtEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdit.Location = new System.Drawing.Point(131, 229);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(67, 29);
            this.txtEdit.TabIndex = 19;
            this.txtEdit.Text = "Edit";
            this.txtEdit.UseVisualStyleBackColor = false;
            this.txtEdit.Click += new System.EventHandler(this.txtEdit_Click);
            // 
            // AddSupplierForm
            // 
            this.AddSupplierForm.Location = new System.Drawing.Point(3, 29);
            this.AddSupplierForm.Name = "AddSupplierForm";
            this.AddSupplierForm.Size = new System.Drawing.Size(322, 233);
            this.AddSupplierForm.TabIndex = 39;
            this.AddSupplierForm.TabStop = false;
            this.AddSupplierForm.Text = "Add Supplier";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.hisabKitabDBDataSet1;
            // 
            // hisabKitabDBDataSet1
            // 
            this.hisabKitabDBDataSet1.DataSetName = "HisabKitabDBDataSet1";
            this.hisabKitabDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hisabKitabDBDataSet
            // 
            this.hisabKitabDBDataSet.DataSetName = "HisabKitabDBDataSet";
            this.hisabKitabDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hisabKitabDBDataSetBindingSource
            // 
            this.hisabKitabDBDataSetBindingSource.DataSource = this.hisabKitabDBDataSet;
            this.hisabKitabDBDataSetBindingSource.Position = 0;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // supplierDataGridView
            // 
            this.supplierDataGridView.AllowUserToAddRows = false;
            this.supplierDataGridView.AllowUserToDeleteRows = false;
            this.supplierDataGridView.AutoGenerateColumns = false;
            this.supplierDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.supplierDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.supplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplier_id,
            this.suppliernameDataGridViewTextBoxColumn,
            this.suppliercontactpersonDataGridViewTextBoxColumn,
            this.suppliercontactnoDataGridViewTextBoxColumn});
            this.supplierDataGridView.DataSource = this.supplierBindingSource1;
            this.supplierDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.supplierDataGridView.Location = new System.Drawing.Point(331, 29);
            this.supplierDataGridView.Name = "supplierDataGridView";
            this.supplierDataGridView.ReadOnly = true;
            this.supplierDataGridView.Size = new System.Drawing.Size(279, 233);
            this.supplierDataGridView.TabIndex = 40;
            this.supplierDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.supplierDataGridView_RowHeaderMouseClick);
            // 
            // supplierBindingSource1
            // 
            this.supplierBindingSource1.DataMember = "Supplier";
            this.supplierBindingSource1.DataSource = this.hisabKitabDBDataSet1;
            // 
            // btnViewSupplier
            // 
            this.btnViewSupplier.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnViewSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSupplier.Location = new System.Drawing.Point(331, 268);
            this.btnViewSupplier.Name = "btnViewSupplier";
            this.btnViewSupplier.Size = new System.Drawing.Size(67, 29);
            this.btnViewSupplier.TabIndex = 41;
            this.btnViewSupplier.Text = "View";
            this.btnViewSupplier.UseVisualStyleBackColor = false;
            this.btnViewSupplier.Click += new System.EventHandler(this.btnViewSupplier_Click);
            // 
            // supplier_id
            // 
            this.supplier_id.DataPropertyName = "supplier_id";
            this.supplier_id.HeaderText = "supplier_id";
            this.supplier_id.Name = "supplier_id";
            this.supplier_id.ReadOnly = true;
            // 
            // suppliernameDataGridViewTextBoxColumn
            // 
            this.suppliernameDataGridViewTextBoxColumn.DataPropertyName = "supplier_name";
            this.suppliernameDataGridViewTextBoxColumn.HeaderText = "supplier_name";
            this.suppliernameDataGridViewTextBoxColumn.Name = "suppliernameDataGridViewTextBoxColumn";
            this.suppliernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suppliercontactpersonDataGridViewTextBoxColumn
            // 
            this.suppliercontactpersonDataGridViewTextBoxColumn.DataPropertyName = "supplier_contactperson";
            this.suppliercontactpersonDataGridViewTextBoxColumn.HeaderText = "supplier_contactperson";
            this.suppliercontactpersonDataGridViewTextBoxColumn.Name = "suppliercontactpersonDataGridViewTextBoxColumn";
            this.suppliercontactpersonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suppliercontactnoDataGridViewTextBoxColumn
            // 
            this.suppliercontactnoDataGridViewTextBoxColumn.DataPropertyName = "supplier_contactno";
            this.suppliercontactnoDataGridViewTextBoxColumn.HeaderText = "supplier_contactno";
            this.suppliercontactnoDataGridViewTextBoxColumn.Name = "suppliercontactnoDataGridViewTextBoxColumn";
            this.suppliercontactnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(622, 333);
            this.Controls.Add(this.btnViewSupplier);
            this.Controls.Add(this.supplierDataGridView);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtContactPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.AddSupplierForm);
            this.Name = "AddSupplier";
            this.Text = "AddSupplier";
            this.Load += new System.EventHandler(this.AddSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisabKitabDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisabKitabDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisabKitabDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button txtDelete;
        private System.Windows.Forms.Button txtEdit;
        private System.Windows.Forms.GroupBox AddSupplierForm;
        private HisabKitabDBDataSet hisabKitabDBDataSet;
        private System.Windows.Forms.BindingSource hisabKitabDBDataSetBindingSource;
        private HisabKitabDBDataSet1 hisabKitabDBDataSet1;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private HisabKitabDBDataSet1TableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.DataGridView supplierDataGridView;
        private System.Windows.Forms.BindingSource supplierBindingSource1;
        private System.Windows.Forms.Button btnViewSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliercontactpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliercontactnoDataGridViewTextBoxColumn;
    }
}