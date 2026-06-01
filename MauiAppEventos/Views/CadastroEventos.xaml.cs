using MauiAppEventos.Models;

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

        dtpck_datatermino.MinimumDate = data_selecionada_datainicio;
        dtpck_datatermino.MaximumDate = data_selecionada_datainicio.AddMonths(6);
        dtpck_datatermino.Date = data_selecionada_datainicio;

    }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            ContratacaoEvento c = new ContratacaoEvento
            {
                EventoSelecionado = (TipoEventos)pck_nomeevento.SelectedItem,
                QntAdultos = Convert.ToInt32(txt_participantesadultos.Text),
                QntCriancas = Convert.ToInt32(txt_participantescriancas.Text),
                nomeevento = txt_nomeevento.Text,
                localevento = txt_local.Text,
                datainicio = dtpck_datainicio.Date.Value,
                datatermino = dtpck_datatermino.Date.Value,
            };

            await Navigation.PushAsync(new ResumoEventos()
            {
                BindingContext = c
            });


        }
        catch (Exception ex)
        {
            await DisplayAlert("OPS", ex.Message, "OK");
        }
    }


}

