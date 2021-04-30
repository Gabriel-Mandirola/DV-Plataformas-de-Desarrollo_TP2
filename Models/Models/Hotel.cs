using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaDeAlojamientos
{
    class Hotel : Alojamiento
    {
        public const int CANTIDAD_DE_ATRIBUTOS = 7;

        private double precioPorPersona;

        public Hotel(int codigo, string ciudad, string barrio, int estrellas, int cantidadDePersonas, bool tv, double precioPorPersona) : 
            base(codigo, ciudad, barrio, estrellas, cantidadDePersonas, tv)
        {
            this.precioPorPersona = precioPorPersona;
        }

        public static Hotel Deserializar(String[] hotelSerializado)
        {
            return new Hotel(
                int.Parse(hotelSerializado[0]),
                hotelSerializado[1],
                hotelSerializado[2],
                int.Parse(hotelSerializado[3]),
                int.Parse(hotelSerializado[4]),
                bool.Parse(hotelSerializado[5]),
                double.Parse(hotelSerializado[6])
                );
        }
        public override String SerializarObjeto()
        {
            String objetoSerializado = "";
            objetoSerializado += this.GetCodigo().ToString() + ",";
            objetoSerializado += this.GetCiudad().ToString() + ",";
            objetoSerializado += this.GetBarrio() + ",";
            objetoSerializado += this.GetEstrellas().ToString() + ",";
            objetoSerializado += this.GetCantidadDePersonas().ToString() + ",";
            objetoSerializado += this.GetTV().ToString() + ",";
            objetoSerializado += this.GetPrecioPorPersona().ToString();

            return objetoSerializado;
        }
        public override double Precio()
        {
            return this.GetPrecioPorPersona() * this.GetCantidadDePersonas();
        }



        /* GETTERS Y SETTERS */
        public double GetPrecioPorPersona()
        {
            return this.precioPorPersona;
        }

    }
}
