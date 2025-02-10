using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormMiniMart
{
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
            this.Load += FrmCategories_Load;
            dgvCategories.CellMouseUp += DgvCategories_CellMouseUp;
        }

        private void DgvCategories_CellMouseUp(object? sender, DataGridViewCellMouseEventArgs e)
        {
            txtCategoryID.Text = dgvCategories.CurrentRow.Cells["categoryID"].Value.ToString();
            txtCategoryName.Text = dgvCategories.CurrentRow.Cells["categoryName"].Value.ToString();
            txtDescription.Text = dgvCategories.CurrentRow.Cells["description"].Value.ToString();
        }

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand com;
        private void FrmCategories_Load(object? sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart();
            showdata();
        }

        private void showdata()
        {
            string sql = "Select * from Categories";
            com = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvCategories.DataSource = ds.Tables[0];
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtCategoryID.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtCategoryName.Focus();
            txtCategoryID.Enabled = false;//cannot input CategoryID
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //insert value
            //check Name is not null
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("ชื่อหมวดหมู่ต้องไม่เป็นที่ว่าง", "เกิดข้อผิดพลาด");
                return;
            }
            //insert data in database
            string sql = "Insert into Categories values(@categoryName, @Description)";
            com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@categoryName", txtCategoryName.Text.Trim());
            com.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
            if (com.ExecuteNonQuery() > 0)
            {
                showdata();//display
                btnClearForm.PerformClick();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Update
            //check Name is not null
            if (string.IsNullOrEmpty(txtCategoryID.Text))
            {
                MessageBox.Show("เลือกหมวดหมู่ที่ต้องการแก้ไขก่อน", "เกิดข้อผิดพลาด");
                return;
            }
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("ชื่อหมวดหมู่ต้องไม่เป็นที่ว่าง", "เกิดข้อผิดพลาด");
                return;
            }
            //insert data in database
            string sql = "Update Categories set CategoryName = @categoryName,description = @Description Where CategoryID = @categoryID";
            com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@categoryName", txtCategoryName.Text.Trim());
            com.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
            com.Parameters.AddWithValue("@categoryID", txtCategoryID.Text.Trim());
            if (com.ExecuteNonQuery() > 0)
            {
                showdata();//display
                btnClearForm.PerformClick();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Delete
            //Check selected value to delete
            if (string.IsNullOrEmpty(txtCategoryID.Text))
            {
                MessageBox.Show("เลือกหมวดหมู่ที่ต้องการลบก่อน", "เกิดข้อผิดพลาด");
                return;
            }
            //ask 
            if (MessageBox.Show("ต้องการลบหรือไม่", "โปรดยืนยัน", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            //delete value from database
            string sql = "delete From Categories where CategoryID = @categoryID";
            com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@categoryID", txtCategoryID.Text.Trim());
            try
            {
                if (com.ExecuteNonQuery() > 0)
                {
                    showdata();
                    btnClearForm.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด :" + Environment.NewLine + ex.Message, "ไม่สามารถลบข้อมูลได้");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmInsertUpdateCategory f = new frmInsertUpdateCategory();
            f.status = "insert";
            f.ShowDialog();
            showdata();
        }

        private void dgvCategories_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmInsertUpdateCategory f = new frmInsertUpdateCategory();
            f.status = "update";
            var dgv = dgvCategories.CurrentRow.Cells;
            f.categoryID = Convert.ToInt16(dgv["CategoryID"].Value);
            f.categoryName = dgv["CategoryName"].Value.ToString();
            f.description=dgv["Description"].Value.ToString();
            f.ShowDialog();
            showdata() ;
        }
    }
}
