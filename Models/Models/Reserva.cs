using System;

namespace AgenciaDeAlojamientos.Models
{
    internal class Reserva
    {
        private int id;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private Alojamiento alojamiento;
        private Usuario usuario;
        private double precio;

        public Reserva(int id, DateTime fechaDesde, DateTime fechaHasta, Alojamiento alojamiento, Usuario usuario, double precio)
        {
            this.setId(id);
            this.SetFechaDesde(fechaDesde);
            this.SetFechaDesde(fechaHasta);
            this.SetAlojamiento(alojamiento);
            this.SetUsuario(usuario);
            this.SetPrecio(precio);
        }
        

        /* METODOS ESTATICOS */


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
        public int GetId() { return this.id; }
        public DateTime GetFechaDesde() { return this.fechaDesde; }
        public DateTime GetFechaHasta() { return this.fechaHasta; }
        public Alojamiento GetAlojamiento() { return this.alojamiento; }
        public Usuario GetUsuario() { return this.usuario; }
        public double GetPrecio() { return this.precio; }
        private void setId(int id) { this.id = id; }
        public void SetFechaDesde(DateTime fechaDesde) { this.fechaDesde = fechaDesde; }
        public void SetFechaHasta(DateTime fechaHasta) { this.fechaHasta = fechaHasta; }
        public void SetAlojamiento(Alojamiento alojamiento) { this.alojamiento = alojamiento; }
        public void SetUsuario(Usuario usuario) { this.usuario = usuario; }
        public void SetPrecio(double precio) { this.precio = precio; }
        #endregion

    }
}
