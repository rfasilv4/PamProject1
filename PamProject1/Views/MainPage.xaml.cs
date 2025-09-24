
namespace PamProject1.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }



    private async void OnEntrarClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(HomePage));
    }

}