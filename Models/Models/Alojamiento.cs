using System;
using System.Collections.Generic;
using System.Text;

using AgenciaDeAlojamientos.Helpers;
using AgenciaDeAlojamientos.Interfaces;

namespace AgenciaDeAlojamientos.Models
{
    abstract partial class Alojamiento
    {
        #region Atributos y Constructor
        public const int MAXIMO_NUMERO_DE_ESTRELLAS = 5;
        public const int MINIMO_NUMERO_DE_ESTRELLAS = 1;

        private int codigo;
        private String ciudad;
        private String barrio;
        private int estrellas;
        private int cantidadDePersonas;
        private bool tv;

        public Alojamiento(int codigo, String ciudad, String barrio, int estrellas, int cantidadDePersonas, bool tv )
        {
            this.codigo = codigo;
            this.ciudad = ciudad;
            this.barrio = barrio;
            this.estrellas = estrellas;
            this.cantidadDePersonas= cantidadDePersonas;
            this.tv= tv;
        }
        #endregion

        public bool IgualCodigo(Alojamiento alojamiento)
        {
            return alojamiento.GetCodigo() == this.GetCodigo();
        }

        /* METODOS AGREGADOS */


        /* METODOS ESTATICOS, ABSTRACTOS Y DE INTERFACES */
        public static bool ValidarEstrellas(int estrellas)
        {
            return Alojamiento.MINIMO_NUMERO_DE_ESTRELLAS >= estrellas && estrellas <= Alojamiento.MAXIMO_NUMERO_DE_ESTRELLAS;
        }
        public abstract double PrecioTotalDelAlojamiento();

        /* ToString */
        public override string ToString()
        {
            String objetoSerializado = "";
            objetoSerializado += this.GetCodigo().ToString() + ",";
            objetoSerializado += this.GetCiudad().ToString() + ",";
            objetoSerializado += this.GetBarrio() + ",";
            objetoSerializado += this.GetEstrellas().ToString() + ",";
            objetoSerializado += this.GetCantidadDePersonas().ToString() + ",";
            objetoSerializado += this.GetTV().ToString();
            return objetoSerializado;
        }

        #region GETTERS Y SETTERS 
        public int GetCodigo()
        {
            return this.codigo;
        }
        public String GetCiudad()
        {
            return this.ciudad;
        }
        public String GetBarrio()
        {
            return this.barrio;
        }
        public int GetEstrellas()
        {
            return this.estrellas;
        }
        public int GetCantidadDePersonas()
        {
            return this.cantidadDePersonas;
        }
        public bool GetTV()
        {
            return this.tv;
        }
        #endregion
    }
}
