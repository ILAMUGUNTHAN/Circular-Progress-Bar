namespace Circle_Progress_Bar
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
            this.IncBtn = new System.Windows.Forms.Button();
            this.decBtn = new System.Windows.Forms.Button();
            this.circleProgressBar1 = new Circle_Progress_Bar.CircleProgressBar();
            this.SuspendLayout();
            // 
            // IncBtn
            // 
            this.IncBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncBtn.Location = new System.Drawing.Point(396, 270);
            this.IncBtn.Name = "IncBtn";
            this.IncBtn.Size = new System.Drawing.Size(102, 60);
            this.IncBtn.TabIndex = 1;
            this.IncBtn.Text = "+";
            this.IncBtn.UseVisualStyleBackColor = true;
            this.IncBtn.Click += new System.EventHandler(this.OnClickInc);
            // 
            // decBtn
            // 
            this.decBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decBtn.Location = new System.Drawing.Point(203, 270);
            this.decBtn.Name = "decBtn";
            this.decBtn.Size = new System.Drawing.Size(102, 60);
            this.decBtn.TabIndex = 1;
            this.decBtn.Text = "-";
            this.decBtn.UseVisualStyleBackColor = true;
            this.decBtn.Click += new System.EventHandler(this.OnclickDec);
            // 
            // circleProgressBar1
            // 
            this.circleProgressBar1.Location = new System.Drawing.Point(284, 101);
            this.circleProgressBar1.Name = "circleProgressBar1";
            this.circleProgressBar1.Size = new System.Drawing.Size(150, 150);
            this.circleProgressBar1.TabIndex = 0;
            this.circleProgressBar1.Text = "circleProgressBar1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.decBtn);
            this.Controls.Add(this.IncBtn);
            this.Controls.Add(this.circleProgressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CircleProgressBar circleProgressBar1;
        private System.Windows.Forms.Button IncBtn;
        private System.Windows.Forms.Button decBtn;
    }
}

