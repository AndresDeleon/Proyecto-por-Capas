using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P2_2019AM606_2019LD601_Capas_Servicio;

namespace P2_2019AM606_2019LD601_Capas_Dominio
{
    public class Departamento
    {
        private readonly dbContext _contexto;

        public Departamento(dbContext miContexto)
        {
            this._contexto = miContexto;
        }

        public IEnumerable<P2_2019AM606_2019LD601_Capas_Entidades.Departamentos> listado()
        {
            IEnumerable<P2_2019AM606_2019LD601_Capas_Entidades.Departamentos> datosDept = from d in _contexto.Departamentos
                                                   select d;
            return datosDept.ToList();
        }
    }
}
