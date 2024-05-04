namespace Goruntuisleme
{
    partial class Main
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.beforePic = new FontAwesome.Sharp.IconPictureBox();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.beforePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 600);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(533, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ıconButton1
            // 
            this.ıconButton1.BackColor = System.Drawing.SystemColors.Control;
            this.ıconButton1.FlatAppearance.BorderSize = 0;
            this.ıconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.ıconButton1.IconColor = System.Drawing.Color.Black;
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.Location = new System.Drawing.Point(203, 661);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Size = new System.Drawing.Size(97, 66);
            this.ıconButton1.TabIndex = 3;
            this.ıconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ıconButton1.UseVisualStyleBackColor = false;
            // 
            // beforePic
            // 
            this.beforePic.BackColor = System.Drawing.SystemColors.Control;
            this.beforePic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.beforePic.IconChar = FontAwesome.Sharp.IconChar.None;
            this.beforePic.IconColor = System.Drawing.SystemColors.ControlText;
            this.beforePic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.beforePic.IconSize = 533;
            this.beforePic.Location = new System.Drawing.Point(12, 12);
            this.beforePic.Name = "beforePic";
            this.beforePic.Size = new System.Drawing.Size(533, 560);
            this.beforePic.TabIndex = 1;
            this.beforePic.TabStop = false;
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.ıconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ıconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox1.IconSize = 533;
            this.ıconPictureBox1.Location = new System.Drawing.Point(612, 12);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(533, 560);
            this.ıconPictureBox1.TabIndex = 4;
            this.ıconPictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 785);
            this.Controls.Add(this.ıconPictureBox1);
            this.Controls.Add(this.ıconButton1);
            this.Controls.Add(this.beforePic);
            this.Controls.Add(this.comboBox1);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.beforePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private FontAwesome.Sharp.IconPictureBox beforePic;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
    }
}