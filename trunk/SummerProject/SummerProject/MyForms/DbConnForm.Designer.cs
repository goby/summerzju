namespace NewSummerProject.MyForms
{
    partial class DbConnForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDBConnPre = new System.Windows.Forms.Button();
            this.lblItemDesctription = new System.Windows.Forms.Label();
            this.txtDBServer = new System.Windows.Forms.TextBox();
            this.btnDBConnCancel = new System.Windows.Forms.Button();
            this.checkOSA = new System.Windows.Forms.CheckBox();
            this.btnDBConnNext = new System.Windows.Forms.Button();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConnName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDBUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDBUserPwd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnStep2Cancel = new System.Windows.Forms.Button();
            this.btnStep2Pre = new System.Windows.Forms.Button();
            this.btnStep2Next = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.btnDBConnPre);
            this.panel1.Controls.Add(this.lblItemDesctription);
            this.panel1.Controls.Add(this.txtDBServer);
            this.panel1.Controls.Add(this.btnDBConnCancel);
            this.panel1.Controls.Add(this.checkOSA);
            this.panel1.Controls.Add(this.btnDBConnNext);
            this.panel1.Controls.Add(this.txtDBName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtConnName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDBUserName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDBUserPwd);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 314);
            this.panel1.TabIndex = 100005;
            this.panel1.Visible = false;
            // 
            // btnDBConnPre
            // 
            this.btnDBConnPre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDBConnPre.Location = new System.Drawing.Point(78, 277);
            this.btnDBConnPre.Name = "btnDBConnPre";
            this.btnDBConnPre.Size = new System.Drawing.Size(75, 23);
            this.btnDBConnPre.TabIndex = 6;
            this.btnDBConnPre.Text = "上一步(&P)";
            this.btnDBConnPre.UseVisualStyleBackColor = true;
            // 
            // lblItemDesctription
            // 
            this.lblItemDesctription.BackColor = System.Drawing.Color.Transparent;
            this.lblItemDesctription.Location = new System.Drawing.Point(11, 9);
            this.lblItemDesctription.Name = "lblItemDesctription";
            this.lblItemDesctription.Size = new System.Drawing.Size(303, 35);
            this.lblItemDesctription.TabIndex = 99999;
            this.lblItemDesctription.Text = "目前只支持Microsoft SQL Server Express版本数据库";
            // 
            // txtDBServer
            // 
            this.txtDBServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDBServer.Location = new System.Drawing.Point(136, 92);
            this.txtDBServer.Name = "txtDBServer";
            this.txtDBServer.Size = new System.Drawing.Size(179, 21);
            this.txtDBServer.TabIndex = 1;
            this.txtDBServer.Text = "narnia\\sqlexpress";
            // 
            // btnDBConnCancel
            // 
            this.btnDBConnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnDBConnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDBConnCancel.Location = new System.Drawing.Point(240, 277);
            this.btnDBConnCancel.Name = "btnDBConnCancel";
            this.btnDBConnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnDBConnCancel.TabIndex = 7;
            this.btnDBConnCancel.Text = "取消(&Q)";
            this.btnDBConnCancel.UseVisualStyleBackColor = false;
            this.btnDBConnCancel.Click += new System.EventHandler(this.btnDBConnCancel_Click);
            // 
            // checkOSA
            // 
            this.checkOSA.AutoSize = true;
            this.checkOSA.BackColor = System.Drawing.Color.Transparent;
            this.checkOSA.Checked = true;
            this.checkOSA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkOSA.Location = new System.Drawing.Point(9, 175);
            this.checkOSA.Name = "checkOSA";
            this.checkOSA.Size = new System.Drawing.Size(162, 16);
            this.checkOSA.TabIndex = 3;
            this.checkOSA.Text = "使用Windows账号验证方式";
            this.checkOSA.UseVisualStyleBackColor = false;
            this.checkOSA.CheckedChanged += new System.EventHandler(this.checkOSA_CheckedChanged);
            // 
            // btnDBConnNext
            // 
            this.btnDBConnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnDBConnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDBConnNext.Location = new System.Drawing.Point(159, 277);
            this.btnDBConnNext.Name = "btnDBConnNext";
            this.btnDBConnNext.Size = new System.Drawing.Size(75, 23);
            this.btnDBConnNext.TabIndex = 6;
            this.btnDBConnNext.Text = "下一步(&N)";
            this.btnDBConnNext.UseVisualStyleBackColor = false;
            this.btnDBConnNext.Click += new System.EventHandler(this.btnDBConnNext_Click);
            // 
            // txtDBName
            // 
            this.txtDBName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDBName.Location = new System.Drawing.Point(136, 131);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(179, 21);
            this.txtDBName.TabIndex = 2;
            this.txtDBName.Text = "arcsde";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(89, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "密码 :";
            // 
            // txtConnName
            // 
            this.txtConnName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConnName.Location = new System.Drawing.Point(136, 51);
            this.txtConnName.Name = "txtConnName";
            this.txtConnName.Size = new System.Drawing.Size(179, 21);
            this.txtConnName.TabIndex = 0;
            this.txtConnName.Text = "narnia_express";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(41, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "数据库用户名 :";
            // 
            // txtDBUserName
            // 
            this.txtDBUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDBUserName.Location = new System.Drawing.Point(136, 197);
            this.txtDBUserName.Name = "txtDBUserName";
            this.txtDBUserName.Size = new System.Drawing.Size(179, 21);
            this.txtDBUserName.TabIndex = 4;
            this.txtDBUserName.Text = "sa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(5, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 99;
            this.label3.Text = "ArcSDE的数据库名称 :";
            // 
            // txtDBUserPwd
            // 
            this.txtDBUserPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDBUserPwd.Location = new System.Drawing.Point(136, 235);
            this.txtDBUserPwd.Name = "txtDBUserPwd";
            this.txtDBUserPwd.PasswordChar = '*';
            this.txtDBUserPwd.Size = new System.Drawing.Size(179, 21);
            this.txtDBUserPwd.TabIndex = 5;
            this.txtDBUserPwd.Text = "sa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(71, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 9999;
            this.label9.Text = "连接名称:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(134, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 12);
            this.label5.TabIndex = 99;
            this.label5.Text = "例如: myserver\\sqlexpress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(59, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 99;
            this.label2.Text = "数据库地址:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(134, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 99;
            this.label10.Text = "例如: 地形数据";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(134, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "例如: sde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(134, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 99;
            this.label4.Text = "例如: SDE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(134, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "例如: sde";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnStep2Cancel);
            this.panel2.Controls.Add(this.btnStep2Pre);
            this.panel2.Controls.Add(this.btnStep2Next);
            this.panel2.Location = new System.Drawing.Point(359, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 314);
            this.panel2.TabIndex = 100003;
            this.panel2.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 255);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 16);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "全选/反选";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 237);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请选择地区地形数据";
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(290, 208);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnStep2Cancel
            // 
            this.btnStep2Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStep2Cancel.Location = new System.Drawing.Point(240, 277);
            this.btnStep2Cancel.Name = "btnStep2Cancel";
            this.btnStep2Cancel.Size = new System.Drawing.Size(75, 23);
            this.btnStep2Cancel.TabIndex = 3;
            this.btnStep2Cancel.Text = "取消(&Q)";
            this.btnStep2Cancel.UseVisualStyleBackColor = true;
            this.btnStep2Cancel.Click += new System.EventHandler(this.btnStep2Cancel_Click);
            // 
            // btnStep2Pre
            // 
            this.btnStep2Pre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStep2Pre.Location = new System.Drawing.Point(78, 277);
            this.btnStep2Pre.Name = "btnStep2Pre";
            this.btnStep2Pre.Size = new System.Drawing.Size(75, 23);
            this.btnStep2Pre.TabIndex = 4;
            this.btnStep2Pre.Text = "上一步(&P)";
            this.btnStep2Pre.UseVisualStyleBackColor = true;
            // 
            // btnStep2Next
            // 
            this.btnStep2Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStep2Next.Location = new System.Drawing.Point(159, 277);
            this.btnStep2Next.Name = "btnStep2Next";
            this.btnStep2Next.Size = new System.Drawing.Size(75, 23);
            this.btnStep2Next.TabIndex = 2;
            this.btnStep2Next.Text = "确定(&N)";
            this.btnStep2Next.UseVisualStyleBackColor = true;
            this.btnStep2Next.Click += new System.EventHandler(this.btnStep2Next_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 300);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(321, 10);
            this.progressBar1.TabIndex = 100000;
            this.progressBar1.Tag = "";
            // 
            // DbConnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 334);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "DbConnForm";
            this.Text = "数据库连接";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DbConnForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDBConnPre;
        private System.Windows.Forms.Label lblItemDesctription;
        private System.Windows.Forms.TextBox txtDBServer;
        private System.Windows.Forms.Button btnDBConnCancel;
        private System.Windows.Forms.CheckBox checkOSA;
        private System.Windows.Forms.Button btnDBConnNext;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConnName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDBUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDBUserPwd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnStep2Cancel;
        private System.Windows.Forms.Button btnStep2Pre;
        private System.Windows.Forms.Button btnStep2Next;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}