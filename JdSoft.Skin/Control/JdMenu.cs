using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JdSoft.Skin.MyControl
{

    public partial class JdMenu : Control
    {
        #region 控件属性
        /// <summary>
        /// 控件中所有项的集合
        /// </summary>
        private JdMenuLayout _MenuLayout = JdMenuLayout.Horizontal;
        [Category("SUI自定义属性"), Description("控件中项的布局方向")]
        public JdMenuLayout MenuLayout
        {
            get { return _MenuLayout; }
            set { _MenuLayout = value; }
        }
        /// <summary>
        /// 控件中所有项的集合
        /// </summary>
        private List<JdMenuItem> _Items = new List<JdMenuItem>();
        [Category("SUI自定义属性"), Description("控件中所有项的集合"),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<JdMenuItem> Items
        {
            get { return _Items; }
        }
        /// <summary>
        /// 选中菜单项的背景颜色
        /// </summary>
        private Color _SelectItemBgColor;
        [Category("SUI自定义属性"), Description("选中菜单项的背景颜色")]
        public Color SelectItemBgColor
        {
            get { return _SelectItemBgColor; }
            set { _SelectItemBgColor = value; }
        }
        /// <summary>
        /// 菜单悬停项的背景颜色
        /// </summary>
        private Color _HoverItemBgColor;
        [Category("SUI自定义属性"), Description("菜单悬停项的背景颜色")]
        public Color HoverItemBgColor
        {
            get { return _HoverItemBgColor; }
            set { _HoverItemBgColor = value; }
        }
        /// <summary>
        /// 菜单悬停项的字体颜色
        /// </summary>
        private Color _HoverFontColor;
        [Category("SUI自定义属性"), Description("菜单悬停项的字体颜色")]
        public Color HoverFontColor
        {
            get { return _HoverFontColor; }
            set { _HoverFontColor = value; }
        }
        /// <summary>
        /// 控件中菜单项之间的大小
        /// </summary>
        private Size _ItemSize;
        [Category("SUI自定义属性"), Description("控件中菜单项的大小")]
        public Size ItemSize
        {
            get { return _ItemSize; }
            set { _ItemSize = value; }
        }
        /// <summary>
        /// 菜单图标的大小
        /// </summary>
        private Size _IconSize;
        [Category("SUI自定义属性"), Description("菜单图标的大小")]
        public Size IconSize
        {
            get { return _IconSize; }
            set { _IconSize = value; }
        }
        /// <summary>
        /// 菜单图标X位置
        /// </summary>
        private int _IconX;
        [Category("SUI自定义属性"), Description("菜单图标X位置")]
        public int IconX
        {
            get { return _IconX; }
            set { _IconX = value; }
        }
        /// <summary>
        /// 当前选中项
        /// </summary>
        private JdMenuItem _SelectItem;
        public JdMenuItem SelectItem
        {
            get { return _SelectItem; }
            set { _SelectItem = value; }
        }
        /// <summary>
        /// 鼠标经过项
        /// </summary>
        private JdMenuItem _HoverItem;
        public JdMenuItem HoverItem
        {
            get { return _HoverItem; }
            set { _HoverItem = value; }
        }
        private Point _mousePos;
        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public JdMenu()
        {
            InitializeComponent();
            SetStyle(
                    ControlStyles.UserPaint |
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.DoubleBuffer |
                    ControlStyles.SupportsTransparentBackColor, true);
            _ItemSize = new Size(145, 70);
            _IconSize = new Size(24, 24);
            _HoverItemBgColor = Color.FromArgb(50, 50, 50);
            _SelectItemBgColor = Color.FromArgb(250, 50, 70);
            _HoverFontColor = Color.White;
        }

        /// <summary>
        /// 鼠标移动事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            _mousePos = e.Location;
            JdMenuItem item= GetItem(_mousePos);
            if (item == null)
            {
                base.OnMouseMove(e);
                return;
            }
            if (_HoverItem == null)
            {
                _HoverItem= item; 
                Invalidate();
            }
            else
            {
                if (item != null && item.Index!=_HoverItem.Index)
                {
                    _HoverItem = item;
                    Invalidate();
                }
            }
            base.OnMouseMove(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            _HoverItem = null;
             Invalidate();
            base.OnMouseLeave(e);
        }

        /// <summary>
        /// 单击事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClick(EventArgs e)
        {
            _SelectItem = GetItem(_mousePos);
            Invalidate();
            base.OnClick(e);
        }
        /// <summary>
        /// 重绘
        /// </summary>
        /// <param name="pe"></param>
        protected override void OnPaint(PaintEventArgs pe)
        {
            var g = pe.Graphics;
            if (_HoverItem != null)
            {
                g.FillRectangle(new SolidBrush(HoverItemBgColor), _HoverItem.Bounds);
            }
            if (_SelectItem != null)
            {
                g.FillRectangle(new SolidBrush(_SelectItemBgColor), _SelectItem.Bounds);
            }

            var rect = new Rectangle(0, 0, _ItemSize.Width, _ItemSize.Height);
            for (int i = 0; i < _Items.Count; i++)
            {
                var item = _Items[i];
                item.Index = i;
                _Items[i].Bounds = rect;
                DrawItem(g, item, rect);
                if (_MenuLayout == JdMenuLayout.Horizontal)
                {
                    rect.X += _ItemSize.Width;
                }
                else
                {
                    rect.Y += _ItemSize.Height;
                }
                
            }
            base.OnPaint(pe);
        }
        #region 公用方法
        /// <summary>
		/// 绘制菜单项
		/// </summary>
		protected void DrawItem(Graphics g, JdMenuItem item, Rectangle rect)
        {
            if (item.Icon != null)
            {
                g.DrawImage(item.Icon, new Rectangle(rect.X + _IconX, rect.Y + (rect.Height - _IconSize.Height) / 2, _IconSize.Width, _IconSize.Height),
                    new Rectangle(new Point(), item.Icon.Size), GraphicsUnit.Pixel);
            }
            Color fontColor = ForeColor;
            if (_HoverItem != null && item.Index == _HoverItem.Index)
            {
                fontColor = _HoverFontColor;
            }
            if (_SelectItem != null && item.Index == _SelectItem.Index)
            {
                fontColor = _HoverFontColor;
            }
            g.DrawString(item.Text, Font, new SolidBrush(fontColor),
                new Rectangle(rect.X+10 , rect.Y + (rect.Height - this.Font.Height) / 2, rect.Width, rect.Height), new StringFormat() { Alignment = StringAlignment.Center });
        }
        /// <summary>
		/// 清空当前列表选择的项
		/// </summary>
		private void ClearSelectItem()
        {
            if (_SelectItem != null)
            {
                this.Invalidate(_SelectItem.Bounds);
                _SelectItem = null;
            }
        }
        /// 根据坐标点 找到对应的Item
        /// </summary>
        /// <param name="mousePos"></param>
        /// <returns></returns>
        private JdMenuItem GetItem(Point mousePos)
        {
            foreach (JdMenuItem item in _Items)
            {
                if (item.Bounds.Contains(_mousePos))
                {
                    return item;
                }
            }
            return null;
        }
        #endregion
    }
    /// <summary>
    /// 菜单项
    /// </summary>
    public class JdMenuItem
    {
        public JdMenuItem() { }
        public JdMenuItem(string text)
        {
            Text = text;
        }
        public JdMenuItem(string text, Image icon)
        {
            Text = text;
            Icon = icon;
        }
        /// <summary>
        /// 显示文本
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        public Image Icon { get; set; }
        /// <summary>
        /// 索引
        /// </summary>
        public int Index { get; set; }

        private Rectangle _bounds;
        /// <summary>
        /// 获取列表项的显示区域
        /// </summary>
        [Browsable(false)]
        public Rectangle Bounds
        {
            get { return _bounds; }
            internal set { _bounds = value; }
        }

        private JdMenu _ownerStIconMenu;
        /// <summary>
        /// 获取列表项所在的控件
        /// </summary>
        [Browsable(false)]
        public JdMenu OwnerStIconMenu
        {
            get { return _ownerStIconMenu; }
            internal set { _ownerStIconMenu = value; }
        }
    }
    // <summary>
    /// 菜单项
    /// </summary>
    public enum JdMenuLayout
    {
        //水平
        Horizontal = 1,
        //垂直
        Vertical = 2
    }
}
