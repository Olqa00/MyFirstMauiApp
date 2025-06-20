namespace MyFirstMauiApp;

public partial class MainPage : ContentPage
{
    public const double FONT_SIZE = 22;
    private int count = 0;

    public MainPage()
    {
        this.InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        this.count++;

        if (this.count == 1)
        {
            this.CounterBtn.Text = $"Clicked {this.count} time";
        }
        else
        {
            this.CounterBtn.Text = $"Clicked {this.count} times";
        }

        SemanticScreenReader.Announce(this.CounterBtn.Text);
    }
}

public class GlobalFontSizeExtension : IMarkupExtension
{
    public object ProvideValue(IServiceProvider serviceProvider)
    {
        return MainPage.FONT_SIZE;
    }
}
