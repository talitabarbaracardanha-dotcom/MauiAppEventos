using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppEventos.Models
{
    public class ContratacaoEvento
    {
        public TipoEventos EventoSelecionado { get; set; }
        public int QntAdultos { get; set; }
        public int QntCriancas { get; set; }
        public string nomeevento { get; set; }
        public string localevento { get; set; }
        public DateTime datainicio { get; set; }
        public DateTime datatermino { get; set; }


        public TimeSpan DuracaoEvento
        {
            get => datatermino.Subtract(datainicio);
        }

        public int TotalDiasEvento
        {
            get => DuracaoEvento.Days + 1;
        }

        public int TotalParticipantes
        {
            get => QntAdultos + QntCriancas;
        }
        public double ValorTotal
        {
            get
            {
                double valor_adultos = QntAdultos * EventoSelecionado.ValorAdulto;
                double valor_criancas = QntCriancas * EventoSelecionado.ValorCrianca;

                double total = (valor_adultos + valor_criancas) * TotalDiasEvento;

                return total;
            }
        }


    }
}
