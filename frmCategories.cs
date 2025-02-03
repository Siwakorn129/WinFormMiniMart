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
    }
}
