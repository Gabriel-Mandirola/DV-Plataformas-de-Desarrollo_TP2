using System;
using System.Collections.Generic;
using System.Text;

using AgenciaDeAlojamientos.Helpers;

namespace AgenciaDeAlojamientos
{
    class Cabania : Alojamiento
    {
        public const int CANTIDAD_DE_ATRIBUTOS = 9;

        private double precioPorDia;
        private int habitaciones;
        private int banios;

        public Cabania(int codigo, string ciudad, string barrio, int estrellas, int cantidadDePersonas, bool tv, double precioPorDia, int habitaciones, int banios) : 
            base(codigo, ciudad, barrio, estrellas, cantidadDePersonas, tv)
        {
            this.precioPorDia = precioPorDia;
            this.habitaciones = habitaciones;
            this.banios = banios;
        }

        public static Cabania Deserializar(String cabaniaSerializada)
        {
            String[] CabaniaArray = Utils.StringToArray(cabaniaSerializada);

            return new Cabania(
                int.Parse(CabaniaArray[0]),
                CabaniaArray[1],
                CabaniaArray[2],
                int.Parse(CabaniaArray[3]),
                int.Parse(CabaniaArray[4]),
                bool.Parse(CabaniaArray[5]),
                double.Parse(CabaniaArray[6]),
                int.Parse(CabaniaArray[7]),
                int.Parse(CabaniaArray[8])
                );
        }
        public override string Serializar()
        {
            String objetoSerializado = "";
            objetoSerializado += this.GetCodigo().ToString() + ",";
            objetoSerializado += this.GetCiudad().ToString() + ",";
            objetoSerializado += this.GetBarrio() + ",";
            objetoSerializado += this.GetEstrellas().ToString() + ",";
            objetoSerializado += this.GetCantidadDePersonas().ToString() + ",";
            objetoSerializado += this.GetTV().ToString() + ",";
            objetoSerializado += this.GetPrecioPorDia().ToString() + ",";
            objetoSerializado += this.GetHabitaciones().ToString() + ",";
            objetoSerializado += this.GetBanios().ToString();

            return objetoSerializado;
        }
        public override double Precio()
        {
            return this.precioPorDia;
        }

        /* GETTERS Y SETTERS */
        public double GetPrecioPorDia()
        {
            return this.precioPorDia;
        }
        public int GetHabitaciones()
        {
            return this.habitaciones;
        }
        public int GetBanios()
        {
            return this.banios;
        }

    }
}
