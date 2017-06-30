using JdSoft.Skin;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace JdSoft.Client
{
    public class MsgHelper
    {
        public static DialogResult Show(string title,string msg,MsgBoxType type)
        {
            MsgBox msgBox = new MsgBox(title, msg, type);
            return msgBox.ShowDialog();
        }
    }
}
