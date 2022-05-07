using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P2_2019AM606_2019LD601_Capas_Servicio;

namespace P2_2019AM606_2019LD601_Capas_Dominio
{
    public class CasosReportados
    {
        private readonly dbContext _contexto;

        public CasosReportados(dbContext miContexto)
        {
            this._contexto = miContexto;
        }

		public IEnumerable<P2_2019AM606_2019LD601_Capas_Entidades.CasosReportados> reporteCasos()
		{

			IEnumerable<P2_2019AM606_2019LD601_Capas_Entidades.CasosReportados> datosRegistro = from m in _contexto.CasosReportados
                                                                                                join d in _contexto.Departamentos on m.ID_DEPARTAMENTOS equals d.ID
                                                                                                join g in _contexto.Generos on m.ID_GENEROS equals g.ID
                                                                                                select new P2_2019AM606_2019LD601_Capas_Entidades.CasosReportados
                                                                                                {
                                                                                                    ID_CASOS_REPORTADOS = m.ID_CASOS_REPORTADOS,
                                                                                                    CONFIRMADOS = m.CONFIRMADOS,
                                                                                                    NOMBRE = g.NOMBRE,
                                                                                                    NOMBRE_DEP = d.NOMBRE,
                                                                                                    FALLECIDOS = m.FALLECIDOS,
                                                                                                    RECUPERADOS = m.RECUPERADOS
                                                                                                };
            return datosRegistro.ToList();
		}

        public void guardar(string DepartamentoSeleccionado, string GeneroSeleccionado, string Conf, string Recup, string Falle)
        {
            P2_2019AM606_2019LD601_Capas_Entidades.CasosReportados nuevoRegistro = new P2_2019AM606_2019LD601_Capas_Entidades.CasosReportados();
            nuevoRegistro.ID_DEPARTAMENTOS = Int32.Parse(DepartamentoSeleccionado);
            nuevoRegistro.ID_GENEROS = Int32.Parse(GeneroSeleccionado);
            nuevoRegistro.CONFIRMADOS = Int32.Parse(Conf);
            nuevoRegistro.RECUPERADOS = Int32.Parse(Recup);
            nuevoRegistro.FALLECIDOS = Int32.Parse(Falle);

            _contexto.CasosReportados.Add(nuevoRegistro);
            _contexto.SaveChanges();
        }
	}
}
