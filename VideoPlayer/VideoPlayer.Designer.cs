namespace VideoPlayer
{
    partial class VideoPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlayer));
            this.btn_SelectVideo = new System.Windows.Forms.Button();
            this.tb_FileLocation = new System.Windows.Forms.TextBox();
            this.btn_StopVideo = new System.Windows.Forms.Button();
            this.btn_PlayVideo = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.player_VideoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPlayerFullScreen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_VideoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SelectVideo
            // 
            this.btn_SelectVideo.Location = new System.Drawing.Point(518, 12);
            this.btn_SelectVideo.Name = "btn_SelectVideo";
            this.btn_SelectVideo.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectVideo.TabIndex = 1;
            this.btn_SelectVideo.Text = "Select Video File";
            this.btn_SelectVideo.UseVisualStyleBackColor = true;
            this.btn_SelectVideo.Click += new System.EventHandler(this.btn_SelectVideo_Click);
            // 
            // tb_FileLocation
            // 
            this.tb_FileLocation.Enabled = false;
            this.tb_FileLocation.Location = new System.Drawing.Point(12, 12);
            this.tb_FileLocation.Name = "tb_FileLocation";
            this.tb_FileLocation.Size = new System.Drawing.Size(499, 20);
            this.tb_FileLocation.TabIndex = 2;
            // 
            // btn_StopVideo
            // 
            this.btn_StopVideo.Location = new System.Drawing.Point(518, 388);
            this.btn_StopVideo.Name = "btn_StopVideo";
            this.btn_StopVideo.Size = new System.Drawing.Size(75, 23);
            this.btn_StopVideo.TabIndex = 3;
            this.btn_StopVideo.Text = "Stop";
            this.btn_StopVideo.UseVisualStyleBackColor = true;
            this.btn_StopVideo.Click += new System.EventHandler(this.btn_StopVideo_Click);
            // 
            // btn_PlayVideo
            // 
            this.btn_PlayVideo.Location = new System.Drawing.Point(13, 388);
            this.btn_PlayVideo.Name = "btn_PlayVideo";
            this.btn_PlayVideo.Size = new System.Drawing.Size(75, 23);
            this.btn_PlayVideo.TabIndex = 4;
            this.btn_PlayVideo.Text = "Play";
            this.btn_PlayVideo.UseVisualStyleBackColor = true;
            this.btn_PlayVideo.Click += new System.EventHandler(this.btn_PlayVideo_Click);
            // 
            // player_VideoPlayer
            // 
            this.player_VideoPlayer.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.player_VideoPlayer.Enabled = true;
            this.player_VideoPlayer.Location = new System.Drawing.Point(12, 38);
            this.player_VideoPlayer.Name = "player_VideoPlayer";
            this.player_VideoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player_VideoPlayer.OcxState")));
            this.player_VideoPlayer.Size = new System.Drawing.Size(580, 344);
            this.player_VideoPlayer.TabIndex = 5;
            // 
            // btnPlayerFullScreen
            // 
            this.btnPlayerFullScreen.Location = new System.Drawing.Point(263, 388);
            this.btnPlayerFullScreen.Name = "btnPlayerFullScreen";
            this.btnPlayerFullScreen.Size = new System.Drawing.Size(75, 23);
            this.btnPlayerFullScreen.TabIndex = 4;
            this.btnPlayerFullScreen.Text = "Full Screen";
            this.btnPlayerFullScreen.UseVisualStyleBackColor = true;
            this.btnPlayerFullScreen.Click += new System.EventHandler(this.btnPlayerFullScreen_Click);
            // 
            // VideoPlayer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 422);
            this.Controls.Add(this.player_VideoPlayer);
            this.Controls.Add(this.btnPlayerFullScreen);
            this.Controls.Add(this.btn_PlayVideo);
            this.Controls.Add(this.btn_StopVideo);
            this.Controls.Add(this.tb_FileLocation);
            this.Controls.Add(this.btn_SelectVideo);
            this.Name = "VideoPlayer";
            this.Text = "Video Player";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_VideoPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_SelectVideo;
        private System.Windows.Forms.TextBox tb_FileLocation;
        private System.Windows.Forms.Button btn_StopVideo;
        private System.Windows.Forms.Button btn_PlayVideo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AxWMPLib.AxWindowsMediaPlayer player_VideoPlayer;
        private System.Windows.Forms.Button btnPlayerFullScreen;
    }
}

