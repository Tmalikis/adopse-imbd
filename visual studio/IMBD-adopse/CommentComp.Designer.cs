﻿
namespace IMBD_adopse
{
    partial class CommentComp
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
            this.num = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.commtext = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Location = new System.Drawing.Point(0, 27);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(16, 15);
            this.num.TabIndex = 0;
            this.num.Text = "1.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comment";
            // 
            // commtext
            // 
            this.commtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commtext.Location = new System.Drawing.Point(16, 27);
            this.commtext.Name = "commtext";
            this.commtext.ReadOnly = true;
            this.commtext.Size = new System.Drawing.Size(246, 47);
            this.commtext.TabIndex = 2;
            this.commtext.Text = "";
            // 
            // CommentComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.commtext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num);
            this.Name = "CommentComp";
            this.Size = new System.Drawing.Size(269, 81);
            this.Load += new System.EventHandler(this.comment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox commtext;
    }
}