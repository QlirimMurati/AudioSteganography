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
            this.lblTextToEncode = new System.Windows.Forms.Label();
            this.lblAudioFileEncode = new System.Windows.Forms.Label();
            this.txtTextFilePath = new System.Windows.Forms.TextBox();
            this.btnUploadTextFile = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            this.radioTextFile = new System.Windows.Forms.RadioButton();
            this.radioText = new System.Windows.Forms.RadioButton();
            this.txtAreaEncode = new System.Windows.Forms.TextBox();
            this.txtAudioPathEncode = new System.Windows.Forms.TextBox();
            this.progressEncode = new System.Windows.Forms.ProgressBar();
            this.btnUploadAudioEncode = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblDecodedText = new System.Windows.Forms.Label();
            this.lblAudioFileDecode = new System.Windows.Forms.Label();
            this.btnDecode = new System.Windows.Forms.Button();
            this.txtAreaDecode = new System.Windows.Forms.TextBox();
            this.progressDecode = new System.Windows.Forms.ProgressBar();
            this.txtAudioPathDecode = new System.Windows.Forms.TextBox();
            this.btnUploadAudioDecode = new System.Windows.Forms.Button();
            this.lblSecretKey = new System.Windows.Forms.Label();
            this.txtAreaSecretKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.decodeTab.Size = new System.Drawing.Size(429, 499);
            this.decodeTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblSecretKey);
            this.tabPage1.Controls.Add(this.txtAreaSecretKey);
            this.tabPage1.Controls.Add(this.lblTextToEncode);
            this.tabPage1.Controls.Add(this.lblAudioFileEncode);
            this.tabPage1.Controls.Add(this.txtTextFilePath);
            this.tabPage1.Controls.Add(this.btnUploadTextFile);
            this.tabPage1.Controls.Add(this.btnEncode);
            this.tabPage1.Controls.Add(this.radioTextFile);
            this.tabPage1.Controls.Add(this.radioText);
            this.tabPage1.Controls.Add(this.txtAreaEncode);
            this.tabPage1.Controls.Add(this.txtAudioPathEncode);
            this.tabPage1.Controls.Add(this.progressEncode);
            this.tabPage1.Controls.Add(this.btnUploadAudioEncode);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(421, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encode";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // txtTextFilePath
            // 
            this.txtTextFilePath.Location = new System.Drawing.Point(9, 85);
            this.txtTextFilePath.Multiline = true;
            this.txtTextFilePath.Name = "txtTextFilePath";
            this.txtTextFilePath.Size = new System.Drawing.Size(285, 28);
            this.txtTextFilePath.TabIndex = 8;
            // 
            // btnUploadTextFile
            // 
            this.btnUploadTextFile.Location = new System.Drawing.Point(298, 85);
            this.btnUploadTextFile.Name = "btnUploadTextFile";
            this.btnUploadTextFile.Size = new System.Drawing.Size(112, 28);
            this.btnUploadTextFile.TabIndex = 7;
            this.btnUploadTextFile.Text = "Text file";
            this.btnUploadTextFile.UseVisualStyleBackColor = true;
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(299, 437);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(112, 28);
            this.btnEncode.TabIndex = 6;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            // 
            // radioTextFile
            // 
            this.radioTextFile.AutoSize = true;
            this.radioTextFile.Location = new System.Drawing.Point(10, 58);
            this.radioTextFile.Name = "radioTextFile";
            this.radioTextFile.Size = new System.Drawing.Size(62, 19);
            this.radioTextFile.TabIndex = 5;
            this.radioTextFile.TabStop = true;
            this.radioTextFile.Text = "Textfile";
            this.radioTextFile.UseVisualStyleBackColor = true;
            // 
            // radioText
            // 
            this.radioText.AutoSize = true;
            this.radioText.Location = new System.Drawing.Point(76, 58);
            this.radioText.Name = "radioText";
            this.radioText.Size = new System.Drawing.Size(46, 19);
            this.radioText.TabIndex = 4;
            this.radioText.TabStop = true;
            this.radioText.Text = "Text";
            this.radioText.UseVisualStyleBackColor = true;
            // 
            // txtAreaEncode
            // 
            this.txtAreaEncode.Location = new System.Drawing.Point(9, 143);
            this.txtAreaEncode.Multiline = true;
            this.txtAreaEncode.Name = "txtAreaEncode";
            this.txtAreaEncode.Size = new System.Drawing.Size(402, 189);
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
            this.progressEncode.Location = new System.Drawing.Point(9, 400);
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
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox1);
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
            this.tabPage2.Size = new System.Drawing.Size(421, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decode";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.btnDecode.Location = new System.Drawing.Point(300, 434);
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
            this.txtAreaDecode.Size = new System.Drawing.Size(402, 246);
            this.txtAreaDecode.TabIndex = 6;
            // 
            // progressDecode
            // 
            this.progressDecode.Location = new System.Drawing.Point(10, 397);
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
            // lblSecretKey
            // 
            this.lblSecretKey.AutoSize = true;
            this.lblSecretKey.Location = new System.Drawing.Point(10, 344);
            this.lblSecretKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecretKey.Name = "lblSecretKey";
            this.lblSecretKey.Size = new System.Drawing.Size(60, 15);
            this.lblSecretKey.TabIndex = 12;
            this.lblSecretKey.Text = "Secret key";
            // 
            // txtAreaSecretKey
            // 
            this.txtAreaSecretKey.Location = new System.Drawing.Point(9, 362);
            this.txtAreaSecretKey.Name = "txtAreaSecretKey";
            this.txtAreaSecretKey.Size = new System.Drawing.Size(402, 23);
            this.txtAreaSecretKey.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Secret key";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(402, 23);
            this.textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 500);
            this.Controls.Add(this.decodeTab);
            this.Name = "Form1";
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
        private TextBox txtTextFilePath;
        private Button btnUploadTextFile;
        private Button btnEncode;
        private RadioButton radioTextFile;
        private RadioButton radioText;
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
        private Label lblSecretKey;
        private TextBox txtAreaSecretKey;
        private Label label1;
        private TextBox textBox1;
    }
}