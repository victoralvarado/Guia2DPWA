using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Guia2DPWA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Guia2DPWA.Pages
{
    public class Ejercicio1Model : PageModel
    {
        [BindProperty]
        public string MostrarNombre { get; set; }
        public string MostrarAnioNac { get; set; }
        public string MostrarSalario { get; set; }


        public void OnPostSubmit(DatosEmpleadoModel datos)
        {
            string i;
            int cont = 0;
            int l;

            for (l = 0; l < datos.Nombre.Length; l++)
            {
                i = datos.Nombre[l].ToString();

                if (i.ToLower() == "a" | i.ToLower() == "á" | i.ToLower() == "e" | i.ToLower() == "é" | i.ToLower() == "i" | i.ToLower() == "í" | i.ToLower() == "o" | i.ToLower() == "ó" | i.ToLower() == "u" | i.ToLower() == "ú")
                {
                    cont++;
                }
            }

            DateTime fechaActual = DateTime.Today;

            this.MostrarNombre = string.Format("{0}, Vocales({1})", datos.Nombre, cont);
            this.MostrarAnioNac = string.Format("{0}", fechaActual.Year - datos.Edad);

        }
        public void OnGet()
        {
        }
    }
}
