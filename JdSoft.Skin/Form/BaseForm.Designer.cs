
namespace JdSoft.Skin
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Skin = new JdSoft.Skin.MyControl.MyButton();
            this.btn_Menu = new JdSoft.Skin.MyControl.MyButton();
            this.btn_Min = new JdSoft.Skin.MyControl.MyButton();
            this.btn_Max = new JdSoft.Skin.MyControl.MyButton();
            this.btn_Close = new JdSoft.Skin.MyControl.MyButton();
            this.SuspendLayout();
            // 
            // btn_Skin
            // 
            this.btn_Skin.BackColor = System.Drawing.Color.Transparent;
            this.btn_Skin.BackgroundImage = global::JdSoft.Skin.Properties.Resources.sysbtn_skin;
            this.btn_Skin.ForeColor = System.Drawing.Color.White;
            this.btn_Skin.HoverBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Skin.Location = new System.Drawing.Point(197, 1);
            this.btn_Skin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Skin.Name = "btn_Skin";
            this.btn_Skin.NormalBgColor = System.Drawing.Color.Transparent;
            this.btn_Skin.Size = new System.Drawing.Size(30, 28);
            this.btn_Skin.TabIndex = 6;
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_Menu.BackgroundImage = global::JdSoft.Skin.Properties.Resources.sysbtn_menu;
            this.btn_Menu.ForeColor = System.Drawing.Color.White;
            this.btn_Menu.HoverBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Menu.Location = new System.Drawing.Point(229, 1);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.NormalBgColor = System.Drawing.Color.Transparent;
            this.btn_Menu.Size = new System.Drawing.Size(30, 28);
            this.btn_Menu.TabIndex = 5;
            // 
            // btn_Min
            // 
            this.btn_Min.BackColor = System.Drawing.Color.Transparent;
            this.btn_Min.BackgroundImage = global::JdSoft.Skin.Properties.Resources.sysbtn_min;
            this.btn_Min.ForeColor = System.Drawing.Color.White;
            this.btn_Min.HoverBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Min.Location = new System.Drawing.Point(259, 1);
            this.btn_Min.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.NormalBgColor = System.Drawing.Color.Transparent;
            this.btn_Min.Size = new System.Drawing.Size(30, 28);
            this.btn_Min.TabIndex = 2;
            // 
            // btn_Max
            // 
            this.btn_Max.BackColor = System.Drawing.Color.Transparent;
            this.btn_Max.BackgroundImage = global::JdSoft.Skin.Properties.Resources.sysbtn_max;
            this.btn_Max.ForeColor = System.Drawing.Color.White;
            this.btn_Max.HoverBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Max.Location = new System.Drawing.Point(289, 1);
            this.btn_Max.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.NormalBgColor = System.Drawing.Color.Transparent;
            this.btn_Max.Size = new System.Drawing.Size(30, 28);
            this.btn_Max.TabIndex = 3;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImage = global::JdSoft.Skin.Properties.Resources.sysbtn_close;
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.HoverBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(54)))), ((int)(((byte)(16)))));
            this.btn_Close.Location = new System.Drawing.Point(319, 1);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.NormalBgColor = System.Drawing.Color.Transparent;
            this.btn_Close.Size = new System.Drawing.Size(30, 28);
            this.btn_Close.TabIndex = 4;
            // 
            // StBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.btn_Skin);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.btn_Min);
            this.Controls.Add(this.btn_Max);
            this.Controls.Add(this.btn_Close);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StBaseForm";
            this.Text = "StBaseForm";
            this.Load += new System.EventHandler(this.StBaseForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyControl.MyButton btn_Min;
        private MyControl.MyButton btn_Max;
        private MyControl.MyButton btn_Close;
        private MyControl.MyButton btn_Menu;
        private MyControl.MyButton btn_Skin;
    }
}