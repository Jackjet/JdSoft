using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JdSoft.Skin.MyControl
{
    /// <summary>
    /// 按钮控件
    /// </summary>
    public partial class MyButton : Control
    {
        #region 控件属性
        /// <summary>
        /// 默认背景色
        /// </summary>
        private Color _NormalBgColor = ColorTranslator.FromHtml(SkinSetting.ButtonStyle_BgColor);
        [Category("SUI自定义属性"),
        Description("默认背景色")]
        public Color NormalBgColor
        {
            get { return _NormalBgColor; }
            set
            {
                _NormalBgColor = value;
                BackColor = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 招标经过背景色
        /// </summary>
        private Color _HoverBgColor = ColorTranslator.FromHtml(SkinSetting.ButtonStyle_Primary_BgHoverColor);
        [Category("SUI自定义属性"),
        Description("鼠标经过背景色")]
        public Color HoverBgColor
        {
            get { return _HoverBgColor; }
            set
            {
                _HoverBgColor = value;
                base.Invalidate();
            }
        }
        [Category("SUI自定义属性")]
        public override Image BackgroundImage
        {
            get
            {
                return base.BackgroundImage;
            }
            set
            {
                base.BackgroundImage = value;
            }
        }

        [Category("SUI自定义属性")]
        public override ImageLayout BackgroundImageLayout
        {
            get
            {
                return base.BackgroundImageLayout;
            }
            set
            {
                base.BackgroundImageLayout = value;
            }
        }
        [Category("SUI自定义属性")]
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }

        [Category("SUI自定义属性")]
        public override System.Drawing.Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
            }
        }
        #endregion

        public MyButton()
        {
            try
            {
                SetStyle(
                    ControlStyles.UserPaint |
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.DoubleBuffer |
                    ControlStyles.SupportsTransparentBackColor, true);
                Size = new Size(80, 30);
                BackColor = NormalBgColor;
                ForeColor = Color.White;
            }
            catch { }
        }

        #region 重写事件
        /// <summary>
        /// 鼠标进入
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            BackColor = Enabled ? _HoverBgColor : SystemColors.ControlDark;
        }
        /// <summary>
        /// 鼠标离开
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = Enabled ? _NormalBgColor : SystemColors.ControlDark;
        }
        /// <summary>
        /// 鼠标点击
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
        /// <summary>
        /// 控件重绘
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Color textColor = Enabled ? ForeColor : SystemColors.GrayText;
            Graphics g = e.Graphics;
            using (SolidBrush sb = new SolidBrush(textColor))
            {
                StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString(Text, Font, sb, ClientRectangle, sf);
            }
        }
        #endregion
    }
}
