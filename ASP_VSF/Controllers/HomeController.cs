using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP_VSF.Models;

namespace ASP_VSF.Controllers
{
    public class HomeController : Controller
    {
        //Aqui el controlador hace toma datos y los inserta en la estructura del modelo
        
        public IActionResult Index()
        {
            //Array para guardar estos registros
            Array Directorios;
            //se crea una lista, esta lista es similar a usar


            List<InstructorModel> instructores = new List<InstructorModel>();
            //-----------DECLARACION DE PERSONAS--------------------
            instructores.Add(new InstructorModel
            {
              Nombre= "Fernando",
              Apellido_Paterno= "Vazquez",
              Apellido_Materno= "Sandoval",
              DNI = "17030107",
              Especialidad = "Programacion Orientado a Objetos"
            });
            //-------PERSONA 2------------
            instructores.Add(new InstructorModel
            {
              Nombre = "Yamilet",
              Apellido_Paterno= "Retana",
              Apellido_Materno = "Hernandez", 
              DNI = "17030180",
              Especialidad = "Diseño de Paginas Web"
            });
            //--------Persona 3-------------
            instructores.Add(new InstructorModel {
              Nombre= "Gabriela",
              Apellido_Paterno= "Gramillo",
              Apellido_Materno= "Vaquera",
              DNI= "17030089",
              Especialidad= "Gestion de proyectos"

            });
            //-----Esta lista se convierte a el arreglo de objetos.
            Directorios = instructores.ToArray();
            //---ViewBag permite mostrar multiples valores a diferencia de model 
            ViewBag.instructores = Directorios;


            //Pruebas anteriores sobre el manual 
            /*clase.DNI = "17030107";
            clase.Nombre = "Fernando";
            clase.Apellido_Paterno = "Vazquez";
            clase.Apellido_Materno = "Sandoval";
            clase.Especialidad = "Programacion Orientada a Objetos";*/


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
