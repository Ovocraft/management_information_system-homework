using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 大作业
{
    public partial class 全部数据 : Form
    {
        private string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db.mdf;Integrated Security=True";
        public 全部数据()
        {
            InitializeComponent();
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // 创建SqlCommand对象
                    using (SqlCommand cmd = new SqlCommand("SELECT departure_station, destination, Terminal, departure, train FROM [Table]", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            table.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发生错误：" + ex.Message);
                }
            }
            dataGridView1.DataSource = table;
        }

        private void 全部数据_Load(object sender, EventArgs e)
        {

        }

        private void 退出_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
