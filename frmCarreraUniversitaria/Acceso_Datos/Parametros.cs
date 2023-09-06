﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmCarreraUniversitaria.Acceso_Datos
{
    public class Parametros
    {
		private string clave;

		public string Clave
		{
			get { return clave; }
			set { clave = value; }
		}
		private object valor;

		public object Valor
		{
			get { return valor; }
			set { valor = value; }
		}

		public Parametros(string clave, object valor)
		{
			this.clave = clave;
			this.valor = valor;
		}
	}
}