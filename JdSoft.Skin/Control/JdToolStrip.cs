using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace JdSoft.Skin.MyControl
{
    public class MyToolStrip : ToolStrip
    {
        public MyToolStrip()
        {
            this.Renderer = new ToolStripRenderer();
        }
    }
}
