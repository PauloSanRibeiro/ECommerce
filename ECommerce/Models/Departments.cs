using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class Departments
    {

        public int Id { get; set; }


        [Required(ErrorMessage = "Campo de Preenchimento Obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo nome deve conter entre {2} e {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "Erro")]
        [Display(Name = "Nome")]
        [Index(IsUnique = true)]

        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
