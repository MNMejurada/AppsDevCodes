namespace MejuradaMidtermExam1
{
    partial class Form1
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
            this.txtVote1 = new System.Windows.Forms.TextBox();
            this.txtVote3 = new System.Windows.Forms.TextBox();
            this.txtVote2 = new System.Windows.Forms.TextBox();
            this.btnCheckDecision = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVote1
            // 
            this.txtVote1.Location = new System.Drawing.Point(223, 112);
            this.txtVote1.Name = "txtVote1";
            this.txtVote1.Size = new System.Drawing.Size(159, 22);
            this.txtVote1.TabIndex = 0;
            // 
            // txtVote3
            // 
            this.txtVote3.Location = new System.Drawing.Point(223, 308);
            this.txtVote3.Name = "txtVote3";
            this.txtVote3.Size = new System.Drawing.Size(159, 22);
            this.txtVote3.TabIndex = 1;
            // 
            // txtVote2
            // 
            this.txtVote2.Location = new System.Drawing.Point(223, 209);
            this.txtVote2.Name = "txtVote2";
            this.txtVote2.Size = new System.Drawing.Size(159, 22);
            this.txtVote2.TabIndex = 2;
            // 
            // btnCheckDecision
            // 
            this.btnCheckDecision.Location = new System.Drawing.Point(116, 387);
            this.btnCheckDecision.Name = "btnCheckDecision";
            this.btnCheckDecision.Size = new System.Drawing.Size(90, 38);
            this.btnCheckDecision.TabIndex = 3;
            this.btnCheckDecision.Text = "Enter";
            this.btnCheckDecision.UseVisualStyleBackColor = true;
            this.btnCheckDecision.Click += new System.EventHandler(this.btnCheckDecision_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(319, 398);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 16);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vote Yes or No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please Enter vote #2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Please Enter vote #1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Please Enter vote #3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(530, 655);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCheckDecision);
            this.Controls.Add(this.txtVote2);
            this.Controls.Add(this.txtVote3);
            this.Controls.Add(this.txtVote1);
            this.Name = "Form1";
            this.Text = "MejuradaMidtermExam1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVote1;
        private System.Windows.Forms.TextBox txtVote3;
        private System.Windows.Forms.TextBox txtVote2;
        private System.Windows.Forms.Button btnCheckDecision;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

