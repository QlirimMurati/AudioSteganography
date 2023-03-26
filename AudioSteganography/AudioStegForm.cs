using System.Security.Cryptography;
using System.Windows.Forms;

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
                RSAParameters publicKey = AudioSteganography.ReadPublicKeyFromXmlFile(txtPublicKeyEncode.Text);
                var encoded = await AudioSteganography.Encrypt("test encrypt", publicKey);
                File.WriteAllBytes(@"C:\Users\Liri\Desktop\Tema\encryptedTest.txt", encoded);
            }
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {

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
                var message = File.ReadAllBytes(@"C:\Users\Liri\Desktop\Tema\encryptedTest.txt");
                RSAParameters privateKey = AudioSteganography.ReadPrivateKeyFromXmlFile(txtPrivateKeyDecode.Text);
                var decoded = await AudioSteganography.Decrypt(message, privateKey);
                txtAreaDecode.Text = decoded;
            }
        }

        private void btnResetEncode_Click(object sender, EventArgs e)
        {
            txtAudioPathEncode.Text = "";
            txtTextFilePathEncode.Text = "";
            txtAreaEncode.Text = "";
            txtPublicKeyEncode.Text = "";
        }

        private void btnResetDecode_Click(object sender, EventArgs e)
        {
            txtAudioPathDecode.Text = "";
            txtPrivateKeyDecode.Text = "";
            txtAreaDecode.Text = "";
        }

    }
}