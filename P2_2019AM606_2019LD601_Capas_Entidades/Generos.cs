using System.ComponentModel.DataAnnotations;

namespace P2_2019AM606_2019LD601_Capas_Entidades
{
    public class Generos
    {
        [Key]
        public int ID { get; set; }
        public string NOMBRE { get; set; }
    }
}
