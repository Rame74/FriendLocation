namespace Client
{
    partial class NearFriends
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_friend = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_friends = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_friend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_friends)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Friend";
            // 
            // dgv_friend
            // 
            this.dgv_friend.AllowUserToAddRows = false;
            this.dgv_friend.AllowUserToDeleteRows = false;
            this.dgv_friend.AllowUserToResizeColumns = false;
            this.dgv_friend.AllowUserToResizeRows = false;
            this.dgv_friend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_friend.Location = new System.Drawing.Point(3, 20);
            this.dgv_friend.MultiSelect = false;
            this.dgv_friend.Name = "dgv_friend";
            this.dgv_friend.ReadOnly = true;
            this.dgv_friend.RowHeadersVisible = false;
            this.dgv_friend.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_friend.Size = new System.Drawing.Size(624, 207);
            this.dgv_friend.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select 3 Near Friends";
            // 
            // dgv_friends
            // 
            this.dgv_friends.AllowUserToAddRows = false;
            this.dgv_friends.AllowUserToDeleteRows = false;
            this.dgv_friends.AllowUserToResizeColumns = false;
            this.dgv_friends.AllowUserToResizeRows = false;
            this.dgv_friends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_friends.Location = new System.Drawing.Point(3, 246);
            this.dgv_friends.Name = "dgv_friends";
            this.dgv_friends.ReadOnly = true;
            this.dgv_friends.RowHeadersVisible = false;
            this.dgv_friends.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_friends.Size = new System.Drawing.Size(624, 272);
            this.dgv_friends.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(552, 524);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // NearFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_friends);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_friend);
            this.Controls.Add(this.label1);
            this.Name = "NearFriends";
            this.Size = new System.Drawing.Size(630, 550);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_friend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_friends)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_friend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_friends;
        private System.Windows.Forms.Button btn_save;
    }
}
