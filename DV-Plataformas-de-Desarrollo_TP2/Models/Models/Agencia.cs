
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


        
        public List<Hotel> getHoteles()
        {
            var lista = new List<Hotel>();
            foreach (Alojamiento hotel in alojamientos)
            {
                if (hotel is Hotel)
                {                  
                    lista.Add((Hotel)hotel);
                }
            }
            return lista;
        }

       public List<Hotel> getHoteles(double precioMinimo, double precioMaximo)
        {
            var lista = new List<Hotel>();
            foreach (Alojamiento hotel in alojamientos)
            {              
                if (hotel is Hotel && hotel.PrecioTotalDelAlojamiento() >= precioMinimo && hotel.PrecioTotalDelAlojamiento() <= precioMaximo )
                {                  
                    lista.Add((Hotel)hotel);
                }
            }
            return lista;
        }

        public List<Cabania> getCabanias()
        {
            var lista = new List<Cabania>();

            foreach (Alojamiento cabania in alojamientos)
            {
                if (cabania is Cabania)
                {
                   
                    lista.Add((Cabania)cabania);
                }
            }
            return lista;
        }

        public List<Cabania> getCabanias(double precioMinimo, double precioMaximo)
        {
            var lista = new List<Cabania>();
            foreach (Cabania cabania in alojamientos)
            {
                if (cabania is Cabania && cabania.PrecioTotalDelAlojamiento() >= precioMinimo && cabania.PrecioTotalDelAlojamiento() <= precioMaximo)
                {
                    lista.Add((Cabania)cabania);
                }
            }
            return lista;
        }

        public List<Alojamiento> getAllAlojamientos(){

            var lista = new List<Alojamiento>();
            foreach(Alojamiento aloja in alojamientos){
                lista.Add(aloja);
            }
            return lista;
        } 

        public List<Alojamiento> getAllAlojamientos(int minimoEstrellas){

            var lista = new List<Alojamiento>();
            foreach(Alojamiento aloja in alojamientos){
                if(aloja.GetEstrellas() >= minimoEstrellas){
                     lista.Add(aloja);
                }              
            }
            return lista;
        } 

        public List<Alojamiento> getAllAlojamientos(double precioMinimo, double precioMaximo){

            var lista = new List<Alojamiento>();
            foreach(Alojamiento aloja in alojamientos){
                if(aloja.PrecioTotalDelAlojamiento() >= precioMinimo && aloja.PrecioTotalDelAlojamiento() <= precioMaximo){
                     lista.Add(aloja);
                }              
            }
            return lista;
        } 

        public List<Alojamiento> getAlojamientoEstrellas(){
            var lista = new List<Alojamiento>();
            lista = alojamientos;
            Alojamiento t;
            for(int i = 1; i < lista.Count; i++){
                for(int j = lista.Count - 1; j >=i; j--){
                    if(lista[j-1].GetEstrellas() > lista[j].GetEstrellas()){
                        t = lista[j-1];
                        lista[j-1] = lista[j];
                        lista[j] = t;
                    }
                }
            }
            return lista;
        }

         public List<Alojamiento> getAlojamientoXPersonas(){
            var lista = new List<Alojamiento>();
            lista = alojamientos;
            Alojamiento t;
            for(int i = 1; i < lista.Count; i++){
                for(int j = lista.Count - 1; j >=i; j--){
                    if(lista[j-1].GetCantidadDePersonas() > lista[j].GetCantidadDePersonas()){
                        t = lista[j-1];
                        lista[j-1] = lista[j];
                        lista[j] = t;
                    }
                }
            }
            return lista;
        }


         public List<Alojamiento> getAlojamientoXCodigo(){
            var lista = new List<Alojamiento>();
            lista = alojamientos;
            Alojamiento t;
            for(int i = 1; i < lista.Count; i++){
                for(int j = lista.Count - 1; j >=i; j--){
                    if(lista[j-1].GetCodigo() > lista[j].GetCodigo()){
                        t = lista[j-1];
                        lista[j-1] = lista[j];
                        lista[j] = t;
                    }
                }
            }
            return lista;
        }




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
            return this.alojamientos.Find(al => al.GetCodigo() == codigoAlojamiento);
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
                else if (cantidadDeAtributosDelAlojamiento == Cabania.CANTIDAD_DE_ATRIBUTOS)
                {
                    this.AgregarAlojamiento(Cabania.Deserializar(alojamiento));
                }
            }
        }
        public bool GuardarCambiosEnElArchivo()
        {
            List<String> alojamientosInLista = new List<string>();
            foreach (Alojamiento al in this.alojamientos)
            {
                alojamientosInLista.Add(al.ToString());
            }
            return Utils.WriteInFile(Config.PATH_FILE_ALOJAMIENTOS, alojamientosInLista);
        }


        /* GETTER */
        public int GetCantidadDeAlojamientos() { return this.cantidadDeAlojamientos; }

    }
}
