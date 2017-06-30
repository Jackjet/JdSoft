using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using JdSoft.Skin.Class;

namespace JdSoft.Skin.MyControl
{
    public class ToolStripRenderer : System.Windows.Forms.ToolStripRenderer
    {
        private int i;
        Bitmap backImg = Properties.Resources.toolstrip; //ImageObject.GetResBitmap("AlSkin.AlControl.AlToolStrip.Toolstrip.png");

        public ToolStripRenderer()
        {
        }

        protected override void InitializeItem(ToolStripItem item)
        {
            base.InitializeItem(item);
            item.AutoSize = false;
            item.Padding = new Padding(5);
            item.Margin = new Padding(0, 0, 0, 1);
            if (item is ToolStripButton)
            {
                ToolStripButton btn = item as ToolStripButton;
                //item.Width =30;
            }           
            
        }

        #region //绘制按钮
        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            bool chk = false;
            chk = (e.Item as ToolStripButton).Checked;
            if (e.Item.Pressed && e.Item.Selected)
            {
                i = 2;
            }
            else if (e.Item.Selected)
            {
                i = 1;
            }
            else if (chk)
            {
                i = 2;
            }
            else
            { i = 0; }
            DrawRectUtil.DrawRect(e.Graphics, backImg, new Rectangle(Point.Empty, e.Item.Size), Rectangle.FromLTRB(5, 15, 5, 5), i, 2);
        }
        #endregion 
    }
}
