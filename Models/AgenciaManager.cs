using System;
using System.Collections.Generic;

using AgenciaDeAlojamientos.Models;
using AgenciaDeAlojamientos.Helpers;

namespace AgenciaDeAlojamientos
{
    public class AgenciaManager
    {
        private Agencia agencia;
        private List<Usuario> usuarios;
        private List<Reserva> reservas;

        private Usuario usuarioLogeado;

        public AgenciaManager()
        {
            this.setAgencia(new Agencia());
            this.usuarios = new List<Usuario>();
            this.reservas = new List<Reserva>();
            this.usuarioLogeado = null;

            this.cargarDatosDeLosUsuarios();
            this.cargarDatosDeLasReservas();
        }

        // TODO: Agregar metodos para los alojamientos

        /* METODOS PARA LAS RESERVAS */
        
        public bool AgregarReserva(DateTime fechaDesde, DateTime fechaHasta, int codigoAlojamiento, int dniUsuario)
        {
            Alojamiento alojamiento = this.GetAgencia().FindAlojamientoForCodigo(codigoAlojamiento);
            Usuario usuario = this.FindUserForDNI(dniUsuario);
            if (alojamiento == null || usuario == null) return false;

            String timestamp = DateTimeOffset.Now.ToUnixTimeSeconds().ToString();
            this.reservas.Add(new Reserva(timestamp, fechaDesde,fechaHasta,alojamiento,usuario,alojamiento.PrecioTotalDelAlojamiento()));
            return true;
        }
        public Reserva FindReservaForId(String id)
        {
            return this.GetReservas().Find(reserva => reserva.GetId() == id);
        }
        private void cargarDatosDeLasReservas()
        {
            List<String> reservasEnLista = Utils.GetDataFile(Config.PATH_FILE_RESERVAS);
            foreach(String reservaSerializada in reservasEnLista)
            {
                String[] reserva = Utils.StringToArray(reservaSerializada);

                Alojamiento alojamiento = this.GetAgencia().FindAlojamientoForCodigo(int.Parse(reserva[3]));
                Usuario usuario = this.FindUserForDNI(int.Parse(reserva[4]));
                if (alojamiento == null || usuario == null) { continue; }

                this.reservas.Add(
                    new Reserva(
                        reserva[0], 
                        DateTime.Parse(reserva[1]), 
                        DateTime.Parse(reserva[2]), 
                        alojamiento,
                        usuario,
                        double.Parse(reserva[5])
                        )
                );
            }
        }
        public bool GuardarCambiosDeLasReservas()
        {
            List<String> reservas = new List<string>();
            foreach (Reserva reserva in this.GetReservas())
                reservas.Add(reserva.ToString());
            return Utils.WriteInFile(Config.PATH_FILE_RESERVAS, reservas);
        }

        /* METODOS PARA LOS USUARIOS */
        public bool AgregarUsuario(int dni, String nombre, String email, String password, bool isAdmin, bool bloqueado)
        {
            this.usuarios.Add(new Usuario(dni,nombre,email,Utils.Encriptar(password), isAdmin,bloqueado));
            return true;
        }
        public bool ModificarUsuario(int dni, String nombre, String email, String password = "")
        {
            int indexUser = this.usuarios.FindIndex(user => user.GetDni() == dni);
            if (indexUser == -1) return false; // Usuario no encontrado

            this.usuarios[indexUser].SetNombre(nombre);
            this.usuarios[indexUser].SetEmail(email);

            if (password == "") return true;
            this.usuarios[indexUser].SetPassword(Utils.Encriptar(password));
            
            return true;
        }
        public bool EliminarUsuario(int dni)
        {
            int indexUser = this.usuarios.FindIndex(user => user.GetDni() == dni);
            if (indexUser == -1) return false;
            this.usuarios.RemoveAt(indexUser);
            return true;
        }
        
        public bool autenticarUsuario(int dni, String password)
        {
            Usuario usuarioEncontrado = this.FindUserForDNI(dni);
            if (usuarioEncontrado == null) return false; // DNI no encontrado
            if (usuarioEncontrado.GetPassword() != Utils.Encriptar(password)) return false; // Contraseña incorrecta
            
            this.usuarioLogeado = usuarioEncontrado;
            return true;
        }
        public void CerrarSession()
        {
            this.usuarioLogeado = null;
        }
        public bool BloquearUsuario(int dni)
        {
            int indexUser = this.usuarios.FindIndex(user => user.GetDni() == dni);
            if (indexUser == -1) return false; // Usuario no encontrado
            this.usuarios[indexUser].SetBloqueado(true);
            return true;
        }
        public bool DesbloquearUsuario(int dni)
        {
            int indexUser = this.usuarios.FindIndex(user => user.GetDni() == dni);
            if (indexUser == -1) return false; // Usuario no encontrado
            this.usuarios[indexUser].SetBloqueado(false);
            return true;
        }
        public Usuario FindUserForDNI(int dni)
        {
            return this.GetUsuarios().Find(user => user.GetDni() == dni);
        }
        private void cargarDatosDeLosUsuarios()
        {
            List<String> usuariosSerializados = Utils.GetDataFile(Config.PATH_FILE_USUARIOS);
            foreach (String usuario in usuariosSerializados)
                this.usuarios.Add(Usuario.Deserializar(usuario));
        }
        public bool GuardarCambiosDeLosUsuarios()
        {
            return Usuario.GuardarCambiosEnElArchivo(this.GetUsuarios());
        }


        /* GETTERS Y SETTERS */
        public List<Usuario> GetUsuarios() { return this.usuarios; }
        public List<Reserva> GetReservas() { return this.reservas; }
        public Agencia GetAgencia() { return this.agencia; }
        public Usuario GetUsuarioLogeado() { return this.usuarioLogeado; }
        private void setAgencia(Agencia agencia) { this.agencia = agencia; }

    }
}
