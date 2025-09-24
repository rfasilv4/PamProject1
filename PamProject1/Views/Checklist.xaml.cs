
namespace PamProject1.Views;

public partial class Checklist : ContentPage
{
    public Checklist()
    {
        InitializeComponent();

    }



    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Treino));
    }


}