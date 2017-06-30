namespace JdSoft.Client
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Username = new JdSoft.Skin.MyControl.MyTextBox();
            this.tb_Password = new JdSoft.Skin.MyControl.MyTextBox();
            this.btn_Login = new JdSoft.Skin.MyControl.MyButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(90, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "用户账号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(90, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "用户密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(143, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "版权所有@小金斗科技";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(97, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "小金斗免费会员管理系统";
            // 
            // tb_Username
            // 
            this.tb_Username.BackColor = System.Drawing.Color.Transparent;
            this.tb_Username.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_Username.DefaultText = "admin";
            this.tb_Username.EnterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tb_Username.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_Username.IsPass = false;
            this.tb_Username.Location = new System.Drawing.Point(90, 134);
            this.tb_Username.MaxLength = 32767;
            this.tb_Username.Multiline = false;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.PassChar = '\0';
            this.tb_Username.Radius = 4;
            this.tb_Username.ReadOnly = false;
            this.tb_Username.Size = new System.Drawing.Size(234, 28);
            this.tb_Username.TabIndex = 10;
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.Color.Transparent;
            this.tb_Password.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(155)))), ((int)(((byte)(239)))));
            this.tb_Password.DefaultText = "";
            this.tb_Password.EnterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tb_Password.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_Password.IsPass = false;
            this.tb_Password.Location = new System.Drawing.Point(90, 195);
            this.tb_Password.MaxLength = 32767;
            this.tb_Password.Multiline = false;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PassChar = '\0';
            this.tb_Password.Radius = 4;
            this.tb_Password.ReadOnly = false;
            this.tb_Password.Size = new System.Drawing.Size(234, 28);
            this.tb_Password.TabIndex = 10;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(183)))), ((int)(((byte)(121)))));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.HoverBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(40)))), ((int)(((byte)(183)))), ((int)(((byte)(121)))));
            this.btn_Login.Location = new System.Drawing.Point(90, 243);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.NormalBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(183)))), ((int)(((byte)(121)))));
            this.btn_Login.Size = new System.Drawing.Size(234, 30);
            this.btn_Login.TabIndex = 11;
            this.btn_Login.Text = "登录";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(78)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(53)))));
            this.BottomBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(53)))));
            this.CaptionBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.CaptionTitleColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(417, 337);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "小金斗免费会员管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tb_Username, 0);
            this.Controls.SetChildIndex(this.tb_Password, 0);
            this.Controls.SetChildIndex(this.btn_Login, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Skin.MyControl.MyTextBox tb_Username;
        private Skin.MyControl.MyTextBox tb_Password;
        private Skin.MyControl.MyButton btn_Login;
    }
}

