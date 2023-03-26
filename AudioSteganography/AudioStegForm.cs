using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AudioSteganography
{
    public partial class AudioStegForm : Form
    {
        public AudioStegForm()
        {
            InitializeComponent();
            main();
        }

        private void main()
        {
            radioTextFileEncode.Checked = true;
            txtAreaEncode.Enabled = false;
        }

        private void btnUploadAudioEncode_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Wave Audio Files (*.wav)|*.wav";
            dialog.Title = "Select a Wave Audio File";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtAudioPathEncode.Text = dialog.FileName;
            }
        }

        private void btnUploadTextFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files (.txt)|*.txt";
            dialog.Title = "Select a Text File";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtTextFilePathEncode.Text = dialog.FileName;
            }
        }

        private void radioEncodingType_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton encodingChoice = (RadioButton)sender;

            if(encodingChoice.Checked)
            {
                if(encodingChoice.Text == "Text")
                {
                    txtAreaEncode.Enabled = true;
                    txtTextFilePathEncode.Enabled = false;
                    btnUploadTextFileEncode.Enabled = false;
                }
                else
                {
                    txtTextFilePathEncode.Enabled = true;
                    btnUploadTextFileEncode.Enabled = true;
                    txtAreaEncode.Enabled = false;
                }
            }
        }

        private async void btnUploadPublicKeyEncode_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Public Key (.xml)|*.xml";
            dialog.Title = "Select a Public Key";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtPublicKeyEncode.Text = dialog.FileName;
            }
        }

        private async void btnEncode_Click(object sender, EventArgs e)
        {
            progressEncode.Value = 0;

            byte[] audioData = File.ReadAllBytes(txtAudioPathEncode.Text);
            string textData = File.ReadAllText(txtTextFilePathEncode.Text);

            if (!AudioSteganography.IsValidWavFile(audioData))
            {
                MessageBox.Show("Invalid WAV file.");
                return;
            }

            RSAParameters publicKey = AudioSteganography.ReadPublicKeyFromXmlFile(txtPublicKeyEncode.Text);
            progressEncode.Value = 25; 

            byte[] encryptedText = await AudioSteganography.EncryptMessage(textData, publicKey);
            progressEncode.Value = 50;

            byte[] encodedAudioData = AudioSteganography.EncodeAudio(audioData, encryptedText);
            progressEncode.Value = 75;

            if (encodedAudioData != null)
            {
                SaveFileDialog dialog = new();
                dialog.Filter = "Wave Audio Files (*.wav)|*.wav";
                dialog.Title = "Select a Wave Audio File";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(dialog.FileName, encodedAudioData);
                    progressEncode.Value = 100;
                    MessageBox.Show("Audio encoded and saved successfully");
                }
            }
            else
            {
                progressDecode.Value = 0;
                MessageBox.Show("Encoding failed. The message might be too large for the audio file.");
            }
        }


        private void btnUploadAudioDecode_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Wave Audio Files (*.wav)|*.wav";
            dialog.Title = "Select a Wave Audio File";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtAudioPathDecode.Text = dialog.FileName;
            }
        }


        private async void btnUploadPrivateKeyDecode_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Private Key (.xml)|*.xml";
            dialog.Title = "Select a Private Key";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtPrivateKeyDecode.Text = dialog.FileName;
            }
        }

        private async void btnDecode_Click(object sender, EventArgs e)
        {
            progressDecode.Value = 0;

            byte[] encodedAudioData = File.ReadAllBytes(txtAudioPathDecode.Text);

            if (!AudioSteganography.IsValidWavFile(encodedAudioData))
            {
                MessageBox.Show("Invalid WAV file.");
                return;
            }

            RSAParameters privateKey = AudioSteganography.ReadPrivateKeyFromXmlFile(txtPrivateKeyDecode.Text);
            progressDecode.Value = 25;

            byte[] decodedTextFromAudio = AudioSteganography.DecodeAudio(encodedAudioData);
            progressDecode.Value = 50;

            string decryptedText = await AudioSteganography.DecryptMessage(decodedTextFromAudio, privateKey);
            progressDecode.Value = 75;

            if (decryptedText != null)
            {
                SaveFileDialog dialog = new();
                dialog.Filter = "Text Files (.txt)|*.txt";
                dialog.Title = "Select a Text File";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtAreaDecode.Text = decryptedText;
                    File.WriteAllText(dialog.FileName, decryptedText);
                    progressDecode.Value = 100;
                    MessageBox.Show("Audio is decoded and message was saved successfully");
                }
            }
            else
            {
                MessageBox.Show("Decoding failed. There might be something wrong with the audio file!");
            }
        }

        private void btnResetEncode_Click(object sender, EventArgs e)
        {
            txtAudioPathEncode.Text = "";
            txtTextFilePathEncode.Text = "";
            txtAreaEncode.Text = "";
            txtPublicKeyEncode.Text = "";
            progressEncode.Value = 0;
        }

        private void btnResetDecode_Click(object sender, EventArgs e)
        {
            txtAudioPathDecode.Text = "";
            txtPrivateKeyDecode.Text = "";
            txtAreaDecode.Text = "";
            progressDecode.Value = 0;
        }

    }
}