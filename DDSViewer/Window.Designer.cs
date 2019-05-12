namespace DDSViewer
{
	partial class Window
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
			this.DDS_Img = new System.Windows.Forms.PictureBox();
			this.OpenDDSbtn = new System.Windows.Forms.Button();
			this.ExportDDSbtn = new System.Windows.Forms.Button();
			this.OpenDDSDialog = new System.Windows.Forms.OpenFileDialog();
			this.ExportDDSDialog = new System.Windows.Forms.SaveFileDialog();
			this.StatusBar = new System.Windows.Forms.StatusStrip();
			this.StatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
			this.TransparencyCheckBox = new System.Windows.Forms.CheckBox();
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();
			((System.ComponentModel.ISupportInitialize)(this.DDS_Img)).BeginInit();
			this.StatusBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// DDS_Img
			// 
			this.DDS_Img.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DDS_Img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DDS_Img.BackgroundImage")));
			this.DDS_Img.Location = new System.Drawing.Point(12, 41);
			this.DDS_Img.Name = "DDS_Img";
			this.DDS_Img.Size = new System.Drawing.Size(541, 541);
			this.DDS_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.DDS_Img.TabIndex = 0;
			this.DDS_Img.TabStop = false;
			// 
			// OpenDDSbtn
			// 
			this.OpenDDSbtn.Location = new System.Drawing.Point(12, 12);
			this.OpenDDSbtn.Name = "OpenDDSbtn";
			this.OpenDDSbtn.Size = new System.Drawing.Size(82, 23);
			this.OpenDDSbtn.TabIndex = 1;
			this.OpenDDSbtn.Text = "Open DDS";
			this.OpenDDSbtn.UseVisualStyleBackColor = true;
			this.OpenDDSbtn.Click += new System.EventHandler(this.OpenDDSbtn_Click);
			// 
			// ExportDDSbtn
			// 
			this.ExportDDSbtn.Location = new System.Drawing.Point(100, 12);
			this.ExportDDSbtn.Name = "ExportDDSbtn";
			this.ExportDDSbtn.Size = new System.Drawing.Size(84, 23);
			this.ExportDDSbtn.TabIndex = 2;
			this.ExportDDSbtn.Text = "Export DDS";
			this.ExportDDSbtn.UseVisualStyleBackColor = true;
			this.ExportDDSbtn.Click += new System.EventHandler(this.ExportDDSbtn_Click);
			// 
			// OpenDDSDialog
			// 
			this.OpenDDSDialog.FileName = "file.dds";
			this.OpenDDSDialog.Filter = "Direct Draw Surface Image|*.dds";
			// 
			// ExportDDSDialog
			// 
			this.ExportDDSDialog.FileName = "untitled.png";
			this.ExportDDSDialog.Filter = "PNG Image|*.png";
			// 
			// StatusBar
			// 
			this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLbl});
			this.StatusBar.Location = new System.Drawing.Point(0, 585);
			this.StatusBar.Name = "StatusBar";
			this.StatusBar.Size = new System.Drawing.Size(565, 22);
			this.StatusBar.TabIndex = 4;
			this.StatusBar.Text = "statusStrip1";
			// 
			// StatusLbl
			// 
			this.StatusLbl.Name = "StatusLbl";
			this.StatusLbl.Size = new System.Drawing.Size(39, 17);
			this.StatusLbl.Text = "Ready";
			// 
			// TransparencyCheckBox
			// 
			this.TransparencyCheckBox.AutoSize = true;
			this.TransparencyCheckBox.Location = new System.Drawing.Point(190, 16);
			this.TransparencyCheckBox.Name = "TransparencyCheckBox";
			this.TransparencyCheckBox.Size = new System.Drawing.Size(127, 17);
			this.TransparencyCheckBox.TabIndex = 5;
			this.TransparencyCheckBox.Text = "Toggle Transparency";
			this.TransparencyCheckBox.UseVisualStyleBackColor = true;
			this.TransparencyCheckBox.CheckedChanged += new System.EventHandler(this.TransparencyCheckBox_CheckedChanged);
			// 
			// helpProvider1
			// 
			this.helpProvider1.HelpNamespace = "help.html";
			// 
			// Window
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(565, 607);
			this.Controls.Add(this.TransparencyCheckBox);
			this.Controls.Add(this.StatusBar);
			this.Controls.Add(this.ExportDDSbtn);
			this.Controls.Add(this.OpenDDSbtn);
			this.Controls.Add(this.DDS_Img);
			this.HelpButton = true;
			this.helpProvider1.SetHelpKeyword(this, "");
			this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
			this.helpProvider1.SetHelpString(this, "");
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(400, 445);
			this.Name = "Window";
			this.helpProvider1.SetShowHelp(this, true);
			this.Text = "DDS Viewer";
			((System.ComponentModel.ISupportInitialize)(this.DDS_Img)).EndInit();
			this.StatusBar.ResumeLayout(false);
			this.StatusBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox DDS_Img;
		private System.Windows.Forms.Button OpenDDSbtn;
		private System.Windows.Forms.Button ExportDDSbtn;
		private System.Windows.Forms.OpenFileDialog OpenDDSDialog;
		private System.Windows.Forms.SaveFileDialog ExportDDSDialog;
		private System.Windows.Forms.StatusStrip StatusBar;
		private System.Windows.Forms.ToolStripStatusLabel StatusLbl;
		private System.Windows.Forms.CheckBox TransparencyCheckBox;
		private System.Windows.Forms.HelpProvider helpProvider1;
	}
}

