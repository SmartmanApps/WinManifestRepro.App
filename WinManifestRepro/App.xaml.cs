using Microsoft.Maui.ApplicationModel;

namespace WinManifestRepro;

public partial class App : Application
{
IAppInfo appInfo;
	public App()
	{
        appInfo=AppInfo.Current;
        InitializeComponent();
        MainPage=new VersionPage(appInfo);
//		MainPage = new AppShell();
	}
}
