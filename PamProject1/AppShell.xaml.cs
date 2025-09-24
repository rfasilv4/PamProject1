using PamProject1.Views;

namespace PamProject1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Registrar rotas
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(Views.Treino), typeof(Views.Treino));
            Routing.RegisterRoute(nameof(Views.Checklist), typeof(Views.Checklist));
            Routing.RegisterRoute(nameof(Views.Cardio), typeof(Views.Cardio));
            Routing.RegisterRoute(nameof(Views.Calorias), typeof(Views.Calorias));
            Routing.RegisterRoute(nameof(Views.MainPage), typeof(Views.MainPage));
            Routing.RegisterRoute(nameof(Views.Upper), typeof(Views.Upper));
            Routing.RegisterRoute(nameof(Views.Lower), typeof(Views.Lower));
        }
    }
}
