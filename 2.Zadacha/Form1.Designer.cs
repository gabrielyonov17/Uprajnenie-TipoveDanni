namespace _2.Zadacha
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
            txtName = new TextBox();
            lblWelcome = new Label();
            btnWelcome = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Showcard Gothic", 13.8F);
            lblName.Location = new Point(221, 108);
            lblName.Name = "lblName";
            lblName.Size = new Size(73, 29);
            lblName.TabIndex = 0;
            lblName.Text = "Име:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Showcard Gothic", 13.8F);
            txtName.Location = new Point(319, 105);
            txtName.Name = "txtName";
            txtName.Size = new Size(231, 36);
            txtName.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Showcard Gothic", 13.8F);
            lblWelcome.Location = new Point(12, 379);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 29);
            lblWelcome.TabIndex = 2;
            // 
            // btnWelcome
            // 
            btnWelcome.Font = new Font("Showcard Gothic", 13.8F);
            btnWelcome.Location = new Point(295, 206);
            btnWelcome.Name = "btnWelcome";
            btnWelcome.Size = new Size(227, 83);
            btnWelcome.TabIndex = 3;
            btnWelcome.Text = "Enter";
            btnWelcome.UseVisualStyleBackColor = true;
            btnWelcome.Click += btnWelcome_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnWelcome);
            Controls.Add(lblWelcome);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblWelcome;
        private Button btnWelcome;
    }
}
