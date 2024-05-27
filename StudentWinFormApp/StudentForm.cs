using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using StudentWinFormApp.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace StudentWinFormApp
{
    public partial class StudentForm : Form
    {
        Regex IDRgxPattern = new Regex(@"[A-Za-z0-9]+$");
        Regex NameRgxPattern = new Regex(@"[A-Za-z\s]+$");
        public StudentForm()
        {
            InitializeComponent();
            this.listViewStudentList.Columns.Add("ID");
            this.listViewStudentList.Columns.Add("Name");
            this.listViewStudentList.Columns.Add("Date Of Birth");
            this.listViewStudentList.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            this.listViewStudentList.Columns.Add("Age");
            this.listViewStudentList.Font = new Font(listViewStudentList.Font, FontStyle.Bold);
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            btnClick.Enabled = false;
            stdNameTextBox.PlaceholderText = "Please type your name.";
            stdIDTextBox.PlaceholderText = "Please type your id.";
        }

        private void SetBtnClick()
        {
            DateTime dateOfBirth = DateTime.Parse(dateOfBirthDatePicker.Text, new CultureInfo("vi-VN"));
            btnClick.Enabled = !string.IsNullOrEmpty(stdIDTextBox.Text)
                && !string.IsNullOrEmpty(stdNameTextBox.Text)
                && (!string.IsNullOrEmpty(dateOfBirthDatePicker.Text) && dateOfBirth.Year < DateTime.Now.Year);
        }

        private void stdNameTextBox_TextChanged(object sender, EventArgs e)
        {
            stdNameErrorMessageLabel.Text = "";
            string stdName = stdNameTextBox.Text;

            if (string.IsNullOrEmpty(stdName))
            {
                btnClick.Enabled = false;
                stdNameErrorMessageLabel.Text = "Student Name cannot be empty";
                stdNameErrorMessageLabel.ForeColor = Color.Red;
            }
            if (this.NameRgxPattern.IsMatch(stdName))
            {
                SetBtnClick();
            }
            else
            {
                btnClick.Enabled = false;
                stdNameErrorMessageLabel.Text = "Please enter only alphabetical letters for student name!";
                stdNameErrorMessageLabel.ForeColor = Color.Red;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateOfBirthDate = DateTime.Parse(dateOfBirthDatePicker.Value.ToString("dd/MM/yyyy"), new CultureInfo("vi-VN"));

                if (dateOfBirthDate.Year > DateTime.Now.Year)
                {
                    throw new Exception("Year of birth must be less than current year!");
                }

                if (string.IsNullOrEmpty(stdIDTextBox.Text))
                {
                    throw new Exception("Student ID must not be empty!");
                }

                if (string.IsNullOrEmpty(stdNameTextBox.Text))
                {
                    throw new Exception("Student Name must not be empty!");
                }

                string stdName = stdNameTextBox.Text;
                stdName = stdName.Trim();
                List<string> stringList = new List<string>(stdName.Split(" "));
                List<string> formattedNameList = new List<string>();
                foreach (string s in stringList)
                {
                    s.ToLower();
                    string newS = char.ToUpper(s.First()) + s.Substring(1).ToLower();
                    formattedNameList.Add(newS);
                }

                string formattedName = string.Join(" ", formattedNameList);

                Student student = new Student
                {
                    Id = stdIDTextBox.Text.ToUpper(),
                    Name = formattedName,
                    DateOfBirth = dateOfBirthDate,
                };
                ListViewItem stdListViewItem = new ListViewItem(
                    new string[]
                    {
                        student.Id.ToString(),
                        student.Name,
                        student.DateOfBirth.ToShortDateString(),
                        student.CalculateAge().ToString(),
                    }
                );
                stdListViewItem.Font = new Font(stdListViewItem.Font, FontStyle.Regular);
                this.listViewStudentList.Items.Add(stdListViewItem);
                this.listViewStudentList.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
                this.listViewStudentList.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
                this.listViewStudentList.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
                this.listViewStudentList.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Submission Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void stdIDTextBox_TextChanged(object sender, EventArgs e)
        {
            stdIDErrorMessageLabel.Text = "";
            string stdID = stdIDTextBox.Text;

            if (string.IsNullOrEmpty(stdID))
            {
                btnClick.Enabled = false;
                stdIDErrorMessageLabel.Text = "Student ID cannot be empty";
                stdIDErrorMessageLabel.ForeColor = Color.Red;
            }
            if (this.IDRgxPattern.IsMatch(stdID))
            {
                SetBtnClick();
            }
            else
            {
                btnClick.Enabled = false;
                stdIDErrorMessageLabel.Text = "Please enter only alphabetical and numeric letters!";
                stdIDErrorMessageLabel.ForeColor = Color.Red;
            }
        }

        private void dateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            stdDateOfBirthErrorMessageLabel.Text = "";
            DateTime dateOfBirthDate = DateTime.Parse(dateOfBirthDatePicker.Value.ToString("dd/MM/yyyy"), new CultureInfo("vi-VN"));

            if (dateOfBirthDate.Year > DateTime.Now.Year)
            {
                btnClick.Enabled = false;
                stdDateOfBirthErrorMessageLabel.Text = "Year of birth must be less than current year!";
                stdDateOfBirthErrorMessageLabel.ForeColor = Color.Red;
            }
            else if (DateTime.Now.Year - dateOfBirthDate.Year < 18)
            {
                btnClick.Enabled = false;
                stdDateOfBirthErrorMessageLabel.Text = "The student age must be greater or equal than 18 years old!";
                stdDateOfBirthErrorMessageLabel.ForeColor = Color.Red;
            }
            else
            {
                SetBtnClick();
            }
        }
    }
}
