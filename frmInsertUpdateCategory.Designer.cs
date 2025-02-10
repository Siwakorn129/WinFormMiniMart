namespace WinFormMiniMart
{
    partial class frmInsertUpdateCategory
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
            txtDescription = new TextBox();
            txtCategoryName = new TextBox();
            txtCategoryID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnCancle = new Button();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            txtDescription.Location = new Point(238, 192);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(470, 195);
            txtDescription.TabIndex = 12;
            // 
            // txtCategoryName
            // 
            txtCategoryName.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryName.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            txtCategoryName.Location = new Point(238, 123);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(470, 51);
            txtCategoryName.TabIndex = 11;
            // 
            // txtCategoryID
            // 
            txtCategoryID.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryID.Enabled = false;
            txtCategoryID.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            txtCategoryID.Location = new Point(238, 55);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(232, 51);
            txtCategoryID.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            label3.Location = new Point(39, 192);
            label3.Name = "label3";
            label3.Size = new Size(193, 44);
            label3.TabIndex = 9;
            label3.Text = "คำอธิบายหมวดหมู่";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            label2.Location = new Point(101, 130);
            label2.Name = "label2";
            label2.Size = new Size(131, 44);
            label2.TabIndex = 8;
            label2.Text = "ชื่อหมวดหมู่";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            label1.Location = new Point(88, 62);
            label1.Name = "label1";
            label1.Size = new Size(144, 44);
            label1.TabIndex = 7;
            label1.Text = "รหัสหมวดหมู่";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(401, 438);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(206, 123);
            btnSave.TabIndex = 13;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancle
            // 
            btnCancle.Location = new Point(673, 438);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(206, 123);
            btnCancle.TabIndex = 14;
            btnCancle.Text = "ยกเลิก";
            btnCancle.UseVisualStyleBackColor = true;
            // 
            // frmInsertUpdateCategory
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancle;
            ClientSize = new Size(1183, 699);
            Controls.Add(btnCancle);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmInsertUpdateCategory";
            Text = "เพิ่ม / ปรับปรุงข้อมุลหมวดหมู่สินค้า";
            Load += frmInsertUpdateCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescription;
        private TextBox txtCategoryName;
        private TextBox txtCategoryID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private Button btnCancle;
    }
}