using Microcharts;
using SkiaSharp;
using Entry = Microcharts.ChartEntry;

namespace PamProject1.Views;

public partial class Calorias : ContentPage
{
    public Calorias()
    {
        InitializeComponent();

        // Dados simulados: horas de treino por dia (domingo a sábado)
        var entries = new[]
        {
            new Entry(1) { Label = "Dom", ValueLabel = "1h", Color = SKColors.Blue },
            new Entry(0.5f) { Label = "Seg", ValueLabel = "0.5h", Color = SKColors.Green },
            new Entry(1.5f) { Label = "Ter", ValueLabel = "1.5h", Color = SKColors.Red },
            new Entry(2) { Label = "Qua", ValueLabel = "2h", Color = SKColors.Orange },
            new Entry(1) { Label = "Qui", ValueLabel = "1h", Color = SKColors.Purple },
            new Entry(0.75f) { Label = "Sex", ValueLabel = "0.75h", Color = SKColors.Cyan },
            new Entry(1.25f) { Label = "Sab", ValueLabel = "1.25h", Color = SKColors.Magenta },
        };

        // Criação do gráfico de barras
        barChart.Chart = new BarChart { Entries = entries };
    }
}
