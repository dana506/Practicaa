namespace Practicaa
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelpatients = new System.Windows.Forms.Label();
            this.PatientstList = new System.Windows.Forms.ListBox();
            this.buttonsave = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.labelfirstname = new System.Windows.Forms.Label();
            this.labeltherapy = new System.Windows.Forms.Label();
            this.labellastname = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.splitContainer1.Panel1.Controls.Add(this.labelpatients);
            this.splitContainer1.Panel1.Controls.Add(this.PatientstList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel2.Controls.Add(this.buttonsave);
            this.splitContainer1.Panel2.Controls.Add(this.buttondelete);
            this.splitContainer1.Panel2.Controls.Add(this.labelfirstname);
            this.splitContainer1.Panel2.Controls.Add(this.labeltherapy);
            this.splitContainer1.Panel2.Controls.Add(this.labellastname);
            this.splitContainer1.Panel2.Controls.Add(this.textBox3);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1190, 450);
            this.splitContainer1.SplitterDistance = 395;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelpatients
            // 
            this.labelpatients.AutoSize = true;
            this.labelpatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelpatients.Location = new System.Drawing.Point(62, 58);
            this.labelpatients.Name = "labelpatients";
            this.labelpatients.Size = new System.Drawing.Size(160, 32);
            this.labelpatients.TabIndex = 1;
            this.labelpatients.Text = "PATIENTS";
            // 
            // PatientstList
            // 
            this.PatientstList.BackColor = System.Drawing.Color.MistyRose;
            this.PatientstList.FormattingEnabled = true;
            this.PatientstList.ItemHeight = 20;
            this.PatientstList.Location = new System.Drawing.Point(42, 106);
            this.PatientstList.Name = "PatientstList";
            this.PatientstList.Size = new System.Drawing.Size(204, 304);
            this.PatientstList.TabIndex = 0;
            // 
            // buttonsave
            // 
            this.buttonsave.BackColor = System.Drawing.Color.Gold;
            this.buttonsave.Location = new System.Drawing.Point(148, 155);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(102, 56);
            this.buttonsave.TabIndex = 7;
            this.buttonsave.Text = "SAVE";
            this.buttonsave.UseVisualStyleBackColor = false;
            // 
            // buttondelete
            // 
            this.buttondelete.BackColor = System.Drawing.Color.Gold;
            this.buttondelete.Location = new System.Drawing.Point(321, 155);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(102, 56);
            this.buttondelete.TabIndex = 6;
            this.buttondelete.Text = "DELETE";
            this.buttondelete.UseVisualStyleBackColor = false;
            // 
            // labelfirstname
            // 
            this.labelfirstname.AutoSize = true;
            this.labelfirstname.Location = new System.Drawing.Point(215, 68);
            this.labelfirstname.Name = "labelfirstname";
            this.labelfirstname.Size = new System.Drawing.Size(140, 20);
            this.labelfirstname.TabIndex = 5;
            this.labelfirstname.Text = "Patient First Name";
            // 
            // labeltherapy
            // 
            this.labeltherapy.AutoSize = true;
            this.labeltherapy.Location = new System.Drawing.Point(388, 68);
            this.labeltherapy.Name = "labeltherapy";
            this.labeltherapy.Size = new System.Drawing.Size(120, 20);
            this.labeltherapy.TabIndex = 4;
            this.labeltherapy.Text = "Patient Therapy";
            // 
            // labellastname
            // 
            this.labellastname.AutoSize = true;
            this.labellastname.Location = new System.Drawing.Point(36, 69);
            this.labellastname.Name = "labellastname";
            this.labellastname.Size = new System.Drawing.Size(140, 20);
            this.labellastname.TabIndex = 3;
            this.labellastname.Text = "Patient Last Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(204, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 26);
            this.textBox3.TabIndex = 2;
        
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 26);
            this.textBox2.TabIndex = 1;
      
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(380, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 26);
            this.textBox1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelpatients;
        private System.Windows.Forms.ListBox PatientstList;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labellastname;
        private System.Windows.Forms.Label labelfirstname;
        private System.Windows.Forms.Label labeltherapy;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttondelete;
    }
}

