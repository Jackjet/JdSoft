namespace JdSoft.Skin
{
    partial class MsgBox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox));
            this.pb_Icon = new System.Windows.Forms.PictureBox();
            this.label_Msg = new System.Windows.Forms.Label();
            this.imageList_Icon = new System.Windows.Forms.ImageList(this.components);
            this.btn_Ok = new JdSoft.Skin.MyControl.MyButton();
            this.btn_Cancel = new JdSoft.Skin.MyControl.MyButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Icon
            // 
            this.pb_Icon.Location = new System.Drawing.Point(23, 48);
            this.pb_Icon.Name = "pb_Icon";
            this.pb_Icon.Size = new System.Drawing.Size(32, 32);
            this.pb_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Icon.TabIndex = 7;
            this.pb_Icon.TabStop = false;
            // 
            // label_Msg
            // 
            this.label_Msg.AutoSize = true;
            this.label_Msg.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Msg.Location = new System.Drawing.Point(64, 54);
            this.label_Msg.Name = "label_Msg";
            this.label_Msg.Size = new System.Drawing.Size(50, 20);
            this.label_Msg.TabIndex = 8;
            this.label_Msg.Text = "label1";
            // 
            // imageList_Icon
            // 
            this.imageList_Icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Icon.ImageStream")));
            this.imageList_Icon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Icon.Images.SetKeyName(0, "msgbox_success.png");
            this.imageList_Icon.Images.SetKeyName(1, "msgbox_info.png");
            this.imageList_Icon.Images.SetKeyName(2, "msgbox_warning.png");
            this.imageList_Icon.Images.SetKeyName(3, "msgbox_error.png");
            this.imageList_Icon.Images.SetKeyName(4, "msgbox_question.png");
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(179)))), ((int)(((byte)(148)))));
            this.btn_Ok.ForeColor = System.Drawing.Color.White;
            this.btn_Ok.HoverBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.btn_Ok.Location = new System.Drawing.Point(104, 128);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.NormalBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(179)))), ((int)(((byte)(148)))));
            this.btn_Ok.Size = new System.Drawing.Size(80, 30);
            this.btn_Ok.TabIndex = 9;
            this.btn_Ok.Text = "确定";
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.HoverBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_Cancel.Location = new System.Drawing.Point(194, 128);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.NormalBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btn_Cancel.Size = new System.Drawing.Size(80, 30);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.pictureBox1.Location = new System.Drawing.Point(10, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 1);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 172);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.pb_Icon);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.label_Msg);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MsgBox";
            this.Text = "MsgBox";
            this.Load += new System.EventHandler(this.MsgBox_Load);
            this.Controls.SetChildIndex(this.label_Msg, 0);
            this.Controls.SetChildIndex(this.btn_Ok, 0);
            this.Controls.SetChildIndex(this.pb_Icon, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Icon;
        private System.Windows.Forms.Label label_Msg;
        private System.Windows.Forms.ImageList imageList_Icon;
        private MyControl.MyButton btn_Ok;
        private MyControl.MyButton btn_Cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}