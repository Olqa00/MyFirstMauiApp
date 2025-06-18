namespace MyFirstMauiApp;

public partial class NewPage1 : ContentPage
{
    private int count;

    public NewPage1()
    {
        this.InitializeComponent();
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        this.count++;
        this.counterLabel.Text = $"Count: {this.count}";

        SemanticScreenReader.Announce(this.counterLabel.Text);
    }
}
