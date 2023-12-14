using Microsoft.AspNetCore.Mvc;
using scaffoldExamen.Models;
using scaffoldExamen.Services;

namespace scaffoldExamen.Controllers
{
    public class AlumnoController : Controller
    {
        private readonly IntzCrudAlumnoService _servicioAlumno;

        public AlumnoController(IntzCrudAlumnoService servicioAlumno)
        {
            _servicioAlumno = servicioAlumno;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RealizarInsert()
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = "Juan";


            Alumno alumno2 = new Alumno();
            alumno.Nombre = "Maria";


            _servicioAlumno.CrearAlumno(alumno);
            _servicioAlumno.CrearAlumno(alumno2);

            Console.WriteLine("[INFO] alumnos insertados correctamente");

            return View("~/Views/Home/Index.cshtml");
        }

        public IActionResult EliminarAlumno()
        {
            _servicioAlumno.EliminarAlumno(_servicioAlumno.ObtenerAlumnoPorId(1));
            Console.WriteLine("[INFO] Realizado con exito un DELETE alumno");

            return View("~/Views/Home/Index.cshtml");
        }

        [HttpGet]
        public IActionResult SelectAllAlumnos()
        {
            Console.WriteLine("[INFO] Realizando un SELECT * FROM alumno");

            List<Alumno> Alumnos = _servicioAlumno.ObtenerAlumnos();

            foreach (Alumno alumno in Alumnos)
            {
                Console.WriteLine(alumno.ToString());
            }
            return View("~/Views/Home/Index.cshtml");
        }
    }
}
