namespace VibeHive
{
    partial class Form1
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
            btnEvents = new Button();
            btnAlbums = new Button();
            SuspendLayout();
            // 
            // btnEvents
            // 
            btnEvents.Font = new Font("Segoe UI", 30F);
            btnEvents.Location = new Point(182, 79);
            btnEvents.Name = "btnEvents";
            btnEvents.Size = new Size(413, 70);
            btnEvents.TabIndex = 0;
            btnEvents.Text = "Events";
            btnEvents.UseVisualStyleBackColor = true;
            btnEvents.Click += btnEvents_Click;
            // 
            // btnAlbums
            // 
            btnAlbums.Font = new Font("Segoe UI", 30F);
            btnAlbums.Location = new Point(182, 176);
            btnAlbums.Name = "btnAlbums";
            btnAlbums.Size = new Size(413, 70);
            btnAlbums.TabIndex = 1;
            btnAlbums.Text = "Albums";
            btnAlbums.UseVisualStyleBackColor = true;
            btnAlbums.Click += btnAlbums_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAlbums);
            Controls.Add(btnEvents);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEvents;
        private Button btnAlbums;
    }
}
