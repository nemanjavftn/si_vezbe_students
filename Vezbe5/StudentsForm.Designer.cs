namespace Vezbe5
{
    partial class StudentsForm
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
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.textBoxStudentSurname = new System.Windows.Forms.TextBox();
            this.textBoxStudentAge = new System.Windows.Forms.TextBox();
            this.textBoxStudentIndexNumber = new System.Windows.Forms.TextBox();
            this.buttonInsertStudent = new System.Windows.Forms.Button();
            this.buttonUpdateStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 15;
            this.listBoxStudents.Location = new System.Drawing.Point(25, 163);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(1011, 319);
            this.listBoxStudents.TabIndex = 0;
            this.listBoxStudents.SelectedIndexChanged += new System.EventHandler(this.listBoxStudents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Godine:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Broj indeksa:";
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(102, 34);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(240, 23);
            this.textBoxStudentName.TabIndex = 5;
            // 
            // textBoxStudentSurname
            // 
            this.textBoxStudentSurname.Location = new System.Drawing.Point(102, 75);
            this.textBoxStudentSurname.Name = "textBoxStudentSurname";
            this.textBoxStudentSurname.Size = new System.Drawing.Size(240, 23);
            this.textBoxStudentSurname.TabIndex = 6;
            // 
            // textBoxStudentAge
            // 
            this.textBoxStudentAge.Location = new System.Drawing.Point(609, 34);
            this.textBoxStudentAge.Name = "textBoxStudentAge";
            this.textBoxStudentAge.Size = new System.Drawing.Size(298, 23);
            this.textBoxStudentAge.TabIndex = 7;
            // 
            // textBoxStudentIndexNumber
            // 
            this.textBoxStudentIndexNumber.Location = new System.Drawing.Point(609, 74);
            this.textBoxStudentIndexNumber.Name = "textBoxStudentIndexNumber";
            this.textBoxStudentIndexNumber.Size = new System.Drawing.Size(298, 23);
            this.textBoxStudentIndexNumber.TabIndex = 8;
            // 
            // buttonInsertStudent
            // 
            this.buttonInsertStudent.Location = new System.Drawing.Point(102, 119);
            this.buttonInsertStudent.Name = "buttonInsertStudent";
            this.buttonInsertStudent.Size = new System.Drawing.Size(127, 23);
            this.buttonInsertStudent.TabIndex = 9;
            this.buttonInsertStudent.Text = "Unesi studenta";
            this.buttonInsertStudent.UseVisualStyleBackColor = true;
            this.buttonInsertStudent.Click += new System.EventHandler(this.buttonInsertStudent_Click);
            // 
            // buttonUpdateStudent
            // 
            this.buttonUpdateStudent.Location = new System.Drawing.Point(360, 119);
            this.buttonUpdateStudent.Name = "buttonUpdateStudent";
            this.buttonUpdateStudent.Size = new System.Drawing.Size(181, 23);
            this.buttonUpdateStudent.TabIndex = 10;
            this.buttonUpdateStudent.Text = "Izmeni studenta";
            this.buttonUpdateStudent.UseVisualStyleBackColor = true;
            this.buttonUpdateStudent.Click += new System.EventHandler(this.buttonUpdateStudent_Click);
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 515);
            this.Controls.Add(this.buttonUpdateStudent);
            this.Controls.Add(this.buttonInsertStudent);
            this.Controls.Add(this.textBoxStudentIndexNumber);
            this.Controls.Add(this.textBoxStudentAge);
            this.Controls.Add(this.textBoxStudentSurname);
            this.Controls.Add(this.textBoxStudentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxStudents);
            this.Name = "StudentsForm";
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.TextBox textBoxStudentSurname;
        private System.Windows.Forms.TextBox textBoxStudentAge;
        private System.Windows.Forms.TextBox textBoxStudentIndexNumber;
        private System.Windows.Forms.Button buttonInsertStudent;
        private System.Windows.Forms.Button buttonUpdateStudent;
    }
}