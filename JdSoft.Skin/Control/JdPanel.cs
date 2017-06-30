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
    public partial class JdPanel : Panel
    {
        #region 控件属性
        
        private Image _Icon;
        [Category("SUI自定义属性"), Description("显示Icon")]
        public Image Icon
        {
            get { return _Icon; }
            set { _Icon = value; }
        }
       
        private int _IconX;
        [Category("SUI自定义属性"), Description("显示Icon的X轴位置")]
        public int IconX
        {
            get { return _IconX; }
            set { _IconX = value; }
        }
        /// <summary>
        /// 图标的大小
        /// </summary>
        private Size _IconSize;
        [Category("SUI自定义属性"), Description("图标的大小")]
        public Size IconSize
        {
            get { return _IconSize; }
            set { _IconSize = value; }
        }

        [Browsable(true)]
        [Category("SUI自定义属性")]
        public override  string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        [Category("SUI自定义属性"),]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set { base.ForeColor = value; }
        }
        #endregion

        public JdPanel()
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
                Size = new Size(100, 30);
                ForeColor = Color.Black;
            }
            catch { }
        }

        #region 重写事件
        /// <summary>
        /// 控件重绘
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            var rect = this.ClientRectangle;
            if (_Icon != null)
            {
                g.DrawImage(_Icon, new Rectangle(rect.X + _IconX, rect.Y + (rect.Height - _IconSize.Height) / 2, _IconSize.Width, _IconSize.Height),
                    new Rectangle(new Point(), _Icon.Size), GraphicsUnit.Pixel);
            }
            
            using (SolidBrush sb = new SolidBrush(this.ForeColor))
            {
                StringFormat sf = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center };
                g.DrawString(Text, Font, sb, new Rectangle(rect.X+_IconX+_IconSize.Width+10,rect.Y,rect.Width,rect.Height), sf);
            }
        }
        #endregion
    }
}
