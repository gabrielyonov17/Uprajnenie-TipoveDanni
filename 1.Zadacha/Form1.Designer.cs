namespace _1.Zadacha
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
            lblNumber1 = new Label();
            lblNumber2 = new Label();
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            btnCalculate = new Button();
            lblSum = new Label();
            lblDifference = new Label();
            lblProduct = new Label();
            lblSumResult = new Label();
            lblDifferenceResult = new Label();
            lblProductResult = new Label();
            SuspendLayout();
            // 
            // lblNumber1
            // 
            lblNumber1.AutoSize = true;
            lblNumber1.Font = new Font("Showcard Gothic", 13.8F);
            lblNumber1.Location = new Point(33, 87);
            lblNumber1.Name = "lblNumber1";
            lblNumber1.Size = new Size(162, 29);
            lblNumber1.TabIndex = 0;
            lblNumber1.Text = "Първо число:";
            // 
            // lblNumber2
            // 
            lblNumber2.AutoSize = true;
            lblNumber2.Font = new Font("Showcard Gothic", 13.8F);
            lblNumber2.Location = new Point(430, 87);
            lblNumber2.Name = "lblNumber2";
            lblNumber2.Size = new Size(167, 29);
            lblNumber2.TabIndex = 1;
            lblNumber2.Text = "Второ число: ";
            // 
            // txtNumber1
            // 
            txtNumber1.Font = new Font("Showcard Gothic", 13.8F);
            txtNumber1.Location = new Point(191, 84);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(169, 36);
            txtNumber1.TabIndex = 2;
            // 
            // txtNumber2
            // 
            txtNumber2.Font = new Font("Showcard Gothic", 13.8F);
            txtNumber2.Location = new Point(587, 84);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(169, 36);
            txtNumber2.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Showcard Gothic", 13.8F);
            btnCalculate.Location = new Point(274, 337);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(240, 82);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Изчисли ";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Font = new Font("Showcard Gothic", 13.8F);
            lblSum.Location = new Point(287, 160);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(82, 29);
            lblSum.TabIndex = 5;
            lblSum.Text = "Сума:";
            // 
            // lblDifference
            // 
            lblDifference.AutoSize = true;
            lblDifference.Font = new Font("Showcard Gothic", 13.8F);
            lblDifference.Location = new Point(287, 200);
            lblDifference.Name = "lblDifference";
            lblDifference.Size = new Size(114, 29);
            lblDifference.TabIndex = 6;
            lblDifference.Text = "Разлика:";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Showcard Gothic", 13.8F);
            lblProduct.Location = new Point(287, 246);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(188, 29);
            lblProduct.TabIndex = 7;
            lblProduct.Text = "Произведение:";
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Font = new Font("Showcard Gothic", 13.8F);
            lblSumResult.Location = new Point(481, 160);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(0, 29);
            lblSumResult.TabIndex = 8;
            // 
            // lblDifferenceResult
            // 
            lblDifferenceResult.AutoSize = true;
            lblDifferenceResult.Font = new Font("Showcard Gothic", 13.8F);
            lblDifferenceResult.Location = new Point(481, 200);
            lblDifferenceResult.Name = "lblDifferenceResult";
            lblDifferenceResult.Size = new Size(0, 29);
            lblDifferenceResult.TabIndex = 9;
            // 
            // lblProductResult
            // 
            lblProductResult.AutoSize = true;
            lblProductResult.Font = new Font("Showcard Gothic", 13.8F);
            lblProductResult.Location = new Point(481, 246);
            lblProductResult.Name = "lblProductResult";
            lblProductResult.Size = new Size(0, 29);
            lblProductResult.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblProductResult);
            Controls.Add(lblDifferenceResult);
            Controls.Add(lblSumResult);
            Controls.Add(lblProduct);
            Controls.Add(lblDifference);
            Controls.Add(lblSum);
            Controls.Add(btnCalculate);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Controls.Add(lblNumber2);
            Controls.Add(lblNumber1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumber1;
        private Label lblNumber2;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Button btnCalculate;
        private Label lblSum;
        private Label lblDifference;
        private Label lblProduct;
        private Label lblSumResult;
        private Label lblDifferenceResult;
        private Label lblProductResult;
    }
}
