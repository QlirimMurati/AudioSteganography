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
    }
}