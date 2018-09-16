namespace Client
{
    partial class Form1
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
            this.lnk_getFriendList = new System.Windows.Forms.LinkLabel();
            this.lnk_setNearFriends = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lnk_getFriendList
            // 
            this.lnk_getFriendList.AutoSize = true;
            this.lnk_getFriendList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_getFriendList.Location = new System.Drawing.Point(13, 13);
            this.lnk_getFriendList.Name = "lnk_getFriendList";
            this.lnk_getFriendList.Size = new System.Drawing.Size(101, 17);
            this.lnk_getFriendList.TabIndex = 1;
            this.lnk_getFriendList.TabStop = true;
            this.lnk_getFriendList.Text = "Get Friend List";
            this.lnk_getFriendList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_getFriendList_LinkClicked);
            // 
            // lnk_setNearFriends
            // 
            this.lnk_setNearFriends.AutoSize = true;
            this.lnk_setNearFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_setNearFriends.Location = new System.Drawing.Point(13, 51);
            this.lnk_setNearFriends.Name = "lnk_setNearFriends";
            this.lnk_setNearFriends.Size = new System.Drawing.Size(115, 17);
            this.lnk_setNearFriends.TabIndex = 5;
            this.lnk_setNearFriends.TabStop = true;
            this.lnk_setNearFriends.Text = "Set Near Friends";
            this.lnk_setNearFriends.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_setNearFriends_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(169, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 550);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lnk_setNearFriends);
            this.Controls.Add(this.lnk_getFriendList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lnk_getFriendList;
        private System.Windows.Forms.LinkLabel lnk_setNearFriends;
        private System.Windows.Forms.Panel panel1;
    }
}

