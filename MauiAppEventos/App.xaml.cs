using MauiAppEventos.Models;
using Microsoft.Extensions.DependencyInjection;

namespace MauiAppEventos
{
    public partial class App : Application
    {
        public List<TipoEventos> lista_tipoeventos = new List<TipoEventos>
        {
            new TipoEventos()
            {
                Descricao = "Casamentos",
                ValorAdulto = 180.0,
                ValorCrianca = 60.0
            },
            new TipoEventos()
            {
                Descricao = "Noivados",
                ValorAdulto = 150.0,
                ValorCrianca = 55.0
            },
            new TipoEventos()
            {
                Descricao = "Aniversários Infantis",
                ValorAdulto = 10.0,
                ValorCrianca = 50.0
            },
            new TipoEventos()
            {
                Descricao = "Festa de Debustante",
                ValorAdulto = 130.0,
                ValorCrianca = 40.0
            },
            new TipoEventos()
            {
                Descricao = "Churrasco e Happy Hours",
                ValorAdulto = 110.0,
                ValorCrianca = 35.0
            }
        };


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.CadastroEventos());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 800;

            return window;
        }
    }
}