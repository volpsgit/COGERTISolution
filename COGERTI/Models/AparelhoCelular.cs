//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COGERTI.Models
{
    using System;
    using System.Collections.Generic;
    
    [Table("AparelhosCelulares")]
    public partial class AparelhoCelular : Equipamento
    {
        [Required]
        public string IMEI1 { get; set; }
        public string IMEI2 { get; set; }

        [Display(Name = "Tipo Aparelho")]
        public int TipoAparelhoCelularId { get; set; }
    
        public virtual TipoAparelhoCelular TipoAparelhoCelular { get; set; }
    }
}
