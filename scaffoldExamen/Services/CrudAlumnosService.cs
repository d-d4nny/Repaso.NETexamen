using scaffoldExamen.Models;
using Microsoft.EntityFrameworkCore;


namespace scaffoldExamen.Services
{
    public class CrudAlumnosService : IntzCrudAlumnoService
    {
        private readonly gestorBibliotecaPersonalContext _contexto;
        public CrudAlumnosService(gestorBibliotecaPersonalContext dbContext)
        {
            _contexto = dbContext;
        }

        public void ActualizarAlumno(Alumno alumno)
        {
            _contexto.Alumnos.Update(alumno);
            _contexto.SaveChanges();
        }

        public void CrearAlumno(Alumno alumno)
        {
            _contexto.Alumnos.Add(alumno);
            _contexto.SaveChanges();
        }

        public void EliminarAlumno(Alumno alumno)
        {
            _contexto.Alumnos.Remove(alumno);
            _contexto.SaveChanges();
        }

        public Alumno ObtenerAlumnoPorId(int id)
        {
            Alumno? alumno = _contexto.Alumnos.FirstOrDefault(e => e.IdAlumno == id);
            return alumno == null ? throw new Exception("Estudiante no encontrado") : alumno;
        }

        public List<Alumno> ObtenerAlumnos()
        {
            return _contexto.Alumnos.ToList();
        }

    }
}
