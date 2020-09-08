namespace Practicaa
{
    partial class AddPatientForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labellastname = new System.Windows.Forms.Label();
            this.labelfirstname = new System.Windows.Forms.Label();
            this.labeltherapy = new System.Windows.Forms.Label();
            this.textboxlastname = new System.Windows.Forms.TextBox();
            this.textboxfirstname = new System.Windows.Forms.TextBox();
            this.textboxtherapy = new System.Windows.Forms.TextBox();
            this.buttonaddpatient = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox1.Controls.Add(this.buttonaddpatient);
            this.groupBox1.Controls.Add(this.textboxtherapy);
            this.groupBox1.Controls.Add(this.textboxfirstname);
            this.groupBox1.Controls.Add(this.textboxlastname);
            this.groupBox1.Controls.Add(this.labeltherapy);
            this.groupBox1.Controls.Add(this.labelfirstname);
            this.groupBox1.Controls.Add(this.labellastname);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(43, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD PATIENT";

            // 
            // labellastname
            // 
            this.labellastname.AutoSize = true;
            this.labellastname.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellastname.Location = new System.Drawing.Point(31, 108);
            this.labellastname.Name = "labellastname";
            this.labellastname.Size = new System.Drawing.Size(250, 28);
            this.labellastname.TabIndex = 0;
            this.labellastname.Text = "Patient Last Name";
            // 
            // labelfirstname
            // 
            this.labelfirstname.AutoSize = true;
            this.labelfirstname.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfirstname.Location = new System.Drawing.Point(31, 174);
            this.labelfirstname.Name = "labelfirstname";
            this.labelfirstname.Size = new System.Drawing.Size(264, 28);
            this.labelfirstname.TabIndex = 1;
            this.labelfirstname.Text = "Patient First Name";
            // 
            // labeltherapy
            // 
            this.labeltherapy.AutoSize = true;
            this.labeltherapy.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltherapy.Location = new System.Drawing.Point(31, 243);
            this.labeltherapy.Name = "labeltherapy";
            this.labeltherapy.Size = new System.Drawing.Size(110, 28);
            this.labeltherapy.TabIndex = 2;
            this.labeltherapy.Text = "Therapy";
            // 
            // textboxlastname
            // 
            this.textboxlastname.Location = new System.Drawing.Point(309, 108);
            this.textboxlastname.Name = "textboxlastname";
            this.textboxlastname.Size = new System.Drawing.Size(239, 42);
            this.textboxlastname.TabIndex = 3;
            // 
            // textboxfirstname
            // 
            this.textboxfirstname.Location = new System.Drawing.Point(309, 174);
            this.textboxfirstname.Name = "textboxfirstname";
            this.textboxfirstname.Size = new System.Drawing.Size(239, 42);
            this.textboxfirstname.TabIndex = 4;
            // 
            // textboxtherapy
            // 
            this.textboxtherapy.Location = new System.Drawing.Point(309, 236);
            this.textboxtherapy.Name = "textboxtherapy";
            this.textboxtherapy.Size = new System.Drawing.Size(239, 42);
            this.textboxtherapy.TabIndex = 5;
            // 
            // buttonaddpatient
            // 
            this.buttonaddpatient.BackColor = System.Drawing.Color.Orange;
            this.buttonaddpatient.Location = new System.Drawing.Point(36, 309);
            this.buttonaddpatient.Name = "buttonaddpatient";
            this.buttonaddpatient.Size = new System.Drawing.Size(512, 60);
            this.buttonaddpatient.TabIndex = 6;
            this.buttonaddpatient.Text = "ADD PATIENT";
            this.buttonaddpatient.UseVisualStyleBackColor = false;
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddPatientForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labellastname;
        private System.Windows.Forms.Label labeltherapy;
        private System.Windows.Forms.Label labelfirstname;
        private System.Windows.Forms.TextBox textboxtherapy;
        private System.Windows.Forms.TextBox textboxfirstname;
        private System.Windows.Forms.TextBox textboxlastname;
        private System.Windows.Forms.Button buttonaddpatient;
    }
}