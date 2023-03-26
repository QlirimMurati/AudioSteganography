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
            this.btnUploadPublicKeyEncode = new System.Windows.Forms.Button();
            this.btnResetEncode = new System.Windows.Forms.Button();
            this.lblPublicKeyEncode = new System.Windows.Forms.Label();
            this.txtPublicKeyEncode = new System.Windows.Forms.TextBox();
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
            this.btnUploadPrivateKeyDecode = new System.Windows.Forms.Button();
            this.btnResetDecode = new System.Windows.Forms.Button();
            this.lblPrivateKeyDecode = new System.Windows.Forms.Label();
            this.txtPrivateKeyDecode = new System.Windows.Forms.TextBox();
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
            this.tabPage1.Controls.Add(this.btnUploadPublicKeyEncode);
            this.tabPage1.Controls.Add(this.btnResetEncode);
            this.tabPage1.Controls.Add(this.lblPublicKeyEncode);
            this.tabPage1.Controls.Add(this.txtPublicKeyEncode);
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
            // btnUploadPublicKeyEncode
            // 
            this.btnUploadPublicKeyEncode.Location = new System.Drawing.Point(298, 327);
            this.btnUploadPublicKeyEncode.Name = "btnUploadPublicKeyEncode";
            this.btnUploadPublicKeyEncode.Size = new System.Drawing.Size(112, 24);
            this.btnUploadPublicKeyEncode.TabIndex = 14;
            this.btnUploadPublicKeyEncode.Text = "Upload key";
            this.btnUploadPublicKeyEncode.UseVisualStyleBackColor = true;
            this.btnUploadPublicKeyEncode.Click += new System.EventHandler(this.btnUploadPublicKeyEncode_Click);
            // 
            // btnResetEncode
            // 
            this.btnResetEncode.Location = new System.Drawing.Point(182, 403);
            this.btnResetEncode.Name = "btnResetEncode";
            this.btnResetEncode.Size = new System.Drawing.Size(112, 28);
            this.btnResetEncode.TabIndex = 13;
            this.btnResetEncode.Text = "Reset";
            this.btnResetEncode.UseVisualStyleBackColor = true;
            this.btnResetEncode.Click += new System.EventHandler(this.btnResetEncode_Click);
            // 
            // lblPublicKeyEncode
            // 
            this.lblPublicKeyEncode.AutoSize = true;
            this.lblPublicKeyEncode.Location = new System.Drawing.Point(9, 309);
            this.lblPublicKeyEncode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPublicKeyEncode.Name = "lblPublicKeyEncode";
            this.lblPublicKeyEncode.Size = new System.Drawing.Size(61, 15);
            this.lblPublicKeyEncode.TabIndex = 12;
            this.lblPublicKeyEncode.Text = "Public key";
            // 
            // txtPublicKeyEncode
            // 
            this.txtPublicKeyEncode.Location = new System.Drawing.Point(8, 327);
            this.txtPublicKeyEncode.Name = "txtPublicKeyEncode";
            this.txtPublicKeyEncode.Size = new System.Drawing.Size(286, 23);
            this.txtPublicKeyEncode.TabIndex = 11;
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
            this.txtTextFilePathEncode.Name = "txtTextFilePathEncode";
            this.txtTextFilePathEncode.Size = new System.Drawing.Size(285, 23);
            this.txtTextFilePathEncode.TabIndex = 8;
            // 
            // btnUploadTextFileEncode
            // 
            this.btnUploadTextFileEncode.Location = new System.Drawing.Point(298, 85);
            this.btnUploadTextFileEncode.Name = "btnUploadTextFileEncode";
            this.btnUploadTextFileEncode.Size = new System.Drawing.Size(112, 24);
            this.btnUploadTextFileEncode.TabIndex = 7;
            this.btnUploadTextFileEncode.Text = "Upload txt";
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
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
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
            this.txtAudioPathEncode.Name = "txtAudioPathEncode";
            this.txtAudioPathEncode.Size = new System.Drawing.Size(285, 23);
            this.txtAudioPathEncode.TabIndex = 2;
            // 
            // progressEncode
            // 
            this.progressEncode.Location = new System.Drawing.Point(8, 365);
            this.progressEncode.Name = "progressEncode";
            this.progressEncode.Size = new System.Drawing.Size(401, 20);
            this.progressEncode.Step = 1;
            this.progressEncode.TabIndex = 1;
            // 
            // btnUploadAudioEncode
            // 
            this.btnUploadAudioEncode.Location = new System.Drawing.Point(297, 22);
            this.btnUploadAudioEncode.Name = "btnUploadAudioEncode";
            this.btnUploadAudioEncode.Size = new System.Drawing.Size(112, 24);
            this.btnUploadAudioEncode.TabIndex = 0;
            this.btnUploadAudioEncode.Text = "Upload audio";
            this.btnUploadAudioEncode.UseVisualStyleBackColor = true;
            this.btnUploadAudioEncode.Click += new System.EventHandler(this.btnUploadAudioEncode_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUploadPrivateKeyDecode);
            this.tabPage2.Controls.Add(this.btnResetDecode);
            this.tabPage2.Controls.Add(this.lblPrivateKeyDecode);
            this.tabPage2.Controls.Add(this.txtPrivateKeyDecode);
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
            // btnUploadPrivateKeyDecode
            // 
            this.btnUploadPrivateKeyDecode.Location = new System.Drawing.Point(297, 78);
            this.btnUploadPrivateKeyDecode.Name = "btnUploadPrivateKeyDecode";
            this.btnUploadPrivateKeyDecode.Size = new System.Drawing.Size(112, 24);
            this.btnUploadPrivateKeyDecode.TabIndex = 16;
            this.btnUploadPrivateKeyDecode.Text = "Upload key";
            this.btnUploadPrivateKeyDecode.UseVisualStyleBackColor = true;
            this.btnUploadPrivateKeyDecode.Click += new System.EventHandler(this.btnUploadPrivateKeyDecode_Click);
            // 
            // btnResetDecode
            // 
            this.btnResetDecode.Location = new System.Drawing.Point(182, 403);
            this.btnResetDecode.Name = "btnResetDecode";
            this.btnResetDecode.Size = new System.Drawing.Size(112, 28);
            this.btnResetDecode.TabIndex = 15;
            this.btnResetDecode.Text = "Reset";
            this.btnResetDecode.UseVisualStyleBackColor = true;
            this.btnResetDecode.Click += new System.EventHandler(this.btnResetDecode_Click);
            // 
            // lblPrivateKeyDecode
            // 
            this.lblPrivateKeyDecode.AutoSize = true;
            this.lblPrivateKeyDecode.Location = new System.Drawing.Point(10, 60);
            this.lblPrivateKeyDecode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrivateKeyDecode.Name = "lblPrivateKeyDecode";
            this.lblPrivateKeyDecode.Size = new System.Drawing.Size(64, 15);
            this.lblPrivateKeyDecode.TabIndex = 14;
            this.lblPrivateKeyDecode.Text = "Private key";
            // 
            // txtPrivateKeyDecode
            // 
            this.txtPrivateKeyDecode.Location = new System.Drawing.Point(9, 78);
            this.txtPrivateKeyDecode.Name = "txtPrivateKeyDecode";
            this.txtPrivateKeyDecode.Size = new System.Drawing.Size(285, 23);
            this.txtPrivateKeyDecode.TabIndex = 13;
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
            this.btnDecode.Location = new System.Drawing.Point(299, 403);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(112, 28);
            this.btnDecode.TabIndex = 7;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
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
            this.progressDecode.Location = new System.Drawing.Point(8, 365);
            this.progressDecode.Name = "progressDecode";
            this.progressDecode.Size = new System.Drawing.Size(400, 20);
            this.progressDecode.Step = 1;
            this.progressDecode.TabIndex = 5;
            // 
            // txtAudioPathDecode
            // 
            this.txtAudioPathDecode.Location = new System.Drawing.Point(9, 22);
            this.txtAudioPathDecode.Name = "txtAudioPathDecode";
            this.txtAudioPathDecode.Size = new System.Drawing.Size(285, 23);
            this.txtAudioPathDecode.TabIndex = 4;
            // 
            // btnUploadAudioDecode
            // 
            this.btnUploadAudioDecode.Location = new System.Drawing.Point(297, 22);
            this.btnUploadAudioDecode.Name = "btnUploadAudioDecode";
            this.btnUploadAudioDecode.Size = new System.Drawing.Size(112, 24);
            this.btnUploadAudioDecode.TabIndex = 3;
            this.btnUploadAudioDecode.Text = "Upload audio";
            this.btnUploadAudioDecode.UseVisualStyleBackColor = true;
            this.btnUploadAudioDecode.Click += new System.EventHandler(this.btnUploadAudioDecode_Click);
            // 
            // AudioStegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 465);
            this.Controls.Add(this.decodeTab);
            this.Name = "AudioStegForm";
            this.Text = "AudioSteganography";
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
        private Label lblPublicKeyEncode;
        private TextBox txtPublicKeyEncode;
        private Label lblSecretKeyDecode;
        private TextBox txtPrivateKeyDecode;
        private Button btnResetEncode;
        private Button btnResetDecode;
        private Button btnUploadPublicKeyEncode;
        private Button btnUploadPrivateKeyDecode;
        private Label lblPrivateKeyDecode;
    }
}