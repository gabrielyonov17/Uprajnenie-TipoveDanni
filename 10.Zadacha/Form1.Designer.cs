namespace _10.Zadacha
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
            lblNumber = new Label();
            lblResult = new Label();
            btnCheck = new Button();
            txtNumber = new TextBox();
            SuspendLayout();
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Segoe UI", 13.8F);
            lblNumber.Location = new Point(217, 104);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(83, 31);
            lblNumber.TabIndex = 0;
            lblNumber.Text = "Число:";
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
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI", 13.8F);
            btnCheck.Location = new Point(301, 241);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(216, 88);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "Провери";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // txtNumber
            // 
            txtNumber.Font = new Font("Segoe UI", 13.8F);
            txtNumber.Location = new Point(301, 101);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(230, 38);
            txtNumber.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumber);
            Controls.Add(btnCheck);
            Controls.Add(lblResult);
            Controls.Add(lblNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumber;
        private Label lblResult;
        private Button btnCheck;
        private TextBox txtNumber;
    }
}
