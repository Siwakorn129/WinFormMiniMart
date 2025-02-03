namespace WinFormMiniMart
{
    partial class frmCategories
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCategories = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCategoryID = new TextBox();
            txtCategoryName = new TextBox();
            txtDescription = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClearForm = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(1, 1);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.Size = new Size(1157, 896);
            dgvCategories.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            label1.Location = new Point(1225, 48);
            label1.Name = "label1";
            label1.Size = new Size(144, 44);
            label1.TabIndex = 1;
            label1.Text = "รหัสหมวดหมู่";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            label2.Location = new Point(1238, 116);
            label2.Name = "label2";
            label2.Size = new Size(131, 44);
            label2.TabIndex = 2;
            label2.Text = "ชื่อหมวดหมู่";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            label3.Location = new Point(1176, 178);
            label3.Name = "label3";
            label3.Size = new Size(193, 44);
            label3.TabIndex = 3;
            label3.Text = "คำอธิบายหมวดหมู่";
            // 
            // txtCategoryID
            // 
            txtCategoryID.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryID.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            txtCategoryID.Location = new Point(1375, 41);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(232, 51);
            txtCategoryID.TabIndex = 4;
            // 
            // txtCategoryName
            // 
            txtCategoryName.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryName.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            txtCategoryName.Location = new Point(1375, 109);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(470, 51);
            txtCategoryName.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            txtDescription.Location = new Point(1375, 178);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(470, 195);
            txtDescription.TabIndex = 6;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(192, 255, 192);
            btnInsert.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            btnInsert.Location = new Point(1386, 421);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(181, 116);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "เพิ่ม";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 192, 192);
            btnUpdate.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            btnUpdate.Location = new Point(1653, 421);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(181, 116);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "ลบ";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 255, 192);
            btnDelete.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            btnDelete.Location = new Point(1386, 590);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(181, 116);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "แก้ไข";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClearForm
            // 
            btnClearForm.BackColor = Color.FromArgb(192, 255, 255);
            btnClearForm.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            btnClearForm.Location = new Point(1653, 590);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(181, 116);
            btnClearForm.TabIndex = 10;
            btnClearForm.Text = "ล้างฟอร์ม";
            btnClearForm.UseVisualStyleBackColor = false;
            // 
            // frmCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1866, 899);
            Controls.Add(btnClearForm);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCategories);
            Name = "frmCategories";
            Text = "จัดการข้อมูลหมวดหมู่สินค้า";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategories;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCategoryID;
        private TextBox txtCategoryName;
        private TextBox txtDescription;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClearForm;
    }
}
