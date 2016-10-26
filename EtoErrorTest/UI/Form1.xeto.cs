using Eto.Forms;
using Eto.Serialization.Xaml;

namespace EtoErrorTest.UI
{
	public class Form1 : Form
	{
		public Form1()
		{
			XamlReader.Load(this);
		}
	}
}