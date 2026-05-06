using System;

namespace PROYECTO_1
{
    class TRABAJO
    {
        // Variables (atributos)

        public string nombre;
        public string ci;
        public string servicio;
        public string numero;
        public int hojas;
        public double precio;
        public double total;

        // Constructor

        public TRABAJO(string nombre, string ci,string numero, string servicio, int hojas, double precio, double total)
        {
            this.nombre = nombre;
            this.ci = ci;
            this.numero = numero;
            this.servicio = servicio;
            this.hojas = hojas;
            this.precio = precio;
            this.total = total;
        }
    }
}