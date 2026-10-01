namespace _8.Zadacha
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
            lblGrade1 = new Label();
            lblGrade2 = new Label();
            lblGrade3 = new Label();
            lblResult = new Label();
            txtGrade1 = new TextBox();
            txtGrade2 = new TextBox();
            txtGrade3 = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // lblGrade1
            // 
            lblGrade1.AutoSize = true;
            lblGrade1.Font = new Font("Segoe UI", 13.8F);
            lblGrade1.Location = new Point(163, 66);
            lblGrade1.Name = "lblGrade1";
            lblGrade1.Size = new Size(116, 31);
            lblGrade1.TabIndex = 0;
            lblGrade1.Text = "Оценка 1:";
            // 
            // lblGrade2
            // 
            lblGrade2.AutoSize = true;
            lblGrade2.Font = new Font("Segoe UI", 13.8F);
            lblGrade2.Location = new Point(163, 143);
            lblGrade2.Name = "lblGrade2";
            lblGrade2.Size = new Size(116, 31);
            lblGrade2.TabIndex = 1;
            lblGrade2.Text = "Оценка 2:";
            // 
            // lblGrade3
            // 
            lblGrade3.AutoSize = true;
            lblGrade3.Font = new Font("Segoe UI", 13.8F);
            lblGrade3.Location = new Point(163, 222);
            lblGrade3.Name = "lblGrade3";
            lblGrade3.Size = new Size(116, 31);
            lblGrade3.TabIndex = 2;
            lblGrade3.Text = "Оценка 3:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 13.8F);
            lblResult.Location = new Point(12, 401);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 31);
            lblResult.TabIndex = 3;
            // 
            // txtGrade1
            // 
            txtGrade1.Font = new Font("Segoe UI", 13.8F);
            txtGrade1.Location = new Point(292, 63);
            txtGrade1.Name = "txtGrade1";
            txtGrade1.Size = new Size(215, 38);
            txtGrade1.TabIndex = 4;
            // 
            // txtGrade2
            // 
            txtGrade2.Font = new Font("Segoe UI", 13.8F);
            txtGrade2.Location = new Point(292, 140);
            txtGrade2.Name = "txtGrade2";
            txtGrade2.Size = new Size(215, 38);
            txtGrade2.TabIndex = 5;
            // 
            // txtGrade3
            // 
            txtGrade3.Font = new Font("Segoe UI", 13.8F);
            txtGrade3.Location = new Point(292, 219);
            txtGrade3.Name = "txtGrade3";
            txtGrade3.Size = new Size(215, 38);
            txtGrade3.TabIndex = 6;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 13.8F);
            btnCalculate.Location = new Point(298, 312);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(209, 85);
            btnCalculate.TabIndex = 7;
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
            Controls.Add(txtGrade3);
            Controls.Add(txtGrade2);
            Controls.Add(txtGrade1);
            Controls.Add(lblResult);
            Controls.Add(lblGrade3);
            Controls.Add(lblGrade2);
            Controls.Add(lblGrade1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGrade1;
        private Label lblGrade2;
        private Label lblGrade3;
        private Label lblResult;
        private TextBox txtGrade1;
        private TextBox txtGrade2;
        private TextBox txtGrade3;
        private Button btnCalculate;
    }
}
