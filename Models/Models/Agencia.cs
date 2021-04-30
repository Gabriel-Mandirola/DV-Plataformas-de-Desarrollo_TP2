
using System;
using System.Collections.Generic;

namespace AgenciaDeAlojamientos
{
    class Agencia
    {
        /* Asegurar que solo el primer objeto creado
         * modifique el archivo de alojamientos */
        private static int cantidadDeObjetos = 1;
        private bool objetoPrincipal = false;
        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */

        private List<Alojamiento> alojamientos;
        private int cantidadDeAlojamientos;

        public Agencia()
        {
            this.alojamientos = new List<Alojamiento>();
            this.cantidadDeAlojamientos = 0;
            this.cargarDatosDeAlojamientos();
        }
        
        // ABM de Alojamientos
        public bool AgregarAlojamiento(Alojamiento alojamiento)
        {
            if (!this.GetObjetoPrincipal()) return false;

            this.alojamientos.Add(alojamiento);
            this.cantidadDeAlojamientos++;
            return true;
        }
        public bool ModificarAlojamiento(Alojamiento alojamiento)
        {
            if (!this.GetObjetoPrincipal()) return false;

            Alojamiento al = this.FindAlojamientoForCodigo(alojamiento.GetCodigo());

            if (al == null) return false;
            
            if (this.EliminarAlojamiento(al) && this.AgregarAlojamiento(alojamiento)) return true;

            return false;
        }
        public bool EliminarAlojamiento(Alojamiento alojamiento)
        {
            if (!this.GetObjetoPrincipal()) return false;

            int indexAlojamiento = this.alojamientos.FindIndex(al => al.GetCodigo() == alojamiento.GetCodigo());
            if (indexAlojamiento == -1) return false; // -1 = no encontro el alojamientos

            // Elimino el alojamiento de la lista
            this.alojamientos.RemoveAt(indexAlojamiento);
            this.cantidadDeAlojamientos--;
            return true;
        }

        public Agencia GetHoteles()
        {
            Agencia agencia = new Agencia();
            foreach(Alojamiento al in this.alojamientos)
            {
                if( al is Hotel)
                {
                    agencia.AgregarAlojamiento(al);
                }
            }
            return agencia;
        }
        public Agencia GetCabanias()
        {
            Agencia agencia = new Agencia();
            foreach (Alojamiento al in this.alojamientos)
            {
                if (al is Cabania)
                {
                    agencia.AgregarAlojamiento(al);
                }
            }
            return agencia;
        }

        public Agencia GetAlojamientosConUnMinimoDeEstrellas(int minimo)
        {
            Agencia agencia = new Agencia();
            foreach (Alojamiento al in this.alojamientos)
            {
                if (al.GetEstrellas() >= minimo)
                {
                    agencia.AgregarAlojamiento(al);
                }
            }
            return agencia;
        }
        public Agencia AlojamientosEntrePrecios(double minimo, double maximo)
        {
            Agencia agencia = new Agencia();
            foreach(Alojamiento al in this.alojamientos)
            {
                if(al.Precio() >= minimo && al.Precio() <= maximo)
                {
                    agencia.AgregarAlojamiento(al);
                }
            }
            return agencia;
        }
        public Agencia GetCabaniasEntrePrecios(double minimo, double maximo)
        {
            Agencia agencia = new Agencia();
            foreach(Alojamiento al in this.alojamientos)
            {
                if ( al is Cabania && al.Precio() >= minimo && al.Precio() <= maximo)
                {
                    agencia.AgregarAlojamiento(al);
                }
            }
            return agencia;
        }
        public Agencia GetHotelesEntrePrecios(double minimo, double maximo)
        {
            Agencia agencia = new Agencia();
            foreach (Alojamiento al in this.alojamientos)
            {
                if (al is Hotel && al.Precio() >= minimo && al.Precio() <= maximo)
                {
                    agencia.AgregarAlojamiento(al);
                }
            }
            return agencia;
        }


        /* METODOS AGREGADOS */
        public Alojamiento FindAlojamientoForCodigo(int codigoAlojamiento)
        {
            return this.alojamientos.Find( al => al.GetCodigo() == codigoAlojamiento );
        }
        public bool ExisteAlojamiento(Alojamiento alojamiento)
        {
            foreach (Alojamiento al in this.alojamientos)
            {
                if (al.IgualCodigo(alojamiento)) return true;
            }
            return false;
        }
        private void cargarDatosDeAlojamientos()
        {
            // Solo se van a cargar los datos con la primer agencia que se cree
            if (Agencia.GetCantidadDeObjetos() > 1) return;

            this.objetoPrincipal = true;

            List<String> contenidoDelArchivo = Utils.GetDataFile(Utils.PATH_FILE_ALOJAMIENTOS);

            if (contenidoDelArchivo == null) return;

            foreach (String alojamiento in contenidoDelArchivo)
            {
                String[] alojamientoArray = Utils.StringSerializadoToArray(alojamiento);
                if (alojamientoArray.Length == Hotel.CANTIDAD_DE_ATRIBUTOS)
                {
                    this.AgregarAlojamiento(Hotel.Deserializar(alojamientoArray));
                }
                else if(alojamientoArray.Length == Cabania.CANTIDAD_DE_ATRIBUTOS)
                {
                    this.AgregarAlojamiento(Cabania.Deserializar(alojamientoArray));
                }
            }

        }
        public bool GuardarCambiosEnElArchivo()
        {
            if (!this.GetObjetoPrincipal()) return false;

            List<String> alojamientosInLista = new List<string>();
            foreach( Alojamiento al in this.alojamientos)
            {
                alojamientosInLista.Add(al.SerializarObjeto());
            }
            return Utils.WriteInFile(Utils.PATH_FILE_ALOJAMIENTOS ,alojamientosInLista);
        }


        /* METODOS ESTATICO */
        private static int GetCantidadDeObjetos()
        {
            int cantidad = Agencia.cantidadDeObjetos;
            Agencia.cantidadDeObjetos++;
            return cantidad;
        }


        /* GETTERS Y SETTERS */
        public int GetCantidadDeAlojamientos()
        {
            return this.cantidadDeAlojamientos;
        }
        public List<Alojamiento> GetAlojamientos()
        {
            return this.alojamientos;
        }

        public bool GetObjetoPrincipal()
        {
            return this.objetoPrincipal;
        }

    }
}
