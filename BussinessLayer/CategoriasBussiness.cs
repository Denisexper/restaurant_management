﻿using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class CategoriasBussiness
    {
        CategoriasData CategoriasD = new CategoriasData();

        public DataTable obtenerCategorias()
        {
            return CategoriasD.obtenerCategorias();
        }
    }
}
