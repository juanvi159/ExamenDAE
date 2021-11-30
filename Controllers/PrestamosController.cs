using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Examen4.Controllers
{
    public class PrestamosController : Controller
    {
        #region Contexto
        private BibliotecaEntities _contexto;
        public BibliotecaEntities Contexto
        {
            set { _contexto = value; }
            get
            {
                if (_contexto == null)
                    _contexto = new BibliotecaEntities();
                return _contexto;
            }
        }
        #endregion
        // GET: Categories
        public ActionResult Index()
        {
            return View(Contexto.Prestamos.ToList());
        }

        // GET: /Categories/Create
        //mostrar formulario
        public ActionResult Create()
        {
            return View();
        }


    }
}