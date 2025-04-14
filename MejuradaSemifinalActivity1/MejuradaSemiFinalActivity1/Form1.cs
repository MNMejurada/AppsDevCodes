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

namespace MejuradaSemiFinalActivity1
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

        private void btnSave_Click(object sender, EventArgs e)
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
            txtIDNumber.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCourse.Clear();
            txtMiddleName.Clear();
            txtYearLevel.Clear();
            


        }


    }
}
