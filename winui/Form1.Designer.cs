namespace quadrotor
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
            this.cbPad = new System.Windows.Forms.ComboBox();
            this.cbSerial = new System.Windows.Forms.ComboBox();
            this.btnOpenSerial = new System.Windows.Forms.Button();
            this.btnOpenPad = new System.Windows.Forms.Button();
            this.lblSerialStatus = new System.Windows.Forms.Label();
            this.lblPadStatus = new System.Windows.Forms.Label();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.lblState = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPad
            // 
            this.cbPad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPad.FormattingEnabled = true;
            this.cbPad.Location = new System.Drawing.Point(12, 39);
            this.cbPad.Name = "cbPad";
            this.cbPad.Size = new System.Drawing.Size(152, 21);
            this.cbPad.TabIndex = 0;
            // 
            // cbSerial
            // 
            this.cbSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerial.FormattingEnabled = true;
            this.cbSerial.Location = new System.Drawing.Point(12, 12);
            this.cbSerial.Name = "cbSerial";
            this.cbSerial.Size = new System.Drawing.Size(152, 21);
            this.cbSerial.TabIndex = 1;
            this.cbSerial.SelectedIndexChanged += new System.EventHandler(this.cbSerial_SelectedIndexChanged);
            // 
            // btnOpenSerial
            // 
            this.btnOpenSerial.Location = new System.Drawing.Point(170, 12);
            this.btnOpenSerial.Name = "btnOpenSerial";
            this.btnOpenSerial.Size = new System.Drawing.Size(75, 23);
            this.btnOpenSerial.TabIndex = 2;
            this.btnOpenSerial.Text = "Open Serial";
            this.btnOpenSerial.UseVisualStyleBackColor = true;
            this.btnOpenSerial.Click += new System.EventHandler(this.btnOpenSerial_Click);
            // 
            // btnOpenPad
            // 
            this.btnOpenPad.Location = new System.Drawing.Point(170, 39);
            this.btnOpenPad.Name = "btnOpenPad";
            this.btnOpenPad.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPad.TabIndex = 3;
            this.btnOpenPad.Text = "Open Pad";
            this.btnOpenPad.UseVisualStyleBackColor = true;
            this.btnOpenPad.Click += new System.EventHandler(this.btnOpenPad_Click);
            // 
            // lblSerialStatus
            // 
            this.lblSerialStatus.AutoSize = true;
            this.lblSerialStatus.Location = new System.Drawing.Point(252, 19);
            this.lblSerialStatus.Name = "lblSerialStatus";
            this.lblSerialStatus.Size = new System.Drawing.Size(37, 13);
            this.lblSerialStatus.TabIndex = 4;
            this.lblSerialStatus.Text = "[nada]";
            // 
            // lblPadStatus
            // 
            this.lblPadStatus.AutoSize = true;
            this.lblPadStatus.Location = new System.Drawing.Point(252, 46);
            this.lblPadStatus.Name = "lblPadStatus";
            this.lblPadStatus.Size = new System.Drawing.Size(37, 13);
            this.lblPadStatus.TabIndex = 5;
            this.lblPadStatus.Text = "[nada]";
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Interval = 10;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(13, 67);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(36, 13);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "[state]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(136, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 167);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 283);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(357, 125);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 420);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblPadStatus);
            this.Controls.Add(this.lblSerialStatus);
            this.Controls.Add(this.btnOpenPad);
            this.Controls.Add(this.btnOpenSerial);
            this.Controls.Add(this.cbSerial);
            this.Controls.Add(this.cbPad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPad;
        private System.Windows.Forms.ComboBox cbSerial;
        private System.Windows.Forms.Button btnOpenSerial;
        private System.Windows.Forms.Button btnOpenPad;
        private System.Windows.Forms.Label lblSerialStatus;
        private System.Windows.Forms.Label lblPadStatus;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

