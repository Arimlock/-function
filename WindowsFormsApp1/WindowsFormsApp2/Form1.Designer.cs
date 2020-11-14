namespace WindowsFormsApp2
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
            this.readC = new System.Windows.Forms.TextBox();
            this.readB = new System.Windows.Forms.TextBox();
            this.readA = new System.Windows.Forms.TextBox();
            this.writeX = new System.Windows.Forms.RichTextBox();
            this.count = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readC
            // 
            this.readC.Location = new System.Drawing.Point(255, 13);
            this.readC.Name = "readC";
            this.readC.Size = new System.Drawing.Size(100, 20);
            this.readC.TabIndex = 9;
            // 
            // readB
            // 
            this.readB.Location = new System.Drawing.Point(135, 13);
            this.readB.Name = "readB";
            this.readB.Size = new System.Drawing.Size(100, 20);
            this.readB.TabIndex = 8;
            // 
            // readA
            // 
            this.readA.Location = new System.Drawing.Point(12, 13);
            this.readA.Name = "readA";
            this.readA.Size = new System.Drawing.Size(100, 20);
            this.readA.TabIndex = 7;
            // 
            // writeX
            // 
            this.writeX.Location = new System.Drawing.Point(12, 86);
            this.writeX.Name = "writeX";
            this.writeX.Size = new System.Drawing.Size(223, 69);
            this.writeX.TabIndex = 6;
            this.writeX.Text = "";
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(280, 86);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(75, 69);
            this.count.TabIndex = 5;
            this.count.Text = "Рассчитать";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 204);
            this.Controls.Add(this.readC);
            this.Controls.Add(this.readB);
            this.Controls.Add(this.readA);
            this.Controls.Add(this.writeX);
            this.Controls.Add(this.count);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox readC;
        private System.Windows.Forms.TextBox readB;
        private System.Windows.Forms.TextBox readA;
        private System.Windows.Forms.RichTextBox writeX;
        private System.Windows.Forms.Button count;
    }
}

