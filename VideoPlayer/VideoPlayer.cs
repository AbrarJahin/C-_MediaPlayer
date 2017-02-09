using System;
using System.Windows.Forms;
using WMPLib;

namespace VideoPlayer
{
    public partial class VideoPlayer : Form
    {
        public VideoPlayer()
        {
            InitializeComponent();
            player_VideoPlayer.uiMode = "none";
        }

        private void btn_SelectVideo_Click(object sender, EventArgs e)
        {
            tb_FileLocation.Text = "OK";

            var openVideoFileDialogue = new OpenFileDialog();
            openVideoFileDialogue.Filter = "Media File|*.mp3;*.wav;*.mp4;*.3gp;*.avi;*.mov;*.flv;*.wmv;*.mpg|all files|*.*";

            if (openVideoFileDialogue.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("No Video Selected");
            }
            else
            {
                tb_FileLocation.Text = openVideoFileDialogue.FileName;
                player_VideoPlayer.URL=tb_FileLocation.Text;
                player_VideoPlayer.Ctlcontrols.play();
                btn_PlayVideo.Text = "Pause";
            }
        }

        private void btn_PlayVideo_Click(object sender, EventArgs e)
        {
            if (player_VideoPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                player_VideoPlayer.Ctlcontrols.pause();
                btn_PlayVideo.Text = "Play";
            }
            else
            {
                player_VideoPlayer.Ctlcontrols.play();
                btn_PlayVideo.Text = "Pause";
            }
        }

        private void btn_StopVideo_Click(object sender, EventArgs e)
        {
            player_VideoPlayer.Ctlcontrols.stop();
            btn_PlayVideo.Text = "Play";
        }

        private void btnPlayerFullScreen_Click(object sender, EventArgs e)
        {
            if (player_VideoPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                player_VideoPlayer.fullScreen = true;
            }
        }
    }
}
