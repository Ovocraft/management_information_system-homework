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
    public partial class 修改列车 : Form
    {
        private string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"F:\\project\\c_plus project_vs\\大作业\\db.mdf\";Integrated Security=True";
        public 修改列车()
        {
            InitializeComponent();
            LoadTrainList();
        }

        private void LoadTrainList()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT train FROM [Table]", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBoxTrain.Items.Add(reader["train"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发生错误：" + ex.Message);
                }
            }
        }

        private void comboBoxTrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTrain = comboBoxTrain.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(selectedTrain))
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Table] WHERE train = @train", conn))
                        {
                            cmd.Parameters.AddWithValue("@train", selectedTrain);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    textBoxDeparture.Text = reader["departure"].ToString();
                                    textBoxTerminal.Text = reader["Terminal"].ToString();
                                    departure_station.Text = reader["start_sattion"].ToString();
                                    destination.Text = reader["final_station"].ToString();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("发生错误：" + ex.Message);
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string selectedTrain = comboBoxTrain.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(selectedTrain))
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("UPDATE [Table] SET departure_station = @departure_station, destination = @destination , departure = @departure, Terminal = @Terminal WHERE train = @train", conn))
                        {
                            cmd.Parameters.AddWithValue("@train", selectedTrain);
                            cmd.Parameters.AddWithValue("@departure", textBoxDeparture.Text);
                            cmd.Parameters.AddWithValue("@Terminal", textBoxTerminal.Text);
                            cmd.Parameters.AddWithValue("@departure_station", departure_station.Text);
                            cmd.Parameters.AddWithValue("@destination", destination.Text);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("修改成功!");
                            }
                            else
                            {
                                MessageBox.Show("未找到指定列车，修改失败!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("发生错误：" + ex.Message);
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
