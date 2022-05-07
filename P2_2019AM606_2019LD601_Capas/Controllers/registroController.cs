using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P2_2019AM606_2019LD601_Capas_Servicio;
using P2_2019AM606_2019LD601_Capas_Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2_2019AM606_2019LD601_Capas.Controllers
{
    public class registroController : Controller
    {
        private readonly dbContext _contexto;

        public registroController(dbContext miContexto)
        {
            this._contexto = miContexto;
        }
        public IActionResult Index()
        {
            ViewBag.ComboDeptValores = comboDepartamentos();
            ViewBag.ComboGenValores = comboGeneros();
            var datosCasosReportados = new CasosReportados(_contexto).reporteCasos();
            return View(datosCasosReportados);
        }

        public IActionResult guardarRegistro(string DepartamentoSeleccionado, string GeneroSeleccionado, string Conf, string Recup, string Falle)
        {
            new CasosReportados(_contexto).guardar(DepartamentoSeleccionado, GeneroSeleccionado, Conf, Recup, Falle);
            ViewBag.ComboDeptValores = comboDepartamentos();
            ViewBag.ComboGenValores = comboGeneros();
            var datosCasosReportados = new CasosReportados(_contexto).reporteCasos();
            return View(datosCasosReportados);
        }

            public List<SelectListItem> comboDepartamentos()
        {
            var listadoDepartamentos = new Departamento(_contexto).listado();
            List<SelectListItem> ComboDeptValores = new List<SelectListItem>();
            foreach (P2_2019AM606_2019LD601_Capas_Entidades.Departamentos dept in listadoDepartamentos)
            {
                SelectListItem miOpcion = new SelectListItem
                {
                    Text = dept.NOMBRE,
                    Value = dept.ID.ToString()
                };
                ComboDeptValores.Add(miOpcion);
            }
            return ComboDeptValores;
        }

        public List<SelectListItem> comboGeneros()
        {
            var listadoGeneros = new Generos(_contexto).listado();
            List<SelectListItem> ComboGenValores = new List<SelectListItem>();
            foreach (P2_2019AM606_2019LD601_Capas_Entidades.Generos gen in listadoGeneros)
            {
                SelectListItem miOpcion = new SelectListItem
                {
                    Text = gen.NOMBRE,
                    Value = gen.ID.ToString()
                };
                ComboGenValores.Add(miOpcion);
            }
            return ComboGenValores;
        }
    }
}
