namespace _3.Zadacha
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
            lblAge = new Label();
            lblResult = new Label();
            btnCheck = new Button();
            txtAge = new TextBox();
            SuspendLayout();
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 13.8F);
            lblAge.Location = new Point(215, 81);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(102, 31);
            lblAge.TabIndex = 0;
            lblAge.Text = "Възраст:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 13.8F);
            lblResult.Location = new Point(323, 140);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 31);
            lblResult.TabIndex = 1;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI", 13.8F);
            btnCheck.Location = new Point(323, 244);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(172, 77);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "Провери";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 13.8F);
            txtAge.Location = new Point(323, 81);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(243, 38);
            txtAge.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAge);
            Controls.Add(btnCheck);
            Controls.Add(lblResult);
            Controls.Add(lblAge);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAge;
        private Label lblResult;
        private Button btnCheck;
        private TextBox txtAge;
    }
}
