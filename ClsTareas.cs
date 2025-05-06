using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryGestionTareasDamonte
{
    public class ClsTareas
    {
        public string titulo {  get; set; }
        public string descrip {  get; set; }
        public string prioridad { get; set; }
        public DateTime vencimiento { get; set; }
        public string estado { get; set; }
        public string usuario { get; set; }
        public string categorias { get; set; }
    }
}
