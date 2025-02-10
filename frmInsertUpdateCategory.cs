using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormMiniMart
{
    public partial class frmInsertUpdateCategory : Form
    {
        public frmInsertUpdateCategory()
        {
            InitializeComponent();
        }
        //property
        public int categoryID { get; set; }
        public string categoryName { get; set; }
        public string description { get; set; }
        public string status { get; set; }//รับค่าสถานะ insert update

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (status=="insert")
            {
                InsertUpdateCategory();
            }
            else if (status=="update")
            {
                UpdateCategories();
            }
        }

        private void UpdateCategories()
        {
            //cpoy code update
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
            com.ExecuteNonQuery();
            this.Close();
        }

        private void InsertUpdateCategory()
        {
            //cpoy code insert
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
            com.ExecuteNonQuery();
            this.Close();
        }

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand com;
        private void frmInsertUpdateCategory_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart();
            txtCategoryID.Text=categoryID.ToString();
            txtCategoryName.Text = categoryName;
            txtDescription.Text= description;
            this.Text += "(" + status + ")";
            txtCategoryName.Focus();
        }
    }
}
