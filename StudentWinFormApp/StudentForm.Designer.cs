namespace StudentWinFormApp
{
    partial class StudentForm
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
            stdIDLabel = new Label();
            stdIDTextBox = new TextBox();
            stdNameTextBox = new TextBox();
            stdNameLabel = new Label();
            stdDateOfBirthLabel = new Label();
            btnClick = new Button();
            dateOfBirthDatePicker = new DateTimePicker();
            stdIDErrorMessageLabel = new Label();
            stdNameErrorMessageLabel = new Label();
            stdDateOfBirthErrorMessageLabel = new Label();
            SuspendLayout();
            // 
            // stdIDLabel
            // 
            stdIDLabel.AutoSize = true;
            stdIDLabel.Location = new Point(12, 15);
            stdIDLabel.Name = "stdIDLabel";
            stdIDLabel.Size = new Size(18, 15);
            stdIDLabel.TabIndex = 0;
            stdIDLabel.Text = "ID";
            stdIDLabel.Click += btnSubmit_Click;
            // 
            // stdIDTextBox
            // 
            stdIDTextBox.Location = new Point(131, 7);
            stdIDTextBox.Name = "stdIDTextBox";
            stdIDTextBox.Size = new Size(208, 23);
            stdIDTextBox.TabIndex = 1;
            stdIDTextBox.TextChanged += stdIDTextBox_TextChanged;
            // 
            // stdNameTextBox
            // 
            stdNameTextBox.Location = new Point(131, 36);
            stdNameTextBox.Name = "stdNameTextBox";
            stdNameTextBox.Size = new Size(208, 23);
            stdNameTextBox.TabIndex = 3;
            stdNameTextBox.TextChanged += stdNameTextBox_TextChanged;
            // 
            // stdNameLabel
            // 
            stdNameLabel.AutoSize = true;
            stdNameLabel.Location = new Point(12, 44);
            stdNameLabel.Name = "stdNameLabel";
            stdNameLabel.Size = new Size(39, 15);
            stdNameLabel.TabIndex = 2;
            stdNameLabel.Text = "Name";
            // 
            // stdDateOfBirthLabel
            // 
            stdDateOfBirthLabel.AutoSize = true;
            stdDateOfBirthLabel.Location = new Point(12, 73);
            stdDateOfBirthLabel.Name = "stdDateOfBirthLabel";
            stdDateOfBirthLabel.Size = new Size(69, 15);
            stdDateOfBirthLabel.TabIndex = 4;
            stdDateOfBirthLabel.Text = "DateOfBirth";
            // 
            // btnClick
            // 
            btnClick.Location = new Point(167, 96);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(100, 23);
            btnClick.TabIndex = 6;
            btnClick.Text = "Submit";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnSubmit_Click;
            // 
            // dateOfBirthDatePicker
            // 
            dateOfBirthDatePicker.Location = new Point(131, 67);
            dateOfBirthDatePicker.Name = "dateOfBirthDatePicker";
            dateOfBirthDatePicker.Size = new Size(208, 23);
            dateOfBirthDatePicker.TabIndex = 7;
            dateOfBirthDatePicker.ValueChanged += dateOfBirth_ValueChanged;
            // 
            // stdIDErrorMessageLabel
            // 
            stdIDErrorMessageLabel.AutoSize = true;
            stdIDErrorMessageLabel.Location = new Point(345, 9);
            stdIDErrorMessageLabel.Name = "stdIDErrorMessageLabel";
            stdIDErrorMessageLabel.Size = new Size(0, 15);
            stdIDErrorMessageLabel.TabIndex = 8;
            // 
            // stdNameErrorMessageLabel
            // 
            stdNameErrorMessageLabel.AutoSize = true;
            stdNameErrorMessageLabel.Location = new Point(345, 36);
            stdNameErrorMessageLabel.Name = "stdNameErrorMessageLabel";
            stdNameErrorMessageLabel.Size = new Size(0, 15);
            stdNameErrorMessageLabel.TabIndex = 9;
            // 
            // stdDateOfBirthErrorMessageLabel
            // 
            stdDateOfBirthErrorMessageLabel.AutoSize = true;
            stdDateOfBirthErrorMessageLabel.Location = new Point(345, 73);
            stdDateOfBirthErrorMessageLabel.Name = "stdDateOfBirthErrorMessageLabel";
            stdDateOfBirthErrorMessageLabel.Size = new Size(0, 15);
            stdDateOfBirthErrorMessageLabel.TabIndex = 10;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(stdDateOfBirthErrorMessageLabel);
            Controls.Add(stdNameErrorMessageLabel);
            Controls.Add(stdIDErrorMessageLabel);
            Controls.Add(dateOfBirthDatePicker);
            Controls.Add(btnClick);
            Controls.Add(stdDateOfBirthLabel);
            Controls.Add(stdNameTextBox);
            Controls.Add(stdNameLabel);
            Controls.Add(stdIDTextBox);
            Controls.Add(stdIDLabel);
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label stdIDLabel;
        private TextBox stdIDTextBox;
        private TextBox stdNameTextBox;
        private Label stdNameLabel;
        private Label stdDateOfBirthLabel;
        private Button btnClick;
        private DateTimePicker dateOfBirthDatePicker;
        private Label stdIDErrorMessageLabel;
        private Label stdNameErrorMessageLabel;
        private Label stdDateOfBirthErrorMessageLabel;
    }
}