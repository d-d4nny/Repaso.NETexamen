using Microsoft.AspNetCore.Mvc;
using scaffoldExamen.Models;
using scaffoldExamen.Services;
using System.Diagnostics;
using System.Security.Cryptography.Xml;

namespace scaffoldExamen.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IntzCrudAlumnoService _servicioAlumno;



        public HomeController(
            ILogger<HomeController> logger,
            IntzCrudAlumnoService servicioEstudiante
            )
        {
            _logger = logger;
            _servicioAlumno = servicioEstudiante;
        }

        public IActionResult Index()
        {

            Alumno alumno1 = new Alumno();
            alumno1.Nombre = "Juan";


            Alumno alumno2 = new Alumno();
            alumno2.Nombre = "Maria";


            _servicioAlumno.CrearAlumno(alumno1);
            _servicioAlumno.CrearAlumno(alumno2);

            Console.WriteLine("[INFO] alumnos insertados correctamente");

            Console.WriteLine("[INFO] Realizando un SELECT * FROM alumno");

            List<Alumno> Alumnos = _servicioAlumno.ObtenerAlumnos();

            foreach (Alumno alumno in Alumnos)
            {
                Console.WriteLine(alumno.ToString());
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}