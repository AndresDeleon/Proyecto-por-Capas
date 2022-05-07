using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P2_2019AM606_2019LD601_Capas_Servicio;

namespace P2_2019AM606_2019LD601_Capas_Dominio
{
    public class Generos
    {
        private readonly dbContext _contexto;

        public Generos(dbContext miContexto)
        {
            this._contexto = miContexto;
        }

        public IEnumerable<P2_2019AM606_2019LD601_Capas_Entidades.Generos> listado()
        {
            IEnumerable<P2_2019AM606_2019LD601_Capas_Entidades.Generos> datosGenero = from g in _contexto.Generos
                                               select g;
            return datosGenero.ToList();
        }
    }
}
