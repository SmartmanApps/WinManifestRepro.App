namespace WinManifestRepro;

public class VersionPage : ContentPage
{
IAppInfo AppInfo;
	public VersionPage(IAppInfo appInfo)
	{
        AppInfo=appInfo;
        Label versionpageLabel = new Label
            {
            HorizontalTextAlignment=TextAlignment.Center,
            VerticalTextAlignment=TextAlignment.Center,
            };
        versionpageLabel.Text=$"AppInfo {AppInfo.Version.Major}.{AppInfo.Version.Minor}.{AppInfo.Version.Build}\r\n" +
                              $"Reflection {System.Reflection.Assembly.GetEntryAssembly()?.GetName().Version.ToString()}";
        Content=versionpageLabel;
	}
}