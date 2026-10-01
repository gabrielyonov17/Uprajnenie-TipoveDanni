namespace _4.Zadacha
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
            lblCelsius = new Label();
            lblFahrenheit = new Label();
            btnConvert = new Button();
            txtCelsius = new TextBox();
            SuspendLayout();
            // 
            // lblCelsius
            // 
            lblCelsius.AutoSize = true;
            lblCelsius.Font = new Font("Segoe UI", 13.8F);
            lblCelsius.Location = new Point(176, 106);
            lblCelsius.Name = "lblCelsius";
            lblCelsius.Size = new Size(185, 31);
            lblCelsius.TabIndex = 0;
            lblCelsius.Text = "Температура °C:";
            // 
            // lblFahrenheit
            // 
            lblFahrenheit.AutoSize = true;
            lblFahrenheit.Font = new Font("Segoe UI", 13.8F);
            lblFahrenheit.Location = new Point(176, 197);
            lblFahrenheit.Name = "lblFahrenheit";
            lblFahrenheit.Size = new Size(0, 31);
            lblFahrenheit.TabIndex = 1;
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Segoe UI", 13.8F);
            btnConvert.Location = new Point(271, 301);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(256, 87);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Преобразувай";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // txtCelsius
            // 
            txtCelsius.Font = new Font("Segoe UI", 13.8F);
            txtCelsius.Location = new Point(367, 103);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(221, 38);
            txtCelsius.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCelsius);
            Controls.Add(btnConvert);
            Controls.Add(lblFahrenheit);
            Controls.Add(lblCelsius);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCelsius;
        private Label lblFahrenheit;
        private Button btnConvert;
        private TextBox txtCelsius;
    }
}
