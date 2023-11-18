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
            string departureStation = textBox1.Text; // 获取始发站输入
            string destinationStation = textBox3.Text; // 获取终点站输入
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db.mdf;Integrated Security=True";
            MessageBox.Show("正在查询........点击确定继续");
            QueryData(connString, departureStation, destinationStation);
        }

        private void QueryData(string connString, string departureStation, string destinationStation)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Table] WHERE departure_station LIKE '%' + @departureStation + '%' OR destination LIKE '%' + @destinationStation + '%'", conn))
                {
                    cmd.Parameters.Add("@departureStation", SqlDbType.NVarChar, 50).Value = departureStation;
                    cmd.Parameters.Add("@destinationStation", SqlDbType.NVarChar, 50).Value = destinationStation;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string train = reader["train"].ToString();
                                string departure = reader["departure"].ToString();
                                string terminal = reader["Terminal"].ToString();
                                string destination = reader["destination"].ToString();
                                string departure_station = reader["departure_station"].ToString();

                                MessageBox.Show("找到火车编号:" + train + "\n出发时间：" + departure + "\n到达时间：" + terminal + "\n终到站：" + destination + "\r\n始发站" + departure_station);
                                textBox2.Text = "找到火车编号: " + train + "\r\n出发时间: " + departure + "\r\n到达时间: " + terminal + "\r\n终到站: " + destination + "\r\n始发站:" + departure_station;
                            }
                        }
                        else
                        {
                            MessageBox.Show("没有找到相关信息");
                            textBox2.Text = "没有找到该火车始发站";
                        }
                    }
                }
            }
        }

        private void 添加火车(object sender, EventArgs e)
        {
            添加火车 添加火车 = new 添加火车();

            添加火车.Show();
        }

        private void 删除列车(object sender, EventArgs e)
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db.mdf;Integrated Security=True";
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

        private void 首页_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
