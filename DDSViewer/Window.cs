using System;
using System.Windows.Forms;
namespace DDSViewer {
	public partial class Window : Form {
		public Window() {
			InitializeComponent();

			if (Program.arg1 != null) {
				openfilename = Program.arg1;
				try {
					DDS_Img.Image = Imaging.DDSReader.DDS.LoadImage(openfilename, transparent);
					StatusLbl.Text = "Successfully loaded new DDS file.";
				} catch {
					StatusLbl.Text = "DDS file is corrupt.";
				}
			}
		}

		string exportfilename = "";
		string openfilename = "";

		bool transparent = false;

		private void ExportDDSbtn_Click(object sender, EventArgs e) {
			if (ExportDDSDialog.ShowDialog() == DialogResult.Cancel) return;
			exportfilename = ExportDDSDialog.FileName;

			DDS_Img.Image.Save(@exportfilename, System.Drawing.Imaging.ImageFormat.Png);
			StatusLbl.Text = "Successfully exported DDS as a PNG.";
		}

		private void OpenDDSbtn_Click(object sender, EventArgs e) {
			if (OpenDDSDialog.ShowDialog() == DialogResult.Cancel) return;
			openfilename = OpenDDSDialog.FileName;

			try {
				DDS_Img.Image = Imaging.DDSReader.DDS.LoadImage(openfilename, transparent);
				StatusLbl.Text = "Successfully loaded new DDS file.";
			} catch {
				StatusLbl.Text = "DDS file is corrupt.";
			}
		}

		private void TransparencyCheckBox_CheckedChanged(object sender, EventArgs e) {
			if (transparent) transparent = false;
			else transparent = true;
			if (openfilename != "") {
				DDS_Img.Image = Imaging.DDSReader.DDS.LoadImage(openfilename, transparent);
			}
		}
	}
}