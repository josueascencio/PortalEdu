﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PortalEDU.Models.ViewModels
{
    public class CursoCardVM
    {
        public IEnumerable<Aula> ListaAulas { get; set; }

        public Aula AulaEnVM { get; set; }

        public IEnumerable<Curso> ListaCursos { get; set; }

        public Curso CursoEnVM { get; set; }

        public IEnumerable<Docente> ListaDocentes { get; set; }

        public Docente DocenteEnVM { get; set; }

        public IEnumerable<CentroEducativo> ListaCentroEducativo { get; set; }

        public CentroEducativo CentroEduEnVM { get; set; }

        public IEnumerable<TareaDocente> ListaTareas { get; set; }

        public TareaDocente TareaDocenteEnVM { get; set; }

    }
}
