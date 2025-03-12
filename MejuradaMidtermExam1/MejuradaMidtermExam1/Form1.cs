using System;
using System.Windows.Forms;

namespace MejuradaMidtermExam1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isValidVote(string vote)
        {
            return vote == "yes" || vote == "no";
        }

        private void btnCheckDecision_Click(object sender, EventArgs e)
        {
            string vote1 = txtVote1.Text.Trim().ToLower();
            string vote2 = txtVote2.Text.Trim().ToLower();
            string vote3 = txtVote3.Text.Trim().ToLower();

            if (!isValidVote(vote1) || !isValidVote(vote2) || !isValidVote(vote3))
            {
                lblResult.Text = "Invalid vote. Please enter 'yes' or 'no'.";
                return;
            }

            int yesCount = (vote1 == "yes" ? 1 : 0) + (vote2 == "yes" ? 1 : 0) + (vote3 == "yes" ? 1 : 0);
            int noCount = 3 - yesCount;

            if (yesCount >= 2)
            {
                lblResult.Text = "The majority vote is 'yes'.";
            }
            else
            {
                lblResult.Text = "The majority vote is 'no'.";
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}




