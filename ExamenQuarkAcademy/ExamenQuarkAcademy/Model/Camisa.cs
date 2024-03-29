﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkAcademy{
    public class Camisa : Prenda{
        #region FIELDS
        private CamisaTipo camisaTipo;
        private CuelloTipo cuelloTipo;
        #endregion

        #region PROPERTIES
        public override CamisaTipo CamisaTipo { get { return camisaTipo; }}
        public override CuelloTipo CuelloTipo { get { return cuelloTipo;}}
        #endregion

        public Camisa(CamisaTipo camisaTipo, CuelloTipo cuelloTipo, Calidad calidad, int stock) : base(calidad, stock){
            this.camisaTipo = camisaTipo;
            this.cuelloTipo = cuelloTipo;
        }
    }
    public enum CamisaTipo{
        NULL,
        mangaLarga,
        mangaCorta
    }
    public enum CuelloTipo{
        NULL,
        Mao,
        Comun
    }
}
