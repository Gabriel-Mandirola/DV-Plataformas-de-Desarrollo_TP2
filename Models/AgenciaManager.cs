using System;
using System.Collections.Generic;

using AgenciaDeAlojamientos.Models;
using AgenciaDeAlojamientos.Helpers;

namespace AgenciaDeAlojamientos
{
    internal class AgenciaManager
    {
        private Agencia agencia;
        private List<Usuario> usuarios;
        private List<Reserva> reservas;

        public AgenciaManager()
        {
            this.setAgencia(new Agencia());

            // Esto va a ser reemplazado por los metodos de cargarDatosDeLosUsuarios y cargarDatosDeLasReservas
            this.usuarios = new List<Usuario>();
            this.reservas = new List<Reserva>();
        }

        // TODO: Agregar metodos para las reservas

        // TODO: Agregar metodos para los alojamientos

        // TODO: Agregar metodos para los usuarios


        /* GETTERS Y SETTERS */
        public List<Usuario> GetUsuarios() { return this.usuarios; }
        public List<Reserva> GetReservas() { return this.reservas; }
        private void setAgencia(Agencia agencia) { this.agencia = agencia; }

    }
}
