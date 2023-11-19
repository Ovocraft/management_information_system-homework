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

namespace 大作业
{
    public partial class 添加火车 : Form
    {
        private string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db.mdf;Integrated Security=True";

        public 添加火车()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTrain_Click(object sender, EventArgs e)
        {
            string trainNo = txtTrainNo.Text;
            string departureTime = txtDepartureTime.Text;
            string terminalTime = txtTerminalTime.Text;
            string departure_station = this.departure_station.Text;
            string destination = this.destination.Text;

            if (string.IsNullOrWhiteSpace(trainNo) || string.IsNullOrWhiteSpace(departureTime) || string.IsNullOrWhiteSpace(terminalTime))
            {
                MessageBox.Show("请填写所有字段");
                return;
            }

            if (AddTrain(trainNo, departureTime, terminalTime, departure_station, destination))
            {
                MessageBox.Show("火车添加成功");
                txtTrainNo.Clear();
                txtDepartureTime.Clear();
                txtTerminalTime.Clear();
                this.departure_station.Clear();
                this.destination.Clear();
            }
            else
            {
                MessageBox.Show("火车添加失败");
            }
        }

        private bool AddTrain(string trainNo, string departureTime, string terminalTime, string departure_station, string destination)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string sql = "INSERT INTO [Table] (train, departure, Terminal, departure_station, destination) VALUES (@trainNo, @departureTime, @terminalTime, @departure_station, @destination)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@trainNo", SqlDbType.NVarChar, 10).Value = trainNo;
                        cmd.Parameters.Add("@departureTime", SqlDbType.Time).Value = TimeSpan.Parse(departureTime);
                        cmd.Parameters.Add("@terminalTime", SqlDbType.Time).Value = TimeSpan.Parse(terminalTime);
                        cmd.Parameters.Add("@departure_station", SqlDbType.NVarChar, 10).Value = departure_station;
                        cmd.Parameters.Add("@destination", SqlDbType.NVarChar, 10).Value = destination;
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误：" + ex.Message);
                return false;
            }
        }

    }
}
