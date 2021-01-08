using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entidades
{
    [Table("TblEventoPolling")]
    public class EventoPolling
    {
        [Key]
        [Display(Name = "Id#")]
        public int EventoPollingId { get; set; }

        [Required(ErrorMessage = "Informe o conteúdo do arquivo JSON.")]
        [Display(Name = "Dados do arquivo JSON")]
        public string ConteudoJSON { get; set; }

        [Required(ErrorMessage = "Informe a quantidade de eventos.")]
        [Display(Name = "Quantidade de eventos no arquivo JSON")]
        public int QuantidadeEventos { get; set; }

        [Display(Name = "Data de cadastro")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}



