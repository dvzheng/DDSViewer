using System;
using System.Windows.Forms;
namespace DDSViewer {
	static class Program {
		public static string arg1 = null;
		[STAThread]
		static void Main(string[] args) {
			if (args.Length > 0)
				arg1 = args[0];
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Window());
		}
	}
}
