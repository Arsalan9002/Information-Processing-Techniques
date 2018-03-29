namespace Assignment5
{
    partial class Assignment5Form
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
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.threadChoiceCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.matrixSizeCombo = new System.Windows.Forms.ComboBox();
            this.timeTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.matrixMultiplyButton = new System.Windows.Forms.Button();
            this.threadBox = new System.Windows.Forms.ListBox();
            this.timeBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // typeCombo
            // 
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Items.AddRange(new object[] {
            "Double",
            "Integer",
            "Decimal"});
            this.typeCombo.Location = new System.Drawing.Point(139, 35);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(121, 21);
            this.typeCombo.TabIndex = 2;
            // 
            // threadChoiceCombo
            // 
            this.threadChoiceCombo.FormattingEnabled = true;
            this.threadChoiceCombo.Items.AddRange(new object[] {
            "Use Single Thread",
            "Use 10 Threads",
            "Use TPL"});
            this.threadChoiceCombo.Location = new System.Drawing.Point(139, 92);
            this.threadChoiceCombo.Name = "threadChoiceCombo";
            this.threadChoiceCombo.Size = new System.Drawing.Size(121, 21);
            this.threadChoiceCombo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose DataType :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose Technique :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose MatrixSize";
            // 
            // matrixSizeCombo
            // 
            this.matrixSizeCombo.FormattingEnabled = true;
            this.matrixSizeCombo.Items.AddRange(new object[] {
            "100 by 100",
            "500 by 500",
            "1000 by 1000"});
            this.matrixSizeCombo.Location = new System.Drawing.Point(139, 153);
            this.matrixSizeCombo.Name = "matrixSizeCombo";
            this.matrixSizeCombo.Size = new System.Drawing.Size(121, 21);
            this.matrixSizeCombo.TabIndex = 7;
            // 
            // timeTxtBox
            // 
            this.timeTxtBox.Location = new System.Drawing.Point(363, 452);
            this.timeTxtBox.Name = "timeTxtBox";
            this.timeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.timeTxtBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Average Time :";
            // 
            // matrixMultiplyButton
            // 
            this.matrixMultiplyButton.Location = new System.Drawing.Point(137, 222);
            this.matrixMultiplyButton.Name = "matrixMultiplyButton";
            this.matrixMultiplyButton.Size = new System.Drawing.Size(123, 49);
            this.matrixMultiplyButton.TabIndex = 10;
            this.matrixMultiplyButton.Text = "Multply Matrix";
            this.matrixMultiplyButton.UseVisualStyleBackColor = true;
            this.matrixMultiplyButton.Click += new System.EventHandler(this.matrixMultiplyButton_Click);
            // 
            // threadBox
            // 
            this.threadBox.FormattingEnabled = true;
            this.threadBox.Location = new System.Drawing.Point(353, 35);
            this.threadBox.Name = "threadBox";
            this.threadBox.Size = new System.Drawing.Size(243, 173);
            this.threadBox.TabIndex = 11;
            // 
            // timeBox
            // 
            this.timeBox.FormattingEnabled = true;
            this.timeBox.Location = new System.Drawing.Point(353, 267);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(243, 121);
            this.timeBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Iterations :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Time:";
            // 
            // Assignment5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 505);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.threadBox);
            this.Controls.Add(this.matrixMultiplyButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeTxtBox);
            this.Controls.Add(this.matrixSizeCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.threadChoiceCombo);
            this.Controls.Add(this.typeCombo);
            this.Name = "Assignment5Form";
            this.Text = "Assignment5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.ComboBox threadChoiceCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox matrixSizeCombo;
        private System.Windows.Forms.TextBox timeTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button matrixMultiplyButton;
        private System.Windows.Forms.ListBox threadBox;
        private System.Windows.Forms.ListBox timeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

