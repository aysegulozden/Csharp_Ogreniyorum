namespace Arac_Kullanimlari
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
            Tıkla = new Button();
            SuspendLayout();
            // 
            // Tıkla
            // 
            Tıkla.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tıkla.Location = new Point(137, 111);
            Tıkla.Name = "Tıkla";
            Tıkla.Size = new Size(158, 70);
            Tıkla.TabIndex = 0;
            Tıkla.Text = "Tıklayınız";
            Tıkla.UseVisualStyleBackColor = true;
            Tıkla.Click += Tıkla_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(425, 343);
            Controls.Add(Tıkla);
            Name = "Form1";
            Text = "İlk kodum";
            ResumeLayout(false);
        }

        #endregion

        private Button Tıkla;
    }
}
