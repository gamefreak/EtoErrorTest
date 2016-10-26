using System;
using System.Collections.Generic;
using Eto.Forms;
using Eto.GtkSharp;
using EtoErrorTest.UI;

namespace EtoErrorTest
{
	public class Program
	{
		[STAThread]
		public static void Main(string[] args)
		{
			Console.WriteLine("Start");
			var app = new Application(Platform.Detect);
			Form1 form1 = new Form1();
			app.Run(form1);

		}
	}
}


