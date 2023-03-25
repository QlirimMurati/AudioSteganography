namespace AudioSteganography
{
    partial class AudioStegForm
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
            this.decodeTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblSecretKeyEncode = new System.Windows.Forms.Label();
            this.txtSecretKeyEncode = new System.Windows.Forms.TextBox();
            this.lblTextToEncode = new System.Windows.Forms.Label();
            this.lblAudioFileEncode = new System.Windows.Forms.Label();
            this.txtTextFilePathEncode = new System.Windows.Forms.TextBox();
            this.btnUploadTextFileEncode = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            this.radioTextFileEncode = new System.Windows.Forms.RadioButton();
            this.radioTextEncode = new System.Windows.Forms.RadioButton();
            this.txtAreaEncode = new System.Windows.Forms.TextBox();
            this.txtAudioPathEncode = new System.Windows.Forms.TextBox();
            this.progressEncode = new System.Windows.Forms.ProgressBar();
            this.btnUploadAudioEncode = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSecretKeyDecode = new System.Windows.Forms.Label();
            this.txtSecretKeyDecode = new System.Windows.Forms.TextBox();
            this.lblDecodedText = new System.Windows.Forms.Label();
            this.lblAudioFileDecode = new System.Windows.Forms.Label();
            this.btnDecode = new System.Windows.Forms.Button();
            this.txtAreaDecode = new System.Windows.Forms.TextBox();
            this.progressDecode = new System.Windows.Forms.ProgressBar();
            this.txtAudioPathDecode = new System.Windows.Forms.TextBox();
            this.btnUploadAudioDecode = new System.Windows.Forms.Button();
            this.decodeTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // decodeTab
            // 
            this.decodeTab.Controls.Add(this.tabPage1);
            this.decodeTab.Controls.Add(this.tabPage2);
            this.decodeTab.Location = new System.Drawing.Point(-1, 2);
            this.decodeTab.Name = "decodeTab";
            this.decodeTab.SelectedIndex = 0;
            this.decodeTab.Size = new System.Drawing.Size(429, 465);
            this.decodeTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblSecretKeyEncode);
            this.tabPage1.Controls.Add(this.txtSecretKeyEncode);
            this.tabPage1.Controls.Add(this.lblTextToEncode);
            this.tabPage1.Controls.Add(this.lblAudioFileEncode);
            this.tabPage1.Controls.Add(this.txtTextFilePathEncode);
            this.tabPage1.Controls.Add(this.btnUploadTextFileEncode);
            this.tabPage1.Controls.Add(this.btnEncode);
            this.tabPage1.Controls.Add(this.radioTextFileEncode);
            this.tabPage1.Controls.Add(this.radioTextEncode);
            this.tabPage1.Controls.Add(this.txtAreaEncode);
            this.tabPage1.Controls.Add(this.txtAudioPathEncode);
            this.tabPage1.Controls.Add(this.progressEncode);
            this.tabPage1.Controls.Add(this.btnUploadAudioEncode);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(421, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblSecretKeyEncode
            // 
            this.lblSecretKeyEncode.AutoSize = true;
            this.lblSecretKeyEncode.Location = new System.Drawing.Point(9, 309);
            this.lblSecretKeyEncode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecretKeyEncode.Name = "lblSecretKeyEncode";
            this.lblSecretKeyEncode.Size = new System.Drawing.Size(60, 15);
            this.lblSecretKeyEncode.TabIndex = 12;
            this.lblSecretKeyEncode.Text = "Secret key";
            // 
            // txtSecretKeyEncode
            // 
            this.txtSecretKeyEncode.Location = new System.Drawing.Point(8, 327);
            this.txtSecretKeyEncode.Name = "txtSecretKeyEncode";
            this.txtSecretKeyEncode.Size = new System.Drawing.Size(402, 23);
            this.txtSecretKeyEncode.TabIndex = 11;
            // 
            // lblTextToEncode
            // 
            this.lblTextToEncode.AutoSize = true;
            this.lblTextToEncode.Location = new System.Drawing.Point(10, 125);
            this.lblTextToEncode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTextToEncode.Name = "lblTextToEncode";
            this.lblTextToEncode.Size = new System.Drawing.Size(84, 15);
            this.lblTextToEncode.TabIndex = 10;
            this.lblTextToEncode.Text = "Text to encode";
            // 
            // lblAudioFileEncode
            // 
            this.lblAudioFileEncode.AutoSize = true;
            this.lblAudioFileEncode.Location = new System.Drawing.Point(10, 5);
            this.lblAudioFileEncode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAudioFileEncode.Name = "lblAudioFileEncode";
            this.lblAudioFileEncode.Size = new System.Drawing.Size(58, 15);
            this.lblAudioFileEncode.TabIndex = 9;
            this.lblAudioFileEncode.Text = "Audio file";
            // 
            // txtTextFilePathEncode
            // 
            this.txtTextFilePathEncode.Location = new System.Drawing.Point(9, 85);
            this.txtTextFilePathEncode.Multiline = true;
            this.txtTextFilePathEncode.Name = "txtTextFilePathEncode";
            this.txtTextFilePathEncode.Size = new System.Drawing.Size(285, 28);
            this.txtTextFilePathEncode.TabIndex = 8;
            // 
            // btnUploadTextFileEncode
            // 
            this.btnUploadTextFileEncode.Location = new System.Drawing.Point(298, 85);
            this.btnUploadTextFileEncode.Name = "btnUploadTextFileEncode";
            this.btnUploadTextFileEncode.Size = new System.Drawing.Size(112, 28);
            this.btnUploadTextFileEncode.TabIndex = 7;
            this.btnUploadTextFileEncode.Text = "Text file";
            this.btnUploadTextFileEncode.UseVisualStyleBackColor = true;
            this.btnUploadTextFileEncode.Click += new System.EventHandler(this.btnUploadTextFile_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(299, 403);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(112, 28);
            this.btnEncode.TabIndex = 6;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            // 
            // radioTextFileEncode
            // 
            this.radioTextFileEncode.AutoSize = true;
            this.radioTextFileEncode.Location = new System.Drawing.Point(10, 58);
            this.radioTextFileEncode.Name = "radioTextFileEncode";
            this.radioTextFileEncode.Size = new System.Drawing.Size(62, 19);
            this.radioTextFileEncode.TabIndex = 5;
            this.radioTextFileEncode.TabStop = true;
            this.radioTextFileEncode.Text = "Textfile";
            this.radioTextFileEncode.UseVisualStyleBackColor = true;
            this.radioTextFileEncode.CheckedChanged += new System.EventHandler(this.radioEncodingType_CheckedChanged);
            // 
            // radioTextEncode
            // 
            this.radioTextEncode.AutoSize = true;
            this.radioTextEncode.Location = new System.Drawing.Point(76, 58);
            this.radioTextEncode.Name = "radioTextEncode";
            this.radioTextEncode.Size = new System.Drawing.Size(46, 19);
            this.radioTextEncode.TabIndex = 4;
            this.radioTextEncode.TabStop = true;
            this.radioTextEncode.Text = "Text";
            this.radioTextEncode.UseVisualStyleBackColor = true;
            this.radioTextEncode.CheckedChanged += new System.EventHandler(this.radioEncodingType_CheckedChanged);
            // 
            // txtAreaEncode
            // 
            this.txtAreaEncode.Location = new System.Drawing.Point(9, 143);
            this.txtAreaEncode.Multiline = true;
            this.txtAreaEncode.Name = "txtAreaEncode";
            this.txtAreaEncode.Size = new System.Drawing.Size(402, 150);
            this.txtAreaEncode.TabIndex = 3;
            // 
            // txtAudioPathEncode
            // 
            this.txtAudioPathEncode.Location = new System.Drawing.Point(9, 22);
            this.txtAudioPathEncode.Multiline = true;
            this.txtAudioPathEncode.Name = "txtAudioPathEncode";
            this.txtAudioPathEncode.Size = new System.Drawing.Size(285, 28);
            this.txtAudioPathEncode.TabIndex = 2;
            // 
            // progressEncode
            // 
            this.progressEncode.Location = new System.Drawing.Point(8, 365);
            this.progressEncode.Name = "progressEncode";
            this.progressEncode.Size = new System.Drawing.Size(401, 20);
            this.progressEncode.TabIndex = 1;
            // 
            // btnUploadAudioEncode
            // 
            this.btnUploadAudioEncode.Location = new System.Drawing.Point(298, 22);
            this.btnUploadAudioEncode.Name = "btnUploadAudioEncode";
            this.btnUploadAudioEncode.Size = new System.Drawing.Size(112, 28);
            this.btnUploadAudioEncode.TabIndex = 0;
            this.btnUploadAudioEncode.Text = "Upload audio";
            this.btnUploadAudioEncode.UseVisualStyleBackColor = true;
            this.btnUploadAudioEncode.Click += new System.EventHandler(this.btnUploadAudioEncode_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblSecretKeyDecode);
            this.tabPage2.Controls.Add(this.txtSecretKeyDecode);
            this.tabPage2.Controls.Add(this.lblDecodedText);
            this.tabPage2.Controls.Add(this.lblAudioFileDecode);
            this.tabPage2.Controls.Add(this.btnDecode);
            this.tabPage2.Controls.Add(this.txtAreaDecode);
            this.tabPage2.Controls.Add(this.progressDecode);
            this.tabPage2.Controls.Add(this.txtAudioPathDecode);
            this.tabPage2.Controls.Add(this.btnUploadAudioDecode);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(421, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblSecretKeyDecode
            // 
            this.lblSecretKeyDecode.AutoSize = true;
            this.lblSecretKeyDecode.Location = new System.Drawing.Point(10, 60);
            this.lblSecretKeyDecode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecretKeyDecode.Name = "lblSecretKeyDecode";
            this.lblSecretKeyDecode.Size = new System.Drawing.Size(60, 15);
            this.lblSecretKeyDecode.TabIndex = 14;
            this.lblSecretKeyDecode.Text = "Secret key";
            // 
            // txtSecretKeyDecode
            // 
            this.txtSecretKeyDecode.Location = new System.Drawing.Point(9, 78);
            this.txtSecretKeyDecode.Name = "txtSecretKeyDecode";
            this.txtSecretKeyDecode.Size = new System.Drawing.Size(402, 23);
            this.txtSecretKeyDecode.TabIndex = 13;
            // 
            // lblDecodedText
            // 
            this.lblDecodedText.AutoSize = true;
            this.lblDecodedText.Location = new System.Drawing.Point(9, 115);
            this.lblDecodedText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDecodedText.Name = "lblDecodedText";
            this.lblDecodedText.Size = new System.Drawing.Size(77, 15);
            this.lblDecodedText.TabIndex = 11;
            this.lblDecodedText.Text = "Decoded text";
            // 
            // lblAudioFileDecode
            // 
            this.lblAudioFileDecode.AutoSize = true;
            this.lblAudioFileDecode.Location = new System.Drawing.Point(10, 5);
            this.lblAudioFileDecode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAudioFileDecode.Name = "lblAudioFileDecode";
            this.lblAudioFileDecode.Size = new System.Drawing.Size(58, 15);
            this.lblAudioFileDecode.TabIndex = 8;
            this.lblAudioFileDecode.Text = "Audio file";
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(297, 403);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(112, 28);
            this.btnDecode.TabIndex = 7;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            // 
            // txtAreaDecode
            // 
            this.txtAreaDecode.Location = new System.Drawing.Point(9, 133);
            this.txtAreaDecode.Multiline = true;
            this.txtAreaDecode.Name = "txtAreaDecode";
            this.txtAreaDecode.Size = new System.Drawing.Size(402, 215);
            this.txtAreaDecode.TabIndex = 6;
            // 
            // progressDecode
            // 
            this.progressDecode.Location = new System.Drawing.Point(9, 369);
            this.progressDecode.Name = "progressDecode";
            this.progressDecode.Size = new System.Drawing.Size(400, 20);
            this.progressDecode.TabIndex = 5;
            // 
            // txtAudioPathDecode
            // 
            this.txtAudioPathDecode.Location = new System.Drawing.Point(9, 22);
            this.txtAudioPathDecode.Multiline = true;
            this.txtAudioPathDecode.Name = "txtAudioPathDecode";
            this.txtAudioPathDecode.Size = new System.Drawing.Size(285, 28);
            this.txtAudioPathDecode.TabIndex = 4;
            // 
            // btnUploadAudioDecode
            // 
            this.btnUploadAudioDecode.Location = new System.Drawing.Point(297, 22);
            this.btnUploadAudioDecode.Name = "btnUploadAudioDecode";
            this.btnUploadAudioDecode.Size = new System.Drawing.Size(112, 28);
            this.btnUploadAudioDecode.TabIndex = 3;
            this.btnUploadAudioDecode.Text = "Upload audio";
            this.btnUploadAudioDecode.UseVisualStyleBackColor = true;
            // 
            // AudioStegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 465);
            this.Controls.Add(this.decodeTab);
            this.Name = "AudioStegForm";
            this.Text = "Form1";
            this.decodeTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl decodeTab;
        private TabPage tabPage1;
        private TextBox txtTextFilePathEncode;
        private Button btnUploadTextFileEncode;
        private Button btnEncode;
        private RadioButton radioTextFileEncode;
        private RadioButton radioTextEncode;
        private TextBox txtAreaEncode;
        private TextBox txtAudioPathEncode;
        private ProgressBar progressEncode;
        private Button btnUploadAudioEncode;
        private TabPage tabPage2;
        private Button btnDecode;
        private TextBox txtAreaDecode;
        private ProgressBar progressDecode;
        private TextBox txtAudioPathDecode;
        private Button btnUploadAudioDecode;
        private Label lblTextToEncode;
        private Label lblAudioFileEncode;
        private Label lblDecodedText;
        private Label lblAudioFileDecode;
        private Label lblSecretKeyEncode;
        private TextBox txtSecretKeyEncode;
        private Label lblSecretKeyDecode;
        private TextBox txtSecretKeyDecode;
    }
}