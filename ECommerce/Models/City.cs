using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class City
    {
        public int id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Compo de Preenchimento Obrigatório")]
        public string Name { get; set; }

        [Display(Name = "Departamento")]
        [Range(1, double.MaxValue, ErrorMessage = "Selecione o Departamento")]
        public int DepartmentsId { get; set; }

        [Display(Name = "Departamento")]
        public virtual Departments Departments { get; set; }
    }
}
