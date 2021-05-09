
using System;
using System.Linq;
using System.Collections.Generic;

using AgenciaDeAlojamientos.Helpers;

namespace AgenciaDeAlojamientos.Models
{
    public class Agencia
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

        /* METODOS PARA FILTRAR ALOJAMIENTOS */
        public List<Alojamiento> GetHoteles()
        {
            return this.alojamientos.FindAll( alojamiento => alojamiento is Hotel);
        }
        public List<Alojamiento> GetHoteles(double precioMinimo, double precioMaximo)
        {
            return this.alojamientos.FindAll( al => al is Hotel && al.PrecioTotalDelAlojamiento() >= precioMinimo && al.PrecioTotalDelAlojamiento() <= precioMaximo);
        }
        public List<Alojamiento> GetCabanias()
        {
            return this.alojamientos.FindAll( alojamiento => alojamiento is Cabania);
        }
        public List<Alojamiento> GetCabanias(double precioMinimo, double precioMaximo)
        {
            return this.alojamientos.FindAll(al => al is Cabania && al.PrecioTotalDelAlojamiento() >= precioMinimo && al.PrecioTotalDelAlojamiento() <= precioMaximo);
        }
        public List<Alojamiento> GetAllAlojamientos()
        {
            return this.getAlojamientos();
        }
        public List<Alojamiento> GetAllAlojamientos(int minimoEstrellas)
        {
            return this.alojamientos.FindAll(alojamiento => alojamiento.GetEstrellas() >= minimoEstrellas);
        }
        public List<Alojamiento> GetAllAlojamientos(double precioMinimo, double precioMaximo)
        {
            return this.alojamientos.FindAll(al => al.PrecioTotalDelAlojamiento() >= precioMinimo && al.PrecioTotalDelAlojamiento() <= precioMaximo);
        }

        /* METODOS DE ORDENAMIENTO */
        public List<Alojamiento> GetAlojamientoPorEstrellas(List<Alojamiento> alojamientos = null)
        {
            List<Alojamiento> alojamientosAOrdenar = alojamientos == null ? this.alojamientos : alojamientos;
            return alojamientosAOrdenar.OrderBy(alojamiento => alojamiento.GetEstrellas()).ToList();
        }
        public List<Alojamiento> GetAlojamientoPorPersonas(List<Alojamiento> alojamientos = null)
        {
            List<Alojamiento> alojamientosAOrdenar = alojamientos == null ? this.alojamientos : alojamientos;
            return alojamientosAOrdenar.OrderBy(alojamiento => alojamiento.GetCantidadDePersonas()).ToList();
        }
        public List<Alojamiento> GetAlojamientoPorCodigo(List<Alojamiento> alojamientos = null)
        {
            List<Alojamiento> alojamientosAOrdenar = alojamientos == null ? this.alojamientos : alojamientos;
            return alojamientosAOrdenar.OrderBy(alojamiento => alojamiento.GetCodigo()).ToList();
        }


        /* METODOS COMPLEMENTARIOS */
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
        private List<Alojamiento> getAlojamientos() { return this.alojamientos; }
    }
}
