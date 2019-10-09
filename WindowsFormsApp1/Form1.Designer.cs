namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.uxInputBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uxInfix = new System.Windows.Forms.Button();
            this.uxPostFix = new System.Windows.Forms.Button();
            this.uxPrefix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxInputBox
            // 
            this.uxInputBox.Location = new System.Drawing.Point(12, 29);
            this.uxInputBox.Name = "uxInputBox";
            this.uxInputBox.Size = new System.Drawing.Size(666, 20);
            this.uxInputBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // uxInfix
            // 
            this.uxInfix.Location = new System.Drawing.Point(696, 33);
            this.uxInfix.Name = "uxInfix";
            this.uxInfix.Size = new System.Drawing.Size(70, 27);
            this.uxInfix.TabIndex = 2;
            this.uxInfix.Text = "Infix";
            this.uxInfix.UseVisualStyleBackColor = true;
            this.uxInfix.Click += new System.EventHandler(this.uxInfix_Click);
            // 
            // uxPostFix
            // 
            this.uxPostFix.Location = new System.Drawing.Point(696, 66);
            this.uxPostFix.Name = "uxPostFix";
            this.uxPostFix.Size = new System.Drawing.Size(70, 27);
            this.uxPostFix.TabIndex = 3;
            this.uxPostFix.Text = "PostFix";
            this.uxPostFix.UseVisualStyleBackColor = true;
            this.uxPostFix.Click += new System.EventHandler(this.uxPostFix_Click);
            // 
            // uxPrefix
            // 
            this.uxPrefix.Location = new System.Drawing.Point(696, 99);
            this.uxPrefix.Name = "uxPrefix";
            this.uxPrefix.Size = new System.Drawing.Size(70, 27);
            this.uxPrefix.TabIndex = 4;
            this.uxPrefix.Text = "Prefix";
            this.uxPrefix.UseVisualStyleBackColor = true;
            this.uxPrefix.Click += new System.EventHandler(this.uxPrefix_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxPrefix);
            this.Controls.Add(this.uxPostFix);
            this.Controls.Add(this.uxInfix);
            this.Controls.Add(this.uxInputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxInputBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button uxInfix;
        private System.Windows.Forms.Button uxPostFix;
        private System.Windows.Forms.Button uxPrefix;
    }
}

