using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 大作业
{
    public partial class 首页 : Form
    {
        public 首页()
        {
            InitializeComponent();
        }

        private void datashow(object sender, EventArgs e)

        {

            全部数据 全部数据 = new 全部数据();

            全部数据.Show();

        }

        private void Quit(object sender, EventArgs e)

        {

            this.Close();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // 获取文本框输入的值
            string trainNo = textBox1.Text;
            // 定义连接字符串
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"F:\\project\\c_plus project_vs\\大作业\\db.mdf\";Integrated Security=True";
            MessageBox.Show("正在查询........点击确定继续");
            // 数据库查询
            QueryData(connString, trainNo);
        }
        
        private void QueryData(string connString, string trainNo)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Table] WHERE train = @trainNo", conn))
            {
                cmd.Parameters.Add("@trainNo", SqlDbType.NVarChar, 10).Value = trainNo;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string train = reader["train"].ToString();
                        string departure = reader["departure"].ToString();
                        string terminal = reader["Terminal"].ToString();
                        string departure_station = reader["departure_station"].ToString();
                        string destination = reader["destination"].ToString();
                        MessageBox.Show("找到火车编号:" + trainNo + "\n出发时间：" + departure + "\n到达时间：" + terminal + "\n始发站：" + departure_station + "\n终到站：" + destination);
                    }
                    else
                    {
                        MessageBox.Show("没有找到该火车编号");
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void 添加火车(object sender, EventArgs e)
        {
            添加火车 添加火车 = new 添加火车();

            添加火车.Show();
        }

        private void 删除列车(object sender, EventArgs e)
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"F:\\project\\c_plus project_vs\\大作业\\db.mdf\";Integrated Security=True";
            string trainToDelete = textBoxTrain.Text.Trim();
            if (!string.IsNullOrEmpty(trainToDelete))
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM [Table] WHERE train = @train", conn))
                        {
                            cmd.Parameters.AddWithValue("@train", trainToDelete);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("删除列车成功!");
                            }
                            else
                            {
                                MessageBox.Show("未找到指定列车，删除失败!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("发生错误：" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("请输入列车train！");
            }
        }

        private void 修改列车(object sender, EventArgs e)
        {
            修改列车 修改列车 = new 修改列车();

            修改列车.Show();
        }
    }
}
