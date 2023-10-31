namespace 大作业
{
    partial class 修改列车
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
            this.components = new System.ComponentModel.Container();
            this.dbDataSet = new 大作业.dbDataSet();
            this.dbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new 大作业.dbDataSetTableAdapters.TableTableAdapter();
            this.comboBoxTrain = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDeparture = new System.Windows.Forms.MaskedTextBox();
            this.departure_station = new System.Windows.Forms.MaskedTextBox();
            this.textBoxTerminal = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbDataSetBindingSource
            // 
            this.dbDataSetBindingSource.DataSource = this.dbDataSet;
            this.dbDataSetBindingSource.Position = 0;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.dbDataSetBindingSource;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxTrain
            // 
            this.comboBoxTrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrain.FormattingEnabled = true;
            this.comboBoxTrain.Location = new System.Drawing.Point(335, 25);
            this.comboBoxTrain.Name = "comboBoxTrain";
            this.comboBoxTrain.Size = new System.Drawing.Size(226, 23);
            this.comboBoxTrain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(119, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "你要修改的列车是";
            // 
            // textBoxDeparture
            // 
            this.textBoxDeparture.Location = new System.Drawing.Point(335, 75);
            this.textBoxDeparture.Name = "textBoxDeparture";
            this.textBoxDeparture.Size = new System.Drawing.Size(154, 25);
            this.textBoxDeparture.TabIndex = 2;
            // 
            // departure_station
            // 
            this.departure_station.Location = new System.Drawing.Point(335, 170);
            this.departure_station.Name = "departure_station";
            this.departure_station.Size = new System.Drawing.Size(154, 25);
            this.departure_station.TabIndex = 3;
            // 
            // textBoxTerminal
            // 
            this.textBoxTerminal.Location = new System.Drawing.Point(335, 124);
            this.textBoxTerminal.Name = "textBoxTerminal";
            this.textBoxTerminal.Size = new System.Drawing.Size(154, 25);
            this.textBoxTerminal.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(119, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "列车始发时间";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(119, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "列车终到时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(119, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "列车始发站";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(123, 268);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(221, 55);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "提交数据";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(119, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "列车终到站";
            // 
            // destination
            // 
            this.destination.Location = new System.Drawing.Point(335, 213);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(154, 25);
            this.destination.TabIndex = 10;
            // 
            // 修改列车
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTerminal);
            this.Controls.Add(this.departure_station);
            this.Controls.Add(this.textBoxDeparture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTrain);
            this.Name = "修改列车";
            this.Text = "修改列车";
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dbDataSetBindingSource;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private dbDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxTrain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textBoxDeparture;
        private System.Windows.Forms.MaskedTextBox departure_station;
        private System.Windows.Forms.MaskedTextBox textBoxTerminal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox destination;
    }
}