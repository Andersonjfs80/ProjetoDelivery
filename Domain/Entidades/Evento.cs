using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entidades
{
    [Table("TblEvento")]
    public class Evento
    {
        [Key]
        [Display(Name = "Id#")]
        public int EventoId { get; set; }

        [Display(Name = "Evento polling Id#")]
        public int EventoPollingId { get; set; }

        [Display(Name = "Situação do pedido")]
        public string EventoCodigo { get; set; }

        [Display(Name = "Código de referência do pedido")]
        public string CorrelacaoId { get; set; }

        [Display(Name = "Código de criação do pedido")]
        public string CriadoEm { get; set; }

        [Display(Name = "Data e hora do evento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EventoDataHora { get; set; } = DateTime.Now;

        [Display(Name = "Código de identificação do pedido")]
        public string PedidoId { get; set; }

        [Required(ErrorMessage = "Informe o conteúdo do arquivo JSON.")]
        [Display(Name = "Dados do arquivo JSON")]
        public string ConteudoJSON { get; set; }


        [Required]
        [Display(Name = "Confirmado")]
        public bool Confirmado { get; set; } = false;

        [Display(Name = "Data de cadastro")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
