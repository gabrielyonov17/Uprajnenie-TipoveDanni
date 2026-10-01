namespace _5.Zadacha
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
            lblLength = new Label();
            lblWidth = new Label();
            lblArea = new Label();
            txtLength = new TextBox();
            txtWidth = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Font = new Font("Segoe UI", 16.2F);
            lblLength.Location = new Point(132, 66);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(141, 38);
            lblLength.TabIndex = 0;
            lblLength.Text = "Дължина:";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Font = new Font("Segoe UI", 16.2F);
            lblWidth.Location = new Point(132, 135);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(128, 38);
            lblWidth.TabIndex = 1;
            lblWidth.Text = "Ширина:";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Segoe UI", 16.2F);
            lblArea.Location = new Point(333, 234);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(0, 38);
            lblArea.TabIndex = 2;
            // 
            // txtLength
            // 
            txtLength.Font = new Font("Segoe UI", 16.2F);
            txtLength.Location = new Point(296, 61);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(297, 43);
            txtLength.TabIndex = 3;
            // 
            // txtWidth
            // 
            txtWidth.Font = new Font("Segoe UI", 16.2F);
            txtWidth.Location = new Point(296, 130);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(297, 43);
            txtWidth.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 16.2F);
            btnCalculate.Location = new Point(261, 316);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(271, 96);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Изчисли";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(txtWidth);
            Controls.Add(txtLength);
            Controls.Add(lblArea);
            Controls.Add(lblWidth);
            Controls.Add(lblLength);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLength;
        private Label lblWidth;
        private Label lblArea;
        private TextBox txtLength;
        private TextBox txtWidth;
        private Button btnCalculate;
    }
}
