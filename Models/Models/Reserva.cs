using System;
using System.Collections.Generic;
using AgenciaDeAlojamientos.Helpers;

namespace AgenciaDeAlojamientos.Models
{
    public class Reserva
    {
        private String id;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private Alojamiento alojamiento;
        private Usuario usuario;
        private double precio;

        public Reserva(String id, DateTime fechaDesde, DateTime fechaHasta, Alojamiento alojamiento, Usuario usuario, double precio)
        {
            this.setId(id);
            this.SetFechaDesde(fechaDesde);
            this.SetFechaDesde(fechaHasta);
            this.SetAlojamiento(alojamiento);
            this.SetUsuario(usuario);
            this.SetPrecio(precio);
        }
        

        /* METODOS ESTATICOS */
        public static bool GuardarCambiosEnElArchivo(List<Reserva> reservas)
        {
            List<String> reservasSerializadas = new List<string>(){};
            foreach(Reserva reserva in reservas)
            {
                reservasSerializadas.Add(reserva.ToString());
            }
            return Utils.WriteInFile(Config.PATH_FILE_RESERVAS, reservasSerializadas);
        }

        /* ToString */
        public override string ToString()
        {
            String objetoSerializado = "";
            objetoSerializado += this.GetId().ToString() + ",";
            objetoSerializado += this.GetFechaDesde() + ",";
            objetoSerializado += this.GetFechaHasta() + ",";
            objetoSerializado += this.GetAlojamiento().GetCodigo().ToString() + ",";
            objetoSerializado += this.GetUsuario().GetDni().ToString() + ",";
            objetoSerializado += this.GetAlojamiento().PrecioTotalDelAlojamiento().ToString();
            return objetoSerializado;
        }

        #region GETTERS Y SETTERS
        public String GetId() { return this.id; }
        public DateTime GetFechaDesde() { return this.fechaDesde; }
        public DateTime GetFechaHasta() { return this.fechaHasta; }
        public Alojamiento GetAlojamiento() { return this.alojamiento; }
        public Usuario GetUsuario() { return this.usuario; }
        public double GetPrecio() { return this.precio; }
        private void setId(String id) { this.id = id; }
        public void SetFechaDesde(DateTime fechaDesde) { this.fechaDesde = fechaDesde; }
        public void SetFechaHasta(DateTime fechaHasta) { this.fechaHasta = fechaHasta; }
        public void SetAlojamiento(Alojamiento alojamiento) { this.alojamiento = alojamiento; }
        public void SetUsuario(Usuario usuario) { this.usuario = usuario; }
        public void SetPrecio(double precio) { this.precio = precio; }
        #endregion

    }
}
