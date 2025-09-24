namespace PamProject1.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private async void OnRunClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Treino));
    }


    private async void OnHeartClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Cardio));
    }


    private async void OnFireClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Calorias));
    }

}


