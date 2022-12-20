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
            this.myButton2 = new Simple_CalculatorV2.MyButton();
            this.myButton3 = new Simple_CalculatorV2.MyButton();
            this.myButton4 = new Simple_CalculatorV2.MyButton();
            this.round1 = new Simple_CalculatorV2.round();
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
            this.myButton1.Size = new System.Drawing.Size(215, 69);
            this.myButton1.TabIndex = 0;
            this.myButton1.Text = "Add";
            this.myButton1.TextColor = System.Drawing.Color.White;
            this.myButton1.UseVisualStyleBackColor = false;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click_1);
            // 
            // myButton2
            // 
            this.myButton2.BackColor = System.Drawing.Color.MediumPurple;
            this.myButton2.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.myButton2.BorderColor = System.Drawing.Color.Black;
            this.myButton2.BorderRadius = 40;
            this.myButton2.BorderSize = 1;
            this.myButton2.FlatAppearance.BorderSize = 0;
            this.myButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton2.ForeColor = System.Drawing.Color.White;
            this.myButton2.Location = new System.Drawing.Point(13, 90);
            this.myButton2.Margin = new System.Windows.Forms.Padding(4);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(215, 69);
            this.myButton2.TabIndex = 1;
            this.myButton2.Text = "Substract";
            this.myButton2.TextColor = System.Drawing.Color.White;
            this.myButton2.UseVisualStyleBackColor = false;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // myButton3
            // 
            this.myButton3.BackColor = System.Drawing.Color.MediumPurple;
            this.myButton3.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.myButton3.BorderColor = System.Drawing.Color.Black;
            this.myButton3.BorderRadius = 40;
            this.myButton3.BorderSize = 1;
            this.myButton3.FlatAppearance.BorderSize = 0;
            this.myButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton3.ForeColor = System.Drawing.Color.White;
            this.myButton3.Location = new System.Drawing.Point(13, 167);
            this.myButton3.Margin = new System.Windows.Forms.Padding(4);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(215, 69);
            this.myButton3.TabIndex = 2;
            this.myButton3.Text = "Divide";
            this.myButton3.TextColor = System.Drawing.Color.White;
            this.myButton3.UseVisualStyleBackColor = false;
            // 
            // myButton4
            // 
            this.myButton4.BackColor = System.Drawing.Color.MediumPurple;
            this.myButton4.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.myButton4.BorderColor = System.Drawing.Color.Black;
            this.myButton4.BorderRadius = 40;
            this.myButton4.BorderSize = 1;
            this.myButton4.FlatAppearance.BorderSize = 0;
            this.myButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton4.ForeColor = System.Drawing.Color.White;
            this.myButton4.Location = new System.Drawing.Point(13, 244);
            this.myButton4.Margin = new System.Windows.Forms.Padding(4);
            this.myButton4.Name = "myButton4";
            this.myButton4.Size = new System.Drawing.Size(215, 69);
            this.myButton4.TabIndex = 3;
            this.myButton4.Text = "Multiply";
            this.myButton4.TextColor = System.Drawing.Color.White;
            this.myButton4.UseVisualStyleBackColor = false;
            // 
            // round1
            // 
            this.round1.BackColor = System.Drawing.Color.MediumPurple;
            this.round1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.round1.Location = new System.Drawing.Point(309, 20);
            this.round1.Multiline = true;
            this.round1.Name = "round1";
            this.round1.Size = new System.Drawing.Size(472, 62);
            this.round1.TabIndex = 4;
            this.round1.TextChanged += new System.EventHandler(this.round1_TextChanged);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(868, 488);
            this.Controls.Add(this.round1);
            this.Controls.Add(this.myButton4);
            this.Controls.Add(this.myButton3);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton1);
            this.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form1";
            this.Text = "Calculator V2";
            this.Load += new System.EventHandler(this.form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyButton myButton1;
        private MyButton myButton2;
        private MyButton myButton3;
        private MyButton myButton4;
        private round round1;
    }
}