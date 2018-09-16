namespace Client
{
    partial class FriendsList
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
            this.dgv_nearFriends = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_friends = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nearFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_friends)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_nearFriends
            // 
            this.dgv_nearFriends.AllowUserToAddRows = false;
            this.dgv_nearFriends.AllowUserToDeleteRows = false;
            this.dgv_nearFriends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nearFriends.Location = new System.Drawing.Point(6, 395);
            this.dgv_nearFriends.Name = "dgv_nearFriends";
            this.dgv_nearFriends.ReadOnly = true;
            this.dgv_nearFriends.RowHeadersVisible = false;
            this.dgv_nearFriends.Size = new System.Drawing.Size(621, 152);
            this.dgv_nearFriends.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Friend List";
            // 
            // dgv_friends
            // 
            this.dgv_friends.AllowUserToAddRows = false;
            this.dgv_friends.AllowUserToDeleteRows = false;
            this.dgv_friends.AllowUserToResizeColumns = false;
            this.dgv_friends.AllowUserToResizeRows = false;
            this.dgv_friends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_friends.Location = new System.Drawing.Point(6, 21);
            this.dgv_friends.MultiSelect = false;
            this.dgv_friends.Name = "dgv_friends";
            this.dgv_friends.ReadOnly = true;
            this.dgv_friends.RowHeadersVisible = false;
            this.dgv_friends.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_friends.Size = new System.Drawing.Size(621, 355);
            this.dgv_friends.TabIndex = 5;
            this.dgv_friends.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_friends_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Near Friends";
            // 
            // FriendsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_nearFriends);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_friends);
            this.Name = "FriendsList";
            this.Size = new System.Drawing.Size(630, 550);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nearFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_friends)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_nearFriends;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_friends;
        private System.Windows.Forms.Label label2;
    }
}
