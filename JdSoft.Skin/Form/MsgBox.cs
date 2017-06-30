
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JdSoft.Skin
{
    public partial class MsgBox : BaseForm
    {
        /// <summary>
        /// 标题
        /// </summary>
        private string _title { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        private string _msg { get; set; }
        /// <summary>
        /// 消息框类型
        /// </summary>
        private MsgBoxType _type { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public MsgBox()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="title"></param>
        /// <param name="msg"></param>
        /// <param name="type"></param>
        public MsgBox(string title, string msg, MsgBoxType type)
        {
            InitializeComponent();
            this._title = title;
            this._msg = msg;
            this._type = type;
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MsgBox_Load(object sender, EventArgs e)
        {
            this.Text = _title;
            this.label_Msg.Text = _msg;
            this.pb_Icon.Image = this.imageList_Icon.Images[(int)_type];
        }
        /// <summary>
        /// 确定事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        /// <summary>
        /// 取消事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
