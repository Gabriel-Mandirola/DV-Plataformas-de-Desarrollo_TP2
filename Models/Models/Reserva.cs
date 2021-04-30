using System;
using System.Collections.Generic;
using System.Text;

using AgenciaDeAlojamientos.Interfaces;

namespace AgenciaDeAlojamientos
{
    class Reserva: ISerializable, IDatosParaLasVistas
    {

        private int id;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private Alojamiento alojamiento;
        private Usuario usuario;
        private double precio;

        public Reserva(int id, DateTime fechaDesde, DateTime fechaHasta, Alojamiento alojamiento, Usuario usuario, double precio)
        {
            this.id = id;
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.alojamiento = alojamiento;
            this.usuario = usuario;
            this.precio = precio;
        }


        /* METODOS DE INTERFACES */
        public string Serializar()
        {
            String objetoSerializado = "";
            objetoSerializado += this.GetId().ToString() + ",";
            objetoSerializado += this.GetFechaDesde() + ",";
            objetoSerializado += this.GetFechaHasta() + ",";
            objetoSerializado += this.GetAlojamiento().GetCodigo().ToString() + ",";
            objetoSerializado += this.GetUsuario().GetDni().ToString() + ",";
            objetoSerializado += this.GetAlojamiento().Precio().ToString();

            return objetoSerializado;
        }
        public List<string> parsearObjetoALista()
        {
            return new List<string>()
            {
                this.id.ToString(),
                this.fechaDesde.ToString(),
                this.fechaHasta.ToString(),
                this.alojamiento.GetCodigo().ToString(),
                this.usuario.GetDni().ToString(),
                this.precio.ToString()
            };
        }


        /* GETTERS Y SETTERS */
        public int GetId() { return this.id; }
        public DateTime GetFechaDesde() { return this.fechaDesde; }
        public DateTime GetFechaHasta() { return this.fechaHasta; }
        public Alojamiento GetAlojamiento() { return this.alojamiento; }
        public Usuario GetUsuario() { return this.usuario; }
        public double GetPrecio() { return this.precio; }
    }
}
