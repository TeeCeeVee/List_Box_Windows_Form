namespace MyFriendsListApp
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_newFriend = new System.Windows.Forms.TextBox();
            this.btn_add_friend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add_five = new System.Windows.Forms.Button();
            this.btn_ascending = new System.Windows.Forms.Button();
            this.btn_descending = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(42, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 340);
            this.listBox1.TabIndex = 0;
            // 
            // txt_newFriend
            // 
            this.txt_newFriend.Location = new System.Drawing.Point(293, 32);
            this.txt_newFriend.Name = "txt_newFriend";
            this.txt_newFriend.Size = new System.Drawing.Size(302, 22);
            this.txt_newFriend.TabIndex = 1;
            // 
            // btn_add_friend
            // 
            this.btn_add_friend.Location = new System.Drawing.Point(302, 84);
            this.btn_add_friend.Name = "btn_add_friend";
            this.btn_add_friend.Size = new System.Drawing.Size(81, 39);
            this.btn_add_friend.TabIndex = 2;
            this.btn_add_friend.Text = "Add Friend";
            this.btn_add_friend.UseVisualStyleBackColor = true;
            this.btn_add_friend.Click += new System.EventHandler(this.btn_addFriend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "0 friends";
            // 
            // btn_add_five
            // 
            this.btn_add_five.Location = new System.Drawing.Point(302, 144);
            this.btn_add_five.Name = "btn_add_five";
            this.btn_add_five.Size = new System.Drawing.Size(96, 45);
            this.btn_add_five.TabIndex = 4;
            this.btn_add_five.Text = "Add 5 friends";
            this.btn_add_five.UseVisualStyleBackColor = true;
            this.btn_add_five.Click += new System.EventHandler(this.btn_add_five_Click);
            // 
            // btn_ascending
            // 
            this.btn_ascending.Location = new System.Drawing.Point(432, 258);
            this.btn_ascending.Name = "btn_ascending";
            this.btn_ascending.Size = new System.Drawing.Size(75, 23);
            this.btn_ascending.TabIndex = 5;
            this.btn_ascending.Text = "A -> Z";
            this.btn_ascending.UseVisualStyleBackColor = true;
            this.btn_ascending.Click += new System.EventHandler(this.btn_ascending_Click);
            // 
            // btn_descending
            // 
            this.btn_descending.Location = new System.Drawing.Point(555, 258);
            this.btn_descending.Name = "btn_descending";
            this.btn_descending.Size = new System.Drawing.Size(75, 23);
            this.btn_descending.TabIndex = 6;
            this.btn_descending.Text = "Z -> A";
            this.btn_descending.UseVisualStyleBackColor = true;
            this.btn_descending.Click += new System.EventHandler(this.btn_descending_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(677, 257);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_add_friend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_descending);
            this.Controls.Add(this.btn_ascending);
            this.Controls.Add(this.btn_add_five);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add_friend);
            this.Controls.Add(this.txt_newFriend);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "My Friends";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_newFriend;
        private System.Windows.Forms.Button btn_add_friend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_five;
        private System.Windows.Forms.Button btn_ascending;
        private System.Windows.Forms.Button btn_descending;
        private System.Windows.Forms.Button btn_clear;
    }
}

