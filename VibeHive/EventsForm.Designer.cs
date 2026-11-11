namespace VibeHive
{
    partial class EventsForm
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
            dgvEvents = new DataGridView();
            btnRefresh = new Button();
            lblTitle = new Label();
            btnMainMenu = new Button();
            btnEventLogin = new Button();
            btnBookTicket = new Button();
            btnOpenCreateEvent = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            SuspendLayout();
            // 
            // dgvEvents
            // 
            dgvEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvents.Location = new Point(52, 84);
            dgvEvents.Name = "dgvEvents";
            dgvEvents.Size = new Size(642, 153);
            dgvEvents.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 20F);
            btnRefresh.Location = new Point(52, 253);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(642, 45);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh Events";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 40F);
            lblTitle.Location = new Point(52, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(410, 72);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "VibeHive Events";
            // 
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(52, 394);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(107, 44);
            btnMainMenu.TabIndex = 3;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // btnEventLogin
            // 
            btnEventLogin.Location = new Point(198, 394);
            btnEventLogin.Name = "btnEventLogin";
            btnEventLogin.Size = new Size(107, 44);
            btnEventLogin.TabIndex = 3;
            btnEventLogin.Text = "Login";
            btnEventLogin.UseVisualStyleBackColor = true;
            btnEventLogin.Click += btnEventLogin_Click;
            // 
            // btnBookTicket
            // 
            btnBookTicket.Font = new Font("Segoe UI", 15F);
            btnBookTicket.Location = new Point(52, 320);
            btnBookTicket.Name = "btnBookTicket";
            btnBookTicket.Size = new Size(642, 38);
            btnBookTicket.TabIndex = 4;
            btnBookTicket.Text = "Book Ticket";
            btnBookTicket.UseVisualStyleBackColor = true;
            btnBookTicket.Click += btnBookTicket_Click;
            // 
            // btnOpenCreateEvent
            // 
            btnOpenCreateEvent.Location = new Point(344, 394);
            btnOpenCreateEvent.Name = "btnOpenCreateEvent";
            btnOpenCreateEvent.Size = new Size(107, 44);
            btnOpenCreateEvent.TabIndex = 5;
            btnOpenCreateEvent.Text = "Create Event";
            btnOpenCreateEvent.UseVisualStyleBackColor = true;
            btnOpenCreateEvent.Click += btnOpenCreateEvent_Click;
            // 
            // EventsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpenCreateEvent);
            Controls.Add(btnBookTicket);
            Controls.Add(btnEventLogin);
            Controls.Add(btnMainMenu);
            Controls.Add(lblTitle);
            Controls.Add(btnRefresh);
            Controls.Add(dgvEvents);
            Name = "EventsForm";
            Text = "EventsForm";
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEvents;
        private Button btnRefresh;
        private Label lblTitle;
        private Button btnMainMenu;
        private Button btnEventLogin;
        private Button btnBookTicket;
        private Button btnOpenCreateEvent;
    }
}