namespace OCR
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.generate_knowledge_base_btn = new System.Windows.Forms.Button();
            this.recognition_btn = new System.Windows.Forms.Button();
            this.path_txb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fh_tvb = new System.Windows.Forms.TextBox();
            this.fv_tbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.charv_tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.charh_tbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vdiff_tbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hdiff_tbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // generate_knowledge_base_btn
            // 
            this.generate_knowledge_base_btn.Location = new System.Drawing.Point(61, 121);
            this.generate_knowledge_base_btn.Name = "generate_knowledge_base_btn";
            this.generate_knowledge_base_btn.Size = new System.Drawing.Size(639, 53);
            this.generate_knowledge_base_btn.TabIndex = 0;
            this.generate_knowledge_base_btn.Text = "Generate Knowledge Base";
            this.generate_knowledge_base_btn.UseVisualStyleBackColor = true;
            this.generate_knowledge_base_btn.Click += new System.EventHandler(this.generate_knowledge_base_btn_Click);
            // 
            // recognition_btn
            // 
            this.recognition_btn.Location = new System.Drawing.Point(61, 236);
            this.recognition_btn.Name = "recognition_btn";
            this.recognition_btn.Size = new System.Drawing.Size(228, 53);
            this.recognition_btn.TabIndex = 1;
            this.recognition_btn.Text = "Recognition";
            this.recognition_btn.UseVisualStyleBackColor = true;
            this.recognition_btn.Click += new System.EventHandler(this.recognition_btn_Click);
            // 
            // path_txb
            // 
            this.path_txb.Location = new System.Drawing.Point(337, 251);
            this.path_txb.Name = "path_txb";
            this.path_txb.Size = new System.Drawing.Size(363, 22);
            this.path_txb.TabIndex = 2;
            this.path_txb.Text = "D:\\Downloads\\char1.bmp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "F H_Proj";
            // 
            // fh_tvb
            // 
            this.fh_tvb.Location = new System.Drawing.Point(134, 367);
            this.fh_tvb.Name = "fh_tvb";
            this.fh_tvb.Size = new System.Drawing.Size(584, 22);
            this.fh_tvb.TabIndex = 5;
            // 
            // fv_tbx
            // 
            this.fv_tbx.Location = new System.Drawing.Point(134, 395);
            this.fv_tbx.Name = "fv_tbx";
            this.fv_tbx.Size = new System.Drawing.Size(584, 22);
            this.fv_tbx.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "F V_Proj";
            // 
            // charv_tbx
            // 
            this.charv_tbx.Location = new System.Drawing.Point(134, 485);
            this.charv_tbx.Name = "charv_tbx";
            this.charv_tbx.Size = new System.Drawing.Size(584, 22);
            this.charv_tbx.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Char V_Proj";
            // 
            // charh_tbx
            // 
            this.charh_tbx.Location = new System.Drawing.Point(134, 457);
            this.charh_tbx.Name = "charh_tbx";
            this.charh_tbx.Size = new System.Drawing.Size(584, 22);
            this.charh_tbx.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Char H_Proj";
            // 
            // vdiff_tbx
            // 
            this.vdiff_tbx.Location = new System.Drawing.Point(134, 574);
            this.vdiff_tbx.Name = "vdiff_tbx";
            this.vdiff_tbx.Size = new System.Drawing.Size(584, 22);
            this.vdiff_tbx.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 577);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "V Diff";
            // 
            // hdiff_tbx
            // 
            this.hdiff_tbx.Location = new System.Drawing.Point(134, 546);
            this.hdiff_tbx.Name = "hdiff_tbx";
            this.hdiff_tbx.Size = new System.Drawing.Size(584, 22);
            this.hdiff_tbx.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 552);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "H Diff";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(783, 351);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 310);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(783, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Abdülsamet Ayyıldız - 180201040";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 673);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.vdiff_tbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hdiff_tbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.charv_tbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.charh_tbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fv_tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fh_tvb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.path_txb);
            this.Controls.Add(this.recognition_btn);
            this.Controls.Add(this.generate_knowledge_base_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generate_knowledge_base_btn;
        private System.Windows.Forms.Button recognition_btn;
        private System.Windows.Forms.TextBox path_txb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fh_tvb;
        private System.Windows.Forms.TextBox fv_tbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox charv_tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox charh_tbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vdiff_tbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hdiff_tbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
    }
}

