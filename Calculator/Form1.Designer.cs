namespace Calculator
{
    partial class Form1
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
            this.Result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Subtrack = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Result.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Result.Location = new System.Drawing.Point(0, 0);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(619, 136);
            this.Result.TabIndex = 0;
            this.Result.Text = "0";
            this.Result.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(0, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 97);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickToOne);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(125, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 97);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickToTwo);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(250, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 97);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickToThree);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(0, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 97);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickToFour);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(125, 242);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 97);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickToFive);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(250, 242);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 97);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickToSix);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(0, 139);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 97);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickToSeven);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(125, 139);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(119, 97);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickToEight);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(250, 139);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(119, 97);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickToNine);
            // 
            // Multiplication
            // 
            this.Multiplication.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Multiplication.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Multiplication.Location = new System.Drawing.Point(375, 139);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(119, 97);
            this.Multiplication.TabIndex = 10;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = false;
            this.Multiplication.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickToMultiplication);
            // 
            // Subtrack
            // 
            this.Subtrack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Subtrack.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Subtrack.Location = new System.Drawing.Point(375, 242);
            this.Subtrack.Name = "Subtrack";
            this.Subtrack.Size = new System.Drawing.Size(119, 97);
            this.Subtrack.TabIndex = 11;
            this.Subtrack.Text = "-";
            this.Subtrack.UseVisualStyleBackColor = false;
            this.Subtrack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickToSubtract);
            // 
            // Addition
            // 
            this.Addition.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Addition.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Addition.Location = new System.Drawing.Point(375, 345);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(119, 97);
            this.Addition.TabIndex = 12;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = false;
            this.Addition.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickToAddition);
            // 
            // Backspace
            // 
            this.Backspace.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Backspace.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Backspace.Location = new System.Drawing.Point(500, 242);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(119, 97);
            this.Backspace.TabIndex = 13;
            this.Backspace.Text = "<=";
            this.Backspace.UseVisualStyleBackColor = false;
            this.Backspace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClikToBackSpace);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Divide.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Divide.Location = new System.Drawing.Point(500, 139);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(119, 97);
            this.Divide.TabIndex = 14;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickToDivide);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clear.Location = new System.Drawing.Point(500, 345);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(119, 97);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickToClear);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button0.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button0.Location = new System.Drawing.Point(0, 448);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(244, 97);
            this.button0.TabIndex = 16;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickToZero);
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Equal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Equal.Location = new System.Drawing.Point(250, 446);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(369, 97);
            this.Equal.TabIndex = 17;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = false;
            this.Equal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClikToEqual);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 546);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Subtrack);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Result);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private Label Result;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button Multiplication;
        private Button Subtrack;
        private Button Addition;
        private Button Backspace;
        private Button Divide;
        private Button Clear;
        private Button button0;
        private Button Equal;
    }
}