namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.tournamentrDropDown = new System.Windows.Forms.ComboBox();
            this.tournamentLabel = new System.Windows.Forms.Label();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.button1createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadExistingTournamentLabel
            // 
            this.loadExistingTournamentLabel.AutoSize = true;
            this.loadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExistingTournamentLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(114, 91);
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(252, 30);
            this.loadExistingTournamentLabel.TabIndex = 34;
            this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // tournamentrDropDown
            // 
            this.tournamentrDropDown.FormattingEnabled = true;
            this.tournamentrDropDown.Location = new System.Drawing.Point(40, 134);
            this.tournamentrDropDown.Name = "tournamentrDropDown";
            this.tournamentrDropDown.Size = new System.Drawing.Size(401, 38);
            this.tournamentrDropDown.TabIndex = 33;
            // 
            // tournamentLabel
            // 
            this.tournamentLabel.AutoSize = true;
            this.tournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentLabel.Location = new System.Drawing.Point(57, 9);
            this.tournamentLabel.Name = "tournamentLabel";
            this.tournamentLabel.Size = new System.Drawing.Size(367, 47);
            this.tournamentLabel.TabIndex = 32;
            this.tournamentLabel.Text = "Tournament Dashboard";
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loadTournamentButton.Location = new System.Drawing.Point(134, 202);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(213, 36);
            this.loadTournamentButton.TabIndex = 35;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // button1createTournamentButton
            // 
            this.button1createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button1createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1createTournamentButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1createTournamentButton.Location = new System.Drawing.Point(134, 262);
            this.button1createTournamentButton.Name = "button1createTournamentButton";
            this.button1createTournamentButton.Size = new System.Drawing.Size(213, 53);
            this.button1createTournamentButton.TabIndex = 36;
            this.button1createTournamentButton.Text = "Add Tournament";
            this.button1createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournametDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 335);
            this.Controls.Add(this.button1createTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.tournamentrDropDown);
            this.Controls.Add(this.tournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournametDashboardForm";
            this.Text = "Tournamet Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loadExistingTournamentLabel;
        private System.Windows.Forms.ComboBox tournamentrDropDown;
        private System.Windows.Forms.Label tournamentLabel;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Button button1createTournamentButton;
    }
}