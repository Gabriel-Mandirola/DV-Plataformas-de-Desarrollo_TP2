
using System;
using System.Collections.Generic;

using AgenciaDeAlojamientos.Helpers;

namespace AgenciaDeAlojamientos.Models
{
    internal class Agencia
    {
        private List<Alojamiento> alojamientos;
        private int cantidadDeAlojamientos;

        public Agencia()
        {
            this.alojamientos = new List<Alojamiento>();
            this.cantidadDeAlojamientos = 0;
            this.cargarDatosDeLosAlojamientos();
        }

        #region ABM de Alojamientos
        public bool AgregarAlojamiento(Alojamiento alojamiento)
        {
            this.alojamientos.Add(alojamiento);
            this.cantidadDeAlojamientos++;
            return true;
        }
        public bool ModificarAlojamiento(Alojamiento alojamiento)
        {
            int indexAlojamiento = this.alojamientos.FindIndex(al => al.IgualCodigo(alojamiento));
            if (indexAlojamiento == -1) return false;

            this.alojamientos[indexAlojamiento] = alojamiento;
            return true;
        }
        public bool EliminarAlojamiento(int codigoDelAlojamiento)
        {
            int indexAlojamiento = this.alojamientos.FindIndex(al => al.GetCodigo() == codigoDelAlojamiento);
            if (indexAlojamiento == -1) return false;

            // Elimino el alojamiento de la lista
            this.alojamientos.RemoveAt(indexAlojamiento);
            this.cantidadDeAlojamientos--;
            return true;
        }
        #endregion

        /* Metodos para obtener Alojamientos con filtros */
        // TODO: Agregar los siguientes metodos:
        /*
        * GetHoteles(): List < Hotel >
        * GetHoteles(double precioMinimo, double precioMaximo): List < Hotel >
        * GetCabanias(): List < Cabania >
        * GetCabanias(double precioMinimo, double precioMaximo): List < Cabania >
        * GetAllAlojamientos(): List < Alojamiento >
        * GetAllAlojamientos(int minimoEstrellas): List < Alojamiento >
        * GetAllAlojamientos(double precioMinimo, double precioMaximo): List<Alojamiento>
        */


        /* Metodos complementarios */
        public Alojamiento FindAlojamientoForCodigo(int codigoAlojamiento)
        {
            return this.alojamientos.Find( al => al.GetCodigo() == codigoAlojamiento );
        }
        public bool ExisteAlojamiento(Alojamiento alojamiento)
        {
            return this.alojamientos.Exists(al => al.IgualCodigo(alojamiento));
        }
        private void cargarDatosDeLosAlojamientos()
        {
            List<string> contenidoDelArchivo = Utils.GetDataFile(Config.PATH_FILE_ALOJAMIENTOS);
            if (contenidoDelArchivo.Count == 0) return;

            foreach (String alojamiento in contenidoDelArchivo)
            {
                int cantidadDeAtributosDelAlojamiento = Utils.StringToArray(alojamiento).Length;
                if (cantidadDeAtributosDelAlojamiento == Hotel.CANTIDAD_DE_ATRIBUTOS)
                {
                    this.AgregarAlojamiento(Hotel.Deserializar(alojamiento));
                }
                else if(cantidadDeAtributosDelAlojamiento == Cabania.CANTIDAD_DE_ATRIBUTOS)
                {
                    this.AgregarAlojamiento(Cabania.Deserializar(alojamiento));
                }
            }
        }
        public bool GuardarCambiosEnElArchivo()
        {
            List<String> alojamientosInLista = new List<string>();
            foreach( Alojamiento al in this.alojamientos)
            {
                alojamientosInLista.Add(al.ToString());
            }
            return Utils.WriteInFile(Config.PATH_FILE_ALOJAMIENTOS, alojamientosInLista);
        }


        /* GETTER */
        public int GetCantidadDeAlojamientos() { return this.cantidadDeAlojamientos; }

    }
}
