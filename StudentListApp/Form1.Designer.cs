namespace StudentListApp
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
            txtName = new TextBox();
            txtID = new TextBox();
            txtSearch = new TextBox();
            txtAge = new TextBox();
            btnAdd = new Button();
            btnShowAll = new Button();
            btnSearch = new Button();
            btnExit = new Button();
            lstStudents = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(268, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Location = new Point(12, 27);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 133);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(356, 23);
            txtSearch.TabIndex = 2;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(594, 27);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 70);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(776, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Telebe Elave Et";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(12, 162);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(356, 23);
            btnShowAll.TabIndex = 5;
            btnShowAll.Text = "Hamisin goster";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(384, 133);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(404, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Ada gore axtar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(384, 162);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(404, 23);
            btnExit.TabIndex = 7;
            btnExit.Text = "Cixis";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.Location = new Point(12, 212);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(776, 94);
            lstStudents.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 9);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(594, 9);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 11;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 110);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 12;
            label4.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstStudents);
            Controls.Add(btnExit);
            Controls.Add(btnSearch);
            Controls.Add(btnShowAll);
            Controls.Add(btnAdd);
            Controls.Add(txtAge);
            Controls.Add(txtSearch);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtID;
        private TextBox txtSearch;
        private TextBox txtAge;
        private Button btnAdd;
        private Button btnShowAll;
        private Button btnSearch;
        private Button btnExit;
        private ListBox lstStudents;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
