namespace EtoErrorTest.UI
{
	public class EnumDropDown<T> : Eto.Forms.EnumDropDown<T> where T : struct {}

	public enum ExampleEnum
	{
		Foo,
		Bar,
		Baz
	}
}