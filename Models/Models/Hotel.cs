using System;
using System.Collections.Generic;
using System.Text;

using AgenciaDeAlojamientos.Helpers;

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

        public static Hotel Deserializar(String hotelSerializado)
        {
            String[] hotelArray = Utils.StringToArray(hotelSerializado);

            return new Hotel(
                int.Parse(hotelArray[0]),
                hotelArray[1],
                hotelArray[2],
                int.Parse(hotelArray[3]),
                int.Parse(hotelArray[4]),
                bool.Parse(hotelArray[5]),
                double.Parse(hotelArray[6])
                );
        }
        public override String Serializar()
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
