using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_VSF.Models
{
    //Esto es una clase dentro del modelo
    public class InstructorModel
    {

        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Especialidad { get; set; }

    }
}
