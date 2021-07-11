using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGetListaMacchine.Models
{
    public class ManutenzioneModel
    {
        
        public int IdMacchina { get; set; }

        public string MacchinaImg { get; set; }

        public string CodMacchina { get; set; }

        public string DesMacchina { get; set; }

        public int IdTipoGetMacchina { get; set; }

        public string Modello { get; set; }

        public string Matricola { get; set; }

        public string Marca { get; set; }

        public double OreDisponibilita { get; set; }

        public int Autonoma { get; set; }

        public int MultiCommessa { get; set; }

        public DateTime DataAcquisto { get; set; }

        public string Specifiche { get; set; }

        public int IdStato { get; set; }

        public int IdFunzione { get; set; }

        public int IdReparto { get; set; }

        public int IdCentrocosto { get; set; }

        public int CostoOrario { get; set; }

        public int OnLine { get; set; }

        public int Schedula { get; set; }

        public int TipoConnessione { get; set; }

        public string DesConnessione { get; set; }

        public int Validita { get; set; }

        public string DesReparto { get; set; }

        public string DesFunzione { get; set; }

        public string DesStato { get; set; }

        public string DesCentrocosto { get; set; }
    }
}
