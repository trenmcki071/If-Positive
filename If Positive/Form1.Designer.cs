
namespace If_Positive
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
            this.integerLabel = new System.Windows.Forms.Label();
            this.inputNumberBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.positiveLabel = new System.Windows.Forms.Label();
            this.divisibleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // integerLabel
            // 
            this.integerLabel.Location = new System.Drawing.Point(37, 36);
            this.integerLabel.Name = "integerLabel";
            this.integerLabel.Size = new System.Drawing.Size(100, 27);
            this.integerLabel.TabIndex = 0;
            this.integerLabel.Text = "Input an integer";
            // 
            // inputNumberBox
            // 
            this.inputNumberBox.Location = new System.Drawing.Point(156, 33);
            this.inputNumberBox.Name = "inputNumberBox";
            this.inputNumberBox.Size = new System.Drawing.Size(66, 20);
            this.inputNumberBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // positiveLabel
            // 
            this.positiveLabel.AutoSize = true;
            this.positiveLabel.Location = new System.Drawing.Point(37, 137);
            this.positiveLabel.Name = "positiveLabel";
            this.positiveLabel.Size = new System.Drawing.Size(121, 13);
            this.positiveLabel.TabIndex = 3;
            this.positiveLabel.Text = "__ is an ______ number";
            // 
            // divisibleLabel
            // 
            this.divisibleLabel.AutoSize = true;
            this.divisibleLabel.Location = new System.Drawing.Point(37, 184);
            this.divisibleLabel.Name = "divisibleLabel";
            this.divisibleLabel.Size = new System.Drawing.Size(91, 13);
            this.divisibleLabel.TabIndex = 4;
            this.divisibleLabel.Text = "__ is ______ by 7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 229);
            this.Controls.Add(this.divisibleLabel);
            this.Controls.Add(this.positiveLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputNumberBox);
            this.Controls.Add(this.integerLabel);
            this.Name = "Form1";
            this.Text = "Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label integerLabel;
        private System.Windows.Forms.TextBox inputNumberBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label positiveLabel;
        private System.Windows.Forms.Label divisibleLabel;
    }
}

