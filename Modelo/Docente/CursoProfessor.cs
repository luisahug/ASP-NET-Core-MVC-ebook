﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Cadastros;

namespace Modelo.Docente
{
    public class CursoProfessor
    {
        public long? CursoID {  get; set; }
        public Curso Curso {  get; set; }
        public long? ProfessorID { get; set; }
        public Professor Professor { get; set; }
    }
}
