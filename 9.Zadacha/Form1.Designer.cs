namespace _9.Zadacha
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
            lblName = new Label();
            lblHourlyWage = new Label();
            lblHours = new Label();
            lblResult = new Label();
            txtName = new TextBox();
            txtHourlyWage = new TextBox();
            txtHours = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 13.8F);
            lblName.Location = new Point(284, 70);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 31);
            lblName.TabIndex = 0;
            lblName.Text = "Име:";
            // 
            // lblHourlyWage
            // 
            lblHourlyWage.AutoSize = true;
            lblHourlyWage.Font = new Font("Segoe UI", 13.8F);
            lblHourlyWage.Location = new Point(184, 118);
            lblHourlyWage.Name = "lblHourlyWage";
            lblHourlyWage.Size = new Size(180, 31);
            lblHourlyWage.TabIndex = 1;
            lblHourlyWage.Text = "Часова заплата:";
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Font = new Font("Segoe UI", 13.8F);
            lblHours.Location = new Point(140, 175);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(224, 31);
            lblHours.TabIndex = 2;
            lblHours.Text = "Изработени часове:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 13.8F);
            lblResult.Location = new Point(12, 410);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 31);
            lblResult.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 13.8F);
            txtName.Location = new Point(370, 63);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 38);
            txtName.TabIndex = 4;
            // 
            // txtHourlyWage
            // 
            txtHourlyWage.Font = new Font("Segoe UI", 13.8F);
            txtHourlyWage.Location = new Point(370, 115);
            txtHourlyWage.Name = "txtHourlyWage";
            txtHourlyWage.Size = new Size(229, 38);
            txtHourlyWage.TabIndex = 5;
            // 
            // txtHours
            // 
            txtHours.Font = new Font("Segoe UI", 13.8F);
            txtHours.Location = new Point(370, 175);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(229, 38);
            txtHours.TabIndex = 6;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 13.8F);
            btnCalculate.Location = new Point(295, 277);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(207, 85);
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
            Controls.Add(txtHours);
            Controls.Add(txtHourlyWage);
            Controls.Add(txtName);
            Controls.Add(lblResult);
            Controls.Add(lblHours);
            Controls.Add(lblHourlyWage);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblHourlyWage;
        private Label lblHours;
        private Label lblResult;
        private TextBox txtName;
        private TextBox txtHourlyWage;
        private TextBox txtHours;
        private Button btnCalculate;
    }
}
