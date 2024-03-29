﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkAcademy.Model{
    public class Cotizacion{
        #region FIELDS
        private int id;
        private DateTime fechaHora;
        private int codVendedor;
        private Prenda prenda;
        private int cantidad;
        private float total;
        private float precioUnit;
        #endregion

        #region PROPERTIES
        public int Id { get { return id; } }
        public DateTime FechaHora { get { return fechaHora; } }
        public int CodVendedor { get { return codVendedor; } }
        public Prenda Prenda { get { return prenda; } }
        public int Cantidad { get { return cantidad; } }
        public float Total { get { return total; } set { total = value; } }
        public float PrecioUnit { get { return precioUnit; } }
        #endregion

        public Cotizacion(int id, DateTime fechaHora, int codVendedor, Prenda prenda, int cantidad){
            this.id = id;
            this.fechaHora = fechaHora;
            this.codVendedor = codVendedor;
            this.prenda = prenda;
            this.cantidad = cantidad;
        }

        public float Cotizar(float precio){
            float subtotal;
            this.precioUnit = precio;
            subtotal = precio * cantidad;
            if (prenda is Camisa){
                if (prenda.CamisaTipo == CamisaTipo.mangaCorta){
                    subtotal -= subtotal * 0.10f;
                    if (prenda.CuelloTipo == CuelloTipo.Mao){
                        subtotal += subtotal * 0.03f;
                    }
                }
            }
            if (prenda is Pantalon){
                if (prenda.PantalonTipo == PantalonTipo.Chupin){
                    subtotal -= subtotal * 0.12f;
                }
            }
            if (prenda.Calidad==Calidad.Premium){
                //aumenta 30%
                subtotal += subtotal * 0.30f;
            }
            return subtotal;
        }
    }
}
