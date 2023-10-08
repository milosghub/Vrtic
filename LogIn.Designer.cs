
namespace PresentationLayer
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_KorisnickoIme = new System.Windows.Forms.TextBox();
            this.textBox_Sifra = new System.Windows.Forms.TextBox();
            this.button_LogIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // textBox_KorisnickoIme
            // 
            this.textBox_KorisnickoIme.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_KorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_KorisnickoIme.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_KorisnickoIme.Location = new System.Drawing.Point(268, 341);
            this.textBox_KorisnickoIme.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_KorisnickoIme.Name = "textBox_KorisnickoIme";
            this.textBox_KorisnickoIme.Size = new System.Drawing.Size(219, 27);
            this.textBox_KorisnickoIme.TabIndex = 3;
            // 
            // textBox_Sifra
            // 
            this.textBox_Sifra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_Sifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Sifra.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_Sifra.Location = new System.Drawing.Point(268, 431);
            this.textBox_Sifra.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Sifra.Name = "textBox_Sifra";
            this.textBox_Sifra.PasswordChar = '*';
            this.textBox_Sifra.Size = new System.Drawing.Size(219, 27);
            this.textBox_Sifra.TabIndex = 4;
            // 
            // button_LogIn
            // 
            this.button_LogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LogIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_LogIn.Location = new System.Drawing.Point(268, 517);
            this.button_LogIn.Margin = new System.Windows.Forms.Padding(4);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(219, 51);
            this.button_LogIn.TabIndex = 5;
            this.button_LogIn.Text = "Log In";
            this.button_LogIn.UseVisualStyleBackColor = false;
            this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 396);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(569, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Red;
            this.button_exit.Location = new System.Drawing.Point(668, 1);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 33);
            this.button_exit.TabIndex = 9;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(746, 581);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_LogIn);
            this.Controls.Add(this.textBox_Sifra);
            this.Controls.Add(this.textBox_KorisnickoIme);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_KorisnickoIme;
        private System.Windows.Forms.TextBox textBox_Sifra;
        private System.Windows.Forms.Button button_LogIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_exit;
    }
}