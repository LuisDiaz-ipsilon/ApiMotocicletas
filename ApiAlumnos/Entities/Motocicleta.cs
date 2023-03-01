using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFacturador.Entities
{
    public class Motocicleta
    {
        public int id { get; set; }

        public string modelo { get; set; }

        public bool piel { get; set; }

        [ForeignKey("Llanta")]
        public int idTipoLlantas { get; set; }

        [ForeignKey("Motor")]
        public int idMotor { get; set; }
    }
}
