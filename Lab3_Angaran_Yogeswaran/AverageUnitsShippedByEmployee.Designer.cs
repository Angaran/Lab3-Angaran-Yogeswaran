
namespace Lab3_Angaran_Yogeswaran
{
    partial class AverageUnitsShippedByEmployee
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
            this.components = new System.ComponentModel.Container();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelAverageOutput = new System.Windows.Forms.Label();
            this.textBoxEmployee1Entries = new System.Windows.Forms.TextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.textboxEntryNumber = new System.Windows.Forms.TextBox();
            this.labelUnitsPrompt = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxEmployee2Entries = new System.Windows.Forms.TextBox();
            this.textBoxEmployee3Entries = new System.Windows.Forms.TextBox();
            this.labelEmployee1Average = new System.Windows.Forms.Label();
            this.labelEmployee2Average = new System.Windows.Forms.Label();
            this.labelEmployee1Prompt = new System.Windows.Forms.Label();
            this.labelEmployee2Prompt = new System.Windows.Forms.Label();
            this.labelEmployee3Prompt = new System.Windows.Forms.Label();
            this.labelEmployee3Average = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(269, 305);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(110, 23);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Click to end the application");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(127, 305);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(118, 23);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Click to reset this form to allow a new week of entries");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(12, 305);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(96, 23);
            this.buttonEnter.TabIndex = 13;
            this.buttonEnter.Text = "&Enter";
            this.toolTip.SetToolTip(this.buttonEnter, "Click the process the current units shipped");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
            // 
            // labelAverageOutput
            // 
            this.labelAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageOutput.Location = new System.Drawing.Point(7, 269);
            this.labelAverageOutput.Name = "labelAverageOutput";
            this.labelAverageOutput.Size = new System.Drawing.Size(372, 23);
            this.labelAverageOutput.TabIndex = 12;
            this.labelAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelAverageOutput, "Displays the calculated average units shipped for the week\r\n");
            // 
            // textBoxEmployee1Entries
            // 
            this.textBoxEmployee1Entries.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxEmployee1Entries.Location = new System.Drawing.Point(12, 80);
            this.textBoxEmployee1Entries.Multiline = true;
            this.textBoxEmployee1Entries.Name = "textBoxEmployee1Entries";
            this.textBoxEmployee1Entries.ReadOnly = true;
            this.textBoxEmployee1Entries.Size = new System.Drawing.Size(105, 139);
            this.textBoxEmployee1Entries.TabIndex = 4;
            this.toolTip.SetToolTip(this.textBoxEmployee1Entries, "Displays the units shipped for employee 1\r\n\r\n");
            // 
            // labelDay
            // 
            this.labelDay.Location = new System.Drawing.Point(228, 12);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(100, 23);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Day 1";
            this.labelDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textboxEntryNumber
            // 
            this.textboxEntryNumber.Location = new System.Drawing.Point(164, 12);
            this.textboxEntryNumber.Name = "textboxEntryNumber";
            this.textboxEntryNumber.Size = new System.Drawing.Size(49, 23);
            this.textboxEntryNumber.TabIndex = 1;
            this.toolTip.SetToolTip(this.textboxEntryNumber, "Enter the units shipped for the specified day");
            // 
            // labelUnitsPrompt
            // 
            this.labelUnitsPrompt.Location = new System.Drawing.Point(45, 12);
            this.labelUnitsPrompt.Name = "labelUnitsPrompt";
            this.labelUnitsPrompt.Size = new System.Drawing.Size(100, 23);
            this.labelUnitsPrompt.TabIndex = 0;
            this.labelUnitsPrompt.Text = "&Units:";
            this.labelUnitsPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxEmployee2Entries
            // 
            this.textBoxEmployee2Entries.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxEmployee2Entries.Location = new System.Drawing.Point(140, 80);
            this.textBoxEmployee2Entries.Multiline = true;
            this.textBoxEmployee2Entries.Name = "textBoxEmployee2Entries";
            this.textBoxEmployee2Entries.ReadOnly = true;
            this.textBoxEmployee2Entries.Size = new System.Drawing.Size(105, 139);
            this.textBoxEmployee2Entries.TabIndex = 7;
            this.toolTip.SetToolTip(this.textBoxEmployee2Entries, "Displays the units shipped for employee 2\r\n");
            // 
            // textBoxEmployee3Entries
            // 
            this.textBoxEmployee3Entries.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxEmployee3Entries.Location = new System.Drawing.Point(269, 80);
            this.textBoxEmployee3Entries.Multiline = true;
            this.textBoxEmployee3Entries.Name = "textBoxEmployee3Entries";
            this.textBoxEmployee3Entries.ReadOnly = true;
            this.textBoxEmployee3Entries.Size = new System.Drawing.Size(110, 139);
            this.textBoxEmployee3Entries.TabIndex = 10;
            this.toolTip.SetToolTip(this.textBoxEmployee3Entries, "Displays the units shipped for employee 3\r\n\r\n");
            // 
            // labelEmployee1Average
            // 
            this.labelEmployee1Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEmployee1Average.Location = new System.Drawing.Point(12, 222);
            this.labelEmployee1Average.Name = "labelEmployee1Average";
            this.labelEmployee1Average.Size = new System.Drawing.Size(105, 23);
            this.labelEmployee1Average.TabIndex = 5;
            this.labelEmployee1Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelEmployee1Average, "Displays the calculated average units shipped for the week for employee 1\r\n");
            this.labelEmployee1Average.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelEmployee2Average
            // 
            this.labelEmployee2Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEmployee2Average.Location = new System.Drawing.Point(140, 222);
            this.labelEmployee2Average.Name = "labelEmployee2Average";
            this.labelEmployee2Average.Size = new System.Drawing.Size(105, 23);
            this.labelEmployee2Average.TabIndex = 8;
            this.labelEmployee2Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelEmployee2Average, "Displays the calculated average units shipped for the week for employee 2\r\n\r\n");
            // 
            // labelEmployee1Prompt
            // 
            this.labelEmployee1Prompt.Location = new System.Drawing.Point(12, 62);
            this.labelEmployee1Prompt.Name = "labelEmployee1Prompt";
            this.labelEmployee1Prompt.Size = new System.Drawing.Size(105, 15);
            this.labelEmployee1Prompt.TabIndex = 3;
            this.labelEmployee1Prompt.Text = "Employee &1";
            this.labelEmployee1Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmployee2Prompt
            // 
            this.labelEmployee2Prompt.AutoSize = true;
            this.labelEmployee2Prompt.Location = new System.Drawing.Point(155, 62);
            this.labelEmployee2Prompt.Name = "labelEmployee2Prompt";
            this.labelEmployee2Prompt.Size = new System.Drawing.Size(68, 15);
            this.labelEmployee2Prompt.TabIndex = 6;
            this.labelEmployee2Prompt.Text = "Employee &2";
            // 
            // labelEmployee3Prompt
            // 
            this.labelEmployee3Prompt.AutoSize = true;
            this.labelEmployee3Prompt.Location = new System.Drawing.Point(295, 62);
            this.labelEmployee3Prompt.Name = "labelEmployee3Prompt";
            this.labelEmployee3Prompt.Size = new System.Drawing.Size(68, 15);
            this.labelEmployee3Prompt.TabIndex = 9;
            this.labelEmployee3Prompt.Text = "Employee &3";
            // 
            // labelEmployee3Average
            // 
            this.labelEmployee3Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEmployee3Average.Location = new System.Drawing.Point(269, 222);
            this.labelEmployee3Average.Name = "labelEmployee3Average";
            this.labelEmployee3Average.Size = new System.Drawing.Size(110, 23);
            this.labelEmployee3Average.TabIndex = 11;
            this.labelEmployee3Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AverageUnitsShippedByEmployee
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(396, 348);
            this.Controls.Add(this.labelEmployee3Average);
            this.Controls.Add(this.labelEmployee2Average);
            this.Controls.Add(this.labelEmployee1Average);
            this.Controls.Add(this.labelEmployee3Prompt);
            this.Controls.Add(this.labelEmployee2Prompt);
            this.Controls.Add(this.labelEmployee1Prompt);
            this.Controls.Add(this.textBoxEmployee3Entries);
            this.Controls.Add(this.textBoxEmployee2Entries);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelAverageOutput);
            this.Controls.Add(this.textBoxEmployee1Entries);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.textboxEntryNumber);
            this.Controls.Add(this.labelUnitsPrompt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AverageUnitsShippedByEmployee";
            this.Text = "Average Units Shipped By Employee";
            this.toolTip.SetToolTip(this, "Displays the calculated average units shipped for the week for employee 3\r\n\r\n");
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelAverageOutput;
        private System.Windows.Forms.TextBox textBoxEmployee1Entries;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textboxEntryNumber;
        private System.Windows.Forms.Label labelUnitsPrompt;
        private System.Windows.Forms.TextBox textBoxEmployee2Entries;
        private System.Windows.Forms.TextBox textBoxEmployee3Entries;
        private System.Windows.Forms.Label labelEmployee1Prompt;
        private System.Windows.Forms.Label labelEmployee2Prompt;
        private System.Windows.Forms.Label labelEmployee3Prompt;
        private System.Windows.Forms.Label labelEmployee1Average;
        private System.Windows.Forms.Label labelEmployee2Average;
        private System.Windows.Forms.Label labelEmployee3Average;
    }
}

