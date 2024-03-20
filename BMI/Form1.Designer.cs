namespace BMI
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
            weightTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            heightTextBox = new TextBox();
            calculateButton = new Button();
            resetButton = new Button();
            label3 = new Label();
            resultTextBox = new TextBox();
            SuspendLayout();
            // 
            // weightTextBox
            // 
            weightTextBox.Location = new Point(85, 6);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(100, 23);
            weightTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "weight (kg)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "height (m)";
            // 
            // heightTextBox
            // 
            heightTextBox.Location = new Point(85, 35);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(100, 23);
            heightTextBox.TabIndex = 2;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(12, 64);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 4;
            calculateButton.Text = "calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(110, 64);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 5;
            resetButton.Text = "reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 7;
            label3.Text = "BMI";
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(85, 93);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(100, 23);
            resultTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(192, 122);
            Controls.Add(label3);
            Controls.Add(resultTextBox);
            Controls.Add(resetButton);
            Controls.Add(calculateButton);
            Controls.Add(label2);
            Controls.Add(heightTextBox);
            Controls.Add(label1);
            Controls.Add(weightTextBox);
            Name = "Form1";
            Text = "BMI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox weightTextBox;
        private Label label1;
        private Label label2;
        private TextBox heightTextBox;
        private Button calculateButton;
        private Button resetButton;
        private Label label3;
        private TextBox resultTextBox;
    }
}
