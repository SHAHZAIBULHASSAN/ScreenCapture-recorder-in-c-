using System;
using System.Linq;
using System.Windows.Forms;
using encoder_Alpha.Properties;
using Microsoft.Expression.Encoder.Devices;
using Microsoft.Expression.Encoder.Profiles;
using Microsoft.Expression.Encoder.ScreenCapture;

namespace encoder_Alpha
{
    public partial class Capture : Form
    {
        private string _savename;
        private string _openname;
        readonly ScreenCaptureJob _job = new ScreenCaptureJob();
        public Capture()
        {
            InitializeComponent();
        }

        private void StopRecoding_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            _job.Stop();
        }
        public void StrtRecording_Click(object sender, EventArgs e)
       {
            try
            {
                _savename = savetextbox.Text;
                _job.OutputPath = _savename;
                label1.Visible = true;
                const string fileName = "ScreenCapture";
                _job.OutputScreenCaptureFileName = _savename + @"\" + fileName + "_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".xesc";
                var audioDevices = EncoderDevices.FindDevices(EncoderDeviceType.Audio);
                for (var deviceCount = 1; deviceCount <= audioDevices.Count; deviceCount++)
                {
                    var id = deviceCount - 1;
                    _job.AddAudioDeviceSource(audioDevices.ElementAt(id));
                }
                _job.ScreenCaptureVideoProfile = new ScreenCaptureVideoProfile();
                _job.ScreenCaptureVideoProfile.AutoFit = true;
                _job.ScreenCaptureVideoProfile.Quality = 25;
                _job.ScreenCaptureVideoProfile.FrameRate = 12;
                _job.Start();
            }
            catch(Exception)
            {
                MessageBox.Show(Resources.Capture_StrtRecording_Click_Please_Enter_the_Valid_Output_Path);
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            openTextbox.Text = _openname;
            axWindowsMediaPlayer1.URL = _openname;
            axWindowsMediaPlayer1.Show();           
        }

        private void browseOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = Resources.Form1_Browse_Click_xesc___xesc;
            openFileDialog1.ShowDialog();
            _openname = openFileDialog1.FileName;
            openTextbox.Text = _openname;
        }

        private void browseSave_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            _savename = folderBrowserDialog1.SelectedPath;
            savetextbox.Text = _savename;
        }

        private void Capture_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
