using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JdSoft.Skin.MyControl
{
    public partial class MYTabControl : TabControl
    {
        #region 属性
        /// <summary>
        /// 控制背景色
        /// </summary>
        private Color _BgColor = ColorTranslator.FromHtml(SkinSetting.TabControlStyle_BgColor);
        [Category("SUI自定义属性"),
         Description("背景色")]
        public Color BgColor
        {
            get { return _BgColor; }
            set
            {
                _BgColor = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 选项卡选正常时颜色
        /// </summary>
        private Color _TabColor=ColorTranslator.FromHtml(SkinSetting.TabControlStyle_TabColor);
        [Category("SUI自定义属性"),
         Description("选择卡选正常时颜色")]
        public Color TabColor
        {
            get { return _TabColor; }
            set
            {
                _TabColor = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 选项卡选中时颜色
        /// </summary>
        private Color _TabSelectColor = ColorTranslator.FromHtml(SkinSetting.TabControlStyle_TabSelectColor);
        [Category("SUI自定义属性"),
         Description("选项卡选中时颜色")]
        public Color TabSelectColor
        {
            get { return _TabSelectColor; }
            set
            {
                _TabSelectColor = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 显示文本的字体
        /// </summary>
        [Category("SUI自定义属性")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
            }
        }
        #endregion

        /// <summary>
        /// 构造
        /// </summary>
        public MYTabControl()
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
                base.UpdateStyles();
                SizeMode = TabSizeMode.FillToRight;  // 大小模式为固定  
                ItemSize = new Size(60, 30);   // 设定每个标签的尺寸
                Padding = new Point(0);
                Margin = new Padding(0);
                BgColor = Color.FromArgb(255, 255, 254);
                TabColor = Color.FromArgb(232, 232, 231);
                TabSelectColor = Color.FromArgb(0, 150, 255);

            }
            catch { }
            InitializeComponent();
        }

        /// <summary>
        /// 重绘选项卡
        /// </summary>
        /// <param name="pe"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            var clirentRect = ClientRectangle;
            //绘制背景
            g.FillRectangle(new SolidBrush(_BgColor), clirentRect);
            clirentRect.Inflate(-1, -1);
            //绘制选项卡
            for (int i = 0; i < this.TabCount; i++)
            {
                var tabRect = this.GetTabRect(i);
                tabRect.Inflate(0, 0);
                // 选项卡背景及选中背景
                g.FillRectangle(new SolidBrush(_TabColor), tabRect.X, tabRect.Height - 1, tabRect.Width, 1);
                if (i == this.SelectedIndex)
                {
                    g.FillRectangle(new SolidBrush(_TabSelectColor), tabRect.X, tabRect.Height - 2, tabRect.Width, 2);
                }
                // 选择卡显示文本
                PointF textPoint = new PointF();
                SizeF textSize = TextRenderer.MeasureText(this.TabPages[i].Text, this.Font);

                // 注意要加上每个标签的左偏移量X  
                textPoint.X = tabRect.X + (tabRect.Width - textSize.Width) / 2;
                textPoint.Y = tabRect.Y + (tabRect.Height - textSize.Height) / 2;

                // 绘制高光  
                g.DrawString(
                    this.TabPages[i].Text,
                    this.Font,
                    SystemBrushes.ControlLightLight,//高光颜色  
                    textPoint.X,
                    textPoint.Y);

                // 绘制正常文字  
                textPoint.Y--;
                g.DrawString(
                    this.TabPages[i].Text,
                    this.Font,
                    SystemBrushes.ControlText,// 正常颜色  
                    textPoint.X,
                    textPoint.Y);
            }
        }
    }
}
