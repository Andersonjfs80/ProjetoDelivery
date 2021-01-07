using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entidades
{
    [Table("TblEvent")]
    public class Event
    {
        [Key]
        [Display(Name = "Id#")]
        public int EventId { get; set; }
    }
}
