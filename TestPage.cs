namespace MyFirstMauiApp;

public class TestPage : ContentPage
{
    private readonly Label counterLabel;
    private int count = 0;

    public TestPage()
    {
        var scrollView = new ScrollView();

        var stackLayout = new StackLayout();
        scrollView.Content = stackLayout;

        this.counterLabel = new Label
        {
            Text = "Count: 0",
            FontSize = 22,
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.Center,
        };

        stackLayout.Children.Add(this.counterLabel);

        var counterButton = new Button
        {
            Text = "Click me!",
            FontSize = 22,
            HorizontalOptions = LayoutOptions.Center,
        };

        stackLayout.Children.Add(counterButton);
        counterButton.Clicked += this.OnClickedEvent;

        this.Content = scrollView;
    }

    private void OnClickedEvent(object sender, EventArgs e)
    {
        this.count++;
        this.counterLabel.Text = $"Count: {this.count}";

        SemanticScreenReader.Announce(this.counterLabel.Text);
    }
}
