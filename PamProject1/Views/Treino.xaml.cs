
namespace PamProject1.Views;

public partial class Treino : ContentPage
{
    public Treino()
    {
        InitializeComponent();
    }
    private async void OnAdicionarClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Checklist));
    }


    private async void OnUpperClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Upper));
    }
    private async void OnLowerClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Lower));
    }

    private async void OnVoltaClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(HomePage));
    }

}



