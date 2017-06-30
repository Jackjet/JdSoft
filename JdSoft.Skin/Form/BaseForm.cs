using JdSoft.Skin.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace JdSoft.Skin
{
    /// <summary>
    /// 基窗体
    /// </summary>
    public partial class BaseForm : Form
    {

        #region 控件属性
       
        /// <summary>
        /// 设置窗口边框颜色
        /// </summary>
        private Color _BorderColor = ColorTranslator.FromHtml(SkinSetting.FormStyle_BorderColor);
        [Category("SUI自定义属性")]
        [Description("设置窗口边框颜色")]
        public Color BorderColor
        {
            get { return this._BorderColor; }
            set
            {
                _BorderColor = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 设置窗口边框颜色
        /// </summary>
        private int _BorderSize = 2;
        [Category("SUI自定义属性")]
        [Description("设置窗口边框大小")]
        public int BorderSize
        {
            get { return this._BorderSize; }
            set
            {
                _BorderSize = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 设置窗口标题栏高度
        /// </summary>
        private int _CaptionHeight = 28;
        [Category("SUI自定义属性")]
        [Description("设置窗口标题栏高度")]
        public int CaptionHeight
        {
            get { return this._CaptionHeight; }
            set
            {
                _CaptionHeight = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 设置窗口标题栏背景模式
        /// </summary>
        private BackgroundMode _CaptionBgMode = BackgroundMode.Color;
        [Category("SUI自定义属性")]
        [Description("设置窗口标题栏背景模式")]
        public BackgroundMode CaptionBgMode
        {
            get { return this._CaptionBgMode; }
            set
            {
                _CaptionBgMode = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 设置窗口标题栏背景颜色
        /// </summary>
        private Color _CaptionBgColor = ColorTranslator.FromHtml(SkinSetting.FormStyle_CaptionBgColor);
        [Category("SUI自定义属性")]
        [Description("设置窗口标题栏背景颜色")]
        public Color CaptionBgColor
        {
            get { return this._CaptionBgColor; }
            set
            {
                _CaptionBgColor = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 设置窗口标题栏背景图片
        /// </summary>
        private Bitmap _CaptionBgImage = null;
        [Category("SUI自定义属性")]
        [Description("设置窗口标题栏背景图片")]
        public Bitmap CaptionBgImage
        {
            get { return this._CaptionBgImage; }
            set
            {
                _CaptionBgImage = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 设置窗口标题栏标题颜色
        /// </summary>
        private Color _CaptionTitleColor = ColorTranslator.FromHtml(SkinSetting.FormStyle_CaptionTitleColor);
        [Category("SUI自定义属性")]
        [Description("设置窗口标题栏标题颜色")]
        public Color CaptionTitleColor
        {
            get { return this._CaptionTitleColor; }
            set
            {
                _CaptionTitleColor = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 设置窗口底部栏高度
        /// </summary>
        private int _BottomHeight = 0;
        [Category("SUI自定义属性")]
        [Description("设置窗口底部栏高度")]
        public int BottomHeight
        {
            get { return this._BottomHeight; }
            set
            {
                _BottomHeight = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 设置窗口底部栏颜色
        /// </summary>
        private Color _BottomBgColor = ColorTranslator.FromHtml(SkinSetting.FormStyle_BottomBgColor);
        [Category("SUI自定义属性")]
        [Description("设置窗口底部栏颜色")]
        public Color BottomBgColor
        {
            get { return this._BottomBgColor; }
            set
            {
                _BottomBgColor = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 是否显示最小化按钮
        /// </summary>
        private bool _MinimizeBox = true;
        [Category("SUI自定义属性")]
        [Description("是否显示最小化按钮")]
        public new bool MinimizeBox
        {
            get { return this._MinimizeBox; }
            set
            {
                _MinimizeBox = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 是否显示最大化按钮
        /// </summary>
        private bool _MaximizeBox = true;
        [Category("SUI自定义属性")]
        [Description("是否显示最大化按钮")]
        public new bool MaximizeBox
        {
            get { return this._MaximizeBox; }
            set
            {
                _MaximizeBox = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 是否显示菜单按钮
        /// </summary>
        private bool _MenuBox = false;
        [Category("SUI自定义属性")]
        [Description("是否显示菜单按钮")]
        public bool MenuBox
        {
            get { return this._MenuBox; }
            set
            {
                _MenuBox = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 是否显示换肤按钮
        /// </summary>
        private bool _SkinBox = false;
        [Category("SUI自定义属性")]
        [Description("是否显示换肤按钮")]
        public bool SkinBox
        {
            get { return this._SkinBox; }
            set
            {
                _SkinBox = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 不显示FormBorderStyle属性
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new FormBorderStyle FormBorderStyle
        {
            get { return base.FormBorderStyle; }
            set { base.FormBorderStyle = FormBorderStyle.None; }
        }
        #endregion

        public BaseForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StBaseForm_Load(object sender, EventArgs e)
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.DoubleBuffer |
                ControlStyles.SupportsTransparentBackColor, true);
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.None;
            BindSystenBtnEvent();
        }

        #region 重写
        /// <summary>
        /// 引发事件时会通过委托调用事件处理程序
        /// </summary>
        /// <param name="e"></param>
        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            SetSystenBtn();
            base.OnInvalidated(e);
        }
        /// <summary>
        /// 重绘事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                //图标及标题绘制开始位置
                int x = 10, y = 5;
                g = e.Graphics;
                g.SmoothingMode = SmoothingMode.HighQuality; //高质量
                g.PixelOffsetMode = PixelOffsetMode.HighQuality; //高像素偏移质量

                #region 标题栏
                //以图片填充标题栏背景
                if (_CaptionBgMode == BackgroundMode.Image && _CaptionBgImage != null)
                {
                    g.FillRectangle(new TextureBrush(_CaptionBgImage), new Rectangle(0, 0, Width-1, _CaptionHeight));
                }
                //以颜色填充标题栏背景
                else
                {
                    using (SolidBrush brush = new SolidBrush(_CaptionBgColor))
                    {
                        g.FillRectangle(brush, new Rectangle(0, 0, Width, _CaptionHeight));
                    }
                }
                //是否显示icon
                if (ShowIcon)
                {
                    g.DrawIcon(Icon, new Rectangle(x, y, 16, 16));
                    x += 20;
                }
                g.DrawString(Text, this.Font, new SolidBrush(_CaptionTitleColor), x, y);
                #endregion

                #region 底部栏
                if (_BottomHeight > 0)
                {
                    using (SolidBrush brush = new SolidBrush(_BottomBgColor))
                    {
                        g.FillRectangle(brush, new Rectangle(0, Height - _BottomHeight, Width, _BottomHeight));
                    }
                }
                #endregion

                #region 绘制边框
                if (_BorderSize > 0)
                {
                    Rectangle borderRect = new Rectangle(0, 0, this.Width, this.Height);
                    ControlPaint.DrawBorder(e.Graphics, borderRect,
                        _BorderColor, 2, ButtonBorderStyle.Solid,
                         _BorderColor, 2, ButtonBorderStyle.Solid,
                          _BorderColor, 2, ButtonBorderStyle.Solid,
                           _BorderColor, 2, ButtonBorderStyle.Solid);//画个边框   
                }
                #endregion
            }
            catch
            { }
        }
        /// <summary>
        /// 消息处理事件
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            try
            {
                switch (m.Msg)
                {
                    // 双击窗体时做相关判断（是否允许最大化或者最小化窗体？）
                    case 0xA3:
                        if (!_MaximizeBox)
                            return;
                        break;
                    //窗体客户区以外的重绘消息,一般是由系统负责处理
                    case Win32.WM_NCPAINT:
                        break;
                    //画窗体被激活或者没有被激活时的样子//http://blog.csdn.net/commandos/archive/2007/11/27/1904558.aspx
                    case Win32.WM_NCACTIVATE:
                        if (m.WParam == (IntPtr)Win32.WM_FALSE)
                        {
                            m.Result = (IntPtr)Win32.WM_TRUE;
                        }
                        break;
                    //在需要计算窗口客户区的大小和位置时发送。通过处理这个消息，应用程序可以在窗口大小或位置改变时控制客户区的内容
                    case Win32.WM_NCCALCSIZE:
                        break;
                    //鼠标移动,按下或释放都会执行该消息
                    case Win32.WM_NCHITTEST:
                        m.Result = (IntPtr)Win32.HTCAPTION;
                        break;
                    default:
                        base.WndProc(ref m);
                        break;
                }
            }
            catch { }
        }
        #endregion

        #region 方法
        /// <summary>
		/// 设置系统按钮位置及可见性
		/// </summary>
		protected void SetSystenBtn()
        {
            btn_Max.Visible = _MaximizeBox;
            btn_Min.Visible = _MinimizeBox;
            btn_Menu.Visible = _MenuBox;
            btn_Skin.Visible = _SkinBox;

            int top = 0;
            btn_Close.Top = top;
            btn_Max.Top = top;
            btn_Min.Top = top;
            btn_Menu.Top = top;
            btn_Skin.Top = top;

            var x = Width;
            //关闭按钮
            x -= btn_Close.Width;
            btn_Close.Left = x;
            //最大化按钮
            if (_MaximizeBox)
            {
                x -= btn_Max.Width;
                btn_Max.Left = x;
            }
            //最小化按钮
            if (_MinimizeBox)
            {
                x -= btn_Min.Width;
                btn_Min.Left = x;
            }
            //菜单按钮
            if (_MenuBox)
            {
                x -= btn_Menu.Width;
                btn_Menu.Left = x;
            }
            //换肤按钮
            if (_SkinBox)
            {
                x -= btn_Skin.Width;
                btn_Skin.Left = x;
            }
        }
        /// <summary>
        /// 绑定系统按钮事件
        /// </summary>
        protected void BindSystenBtnEvent()
        {
            //关闭按钮
            btn_Close.Click += (s, e) =>
            {
                Close();
            };
            //最大化按钮
            btn_Max.Click += (s, e) =>
            {
                this.ShowInTaskbar = true;
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                else
                {
                    this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                    this.WindowState = FormWindowState.Maximized;
                }
            };
            //最小化按钮
            btn_Min.Click += (s, e) =>
            {
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = true;
            };
            //菜单按钮
            btn_Menu.Click += (s, e) =>
            {

            };
            //菜单按钮
            btn_Skin.Click += (s, e) =>
            {

            };
        }
        #endregion
    }
}
