namespace MyFirstMauiApp;

public partial class LayoutExample : ContentPage
{
    public LayoutExample()
    {
        this.InitializeComponent();

        this.VStackLayout.Padding = DeviceInfo.Platform == DevicePlatform.iOS
            ? new Thickness(left: 0, top: 20, right: 0, bottom: 0)
            : new Thickness(0);
    }
}
