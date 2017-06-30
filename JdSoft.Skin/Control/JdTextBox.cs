using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using JdSoft.Skin.Class;

namespace JdSoft.Skin.MyControl
{
    public partial class MyTextBox : UserControl
    {
        #region 属性
        public Color _BorderColor = ColorTranslator.FromHtml(SkinSetting.TextBoxStyle_BorderColor);
        public Color _DefaultBorderColor = ColorTranslator.FromHtml(SkinSetting.TextBoxStyle_BorderColor);
        public Color _EnterBorderColor = ColorTranslator.FromHtml(SkinSetting.TextBoxStyle_BorderHoverColor);
        /// <summary>
        /// 默认边框颜色
        /// </summary>
        [Category("SUI自定义属性"), Description("默认边框颜色")]
        public Color DefaultBorderColor
        {
            get { return _DefaultBorderColor; }
            set { _DefaultBorderColor = value; }
        }

        /// <summary>
        /// 鼠标进入时边框颜色
        /// </summary>
        [Category("SUI自定义属性"), Description("鼠标进入时边框颜色")]
        public Color EnterBorderColor
        {
            get { return _EnterBorderColor; }
            set { _EnterBorderColor = value; }
        }
        /// <summary>
        /// 设置控件圆角半径
        /// </summary>
        private int _Radius = 4;
        [Category("SUI自定义属性")]
        [Description("设置控件圆角半径")]
        public int Radius
        {
            get { return this._Radius; }
            set
            {
                _Radius = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 与控件关联的文本
        /// </summary>
        [Category("SUI自定义属性"), Description("与控件关联的文本")]
        public string DefaultText
        {
            get { return BaseText.Text; }
            set { BaseText.Text = value; }
        }
        /// <summary>
        /// 输入最大字符数
        /// </summary>
        [Category("SUI自定义属性"), Description("输入最大字符数")]
        public int MaxLength
        {
            get { return BaseText.MaxLength; }
            set { BaseText.MaxLength = value; }
        }
        /// <summary>
        /// 将控件设为密码显示
        /// </summary>
        [Category("SUI自定义属性"), Description("将控件设为密码显示")]
        public bool IsPass
        {
            get { return BaseText.UseSystemPasswordChar; }
            set { BaseText.UseSystemPasswordChar = value; }
        }
        /// <summary>
        /// 密码显示字符
        /// </summary>
        [Category("SUI自定义属性"), Description("密码显示字符")]
        public char PassChar
        {
            get { return BaseText.PasswordChar; }
            set { BaseText.PasswordChar = value; }
        }
        /// <summary>
        /// 将控件设为多行文本显示
        /// </summary>
        [Category("SUI自定义属性"), Description("将控件设为多行文本显示")]
        public bool Multiline
        {
            get { return BaseText.Multiline; }
            set
            {
                BaseText.Multiline = value;
                if (value)
                {
                    BaseText.Height = this.Height - 6;
                }
                else
                {
                    base.Height = this.Height;
                    BaseText.Height = this.Height;
                    this.Invalidate();
                }
            }
        }
        /// <summary>
        /// 设置控件中文本字体
        /// </summary>
        [Category("SUI自定义属性"), Description("设置控件中文本字体")]
        public new Font Font
        {
            get { return BaseText.Font; }
            set { BaseText.Font = value; }
        }
        /// <summary>
        /// 将控件设为只读
        /// </summary>
        [Category("SUI自定义属性"), Description("将控件设为只读")]
        public bool ReadOnly
        {
            get { return BaseText.ReadOnly; }
            set { BaseText.ReadOnly = value; }
        }
        #endregion

        /// <summary>
        /// 构造
        /// </summary>
        public MyTextBox()
        {
            InitializeComponent();
            SetStyle(
                    ControlStyles.UserPaint |
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.DoubleBuffer |
                    ControlStyles.SupportsTransparentBackColor, true);

            this.BackColor = Color.Transparent;
            this.BaseText.LostFocus += BaseText_LostFocus;
            this.BaseText.GotFocus += BaseText_GotFocus;
            this.BaseText.MouseEnter += BaseText_MouseEnter;
            this.BaseText.MouseLeave += BaseText_LostFocus;
        }

        /// <summary>
        /// 引发事件时会通过委托调用事件处理程序
        /// </summary>
        /// <param name="e"></param>
        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);
        }
        /// <summary>
        /// 重绘
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int radius = 1;

            int width = this.ClientRectangle.Width;
            int height = this.ClientRectangle.Height;
            if (width % 2 != 0)
                width++;
            if (height % 2 != 0)
                height++;
            this.Width = width;
            this.Height = height;

            Rectangle clientRect = new Rectangle(new Point(0, 0), new Size(width, height));

            GraphicsPath gp = DrawRectUtil.CreatePath(clientRect, radius, RoundStyle.All, true);
            g.SmoothingMode = SmoothingMode.HighQuality;
            //绘制背景
            g.FillPath(new SolidBrush(Color.White), gp);
            //绘制阴影
            e.Graphics.DrawLine(new Pen(Color.FromArgb(50, _BorderColor), 2), 1, 1, clientRect.Width - 1, 1);
            //绘制圆角
            g.DrawPath(new Pen(_BorderColor), gp);

        }
        #region 文本框焦点,鼠标事件
        /// <summary>
        /// 获得焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BaseText_GotFocus(object sender, EventArgs e)
        {
            //_BorderColor = EnterBorderColor;
            //this.Invalidate();
        }
        /// <summary>
        /// 失去焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BaseText_LostFocus(object sender, EventArgs e)
        {
            _BorderColor = DefaultBorderColor;
            this.Invalidate();
        }
        /// <summary>
        /// 鼠标进入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BaseText_MouseEnter(object sender, EventArgs e)
        {
            _BorderColor = EnterBorderColor;
            this.Invalidate();
        }
        #endregion
    }
}
