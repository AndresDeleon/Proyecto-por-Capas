using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace P2_2019AM606_2019LD601_Capas_Entidades
{
    public class CasosReportados
    {
        [Key]
        public int ID_CASOS_REPORTADOS { get; set; }

        public int CONFIRMADOS { get; set; }
        public int RECUPERADOS { get; set; }
        public int FALLECIDOS { get; set; }

        [NotMapped]
        public string NOMBRE { get; set; }
        public int ID_GENEROS { get; set; }

        [NotMapped]
        public string NOMBRE_DEP { get; set; }
        public int ID_DEPARTAMENTOS { get; set; }
    }
}
