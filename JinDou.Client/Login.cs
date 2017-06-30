using JdSoft.Skin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JdSoft.Client
{
    public partial class Login : BaseForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (this.tb_Username.DefaultText == "admin")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                if(MsgHelper.Show("温馨提示", "提交成功", MsgBoxType.Success) == DialogResult.OK)
                {
                    MsgHelper.Show("温馨提示", "OK", MsgBoxType.Success);
                }
                else
                {
                    MsgHelper.Show("温馨提示", "Cancel", MsgBoxType.Success);
                }
            }
        }
    }
}
