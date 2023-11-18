namespace 大作业
{
    partial class 登录界面
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.用户名 = new System.Windows.Forms.MaskedTextBox();
            this.密码 = new System.Windows.Forms.MaskedTextBox();
            this.普通用户登录 = new System.Windows.Forms.Button();
            this.管理员登录 = new System.Windows.Forms.Button();
            this.显示密码 = new System.Windows.Forms.CheckBox();
            this.tableAdapterManager1 = new 大作业.dbDataSetTableAdapters.TableAdapterManager();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(90, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 20F);
            this.label2.Location = new System.Drawing.Point(90, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // 用户名
            // 
            this.用户名.Font = new System.Drawing.Font("宋体", 14F);
            this.用户名.Location = new System.Drawing.Point(261, 107);
            this.用户名.Name = "用户名";
            this.用户名.Size = new System.Drawing.Size(303, 34);
            this.用户名.TabIndex = 2;
            // 
            // 密码
            // 
            this.密码.Font = new System.Drawing.Font("宋体", 14F);
            this.密码.Location = new System.Drawing.Point(261, 182);
            this.密码.Name = "密码";
            this.密码.PasswordChar = '*';
            this.密码.Size = new System.Drawing.Size(303, 34);
            this.密码.TabIndex = 3;
            // 
            // 普通用户登录
            // 
            this.普通用户登录.Font = new System.Drawing.Font("宋体", 14F);
            this.普通用户登录.Location = new System.Drawing.Point(124, 338);
            this.普通用户登录.Name = "普通用户登录";
            this.普通用户登录.Size = new System.Drawing.Size(216, 50);
            this.普通用户登录.TabIndex = 4;
            this.普通用户登录.Text = "普通用户登录";
            this.普通用户登录.UseVisualStyleBackColor = true;
            this.普通用户登录.Click += new System.EventHandler(this.普通用户);
            // 
            // 管理员登录
            // 
            this.管理员登录.Font = new System.Drawing.Font("宋体", 14F);
            this.管理员登录.Location = new System.Drawing.Point(408, 338);
            this.管理员登录.Name = "管理员登录";
            this.管理员登录.Size = new System.Drawing.Size(216, 50);
            this.管理员登录.TabIndex = 5;
            this.管理员登录.Text = "管理员登录";
            this.管理员登录.UseVisualStyleBackColor = true;
            this.管理员登录.Click += new System.EventHandler(this.管理员);
            // 
            // 显示密码
            // 
            this.显示密码.AutoSize = true;
            this.显示密码.Font = new System.Drawing.Font("宋体", 14F);
            this.显示密码.Location = new System.Drawing.Point(583, 188);
            this.显示密码.Name = "显示密码";
            this.显示密码.Size = new System.Drawing.Size(128, 28);
            this.显示密码.TabIndex = 6;
            this.显示密码.Text = "显示密码";
            this.显示密码.UseVisualStyleBackColor = true;
            this.显示密码.CheckedChanged += new System.EventHandler(this.密码显示);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.TableTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = 大作业.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1, 408);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(797, 39);
            this.progressBar1.TabIndex = 7;
            // 
            // 登录界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.显示密码);
            this.Controls.Add(this.管理员登录);
            this.Controls.Add(this.普通用户登录);
            this.Controls.Add(this.密码);
            this.Controls.Add(this.用户名);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "登录界面";
            this.Text = "登录界面";
            this.Click += new System.EventHandler(this.普通用户);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox 用户名;
        private System.Windows.Forms.MaskedTextBox 密码;
        private System.Windows.Forms.Button 普通用户登录;
        private System.Windows.Forms.Button 管理员登录;
        private System.Windows.Forms.CheckBox 显示密码;
        private dbDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}