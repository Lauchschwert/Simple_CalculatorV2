namespace Simple_CalculatorV2
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myButton1 = new Simple_CalculatorV2.MyButton();
            this.SuspendLayout();
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.MediumPurple;
            this.myButton1.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.myButton1.BorderColor = System.Drawing.Color.Black;
            this.myButton1.BorderRadius = 40;
            this.myButton1.BorderSize = 1;
            this.myButton1.FlatAppearance.BorderSize = 0;
            this.myButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton1.ForeColor = System.Drawing.Color.White;
            this.myButton1.Location = new System.Drawing.Point(13, 13);
            this.myButton1.Margin = new System.Windows.Forms.Padding(4);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(193, 57);
            this.myButton1.TabIndex = 0;
            this.myButton1.Text = "myButton1";
            this.myButton1.TextColor = System.Drawing.Color.White;
            this.myButton1.UseVisualStyleBackColor = false;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1171, 850);
            this.Controls.Add(this.myButton1);
            this.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form1";
            this.Text = "Calculator V2";
            this.Load += new System.EventHandler(this.form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyButton myButton1;
    }
}