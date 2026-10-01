namespace _6.Zadacha
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
            lblFirstName = new Label();
            lblLastName = new Label();
            lblResult = new Label();
            btnGreeting = new Button();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 13.8F);
            lblFirstName.Location = new Point(75, 82);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 31);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "Име:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 13.8F);
            lblLastName.Location = new Point(403, 79);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(114, 31);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Фамилия:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 13.8F);
            lblResult.Location = new Point(24, 400);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 31);
            lblResult.TabIndex = 2;
            // 
            // btnGreeting
            // 
            btnGreeting.Font = new Font("Segoe UI", 13.8F);
            btnGreeting.Location = new Point(270, 231);
            btnGreeting.Name = "btnGreeting";
            btnGreeting.Size = new Size(247, 104);
            btnGreeting.TabIndex = 3;
            btnGreeting.Text = "Поздрави";
            btnGreeting.UseVisualStyleBackColor = true;
            btnGreeting.Click += btnGreeting_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 13.8F);
            txtFirstName.Location = new Point(135, 79);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(208, 38);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 13.8F);
            txtLastName.Location = new Point(512, 76);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(208, 38);
            txtLastName.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(btnGreeting);
            Controls.Add(lblResult);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblResult;
        private Button btnGreeting;
        private TextBox txtFirstName;
        private TextBox txtLastName;
    }
}
