namespace _11.Zadacha
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
            lblInput = new Label();
            lblResult = new Label();
            txtInput = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Segoe UI", 13.8F);
            lblInput.Location = new Point(220, 122);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(164, 31);
            lblInput.TabIndex = 0;
            lblInput.Text = "Въведи число:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 13.8F);
            lblResult.Location = new Point(12, 410);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 31);
            lblResult.TabIndex = 1;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 13.8F);
            txtInput.Location = new Point(380, 119);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(209, 38);
            txtInput.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 13.8F);
            btnCalculate.Location = new Point(304, 261);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(238, 79);
            btnCalculate.TabIndex = 3;
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
            Controls.Add(txtInput);
            Controls.Add(lblResult);
            Controls.Add(lblInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInput;
        private Label lblResult;
        private TextBox txtInput;
        private Button btnCalculate;
    }
}
