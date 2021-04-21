﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PortalEDU.AccesoDatos.Data.Repository;
using PortalEDU.Models.ViewModels;
using PortalEDU.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using PortalEDU.AccesoDatos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Docs.Samples;

namespace PortalEDU.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TareasDocentesController : Controller
    {


        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly IWebHostEnvironment _hostinEnvironment;
        private readonly ApplicationDbContext _context;

        public TareasDocentesController(ApplicationDbContext context, IContenedorTrabajo contenedorTrabajo, IWebHostEnvironment hostinEnvironment)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _hostinEnvironment = hostinEnvironment;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {


            return View();
        }



        [HttpGet]

        public IActionResult Create()
        {
            TareaDocenteVM tareaDocenteVM = new TareaDocenteVM()
            {
                TareaDocente = new TareaDocente(),
                AulaVM = new Aula(),

                ListaCursoItem = _contenedorTrabajo.Curso.GetListaCurso(),
                ListaDocenteItem = _contenedorTrabajo.Docente.GetListaDocente(),

                DocenteList = _contenedorTrabajo.Docente.GetAll().ToList(),
                CursoList = _contenedorTrabajo.Curso.GetAll().ToList(),

                AulaList = _contenedorTrabajo.Aula.GetAll().ToList(),

                // Articulo = new Models.

            };

            return View(tareaDocenteVM);

        }


        //public IActionResult _TareaDocentePartial(int? id)
        //{

        //    AlumnoVM homeVM = new AlumnoVM()
        //    {
        //        ListaCalificaciones = _contenedorTrabajo.Calificaciones.GetAll(),
        //        alumno = new Models.Alumno(),
        //        //AulaEnVM = new Aula(),
        //        //CentroEduEnVM = new CentroEducativo(),
        //        calificaciones = _contenedorTrabajo.Calificaciones.GetFirstOrDefault(m => m.IdAlumno == id)

        //    };


        //    return PartialView("_TareaDocentePartia",homeVM);
        //}




        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TareaDocenteVM tareaDocenteVM)
        {
            if (ModelState.IsValid)
            {
                string rutaPrincipal = _hostinEnvironment.WebRootPath;
                var archivos = HttpContext.Request.Form.Files;

                if (tareaDocenteVM.TareaDocente.Id == 0)
                {
                    //string nombreArchivo = Guid.NewGuid().ToString();
                    string nombreArchivo = Path.GetFileName(archivos[0].FileName);
                    var subidas = Path.Combine(rutaPrincipal, @"documentos\tareadocente");
                    var extension = Path.GetExtension(archivos[0].FileName);

                    using (var fileStreams = new FileStream(Path.Combine(subidas, nombreArchivo/* + extension*/), FileMode.Create))
                    {
                        archivos[0].CopyTo(fileStreams);
                    }

                    tareaDocenteVM.TareaDocente.Documento = @"\documentos\tareadocente\" + nombreArchivo /*+ extension*/;
                    //alumnoVM.alumno.update = DateTime.Now.ToString();

                    _contenedorTrabajo.TareaDocente.Add(tareaDocenteVM.TareaDocente);
                    _contenedorTrabajo.Save();


                    return RedirectToAction(nameof(Index));
                }
            }

            tareaDocenteVM.ListaCursoItem = _contenedorTrabajo.Curso.GetListaCurso();
            tareaDocenteVM.ListaDocenteItem = _contenedorTrabajo.Docente.GetListaDocente();
            tareaDocenteVM.DocenteList = _contenedorTrabajo.Docente.GetAll().ToList();
            tareaDocenteVM.CursoList = _contenedorTrabajo.Curso.GetAll().ToList();
            tareaDocenteVM.AulaList = _contenedorTrabajo.Aula.GetAll().ToList();
            return View(tareaDocenteVM);
        }



        //// Intentanto crear la inscripcion a cursos con base al proyecto Contoso University SPA

        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var student = await _context.Alumno
        //        .Include(s => s.AlumnoCursos)
        //            .ThenInclude(e => e.Curso)
        //        .AsNoTracking()
        //        .SingleOrDefaultAsync(m => m.Id == id);

        //    if (student == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(student);
        //}




        ////public async Task<IActionResult> Notas(int? id)
        ////{
        ////    if (id == null)
        ////    {
        ////        return NotFound();
        ////    }

        ////    var curso = await _context.Calificaciones
        ////        .Include(c => c.Alumno)
        ////        .FirstOrDefaultAsync(m => m.Id == id);
        ////    if (curso == null)
        ////    {
        ////        return NotFound();
        ////    }

        ////    return View(curso);
        ////}


        //public IActionResult Notas(int? id)
        //{

        //    AlumnoVM homeVM = new AlumnoVM()
        //    {
        //        ListaCalificaciones = _contenedorTrabajo.Calificaciones.GetAll(),
        //        alumno = new Models.Alumno(),
        //        //AulaEnVM = new Aula(),
        //        //CentroEduEnVM = new CentroEducativo(),
        //        calificaciones = _contenedorTrabajo.Calificaciones.GetFirstOrDefault(m => m.IdAlumno == id)

        //    };


        //    return View(homeVM);
        //}














        //[HttpGet]

        //public IActionResult Edit(int? id)
        //{

        //    AlumnoVM alumnoVM = new AlumnoVM()
        //    {

        //        alumno = new PortalEDU.Models.Alumno(),

        //        ListaCentroEducativo = _contenedorTrabajo.CentroEducativo.GetListaCentroEducativo(),
        //        ListaResponsable = _contenedorTrabajo.Responsable.GetListaResponsable(),

        //        // Articulo = new Models.

        //    };

        //    if (id != null)
        //    {
        //        alumnoVM.alumno = _contenedorTrabajo.Alumno.Get(id.GetValueOrDefault());
        //    }
        //    alumnoVM.ListaCentroEducativo = _contenedorTrabajo.CentroEducativo.GetListaCentroEducativo();
        //    alumnoVM.ListaResponsable = _contenedorTrabajo.Responsable.GetListaResponsable();
        //    return View(alumnoVM);
        //}




        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(AlumnoVM alumnoVM)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        string rutaPrincipal = _hostinEnvironment.WebRootPath;
        //        var archivos = HttpContext.Request.Form.Files;

        //        var alumnoDesdeDb = _contenedorTrabajo.Alumno.Get(alumnoVM.alumno.Id);

        //        if (archivos.Count() > 0)
        //        {
        //            // Editamos Imagenes
        //            string nombreArchivo = Guid.NewGuid().ToString();
        //            var subidas = Path.Combine(rutaPrincipal, @"imagenes\alumnos");
        //            var extension = Path.GetExtension(archivos[0].FileName);
        //            var nuevaExtension = Path.GetExtension(archivos[0].FileName);
        //            var rutaImagen = Path.Combine(rutaPrincipal, alumnoDesdeDb.Foto.TrimStart('\\'));


        //            if (System.IO.File.Exists(rutaImagen))
        //            {
        //                System.IO.File.Delete(rutaImagen);
        //            }

        //            // Subimos nuevamente el archivo
        //            using (var fileStreams = new FileStream(Path.Combine(subidas, nombreArchivo + nuevaExtension), FileMode.Create))
        //            {
        //                archivos[0].CopyTo(fileStreams);
        //            }

        //            alumnoVM.alumno.Foto = @"\imagenes\alumnos\" + nombreArchivo + nuevaExtension;


        //            _contenedorTrabajo.Alumno.update(alumnoVM.alumno);
        //            _contenedorTrabajo.Save();


        //            return RedirectToAction(nameof(Index));
        //        }

        //        else
        //        {
        //            // Aqui es cuando la imagen ya existe y no se reeemplaza 
        //            // debe conservar la que ya esta en la base de datos
        //            alumnoVM.alumno.Foto = alumnoDesdeDb.Foto;
        //            // alumnoVM.alumno.FechaNacimiento = alumnoDesdeDb.FechaNacimiento;

        //        }

        //        _contenedorTrabajo.Alumno.update(alumnoVM.alumno);
        //        _contenedorTrabajo.Save();
        //        return RedirectToAction(nameof(Index));

        //    }
        //    alumnoVM.alumno.FechaNacimiento = alumnoVM.alumno.FechaNacimiento;
        //    alumnoVM.ListaCentroEducativo = _contenedorTrabajo.CentroEducativo.GetListaCentroEducativo();
        //    alumnoVM.ListaResponsable = _contenedorTrabajo.Responsable.GetListaResponsable();
        //    return View(alumnoVM);
        //}


        //// Aqui haremos el enrroll de alumnos a cursos


        //public async Task<IActionResult> _AddCourseModal(int studentID)
        //{

        //    ViewBag.StudentID = studentID;
        //    var courses = await _context.Curso.Include(s => s.Aula).ThenInclude(c => c.CentroEducativo).Where(x => x.AlumnoCursos.Any(y => y.IdAlumno == studentID) == false).ToListAsync();
        //    return PartialView(courses);
        //}
        //public async Task<IActionResult> addEnrollment(AlumnoCurso enrollment)//int IdAlumno,int IdCursoD)
        //{
        //    enrollment.Curso = await _context.Curso.SingleOrDefaultAsync(x => x.Id == enrollment.IdAlumno);

        //    _context.AlumnoCurso.Add(enrollment);
        //    await _context.SaveChangesAsync();
        //    // Falta solucionar el retorno de la vista
        //    var alumnoDesdeDb = _contenedorTrabajo.Alumno.Get(enrollment.IdAlumno);

        //    return RedirectToAction("Details", "Alumnos", alumnoDesdeDb);
        //}
        //public async Task<IActionResult> deleteEnrollment(int enrollmentID)
        //{
        //    var enrollment = await _context.AlumnoCurso.SingleOrDefaultAsync(x => x.IdAlumnoCurso == enrollmentID);
        //    _context.AlumnoCurso.Remove(enrollment);
        //    await _context.SaveChangesAsync();

        //    var alumnoDesdeDb = _contenedorTrabajo.Alumno.Get(enrollment.IdAlumno);
        //    return RedirectToAction("Details", "Alumnos", alumnoDesdeDb);


        //}
        //private bool StudentExists(int id)
        //{
        //    return _context.Alumno.Any(e => e.Id == id);
        //}






























        #region LLAMADAS A LAS API


        [HttpGet]

        public IActionResult GetAll()
        {
            return Json(new { data = _contenedorTrabajo.TareaDocente.GetAll(includeProperties: "Docente,Curso") });

        }


        public IActionResult Delete(int id)
        {
            var articuloDesdeDb = _contenedorTrabajo.TareaDocente.Get(id);
            string rutaDirectorioPrincipal = _hostinEnvironment.WebRootPath;
            var rutaDocumento = Path.Combine(rutaDirectorioPrincipal, articuloDesdeDb.Documento.TrimStart('\\'));

            if (System.IO.File.Exists(rutaDocumento))
            {
                System.IO.File.Delete(rutaDocumento);
            }

            if (articuloDesdeDb == null)

            {
                return Json(new { success = false, message = "Error al intentar borrar Tarea" });

            }

            _contenedorTrabajo.TareaDocente.Remove(articuloDesdeDb);
            _contenedorTrabajo.Save();

            return Json(new { success = true, message = "Tarea borrada con exito" });
        }




        #endregion

    }
}