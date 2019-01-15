namespace RL_ReplayManager
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        public void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Ping_button = new System.Windows.Forms.Button();
            this.Log_textBox = new System.Windows.Forms.TextBox();
            this.LogClear_button = new System.Windows.Forms.Button();
            this.Token_groupBox = new System.Windows.Forms.GroupBox();
            this.Token_textBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ReplayM_groupBox = new System.Windows.Forms.GroupBox();
            this.ReplayBlue_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReplayRed_dataGridView = new System.Windows.Forms.DataGridView();
            this.Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assists = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReplayLoad_progressBar = new System.Windows.Forms.ProgressBar();
            this.ReplayList_dataGridView = new System.Windows.Forms.DataGridView();
            this.ReplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReplayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReplayTeamSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReplayFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReplayLRefresh_button = new System.Windows.Forms.Button();
            this.Dir_groupBox = new System.Windows.Forms.GroupBox();
            this.Dir_textBox = new System.Windows.Forms.TextBox();
            this.Upload_button = new System.Windows.Forms.Button();
            this.UploadVisibility_comboBox = new System.Windows.Forms.ComboBox();
            this.Token_groupBox.SuspendLayout();
            this.ReplayM_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReplayBlue_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReplayRed_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReplayList_dataGridView)).BeginInit();
            this.Dir_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ping_button
            // 
            this.Ping_button.Location = new System.Drawing.Point(485, 121);
            this.Ping_button.Name = "Ping_button";
            this.Ping_button.Size = new System.Drawing.Size(75, 23);
            this.Ping_button.TabIndex = 0;
            this.Ping_button.Text = "Ping";
            this.Ping_button.UseVisualStyleBackColor = true;
            this.Ping_button.Click += new System.EventHandler(this.Ping_button_Click);
            // 
            // Log_textBox
            // 
            this.Log_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Log_textBox.Location = new System.Drawing.Point(289, 12);
            this.Log_textBox.Multiline = true;
            this.Log_textBox.Name = "Log_textBox";
            this.Log_textBox.ReadOnly = true;
            this.Log_textBox.Size = new System.Drawing.Size(352, 103);
            this.Log_textBox.TabIndex = 1;
            this.Log_textBox.Text = "-----> Logger <-----";
            // 
            // LogClear_button
            // 
            this.LogClear_button.Location = new System.Drawing.Point(566, 121);
            this.LogClear_button.Name = "LogClear_button";
            this.LogClear_button.Size = new System.Drawing.Size(75, 23);
            this.LogClear_button.TabIndex = 2;
            this.LogClear_button.Text = "Clear";
            this.LogClear_button.UseVisualStyleBackColor = true;
            this.LogClear_button.Click += new System.EventHandler(this.LogClear_button_Click);
            // 
            // Token_groupBox
            // 
            this.Token_groupBox.Controls.Add(this.Token_textBox);
            this.Token_groupBox.Location = new System.Drawing.Point(12, 12);
            this.Token_groupBox.Name = "Token_groupBox";
            this.Token_groupBox.Size = new System.Drawing.Size(271, 46);
            this.Token_groupBox.TabIndex = 3;
            this.Token_groupBox.TabStop = false;
            this.Token_groupBox.Text = "Upload token";
            // 
            // Token_textBox
            // 
            this.Token_textBox.Location = new System.Drawing.Point(6, 19);
            this.Token_textBox.Name = "Token_textBox";
            this.Token_textBox.Size = new System.Drawing.Size(259, 20);
            this.Token_textBox.TabIndex = 4;
            // 
            // ReplayM_groupBox
            // 
            this.ReplayM_groupBox.Controls.Add(this.ReplayBlue_dataGridView);
            this.ReplayM_groupBox.Controls.Add(this.ReplayRed_dataGridView);
            this.ReplayM_groupBox.Controls.Add(this.ReplayLoad_progressBar);
            this.ReplayM_groupBox.Controls.Add(this.ReplayList_dataGridView);
            this.ReplayM_groupBox.Controls.Add(this.ReplayLRefresh_button);
            this.ReplayM_groupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReplayM_groupBox.Location = new System.Drawing.Point(0, 150);
            this.ReplayM_groupBox.Name = "ReplayM_groupBox";
            this.ReplayM_groupBox.Size = new System.Drawing.Size(653, 518);
            this.ReplayM_groupBox.TabIndex = 5;
            this.ReplayM_groupBox.TabStop = false;
            this.ReplayM_groupBox.Text = "Replays";
            // 
            // ReplayBlue_dataGridView
            // 
            this.ReplayBlue_dataGridView.AllowUserToAddRows = false;
            this.ReplayBlue_dataGridView.AllowUserToDeleteRows = false;
            this.ReplayBlue_dataGridView.AllowUserToResizeColumns = false;
            this.ReplayBlue_dataGridView.AllowUserToResizeRows = false;
            this.ReplayBlue_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ReplayBlue_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReplayBlue_dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ReplayBlue_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReplayBlue_dataGridView.ColumnHeadersVisible = false;
            this.ReplayBlue_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReplayBlue_dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ReplayBlue_dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.ReplayBlue_dataGridView.Location = new System.Drawing.Point(288, 19);
            this.ReplayBlue_dataGridView.MultiSelect = false;
            this.ReplayBlue_dataGridView.Name = "ReplayBlue_dataGridView";
            this.ReplayBlue_dataGridView.ReadOnly = true;
            this.ReplayBlue_dataGridView.RowHeadersVisible = false;
            this.ReplayBlue_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ReplayBlue_dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ReplayBlue_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReplayBlue_dataGridView.Size = new System.Drawing.Size(353, 111);
            this.ReplayBlue_dataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Team";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 50F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Score";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 50F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Goals";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 50F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Assists";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 50F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Saves";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 50F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Shots";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // ReplayRed_dataGridView
            // 
            this.ReplayRed_dataGridView.AllowUserToAddRows = false;
            this.ReplayRed_dataGridView.AllowUserToDeleteRows = false;
            this.ReplayRed_dataGridView.AllowUserToResizeColumns = false;
            this.ReplayRed_dataGridView.AllowUserToResizeRows = false;
            this.ReplayRed_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ReplayRed_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReplayRed_dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ReplayRed_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReplayRed_dataGridView.ColumnHeadersVisible = false;
            this.ReplayRed_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Team,
            this.Score,
            this.Goals,
            this.Assists,
            this.Saves,
            this.Shots});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReplayRed_dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.ReplayRed_dataGridView.Location = new System.Drawing.Point(288, 136);
            this.ReplayRed_dataGridView.MultiSelect = false;
            this.ReplayRed_dataGridView.Name = "ReplayRed_dataGridView";
            this.ReplayRed_dataGridView.ReadOnly = true;
            this.ReplayRed_dataGridView.RowHeadersVisible = false;
            this.ReplayRed_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ReplayRed_dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ReplayRed_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReplayRed_dataGridView.Size = new System.Drawing.Size(353, 111);
            this.ReplayRed_dataGridView.TabIndex = 8;
            // 
            // Team
            // 
            this.Team.HeaderText = "Team";
            this.Team.Name = "Team";
            this.Team.ReadOnly = true;
            this.Team.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Score
            // 
            this.Score.FillWeight = 50F;
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Score.Width = 50;
            // 
            // Goals
            // 
            this.Goals.FillWeight = 50F;
            this.Goals.HeaderText = "Goals";
            this.Goals.Name = "Goals";
            this.Goals.ReadOnly = true;
            this.Goals.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Goals.Width = 50;
            // 
            // Assists
            // 
            this.Assists.FillWeight = 50F;
            this.Assists.HeaderText = "Assists";
            this.Assists.Name = "Assists";
            this.Assists.ReadOnly = true;
            this.Assists.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Assists.Width = 50;
            // 
            // Saves
            // 
            this.Saves.FillWeight = 50F;
            this.Saves.HeaderText = "Saves";
            this.Saves.Name = "Saves";
            this.Saves.ReadOnly = true;
            this.Saves.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Saves.Width = 50;
            // 
            // Shots
            // 
            this.Shots.FillWeight = 50F;
            this.Shots.HeaderText = "Shots";
            this.Shots.Name = "Shots";
            this.Shots.ReadOnly = true;
            this.Shots.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Shots.Width = 50;
            // 
            // ReplayLoad_progressBar
            // 
            this.ReplayLoad_progressBar.Location = new System.Drawing.Point(6, 483);
            this.ReplayLoad_progressBar.Name = "ReplayLoad_progressBar";
            this.ReplayLoad_progressBar.Size = new System.Drawing.Size(190, 23);
            this.ReplayLoad_progressBar.TabIndex = 7;
            // 
            // ReplayList_dataGridView
            // 
            this.ReplayList_dataGridView.AllowUserToAddRows = false;
            this.ReplayList_dataGridView.AllowUserToDeleteRows = false;
            this.ReplayList_dataGridView.AllowUserToResizeColumns = false;
            this.ReplayList_dataGridView.AllowUserToResizeRows = false;
            this.ReplayList_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ReplayList_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReplayList_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReplayName,
            this.ReplayDate,
            this.ReplayTeamSize,
            this.ReplayFileName});
            this.ReplayList_dataGridView.Location = new System.Drawing.Point(6, 19);
            this.ReplayList_dataGridView.MultiSelect = false;
            this.ReplayList_dataGridView.Name = "ReplayList_dataGridView";
            this.ReplayList_dataGridView.ReadOnly = true;
            this.ReplayList_dataGridView.RowHeadersVisible = false;
            this.ReplayList_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ReplayList_dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReplayList_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReplayList_dataGridView.Size = new System.Drawing.Size(271, 458);
            this.ReplayList_dataGridView.TabIndex = 6;
            // 
            // ReplayName
            // 
            this.ReplayName.HeaderText = "Title";
            this.ReplayName.Name = "ReplayName";
            this.ReplayName.ReadOnly = true;
            this.ReplayName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ReplayDate
            // 
            this.ReplayDate.HeaderText = "Date";
            this.ReplayDate.Name = "ReplayDate";
            this.ReplayDate.ReadOnly = true;
            this.ReplayDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ReplayTeamSize
            // 
            this.ReplayTeamSize.HeaderText = "Size";
            this.ReplayTeamSize.Name = "ReplayTeamSize";
            this.ReplayTeamSize.ReadOnly = true;
            this.ReplayTeamSize.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ReplayTeamSize.Width = 50;
            // 
            // ReplayFileName
            // 
            this.ReplayFileName.HeaderText = "File Name";
            this.ReplayFileName.Name = "ReplayFileName";
            this.ReplayFileName.ReadOnly = true;
            this.ReplayFileName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ReplayFileName.Visible = false;
            // 
            // ReplayLRefresh_button
            // 
            this.ReplayLRefresh_button.Location = new System.Drawing.Point(202, 483);
            this.ReplayLRefresh_button.Name = "ReplayLRefresh_button";
            this.ReplayLRefresh_button.Size = new System.Drawing.Size(75, 23);
            this.ReplayLRefresh_button.TabIndex = 5;
            this.ReplayLRefresh_button.Text = "Refresh";
            this.ReplayLRefresh_button.UseVisualStyleBackColor = true;
            this.ReplayLRefresh_button.Click += new System.EventHandler(this.ReplayLRefresh_button_Click);
            // 
            // Dir_groupBox
            // 
            this.Dir_groupBox.Controls.Add(this.Dir_textBox);
            this.Dir_groupBox.Location = new System.Drawing.Point(12, 64);
            this.Dir_groupBox.Name = "Dir_groupBox";
            this.Dir_groupBox.Size = new System.Drawing.Size(271, 46);
            this.Dir_groupBox.TabIndex = 5;
            this.Dir_groupBox.TabStop = false;
            this.Dir_groupBox.Text = "Directory";
            // 
            // Dir_textBox
            // 
            this.Dir_textBox.Location = new System.Drawing.Point(6, 19);
            this.Dir_textBox.Name = "Dir_textBox";
            this.Dir_textBox.Size = new System.Drawing.Size(259, 20);
            this.Dir_textBox.TabIndex = 4;
            // 
            // Upload_button
            // 
            this.Upload_button.Enabled = false;
            this.Upload_button.Location = new System.Drawing.Point(18, 121);
            this.Upload_button.Name = "Upload_button";
            this.Upload_button.Size = new System.Drawing.Size(95, 23);
            this.Upload_button.TabIndex = 6;
            this.Upload_button.Text = "Upload Replay";
            this.Upload_button.UseVisualStyleBackColor = true;
            this.Upload_button.Click += new System.EventHandler(this.Upload_button_Click);
            // 
            // UploadVisibility_comboBox
            // 
            this.UploadVisibility_comboBox.BackColor = System.Drawing.SystemColors.Window;
            this.UploadVisibility_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UploadVisibility_comboBox.FormattingEnabled = true;
            this.UploadVisibility_comboBox.Items.AddRange(new object[] {
            "Public",
            "Private",
            "Unlisted"});
            this.UploadVisibility_comboBox.Location = new System.Drawing.Point(119, 122);
            this.UploadVisibility_comboBox.Name = "UploadVisibility_comboBox";
            this.UploadVisibility_comboBox.Size = new System.Drawing.Size(121, 21);
            this.UploadVisibility_comboBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 668);
            this.Controls.Add(this.UploadVisibility_comboBox);
            this.Controls.Add(this.Upload_button);
            this.Controls.Add(this.Dir_groupBox);
            this.Controls.Add(this.ReplayM_groupBox);
            this.Controls.Add(this.Token_groupBox);
            this.Controls.Add(this.LogClear_button);
            this.Controls.Add(this.Log_textBox);
            this.Controls.Add(this.Ping_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rocket League Replay Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Token_groupBox.ResumeLayout(false);
            this.Token_groupBox.PerformLayout();
            this.ReplayM_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReplayBlue_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReplayRed_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReplayList_dataGridView)).EndInit();
            this.Dir_groupBox.ResumeLayout(false);
            this.Dir_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ping_button;
        private System.Windows.Forms.TextBox Log_textBox;
        private System.Windows.Forms.Button LogClear_button;
        private System.Windows.Forms.GroupBox Token_groupBox;
        private System.Windows.Forms.TextBox Token_textBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox ReplayM_groupBox;
        private System.Windows.Forms.GroupBox Dir_groupBox;
        private System.Windows.Forms.TextBox Dir_textBox;
        private System.Windows.Forms.Button ReplayLRefresh_button;
        private System.Windows.Forms.DataGridView ReplayList_dataGridView;
        private System.Windows.Forms.ProgressBar ReplayLoad_progressBar;
        private System.Windows.Forms.DataGridView ReplayRed_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goals;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assists;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shots;
        private System.Windows.Forms.DataGridView ReplayBlue_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReplayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReplayTeamSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReplayFileName;
        private System.Windows.Forms.Button Upload_button;
        private System.Windows.Forms.ComboBox UploadVisibility_comboBox;
    }
}

