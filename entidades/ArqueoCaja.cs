﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_DePrisa.entidades
{
    internal class ArqueoCaja
    {

        // * Definicion de atributos de la clase *
        public int IdArqueoCaja { get; set; }
        public decimal MontoInicial { get; set; }
        public decimal MontoFinal { get; set; }
        public DateTime FechaApertura { get; set; }
        public DateTime FechaCierre { get; set; }
        public bool Estado { get; set; }
        public int IdUsuario { get; set; }

        // * Definicion de constructores *
        // Constructor vacio
        public ArqueoCaja()
        {
        }

        // Constructor con parametros
        public ArqueoCaja(int idArqueoCaja, decimal montoInicial, decimal montoFinal, DateTime fechaApertura, DateTime fechaCierre, bool estado, int idUsuario)
        {
            IdArqueoCaja = idArqueoCaja;
            MontoInicial = montoInicial;
            MontoFinal = montoFinal;
            FechaApertura = fechaApertura;
            FechaCierre = fechaCierre;
            Estado = estado;
            IdUsuario = idUsuario;
        }
    }
}
