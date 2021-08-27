using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class Departments
    {

        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo de Preenchimento Obrigatório")]
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
