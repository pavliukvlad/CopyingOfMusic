namespace CopyingOfMusic
{
    partial class MainForm
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
            this.btnChooseDirectoryTo = new System.Windows.Forms.Button();
            this.btnDirectoryFrom = new System.Windows.Forms.Button();
            this.progressCopying = new System.Windows.Forms.ProgressBar();
            this.songName = new System.Windows.Forms.TextBox();
            this.btnCopyMusic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChooseDirectoryTo
            // 
            this.btnChooseDirectoryTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChooseDirectoryTo.Location = new System.Drawing.Point(12, 396);
            this.btnChooseDirectoryTo.Name = "btnChooseDirectoryTo";
            this.btnChooseDirectoryTo.Size = new System.Drawing.Size(313, 23);
            this.btnChooseDirectoryTo.TabIndex = 13;
            this.btnChooseDirectoryTo.Text = "Choose Directory To";
            this.btnChooseDirectoryTo.UseVisualStyleBackColor = true;
            this.btnChooseDirectoryTo.Click += new System.EventHandler(this.btnChooseDirectoryTo_Click);
            // 
            // btnDirectoryFrom
            // 
            this.btnDirectoryFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDirectoryFrom.Location = new System.Drawing.Point(12, 367);
            this.btnDirectoryFrom.Name = "btnDirectoryFrom";
            this.btnDirectoryFrom.Size = new System.Drawing.Size(313, 23);
            this.btnDirectoryFrom.TabIndex = 12;
            this.btnDirectoryFrom.Text = "Choose Directory From";
            this.btnDirectoryFrom.UseVisualStyleBackColor = true;
            this.btnDirectoryFrom.Click += new System.EventHandler(this.btnDirectoryFrom_Click);
            // 
            // progressCopying
            // 
            this.progressCopying.Location = new System.Drawing.Point(12, 338);
            this.progressCopying.Name = "progressCopying";
            this.progressCopying.Size = new System.Drawing.Size(313, 23);
            this.progressCopying.TabIndex = 11;
            // 
            // songName
            // 
            this.songName.Location = new System.Drawing.Point(12, 12);
            this.songName.Multiline = true;
            this.songName.Name = "songName";
            this.songName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.songName.Size = new System.Drawing.Size(313, 320);
            this.songName.TabIndex = 10;
            // 
            // btnCopyMusic
            // 
            this.btnCopyMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopyMusic.Location = new System.Drawing.Point(79, 434);
            this.btnCopyMusic.Name = "btnCopyMusic";
            this.btnCopyMusic.Size = new System.Drawing.Size(170, 33);
            this.btnCopyMusic.TabIndex = 9;
            this.btnCopyMusic.Text = "Copy Music";
            this.btnCopyMusic.UseVisualStyleBackColor = true;
            this.btnCopyMusic.Click += new System.EventHandler(this.btnCopyMusic_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 475);
            this.Controls.Add(this.btnChooseDirectoryTo);
            this.Controls.Add(this.btnDirectoryFrom);
            this.Controls.Add(this.progressCopying);
            this.Controls.Add(this.songName);
            this.Controls.Add(this.btnCopyMusic);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseDirectoryTo;
        private System.Windows.Forms.Button btnDirectoryFrom;
        private System.Windows.Forms.ProgressBar progressCopying;
        private System.Windows.Forms.TextBox songName;
        private System.Windows.Forms.Button btnCopyMusic;
    }
}

