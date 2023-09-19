namespace Examination_System
{
    partial class GenerateExam
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
            this.nummcq = new System.Windows.Forms.NumericUpDown();
            this.numtf = new System.Windows.Forms.NumericUpDown();
            this.comcrsname = new System.Windows.Forms.ComboBox();
            this.btngenerate = new System.Windows.Forms.Button();
            this.lblerror = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nummcq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numtf)).BeginInit();
            this.SuspendLayout();
            // 
            // nummcq
            // 
            this.nummcq.Location = new System.Drawing.Point(518, 272);
            this.nummcq.Name = "nummcq";
            this.nummcq.Size = new System.Drawing.Size(305, 27);
            this.nummcq.TabIndex = 0;
            // 
            // numtf
            // 
            this.numtf.Location = new System.Drawing.Point(518, 321);
            this.numtf.Name = "numtf";
            this.numtf.Size = new System.Drawing.Size(305, 27);
            this.numtf.TabIndex = 1;
            // 
            // comcrsname
            // 
            this.comcrsname.FormattingEnabled = true;
            this.comcrsname.Location = new System.Drawing.Point(518, 220);
            this.comcrsname.Name = "comcrsname";
            this.comcrsname.Size = new System.Drawing.Size(305, 28);
            this.comcrsname.TabIndex = 2;
            // 
            // btngenerate
            // 
            this.btngenerate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btngenerate.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btngenerate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btngenerate.Location = new System.Drawing.Point(365, 430);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(305, 55);
            this.btngenerate.TabIndex = 3;
            this.btngenerate.Text = "Generate Exam";
            this.btngenerate.UseVisualStyleBackColor = false;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblerror.Location = new System.Drawing.Point(458, 371);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 20);
            this.lblerror.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(409, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Generate Exam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(218, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(218, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of MCQ Questions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(218, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number of T/F Questions";
            // 
            // btnback
            // 
            this.btnback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnback.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnback.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnback.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnback.Location = new System.Drawing.Point(803, 589);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(94, 53);
            this.btnback.TabIndex = 13;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click_1);
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnshow.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnshow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnshow.Location = new System.Drawing.Point(365, 528);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(305, 55);
            this.btnshow.TabIndex = 12;
            this.btnshow.Text = "Show Generated Exam";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Visible = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click_1);
            // 
            // GenerateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1122, 703);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.btngenerate);
            this.Controls.Add(this.comcrsname);
            this.Controls.Add(this.numtf);
            this.Controls.Add(this.nummcq);
            this.MaximumSize = new System.Drawing.Size(1140, 750);
            this.MinimumSize = new System.Drawing.Size(1140, 750);
            this.Name = "GenerateExam";
            this.Text = "Generate Exam";
            ((System.ComponentModel.ISupportInitialize)(this.nummcq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numtf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown nummcq;
        private NumericUpDown numtf;
        private ComboBox comcrsname;
        private Button btngenerate;
        private Label lblerror;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnback;
        private Button btnshow;
    }
}