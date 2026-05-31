namespace MauiAppEventos.Views;

public partial class CadastroEventos : ContentPage
{
    App PropriedadesApp;

    public CadastroEventos()
    {
        InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_nomeevento.ItemsSource = PropriedadesApp.lista_tipoeventos;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new ResumoEventos());


        }
        catch (Exception ex)
        {
            DisplayAlert("OPS", ex.Message, "OK");
        }
    }
}

