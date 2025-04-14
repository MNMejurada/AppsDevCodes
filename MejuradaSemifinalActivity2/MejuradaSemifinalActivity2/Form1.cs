using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MejuradaSemifinalActivity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ValidateInputs()
        {
            if (!Regex.IsMatch(txtIDNumber.Text, @"^\d+$"))
            {
                MessageBox.Show("ID Number must contain only numbers.");
                return false;
            }

            if (!Regex.IsMatch(txtFirstName.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("First Name must contain only letters.");
                return false;
            }

            if (!Regex.IsMatch(txtLastName.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Last Name must contain only letters.");
                return false;
            }

            if (!Regex.IsMatch(txtYearLevel.Text, @"^\d+$"))
            {
                MessageBox.Show("Year Level must contain only numbers.");
                return false;
            }
            return true;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                SaveToFile();
                MessageBox.Show("Student information saved successfully.");
            }
        }

        private void SaveToFile()
        {
            string[] studentInfo = {
                $"ID Number: {txtIDNumber.Text}",
                $"First Name: {txtFirstName.Text}",
                $"Last Name: {txtLastName.Text}",
                $"Middle Name: {txtMiddleName.Text}",
                $"Course: {txtCourse.Text}",
                $"Year Level: {txtYearLevel.Text}",
                $"Birthday: {dtBirthday.Text}",
                $"_______________________________________\n"
            };

            File.AppendAllLines("student_record.txt", studentInfo);
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtIDNumber.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCourse.Clear();
            txtMiddleName.Clear();
            txtYearLevel.Clear();
        }

        private void DeleteFromFile(string idNumber)
        {
            var lines = File.ReadAllLines("student_record.txt").ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Contains($"ID Number: {idNumber}"))
                {
                    lines.RemoveRange(i, 8);
                    break;
                }
            }

            if (Regex.IsMatch(txtIDNumber.Text, @"^\d+$"))
            {
                DeleteFromFile(txtIDNumber.Text);
            }
            else
            {
                MessageBox.Show("ID Number must contain only numbers.");
            }
        }

        private void UpdateInFile(string idNumber, string[] updatedInfo)
        {
            var lines = File.ReadAllLines("student_record.txt").ToList();
            bool recordFound = false;

            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Contains($"ID Number: {idNumber}"))
                {
                    recordFound = true;
                    lines.RemoveRange(i, 8); 
                    lines.InsertRange(i, updatedInfo);
                    break;
                }
            }

            if (recordFound)
            {
                File.WriteAllLines("student_record.txt", lines);
                MessageBox.Show("Record updated successfully.");
            }
            else
            {
                MessageBox.Show("Record not found.");
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtIDNumber.Text, @"^\d+$"))
            {
                MessageBox.Show("ID Number must contain only numbers.");
                return;
            }

            var lines = File.ReadAllLines("student_record.txt").ToList();
            bool recordFound = false;

            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Contains($"ID Number: {txtIDNumber.Text}"))
                {
                    lines.RemoveRange(i, 8);
                    recordFound = true;
                    break;
                }
            }

            if (recordFound)
            {
                File.WriteAllLines("student_record.txt", lines);
                MessageBox.Show("Record deleted successfully.");
            }
            else
            {
                MessageBox.Show("Record not found.");
            }

            ClearInputs();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string[] updatedInfo = {
                    $"ID Number: {txtIDNumber.Text}",
                    $"First Name: {txtFirstName.Text}",
                    $"Last Name: {txtLastName.Text}",
                    $"Middle Name: {txtMiddleName.Text}",
                    $"Course: {txtCourse.Text}",
                    $"Year Level: {txtYearLevel.Text}",
                    $"Birthday: {dtBirthday.Text}",
                    $"_______________________________________\n"
                };
                UpdateInFile(txtIDNumber.Text, updatedInfo);
            }
        }

        private void txtIDNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
