
namespace Height_Map_Generator
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
            this.components = new System.ComponentModel.Container();
            this.RedChannel = new System.Windows.Forms.CheckBox();
            this.GreenChannel = new System.Windows.Forms.CheckBox();
            this.BlueChannel = new System.Windows.Forms.CheckBox();
            this.filePath = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.InputPicture = new System.Windows.Forms.PictureBox();
            this.GenerateImage = new System.Windows.Forms.Button();
            this.OutputPicture = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TickTimer = new System.Windows.Forms.Timer(this.components);
            this.InverseChannels = new System.Windows.Forms.CheckBox();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InputPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // RedChannel
            // 
            this.RedChannel.AutoSize = true;
            this.RedChannel.Location = new System.Drawing.Point(12, 13);
            this.RedChannel.Name = "RedChannel";
            this.RedChannel.Size = new System.Drawing.Size(45, 17);
            this.RedChannel.TabIndex = 0;
            this.RedChannel.Text = "Red";
            this.RedChannel.UseVisualStyleBackColor = true;
            // 
            // GreenChannel
            // 
            this.GreenChannel.AutoSize = true;
            this.GreenChannel.Location = new System.Drawing.Point(63, 13);
            this.GreenChannel.Name = "GreenChannel";
            this.GreenChannel.Size = new System.Drawing.Size(55, 17);
            this.GreenChannel.TabIndex = 1;
            this.GreenChannel.Text = "Green";
            this.GreenChannel.UseVisualStyleBackColor = true;
            // 
            // BlueChannel
            // 
            this.BlueChannel.AutoSize = true;
            this.BlueChannel.Location = new System.Drawing.Point(124, 12);
            this.BlueChannel.Name = "BlueChannel";
            this.BlueChannel.Size = new System.Drawing.Size(46, 17);
            this.BlueChannel.TabIndex = 2;
            this.BlueChannel.Text = "Blue";
            this.BlueChannel.UseVisualStyleBackColor = true;
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(12, 36);
            this.filePath.Name = "filePath";
            this.filePath.ReadOnly = true;
            this.filePath.Size = new System.Drawing.Size(680, 20);
            this.filePath.TabIndex = 3;
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(698, 33);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 4;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.BrowseClicked);
            // 
            // InputPicture
            // 
            this.InputPicture.Cursor = System.Windows.Forms.Cursors.No;
            this.InputPicture.Location = new System.Drawing.Point(12, 62);
            this.InputPicture.Name = "InputPicture";
            this.InputPicture.Size = new System.Drawing.Size(480, 270);
            this.InputPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InputPicture.TabIndex = 5;
            this.InputPicture.TabStop = false;
            // 
            // GenerateImage
            // 
            this.GenerateImage.Location = new System.Drawing.Point(498, 62);
            this.GenerateImage.Name = "GenerateImage";
            this.GenerateImage.Size = new System.Drawing.Size(75, 271);
            this.GenerateImage.TabIndex = 6;
            this.GenerateImage.Text = "Generate";
            this.GenerateImage.UseVisualStyleBackColor = true;
            this.GenerateImage.Click += new System.EventHandler(this.GenerateImage_Click);
            // 
            // OutputPicture
            // 
            this.OutputPicture.Cursor = System.Windows.Forms.Cursors.No;
            this.OutputPicture.Location = new System.Drawing.Point(579, 63);
            this.OutputPicture.Name = "OutputPicture";
            this.OutputPicture.Size = new System.Drawing.Size(480, 270);
            this.OutputPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OutputPicture.TabIndex = 7;
            this.OutputPicture.TabStop = false;
            this.OutputPicture.Click += new System.EventHandler(this.OutputPicture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // TickTimer
            // 
            this.TickTimer.Enabled = true;
            this.TickTimer.Interval = 50;
            this.TickTimer.Tick += new System.EventHandler(this.Tick);
            // 
            // InverseChannels
            // 
            this.InverseChannels.AutoSize = true;
            this.InverseChannels.Location = new System.Drawing.Point(176, 13);
            this.InverseChannels.Name = "InverseChannels";
            this.InverseChannels.Size = new System.Drawing.Size(63, 17);
            this.InverseChannels.TabIndex = 8;
            this.InverseChannels.Text = "Inverse";
            this.InverseChannels.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(779, 34);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 9;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.SaveResult);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 344);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.InverseChannels);
            this.Controls.Add(this.OutputPicture);
            this.Controls.Add(this.GenerateImage);
            this.Controls.Add(this.InputPicture);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.BlueChannel);
            this.Controls.Add(this.GreenChannel);
            this.Controls.Add(this.RedChannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Height Map Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InputPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox RedChannel;
        private System.Windows.Forms.CheckBox GreenChannel;
        private System.Windows.Forms.CheckBox BlueChannel;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.PictureBox InputPicture;
        private System.Windows.Forms.Button GenerateImage;
        private System.Windows.Forms.PictureBox OutputPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer TickTimer;
        private System.Windows.Forms.CheckBox InverseChannels;
        private System.Windows.Forms.Button Save;
    }
}

