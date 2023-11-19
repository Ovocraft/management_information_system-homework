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
    public partial class 登录界面 : Form
    {
        private string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db.mdf;Integrated Security=True";
        public 登录界面()
        {
            InitializeComponent();
        }

        private async Task SimulateLoading(System.Windows.Forms.ProgressBar progressBar)
        {
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Value = 0;

            Timer timer = new Timer();
            timer.Interval = 30;
            timer.Tick += (s, args) =>
            {
                if (progressBar.Value >= 100)
                {
                    timer.Stop();
                }
                else
                {
                    progressBar.Value += 5;
                }
            };

            timer.Start();

            await Task.Delay(3000); // 异步等待
            timer.Stop();
        }


        private async void 普通用户(object sender, EventArgs e)
        {
            string username = 用户名.Text;
            string password = 密码.Text;
            await SimulateLoading(progressBar1);
            if (ValidateUser("用户", username, password))
            {
                全部数据 全部数据 = new 全部数据();
                全部数据.Show();
                MessageBox.Show("普通用户登录成功！");
                this.Hide();// 关闭当前窗口
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
            }
        }

        private async void 管理员(object sender, EventArgs e)
        {
            string username = 用户名.Text;
            string password = 密码.Text;
            await SimulateLoading(progressBar1);
            if (ValidateUser("管理员", username, password))
            {
                首页 首页 = new 首页();
                首页.Show();
                MessageBox.Show("管理员登录成功！");
                this.Hide(); // 关闭当前窗口
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
            }
        }

        private bool ValidateUser(string userType, string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = $"SELECT * FROM [{userType}] WHERE [用户名] = @Username AND [密码] = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    return true; // 用户名和密码匹配
                }
                else
                {
                    reader.Close();
                    return false; // 用户名或密码不匹配
                }
            }
        }

        private void 密码显示(object sender, EventArgs e)
        {
            if (显示密码.Checked)
            {
                密码.PasswordChar = '\0';   //显示输入
            }
            else
            {
                密码.PasswordChar = '*';   //显示*
            }
        }
    }
}
