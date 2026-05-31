namespace MauiAppEventos.Views;

public partial class CadastroEventos : ContentPage
{
    App PropriedadesApp;

    public CadastroEventos()
    {
        InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_nomeevento.ItemsSource = PropriedadesApp.lista_tipoeventos;

        dtpck_datainicio.MinimumDate = DateTime.Now;
        dtpck_datainicio.Date = DateTime.Now;

        dtpck_datatermino.MaximumDate = DateTime.Now.AddMonths(6);
                        
    }

    private void dtpck_datainicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_datainicio = elemento.Date.Value;

        dtpck_datatermino.MinimumDate = data_selecionada_datainicio.AddDays(1);
        dtpck_datatermino.MaximumDate = data_selecionada_datainicio.AddMonths(6);
         
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

