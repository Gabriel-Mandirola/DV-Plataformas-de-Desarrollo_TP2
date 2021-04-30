using System;
using System.Collections.Generic;
using System.Text;
using AgenciaDeAlojamientos.Helpers;
using AgenciaDeAlojamientos.Interfaces;

namespace AgenciaDeAlojamientos
{
    abstract class Alojamiento: ISerializable, IDatosParaLasVistas
    {
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
    
        
        public bool IgualCodigo(Alojamiento alojamiento)
        {
            return alojamiento.GetCodigo() == this.GetCodigo();
        }

        /* METODOS AGREGADOS */
        public static Alojamiento Deserializar(String alojamientoSerializado)
        {
            int atributosDelTipoDeAlojamiento = Utils.StringToArray(alojamientoSerializado).Length;

            if(atributosDelTipoDeAlojamiento == Hotel.CANTIDAD_DE_ATRIBUTOS)
            {
                return Hotel.Deserializar(alojamientoSerializado);
            }else if(atributosDelTipoDeAlojamiento == Cabania.CANTIDAD_DE_ATRIBUTOS)
            {
                return Cabania.Deserializar(alojamientoSerializado);
            }
            return null;
        }


        /* METODOS ESTATICOS, ABSTRACTOS Y DE INTERFACES */
        public static bool ValidarEstrellas(int estrellas)
        {
            return Alojamiento.MINIMO_NUMERO_DE_ESTRELLAS >= estrellas && estrellas <= Alojamiento.MAXIMO_NUMERO_DE_ESTRELLAS;
        }
        public abstract double Precio();
        public abstract string Serializar();
        public List<string> parsearObjetoALista()
        {
            return new List<string>() {
                this.GetCodigo().ToString(),
                this.GetCiudad().ToString(),
                this.GetBarrio(),
                this.GetEstrellas().ToString(),
                this.GetCantidadDePersonas().ToString(),
                this.GetTV().ToString(),
                this.Precio().ToString()
            };
        }
        


        /* GETTERS Y SETTERS */
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

    }
}
