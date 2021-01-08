using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entidades
{
    [Table("TblEventoOrder")]
    public class EventoOrder
    {
        [Key]
        [Display(Name = "Id#")]
        public int EventoOrderId { get; set; }

        [Display(Name = "Id#")]
        public int EventoId { get; set; }

        [Required(ErrorMessage = "Informe o conteúdo do arquivo JSON.")]
        [Display(Name = "Dados do arquivo JSON")]
        public string ConteudoJSON { get; set; }

        [Display(Name = "Data de cadastro")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
