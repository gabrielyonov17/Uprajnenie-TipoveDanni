namespace _7.Zadacha
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
            lblX = new Label();
            lblY = new Label();
            lblResult = new Label();
            btnCalculate = new Button();
            txtY = new TextBox();
            txtX = new TextBox();
            SuspendLayout();
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Font = new Font("Segoe UI", 13.8F);
            lblX.Location = new Point(113, 97);
            lblX.Name = "lblX";
            lblX.Size = new Size(33, 31);
            lblX.TabIndex = 0;
            lblX.Text = "X:";
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Font = new Font("Segoe UI", 13.8F);
            lblY.Location = new Point(499, 97);
            lblY.Name = "lblY";
            lblY.Size = new Size(32, 31);
            lblY.TabIndex = 1;
            lblY.Text = "Y:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 13.8F);
            lblResult.Location = new Point(12, 410);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 31);
            lblResult.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 13.8F);
            btnCalculate.Location = new Point(317, 237);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(214, 90);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Изчисли";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtY
            // 
            txtY.Font = new Font("Segoe UI", 13.8F);
            txtY.Location = new Point(528, 90);
            txtY.Name = "txtY";
            txtY.Size = new Size(197, 38);
            txtY.TabIndex = 4;
            // 
            // txtX
            // 
            txtX.Font = new Font("Segoe UI", 13.8F);
            txtX.Location = new Point(152, 90);
            txtX.Name = "txtX";
            txtX.Size = new Size(197, 38);
            txtX.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtX);
            Controls.Add(txtY);
            Controls.Add(btnCalculate);
            Controls.Add(lblResult);
            Controls.Add(lblY);
            Controls.Add(lblX);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblX;
        private Label lblY;
        private Label lblResult;
        private Button btnCalculate;
        private TextBox txtY;
        private TextBox txtX;
    }
}
