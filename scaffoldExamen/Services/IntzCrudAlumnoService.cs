using scaffoldExamen.Models;

namespace scaffoldExamen.Services
{
    public interface IntzCrudAlumnoService
    {
        public List<Alumno> ObtenerAlumnos();
        public Alumno ObtenerAlumnoPorId(int id);

        public void CrearAlumno(Alumno alumno);

        public void ActualizarAlumno(Alumno alumno);

        public void EliminarAlumno(Alumno alumno);
    }
}
