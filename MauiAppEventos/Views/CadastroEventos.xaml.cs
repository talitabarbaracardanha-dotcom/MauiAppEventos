namespace MauiAppEventos.Views;

public partial class CadastroEventos : ContentPage
{
    public CadastroEventos()
    {
        InitializeComponent();
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

