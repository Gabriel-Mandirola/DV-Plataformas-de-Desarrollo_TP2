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

        private Usuario usuarioRegistrado;

        public AgenciaManager()
        {
            this.setAgencia(new Agencia());
            this.usuarios = new List<Usuario>();
            this.reservas = new List<Reserva>();
            this.usuarioRegistrado = null;

            this.cargarDatosDeLosUsuarios();
        }

        // TODO: Agregar metodos para las reservas

        // TODO: Agregar metodos para los alojamientos

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
            
            this.usuarioRegistrado = usuarioEncontrado;
            return true;
        }
        public void CerrarSession()
        {
            this.usuarioRegistrado = null;
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
        public bool GuardarCambiosEnLosUsuarios()
        {
            return Usuario.GuardarCambiosEnElArchivo(this.GetUsuarios());
        }


        /* GETTERS Y SETTERS */
        public List<Usuario> GetUsuarios() { return this.usuarios; }
        public List<Reserva> GetReservas() { return this.reservas; }
        public Usuario GetUsuarioRegistrado() { return this.usuarioRegistrado; }
        private void setAgencia(Agencia agencia) { this.agencia = agencia; }

    }
}
