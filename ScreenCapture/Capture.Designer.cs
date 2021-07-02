namespace encoder_Alpha
{
    partial class Capture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Capture));
            this.StrtRecording = new System.Windows.Forms.Button();
            this.StopRecoding = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Play = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openTextbox = new System.Windows.Forms.TextBox();
            this.Player = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browseSave = new System.Windows.Forms.Button();
            this.savetextbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.browseOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.Player.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StrtRecording
            // 
            this.StrtRecording.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.StrtRecording.Location = new System.Drawing.Point(581, 11);
            this.StrtRecording.Name = "StrtRecording";
            this.StrtRecording.Size = new System.Drawing.Size(119, 34);
            this.StrtRecording.TabIndex = 0;
            this.StrtRecording.Text = "Start Recording";
            this.StrtRecording.UseVisualStyleBackColor = true;
            this.StrtRecording.Click += new System.EventHandler(this.StrtRecording_Click);
            // 
            // StopRecoding
            // 
            this.StopRecoding.ForeColor = System.Drawing.Color.Crimson;
            this.StopRecoding.Location = new System.Drawing.Point(581, 65);
            this.StopRecoding.Name = "StopRecoding";
            this.StopRecoding.Size = new System.Drawing.Size(119, 33);
            this.StopRecoding.TabIndex = 1;
            this.StopRecoding.Text = "Stop Recording";
            this.StopRecoding.UseVisualStyleBackColor = true;
            this.StopRecoding.Click += new System.EventHandler(this.StopRecoding_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 237);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1083, 505);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(581, 17);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(119, 32);
            this.Play.TabIndex = 6;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // openTextbox
            // 
            this.openTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openTextbox.Location = new System.Drawing.Point(19, 17);
            this.openTextbox.Multiline = true;
            this.openTextbox.Name = "openTextbox";
            this.openTextbox.Size = new System.Drawing.Size(404, 26);
            this.openTextbox.TabIndex = 7;
            // 
            // Player
            // 
            this.Player.Controls.Add(this.openTextbox);
            this.Player.Controls.Add(this.Play);
            this.Player.Controls.Add(this.browseOpen);
            this.Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player.Location = new System.Drawing.Point(328, 128);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(743, 55);
            this.Player.TabIndex = 14;
            this.Player.TabStop = false;
            this.Player.Text = "Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(593, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Recording......";
            // 
            // browseSave
            // 
            this.browseSave.Location = new System.Drawing.Point(445, 43);
            this.browseSave.Name = "browseSave";
            this.browseSave.Size = new System.Drawing.Size(106, 33);
            this.browseSave.TabIndex = 10;
            this.browseSave.Text = "Browse";
            this.browseSave.UseVisualStyleBackColor = true;
            this.browseSave.Click += new System.EventHandler(this.browseSave_Click);
            // 
            // savetextbox
            // 
            this.savetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savetextbox.Location = new System.Drawing.Point(18, 47);
            this.savetextbox.Multiline = true;
            this.savetextbox.Name = "savetextbox";
            this.savetextbox.Size = new System.Drawing.Size(405, 28);
            this.savetextbox.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.StopRecoding);
            this.groupBox1.Controls.Add(this.StrtRecording);
            this.groupBox1.Controls.Add(this.savetextbox);
            this.groupBox1.Controls.Add(this.browseSave);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(328, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 105);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Screen Recording";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(568, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Double Click On the Player to Get Full Size Video";
            // 
            // browseOpen
            // 
            this.browseOpen.Location = new System.Drawing.Point(445, 11);
            this.browseOpen.Name = "browseOpen";
            this.browseOpen.Size = new System.Drawing.Size(106, 32);
            this.browseOpen.TabIndex = 8;
            this.browseOpen.Text = "Open";
            this.browseOpen.UseVisualStyleBackColor = true;
            this.browseOpen.Click += new System.EventHandler(this.browseOpen_Click);
            // 
            // Capture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 742);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Capture";
            this.Text = "SeshScreen Recorder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Capture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.Player.ResumeLayout(false);
            this.Player.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StrtRecording;
        private System.Windows.Forms.Button StopRecoding;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox openTextbox;
        private System.Windows.Forms.GroupBox Player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox savetextbox;
        private System.Windows.Forms.Button browseSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseOpen;
    }
}

