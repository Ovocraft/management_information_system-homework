namespace 大作业
{
    partial class 添加火车
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
            this.txtTrainNo = new System.Windows.Forms.MaskedTextBox();
            this.txtDepartureTime = new System.Windows.Forms.MaskedTextBox();
            this.txtTerminalTime = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.departure_station = new System.Windows.Forms.MaskedTextBox();
            this.destination = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtTrainNo
            // 
            this.txtTrainNo.Location = new System.Drawing.Point(81, 97);
            this.txtTrainNo.Name = "txtTrainNo";
            this.txtTrainNo.Size = new System.Drawing.Size(161, 25);
            this.txtTrainNo.TabIndex = 0;
            this.txtTrainNo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtDepartureTime
            // 
            this.txtDepartureTime.Location = new System.Drawing.Point(81, 187);
            this.txtDepartureTime.Name = "txtDepartureTime";
            this.txtDepartureTime.Size = new System.Drawing.Size(161, 25);
            this.txtDepartureTime.TabIndex = 1;
            this.txtDepartureTime.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected_1);
            // 
            // txtTerminalTime
            // 
            this.txtTerminalTime.Location = new System.Drawing.Point(81, 290);
            this.txtTerminalTime.Name = "txtTerminalTime";
            this.txtTerminalTime.Size = new System.Drawing.Size(161, 25);
            this.txtTerminalTime.TabIndex = 2;
            this.txtTerminalTime.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(78, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "这里输入列车班次";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(78, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "这里输入始发时间";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(77, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "这里输入终到时间";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "录入到数据库";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddTrain_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(318, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "这里输入始发站";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(318, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "这里输入终到站";
            // 
            // departure_station
            // 
            this.departure_station.Location = new System.Drawing.Point(322, 187);
            this.departure_station.Name = "departure_station";
            this.departure_station.Size = new System.Drawing.Size(161, 25);
            this.departure_station.TabIndex = 9;
            // 
            // destination
            // 
            this.destination.Location = new System.Drawing.Point(322, 290);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(161, 25);
            this.destination.TabIndex = 10;
            // 
            // 添加火车
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.departure_station);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTerminalTime);
            this.Controls.Add(this.txtDepartureTime);
            this.Controls.Add(this.txtTrainNo);
            this.Name = "添加火车";
            this.Text = "添加火车";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtTrainNo;
        private System.Windows.Forms.MaskedTextBox txtDepartureTime;
        private System.Windows.Forms.MaskedTextBox txtTerminalTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox departure_station;
        private System.Windows.Forms.MaskedTextBox destination;
    }
}