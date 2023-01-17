namespace TutorialesMaui;
using TutorialesMaui.Pages;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new FlyoutPageT();
	}
}
