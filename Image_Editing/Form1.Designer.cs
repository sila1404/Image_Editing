namespace Image_Editing
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
            btn_origin = new Button();
            btn_gray_1 = new Button();
            btn_gray_2 = new Button();
            btn_open = new Button();
            btn_b_w = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txt_thread = new TextBox();
            btn_negative = new Button();
            btn_invert = new Button();
            cValue1 = new Label();
            btn_power = new Button();
            txt_c_2 = new TextBox();
            cValue2 = new Label();
            txt_alpha = new TextBox();
            label4 = new Label();
            btn_log = new Button();
            txt_c_1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_origin
            // 
            btn_origin.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_origin.Location = new Point(23, 26);
            btn_origin.Name = "btn_origin";
            btn_origin.Size = new Size(130, 60);
            btn_origin.TabIndex = 0;
            btn_origin.Text = "Origin";
            btn_origin.UseVisualStyleBackColor = true;
            btn_origin.Click += btn_origin_Click;
            // 
            // btn_gray_1
            // 
            btn_gray_1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_gray_1.Location = new Point(189, 26);
            btn_gray_1.Name = "btn_gray_1";
            btn_gray_1.Size = new Size(130, 60);
            btn_gray_1.TabIndex = 1;
            btn_gray_1.Text = "Gray Scale 1";
            btn_gray_1.UseVisualStyleBackColor = true;
            btn_gray_1.Click += btn_gray_1_Click;
            // 
            // btn_gray_2
            // 
            btn_gray_2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_gray_2.Location = new Point(353, 26);
            btn_gray_2.Name = "btn_gray_2";
            btn_gray_2.Size = new Size(130, 60);
            btn_gray_2.TabIndex = 2;
            btn_gray_2.Text = "Gray Scale 2";
            btn_gray_2.UseVisualStyleBackColor = true;
            btn_gray_2.Click += btn_gray_2_Click;
            // 
            // btn_open
            // 
            btn_open.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_open.Location = new Point(519, 26);
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(244, 60);
            btn_open.TabIndex = 3;
            btn_open.Text = "Open Picture";
            btn_open.UseVisualStyleBackColor = true;
            btn_open.Click += btn_open_Click;
            // 
            // btn_b_w
            // 
            btn_b_w.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_b_w.Location = new Point(519, 120);
            btn_b_w.Name = "btn_b_w";
            btn_b_w.Size = new Size(244, 60);
            btn_b_w.TabIndex = 4;
            btn_b_w.Text = "Black_White 1";
            btn_b_w.UseVisualStyleBackColor = true;
            btn_b_w.Click += btn_b_w_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(23, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(460, 533);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(519, 197);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 6;
            label1.Text = "Threadhold";
            // 
            // txt_thread
            // 
            txt_thread.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_thread.Location = new Point(653, 195);
            txt_thread.Name = "txt_thread";
            txt_thread.Size = new Size(110, 32);
            txt_thread.TabIndex = 7;
            txt_thread.Text = "100";
            // 
            // btn_negative
            // 
            btn_negative.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_negative.Location = new Point(519, 260);
            btn_negative.Name = "btn_negative";
            btn_negative.Size = new Size(113, 60);
            btn_negative.TabIndex = 8;
            btn_negative.Text = "Negative";
            btn_negative.UseVisualStyleBackColor = true;
            btn_negative.Click += btn_negative_Click;
            // 
            // btn_invert
            // 
            btn_invert.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_invert.Location = new Point(653, 260);
            btn_invert.Name = "btn_invert";
            btn_invert.Size = new Size(109, 60);
            btn_invert.TabIndex = 9;
            btn_invert.Text = "Invert";
            btn_invert.UseVisualStyleBackColor = true;
            btn_invert.Click += btn_invert_Click;
            // 
            // cValue1
            // 
            cValue1.AutoSize = true;
            cValue1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cValue1.Location = new Point(519, 439);
            cValue1.Name = "cValue1";
            cValue1.Size = new Size(42, 25);
            cValue1.TabIndex = 11;
            cValue1.Text = "C =";
            // 
            // btn_power
            // 
            btn_power.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_power.Location = new Point(518, 493);
            btn_power.Name = "btn_power";
            btn_power.Size = new Size(244, 60);
            btn_power.TabIndex = 13;
            btn_power.Text = "Power Law";
            btn_power.UseVisualStyleBackColor = true;
            btn_power.Click += btn_power_Click;
            // 
            // txt_c_2
            // 
            txt_c_2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_c_2.Location = new Point(567, 577);
            txt_c_2.Name = "txt_c_2";
            txt_c_2.Size = new Size(98, 32);
            txt_c_2.TabIndex = 15;
            txt_c_2.Text = "1";
            // 
            // cValue2
            // 
            cValue2.AutoSize = true;
            cValue2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cValue2.Location = new Point(519, 580);
            cValue2.Name = "cValue2";
            cValue2.Size = new Size(42, 25);
            cValue2.TabIndex = 14;
            cValue2.Text = "C =";
            // 
            // txt_alpha
            // 
            txt_alpha.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_alpha.Location = new Point(604, 625);
            txt_alpha.Name = "txt_alpha";
            txt_alpha.Size = new Size(61, 32);
            txt_alpha.TabIndex = 17;
            txt_alpha.Text = "15";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(519, 628);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 16;
            label4.Text = "Alpha =";
            // 
            // btn_log
            // 
            btn_log.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_log.Location = new Point(518, 348);
            btn_log.Name = "btn_log";
            btn_log.Size = new Size(244, 60);
            btn_log.TabIndex = 18;
            btn_log.Text = "Log Transform";
            btn_log.UseVisualStyleBackColor = true;
            btn_log.Click += btn_log_Click;
            // 
            // txt_c_1
            // 
            txt_c_1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_c_1.Location = new Point(567, 436);
            txt_c_1.Name = "txt_c_1";
            txt_c_1.Size = new Size(98, 32);
            txt_c_1.TabIndex = 19;
            txt_c_1.Text = "20";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 753);
            Controls.Add(txt_c_1);
            Controls.Add(btn_log);
            Controls.Add(txt_alpha);
            Controls.Add(label4);
            Controls.Add(txt_c_2);
            Controls.Add(cValue2);
            Controls.Add(btn_power);
            Controls.Add(cValue1);
            Controls.Add(btn_invert);
            Controls.Add(btn_negative);
            Controls.Add(txt_thread);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btn_b_w);
            Controls.Add(btn_open);
            Controls.Add(btn_gray_2);
            Controls.Add(btn_gray_1);
            Controls.Add(btn_origin);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_origin;
        private Button btn_gray_1;
        private Button btn_gray_2;
        private Button btn_open;
        private Button btn_b_w;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txt_thread;
        private Button btn_negative;
        private Button btn_invert;
        private Label cValue1;
        private Button btn_power;
        private TextBox txt_c_2;
        private Label cValue2;
        private TextBox txt_alpha;
        private Label label4;
        private Button btn_log;
        private TextBox txt_c_1;
    }
}