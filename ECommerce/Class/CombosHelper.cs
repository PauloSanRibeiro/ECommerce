using ECommerce.Data;
using ECommerce.Models;
using ECommerce.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.Class
{
    public class CombosHelper : IDisposable
    {
        private static readonly ECommerceContext db = new ECommerceContext();

        public static List<Departments> GetDepartments()
        {


            var dep = db.Departments.ToList();
                
            dep.Add(new Departments
            {
                Id = 0,
                Name = "[Selecione o Departamento]"
            });

            return dep = dep.OrderBy(d => d.Name).ToList();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
