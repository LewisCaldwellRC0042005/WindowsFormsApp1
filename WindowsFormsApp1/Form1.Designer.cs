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
            this.Hello = new System.Windows.Forms.Button();
            this.txtbxname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Hello
            // 
            this.Hello.Location = new System.Drawing.Point(398, 206);
            this.Hello.Name = "Hello";
            this.Hello.Size = new System.Drawing.Size(66, 23);
            this.Hello.TabIndex = 0;
            this.Hello.Text = "button1";
            this.Hello.UseVisualStyleBackColor = true;
            this.Hello.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtbxname
            // 
            this.txtbxname.Location = new System.Drawing.Point(556, 58);
            this.txtbxname.Name = "txtbxname";
            this.txtbxname.Size = new System.Drawing.Size(66, 20);
            this.txtbxname.TabIndex = 1;
            this.txtbxname.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbxname);
            this.Controls.Add(this.Hello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hello;
        private System.Windows.Forms.TextBox txtbxname;
    }
}

