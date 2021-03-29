﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PortalEDU.AccesoDatos.Data;
using PortalEDU.AccesoDatos.Data.Repository;
using PortalEDU.Models;
using PortalEDU.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Vereyon.Web;

namespace PortalEDU.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ResponsablesController : Controller
    {


        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly IWebHostEnvironment _hostinEnvironment;
        private readonly IFlashMessage _flashMessage;

        public ResponsablesController(IContenedorTrabajo contenedorTrabajo, IWebHostEnvironment hostinEnvironment, IFlashMessage flashMessage)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _hostinEnvironment = hostinEnvironment;
            _flashMessage = flashMessage;
        }

        //private readonly ApplicationDbContext _context;

        //public ResponsablesController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        [HttpGet]
        public IActionResult Index()
        {

            //    //ResponsableVM artivm = new ResponsableVM()
            //    //{
            //    //    responsable = new PortalEDU.Models.Responsable(),
            //    //    ListaAlumnos = _contenedorTrabajo.Alumno.GetListaAlumno()
            //    //    // Articulo = new Models.

            //    //};


            //    //////Funciona

            //    // var responsables = _context.Responsable.Include( c => c.AlumnoListaProp).AsNoTracking();



            //    //////Funciona

            //    //List<Responsable> objlist = _context.Responsable.ToList();

            //    //foreach (var obj in objlist)
            //    //{
            //    //    _context.Entry(obj).Collection(u => u.AlumnoListaProp).Load();

            //    //    foreach (var ResponAlumno in obj.AlumnoListaProp)
            //    //    {
            //    //        _context.Entry(ResponAlumno).Reference(a => a.Responsable).Load();
            //    //    }

            //    //   }


            return View();

        }

 
            #region LLAMADAS A LAS API


            [HttpGet]

        //public IActionResult GetAll()
        //{
        //    return Json(new { data = _contenedorTrabajo.Responsable.GetAll(includeProperties: "Alumno") });

        //}

        [HttpGet]
        public IActionResult GetAll()
        {
            var allObj = _contenedorTrabajo.Responsable.GetAll(includeProperties: "AlumnoLista");
            return Json(new { data = allObj });
        }

        //[HttpDelete]
        //public IActionResult Delete(int id)
        //{

        //    var responsableDesdeDb = _contenedorTrabajo.Responsable.Get(id);
        //    _contenedorTrabajo.Responsable.Remove(responsableDesdeDb);
        //    string rutaDirectorioPrincipal = _hostinEnvironment.WebRootPath;
        //    var rutaImagen = Path.Combine(rutaDirectorioPrincipal, responsableDesdeDb.Foto.TrimStart('\\'));

        //    if (System.IO.File.Exists(rutaImagen))
        //    {
        //        System.IO.File.Delete(rutaImagen);
        //    }


        //    if (responsableDesdeDb == null)

        //    {
        //        //return Json(new { success = false, message = "Error al intentar borrar Responsable de Alumno" });
        //        _flashMessage.Danger("The category can't be deleted because it has related records.");

        //        return NotFound();

        //    }
        //    try
        //    {
        //        _contenedorTrabajo.Responsable.Remove(responsableDesdeDb);
        //        _contenedorTrabajo.Save();
        //        _flashMessage.Confirmation("The category was deleted.");

        //    }
        //    catch
        //    { 
        //        _flashMessage.Danger("The category can't be deleted because it has related records.");
        //      //  return Json(new { success = true, message = "Responsable de Alumno borrado con exito" });

        //    }

        //    return View(responsableDesdeDb);
        // }












        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _contenedorTrabajo.Responsable.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            string webRootPath = _hostinEnvironment.WebRootPath;
            var imagePath = Path.Combine(webRootPath, objFromDb.Foto.TrimStart('\\'));
            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
            }
            _contenedorTrabajo.Responsable.Remove(objFromDb);
            _contenedorTrabajo.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }



























        #endregion






    }
}