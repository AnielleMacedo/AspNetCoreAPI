using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestCrudCore.Models
{
    //Data Annotation per i nomi delle tbl
    [Table("tbl_manutenzione")]
    public class ManutenzioneModel
    {
        [Key]
        [Display(Name = "id_macchina")]
        [Column("id_macchina")]
        public int IdMacchina { get; set; }

        [Display(Name = "macchina_img")]
        [Column("macchina_img")]
        public string MacchinaImg { get; set; } 

        [Display(Name = "cod_macchina")]
        [Column("cod_macchina")]
        public string CodMacchina { get; set; }

        [Display(Name = "des_macchina")]
        [Column("des_macchina")]
        public string DesMacchina { get; set; }

        [Display(Name = "id_tipo_get_macchina")]
        [Column("id_tipo_get_macchina")]
        public int IdTipoGetMacchina { get; set; }

        [Display(Name = "modello")]
        [Column("modello")]
        public string Modello { get; set; }

        [Display(Name = "matricola")]
        [Column("matricola")]
        public string Matricola { get; set; }

        [Display(Name = "marca")]
        [Column("marca")]
        public string Marca { get; set; }

        [Display(Name = "ore_disponibilita")]
        [Column("ore_disponibilita")]
        public double OreDisponibilita { get; set; }

        [Display(Name = "autonoma")]
        [Column("autonoma")]
        public int Autonoma { get; set; }

        [Display(Name = "multi_commessa")]
        [Column("multi_commessa")]
        public int MultiCommessa { get; set; }

        [Display(Name = "data_acquisto")]
        [Column("data_acquisto")]
        public DateTime DataAcquisto { get; set; }

        [Display(Name = "specifiche")]
        [Column("specifiche")]
        public string Specifiche { get; set; }

        [Display(Name = "id_stato")]
        [Column("id_stato")]
        public int IdStato { get; set; }

        [Display(Name = "id_funzione")]
        [Column("id_funzione")]
        public int IdFunzione { get; set; }

        [Display(Name = "id_reparto")]
        [Column("id_reparto")]
        public int IdReparto { get; set; }

        [Display(Name = "id_centrocosto")]
        [Column("id_centrocosto")]
        public int IdCentrocosto { get; set; }

        [Display(Name = "costo_orario")]
        [Column("costo_orario")]
        public int CostoOrario { get; set; }

        [Display(Name = "on_line")]
        [Column("on_line")]
        public int OnLine { get; set; }

        [Display(Name = "schedula")]
        [Column("schedula")]
        public int Schedula { get; set; }

        [Display(Name = "tipo_connessione")]
        [Column("tipo_connessione")]
        public int TipoConnessione { get; set; }

        [Display(Name = "des_connessione")]
        [Column("des_connessione")]
        public string DesConnessione { get; set; }

        [Display(Name = "validita")]
        [Column("validita")]
        public int Validita { get; set; }

        [Display(Name = "des_reparto")]
        [Column("des_reparto")]
        public string DesReparto { get; set; }

        [Display(Name = "des_funzione")]
        [Column("des_funzione")]
        public string DesFunzione { get; set; }

        [Display(Name = "des_stato")]
        [Column("des_stato")]
        public string DesStato { get; set; }

        [Display(Name = "des_centrocosto")]
        [Column("des_centrocosto")]
        public string DesCentrocosto { get; set; }
    }
}
