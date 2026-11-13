namespace VibeHive
{
    partial class CreateEventForm
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
            btnCreateEvent = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEventName = new TextBox();
            txtVenue = new TextBox();
            txtGenre = new TextBox();
            dtpEventDate = new DateTimePicker();
            numTickets = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numTickets).BeginInit();
            SuspendLayout();
            // 
            // btnCreateEvent
            // 
            btnCreateEvent.Location = new Point(617, 169);
            btnCreateEvent.Name = "btnCreateEvent";
            btnCreateEvent.Size = new Size(75, 67);
            btnCreateEvent.TabIndex = 0;
            btnCreateEvent.Text = "Create Event";
            btnCreateEvent.UseVisualStyleBackColor = true;
            btnCreateEvent.Click += btnCreateEvent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(65, 60);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 1;
            label1.Text = "Event Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(63, 128);
            label2.Name = "label2";
            label2.Size = new Size(138, 28);
            label2.TabIndex = 1;
            label2.Text = "Date and Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(63, 208);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 1;
            label3.Text = "Venue";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(63, 278);
            label4.Name = "label4";
            label4.Size = new Size(64, 28);
            label4.TabIndex = 1;
            label4.Text = "Genre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(63, 349);
            label5.Name = "label5";
            label5.Size = new Size(156, 28);
            label5.TabIndex = 1;
            label5.Text = "Available Tickets";
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(63, 91);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(258, 23);
            txtEventName.TabIndex = 2;
            // 
            // txtVenue
            // 
            txtVenue.Location = new Point(65, 239);
            txtVenue.Name = "txtVenue";
            txtVenue.Size = new Size(258, 23);
            txtVenue.TabIndex = 3;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(63, 309);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(260, 23);
            txtGenre.TabIndex = 4;
            txtGenre.TextChanged += textBox3_TextChanged;
            // 
            // dtpEventDate
            // 
            dtpEventDate.Location = new Point(63, 159);
            dtpEventDate.Name = "dtpEventDate";
            dtpEventDate.Size = new Size(260, 23);
            dtpEventDate.TabIndex = 5;
            // 
            // numTickets
            // 
            numTickets.Location = new Point(65, 389);
            numTickets.Name = "numTickets";
            numTickets.Size = new Size(259, 23);
            numTickets.TabIndex = 6;
            // 
            // CreateEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numTickets);
            Controls.Add(dtpEventDate);
            Controls.Add(txtGenre);
            Controls.Add(txtVenue);
            Controls.Add(txtEventName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCreateEvent);
            Name = "CreateEventForm";
            Text = "CreateEventForm";
            ((System.ComponentModel.ISupportInitialize)numTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateEvent;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEventName;
        private TextBox txtVenue;
        private TextBox txtGenre;
        private DateTimePicker dtpEventDate;
        private NumericUpDown numTickets;
    }
}