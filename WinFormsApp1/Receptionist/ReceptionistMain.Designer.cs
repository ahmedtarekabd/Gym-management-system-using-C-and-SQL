using System.Windows.Forms;
namespace Receptionist
{
    partial class ReceptionistMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistMain));
            trainees_button = new Button();
            navigationPanel = new Panel();
            settingsButton = new Button();
            financeButton = new Button();
            trainersPanel = new Panel();
            assignTrainersButton = new Button();
            loginButton = new Button();
            trainersButton = new Button();
            respondPanel = new Panel();
            requestButton = new Button();
            traineesPanel = new Panel();
            lockersButton = new Button();
            programsButton = new Button();
            invitationsButton = new Button();
            membershipsButton = new Button();
            userInfoPanel = new Panel();
            welcomeLabel = new Label();
            usernameLabel = new Label();
            formName = new Label();
            managePanelAniamtion = new System.Windows.Forms.Timer(components);
            viewPanelAniamtion = new System.Windows.Forms.Timer(components);
            loadedFormPanel = new Panel();
            navigationPanel.SuspendLayout();
            trainersPanel.SuspendLayout();
            respondPanel.SuspendLayout();
            traineesPanel.SuspendLayout();
            userInfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // trainees_button
            // 
            trainees_button.BackColor = Color.FromArgb(154, 81, 49);
            trainees_button.Dock = DockStyle.Top;
            trainees_button.FlatAppearance.BorderSize = 0;
            trainees_button.FlatStyle = FlatStyle.Flat;
            trainees_button.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            trainees_button.ForeColor = Color.White;
            trainees_button.Image = (Image)resources.GetObject("trainees_button.Image");
            trainees_button.ImageAlign = ContentAlignment.MiddleLeft;
            trainees_button.Location = new Point(0, 0);
            trainees_button.Margin = new Padding(0);
            trainees_button.MinimumSize = new Size(250, 45);
            trainees_button.Name = "trainees_button";
            trainees_button.Padding = new Padding(10, 0, 10, 0);
            trainees_button.RightToLeft = RightToLeft.No;
            trainees_button.Size = new Size(250, 45);
            trainees_button.TabIndex = 1;
            trainees_button.Text = "Trainees";
            trainees_button.UseVisualStyleBackColor = false;
            trainees_button.Click += trainees_button_Click;
            // 
            // navigationPanel
            // 
            navigationPanel.BackColor = Color.FromArgb(154, 81, 49);
            navigationPanel.Controls.Add(settingsButton);
            navigationPanel.Controls.Add(financeButton);
            navigationPanel.Controls.Add(trainersPanel);
            navigationPanel.Controls.Add(respondPanel);
            navigationPanel.Controls.Add(traineesPanel);
            navigationPanel.Controls.Add(userInfoPanel);
            navigationPanel.Dock = DockStyle.Left;
            navigationPanel.Location = new Point(0, 0);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(250, 703);
            navigationPanel.TabIndex = 6;
            // 
            // settingsButton
            // 
            settingsButton.BackColor = Color.FromArgb(154, 81, 49);
            settingsButton.Dock = DockStyle.Bottom;
            settingsButton.FlatAppearance.BorderSize = 0;
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            settingsButton.ForeColor = Color.White;
            settingsButton.Image = (Image)resources.GetObject("settingsButton.Image");
            settingsButton.ImageAlign = ContentAlignment.MiddleLeft;
            settingsButton.Location = new Point(0, 658);
            settingsButton.Margin = new Padding(0);
            settingsButton.MinimumSize = new Size(250, 45);
            settingsButton.Name = "settingsButton";
            settingsButton.Padding = new Padding(10, 2, 10, 0);
            settingsButton.RightToLeft = RightToLeft.No;
            settingsButton.Size = new Size(250, 45);
            settingsButton.TabIndex = 8;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = false;
            settingsButton.Click += settingsButton_Click;
            // 
            // financeButton
            // 
            financeButton.BackColor = Color.FromArgb(154, 81, 49);
            financeButton.Dock = DockStyle.Top;
            financeButton.FlatAppearance.BorderSize = 0;
            financeButton.FlatStyle = FlatStyle.Flat;
            financeButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            financeButton.ForeColor = Color.White;
            financeButton.Image = (Image)resources.GetObject("financeButton.Image");
            financeButton.ImageAlign = ContentAlignment.MiddleLeft;
            financeButton.Location = new Point(0, 285);
            financeButton.Margin = new Padding(0);
            financeButton.MinimumSize = new Size(250, 45);
            financeButton.Name = "financeButton";
            financeButton.Padding = new Padding(10, 2, 10, 0);
            financeButton.RightToLeft = RightToLeft.No;
            financeButton.Size = new Size(250, 45);
            financeButton.TabIndex = 7;
            financeButton.Text = "Finance";
            financeButton.UseVisualStyleBackColor = false;
            financeButton.Click += financeButton_Click;
            // 
            // trainersPanel
            // 
            trainersPanel.Controls.Add(assignTrainersButton);
            trainersPanel.Controls.Add(loginButton);
            trainersPanel.Controls.Add(trainersButton);
            trainersPanel.Dock = DockStyle.Top;
            trainersPanel.Location = new Point(0, 240);
            trainersPanel.MaximumSize = new Size(250, 125);
            trainersPanel.MinimumSize = new Size(250, 45);
            trainersPanel.Name = "trainersPanel";
            trainersPanel.Size = new Size(250, 45);
            trainersPanel.TabIndex = 4;
            // 
            // assignTrainersButton
            // 
            assignTrainersButton.BackColor = Color.FromArgb(234, 108, 54);
            assignTrainersButton.Dock = DockStyle.Top;
            assignTrainersButton.FlatAppearance.BorderSize = 0;
            assignTrainersButton.FlatStyle = FlatStyle.Flat;
            assignTrainersButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            assignTrainersButton.ForeColor = Color.White;
            assignTrainersButton.Image = (Image)resources.GetObject("assignTrainersButton.Image");
            assignTrainersButton.ImageAlign = ContentAlignment.MiddleLeft;
            assignTrainersButton.Location = new Point(0, 85);
            assignTrainersButton.Margin = new Padding(3, 4, 3, 4);
            assignTrainersButton.Name = "assignTrainersButton";
            assignTrainersButton.Padding = new Padding(40, 0, 10, 0);
            assignTrainersButton.RightToLeft = RightToLeft.No;
            assignTrainersButton.Size = new Size(250, 40);
            assignTrainersButton.TabIndex = 3;
            assignTrainersButton.Text = "          Assign Trainers";
            assignTrainersButton.TextAlign = ContentAlignment.MiddleLeft;
            assignTrainersButton.UseVisualStyleBackColor = false;
            assignTrainersButton.Click += assignTrainersButton_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(234, 108, 54);
            loginButton.Dock = DockStyle.Top;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.White;
            loginButton.Image = (Image)resources.GetObject("loginButton.Image");
            loginButton.ImageAlign = ContentAlignment.MiddleLeft;
            loginButton.Location = new Point(0, 45);
            loginButton.Margin = new Padding(0);
            loginButton.Name = "loginButton";
            loginButton.Padding = new Padding(40, 0, 10, 0);
            loginButton.RightToLeft = RightToLeft.No;
            loginButton.Size = new Size(250, 40);
            loginButton.TabIndex = 1;
            loginButton.Text = "          Login";
            loginButton.TextAlign = ContentAlignment.MiddleLeft;
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // trainersButton
            // 
            trainersButton.BackColor = Color.FromArgb(154, 81, 49);
            trainersButton.Dock = DockStyle.Top;
            trainersButton.FlatAppearance.BorderSize = 0;
            trainersButton.FlatStyle = FlatStyle.Flat;
            trainersButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            trainersButton.ForeColor = Color.White;
            trainersButton.Image = (Image)resources.GetObject("trainersButton.Image");
            trainersButton.ImageAlign = ContentAlignment.MiddleLeft;
            trainersButton.Location = new Point(0, 0);
            trainersButton.Margin = new Padding(0);
            trainersButton.MinimumSize = new Size(250, 45);
            trainersButton.Name = "trainersButton";
            trainersButton.Padding = new Padding(10, 2, 10, 0);
            trainersButton.RightToLeft = RightToLeft.No;
            trainersButton.Size = new Size(250, 45);
            trainersButton.TabIndex = 0;
            trainersButton.Text = "Trainers";
            trainersButton.UseVisualStyleBackColor = false;
            trainersButton.Click += trainers_button_Click;
            // 
            // respondPanel
            // 
            respondPanel.Controls.Add(requestButton);
            respondPanel.Dock = DockStyle.Top;
            respondPanel.Location = new Point(0, 195);
            respondPanel.MaximumSize = new Size(250, 45);
            respondPanel.MinimumSize = new Size(250, 45);
            respondPanel.Name = "respondPanel";
            respondPanel.Size = new Size(250, 45);
            respondPanel.TabIndex = 3;
            // 
            // requestButton
            // 
            requestButton.BackColor = Color.FromArgb(154, 81, 49);
            requestButton.Dock = DockStyle.Top;
            requestButton.FlatAppearance.BorderSize = 0;
            requestButton.FlatStyle = FlatStyle.Flat;
            requestButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            requestButton.ForeColor = Color.White;
            requestButton.Image = (Image)resources.GetObject("requestButton.Image");
            requestButton.ImageAlign = ContentAlignment.MiddleLeft;
            requestButton.Location = new Point(0, 0);
            requestButton.Margin = new Padding(0);
            requestButton.MinimumSize = new Size(250, 45);
            requestButton.Name = "requestButton";
            requestButton.Padding = new Padding(10, 2, 10, 0);
            requestButton.RightToLeft = RightToLeft.No;
            requestButton.Size = new Size(250, 45);
            requestButton.TabIndex = 0;
            requestButton.Text = "Request";
            requestButton.UseVisualStyleBackColor = false;
            requestButton.Click += request_button_Click;
            // 
            // traineesPanel
            // 
            traineesPanel.Controls.Add(lockersButton);
            traineesPanel.Controls.Add(programsButton);
            traineesPanel.Controls.Add(invitationsButton);
            traineesPanel.Controls.Add(membershipsButton);
            traineesPanel.Controls.Add(trainees_button);
            traineesPanel.Dock = DockStyle.Top;
            traineesPanel.Location = new Point(0, 150);
            traineesPanel.MaximumSize = new Size(250, 205);
            traineesPanel.MinimumSize = new Size(250, 45);
            traineesPanel.Name = "traineesPanel";
            traineesPanel.Size = new Size(250, 45);
            traineesPanel.TabIndex = 2;
            // 
            // lockersButton
            // 
            lockersButton.BackColor = Color.FromArgb(234, 108, 54);
            lockersButton.Dock = DockStyle.Top;
            lockersButton.FlatAppearance.BorderSize = 0;
            lockersButton.FlatStyle = FlatStyle.Flat;
            lockersButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lockersButton.ForeColor = Color.White;
            lockersButton.Image = (Image)resources.GetObject("lockersButton.Image");
            lockersButton.ImageAlign = ContentAlignment.MiddleLeft;
            lockersButton.Location = new Point(0, 165);
            lockersButton.Margin = new Padding(3, 4, 3, 4);
            lockersButton.Name = "lockersButton";
            lockersButton.Padding = new Padding(40, 0, 10, 0);
            lockersButton.RightToLeft = RightToLeft.No;
            lockersButton.Size = new Size(250, 40);
            lockersButton.TabIndex = 5;
            lockersButton.Text = "          Lockers";
            lockersButton.TextAlign = ContentAlignment.MiddleLeft;
            lockersButton.UseVisualStyleBackColor = false;
            lockersButton.Click += lockersButton_Click;
            // 
            // programsButton
            // 
            programsButton.BackColor = Color.FromArgb(234, 108, 54);
            programsButton.Dock = DockStyle.Top;
            programsButton.FlatAppearance.BorderSize = 0;
            programsButton.FlatStyle = FlatStyle.Flat;
            programsButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            programsButton.ForeColor = Color.White;
            programsButton.Image = (Image)resources.GetObject("programsButton.Image");
            programsButton.ImageAlign = ContentAlignment.MiddleLeft;
            programsButton.Location = new Point(0, 125);
            programsButton.Margin = new Padding(3, 4, 3, 4);
            programsButton.Name = "programsButton";
            programsButton.Padding = new Padding(40, 0, 10, 0);
            programsButton.RightToLeft = RightToLeft.No;
            programsButton.Size = new Size(250, 40);
            programsButton.TabIndex = 4;
            programsButton.Text = "          Programs";
            programsButton.TextAlign = ContentAlignment.MiddleLeft;
            programsButton.UseVisualStyleBackColor = false;
            programsButton.Click += programsButton_Click;
            // 
            // invitationsButton
            // 
            invitationsButton.BackColor = Color.FromArgb(234, 108, 54);
            invitationsButton.Dock = DockStyle.Top;
            invitationsButton.FlatAppearance.BorderSize = 0;
            invitationsButton.FlatStyle = FlatStyle.Flat;
            invitationsButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            invitationsButton.ForeColor = Color.White;
            invitationsButton.Image = (Image)resources.GetObject("invitationsButton.Image");
            invitationsButton.ImageAlign = ContentAlignment.MiddleLeft;
            invitationsButton.Location = new Point(0, 85);
            invitationsButton.Margin = new Padding(3, 4, 3, 4);
            invitationsButton.Name = "invitationsButton";
            invitationsButton.Padding = new Padding(40, 0, 10, 0);
            invitationsButton.RightToLeft = RightToLeft.No;
            invitationsButton.Size = new Size(250, 40);
            invitationsButton.TabIndex = 3;
            invitationsButton.Text = "          Invitations";
            invitationsButton.TextAlign = ContentAlignment.MiddleLeft;
            invitationsButton.UseVisualStyleBackColor = false;
            invitationsButton.Click += invitationsButton_Click;
            // 
            // membershipsButton
            // 
            membershipsButton.BackColor = Color.FromArgb(234, 108, 54);
            membershipsButton.Dock = DockStyle.Top;
            membershipsButton.FlatAppearance.BorderSize = 0;
            membershipsButton.FlatStyle = FlatStyle.Flat;
            membershipsButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            membershipsButton.ForeColor = Color.White;
            membershipsButton.Image = (Image)resources.GetObject("membershipsButton.Image");
            membershipsButton.ImageAlign = ContentAlignment.MiddleLeft;
            membershipsButton.Location = new Point(0, 45);
            membershipsButton.Margin = new Padding(0);
            membershipsButton.Name = "membershipsButton";
            membershipsButton.Padding = new Padding(40, 0, 10, 0);
            membershipsButton.RightToLeft = RightToLeft.No;
            membershipsButton.Size = new Size(250, 40);
            membershipsButton.TabIndex = 2;
            membershipsButton.Text = "          Memberships";
            membershipsButton.TextAlign = ContentAlignment.MiddleLeft;
            membershipsButton.UseVisualStyleBackColor = false;
            membershipsButton.Click += membershipsButton_Click;
            // 
            // userInfoPanel
            // 
            userInfoPanel.BackColor = Color.FromArgb(154, 81, 49);
            userInfoPanel.Controls.Add(welcomeLabel);
            userInfoPanel.Controls.Add(usernameLabel);
            userInfoPanel.Dock = DockStyle.Top;
            userInfoPanel.Location = new Point(0, 0);
            userInfoPanel.Name = "userInfoPanel";
            userInfoPanel.Size = new Size(250, 150);
            userInfoPanel.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            welcomeLabel.ForeColor = Color.White;
            welcomeLabel.Location = new Point(12, 74);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(84, 23);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.ForeColor = Color.White;
            usernameLabel.Location = new Point(12, 97);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(158, 41);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username";
            // 
            // formName
            // 
            formName.AutoSize = true;
            formName.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            formName.Location = new Point(270, 19);
            formName.Name = "formName";
            formName.Size = new Size(178, 54);
            formName.TabIndex = 0;
            formName.Text = "Trainees";
            // 
            // managePanelAniamtion
            // 
            managePanelAniamtion.Interval = 10;
            managePanelAniamtion.Tick += traineesPanelAniamtion_Tick;
            // 
            // viewPanelAniamtion
            // 
            viewPanelAniamtion.Interval = 10;
            viewPanelAniamtion.Tick += trainersPanelAniamtion_Tick;
            // 
            // loadedFormPanel
            // 
            loadedFormPanel.Dock = DockStyle.Bottom;
            loadedFormPanel.Location = new Point(250, 94);
            loadedFormPanel.Name = "loadedFormPanel";
            loadedFormPanel.Size = new Size(914, 609);
            loadedFormPanel.TabIndex = 7;
            // 
            // ReceptionistMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1164, 703);
            Controls.Add(loadedFormPanel);
            Controls.Add(formName);
            Controls.Add(navigationPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReceptionistMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receptionist Main";
            FormClosed += ReceptionistMain_FormClosed;
            navigationPanel.ResumeLayout(false);
            trainersPanel.ResumeLayout(false);
            respondPanel.ResumeLayout(false);
            traineesPanel.ResumeLayout(false);
            userInfoPanel.ResumeLayout(false);
            userInfoPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button trainees_button;
        private Panel navigationPanel;
        private Panel traineesPanel;
        private Button membershipsButton;
        private Button lockersButton;
        private Button programsButton;
        private Button invitationsButton;
        private Panel respondPanel;
        private Button requestButton;
        private Panel userInfoPanel;
        private Label formName;
        private Label usernameLabel;
        private Label welcomeLabel;
        private Panel trainersPanel;
        private Button assignTrainersButton;
        private Button loginButton;
        private Button trainersButton;
        private System.Windows.Forms.Timer managePanelAniamtion;
        private System.Windows.Forms.Timer viewPanelAniamtion;
        private Button financeButton;
        private Panel loadedFormPanel;
        private Button settingsButton;
    }
}