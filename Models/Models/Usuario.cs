using System;
using System.Collections.Generic;
using System.Text;

using AgenciaDeAlojamientos.Interfaces;

namespace AgenciaDeAlojamientos
{
    class Usuario : ISerializable, IDatosParaLasVistas
    {
        private int dni;
        private String nombre;
        private String email;
        private String password;
        private bool esAdmin;
        private bool bloqueado;

        public Usuario(int dni, String nombre, String email,String password, bool esAdmin, bool bloqueado = false)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.email = email;
            this.password = password;
            this.esAdmin = esAdmin;
            this.bloqueado = bloqueado;
        }

        
        /* METODOS DE INTERFACES */
        public string SerializarObjeto()
        {
            String objetoSerializado = "";
            objetoSerializado += this.GetDni().ToString() + ",";
            objetoSerializado += this.GetNombre() + ",";
            objetoSerializado += this.GetEmail() + ",";
            objetoSerializado += this.GetPassword() + ",";
            objetoSerializado += this.GetEsAdmin().ToString() + ",";
            objetoSerializado += this.GetBloqueado().ToString();

            return objetoSerializado;
        }
        public List<string> parsearObjetoALista()
        {
            return new List<string>() { 
                this.dni.ToString(), 
                this.nombre, 
                this.email, 
                this.esAdmin ? "admin" : "usuario", 
                this.bloqueado ? "si" : "no" 
            };
        }
        public static Usuario Deserializar(String[] UsuarioSerializado)
        {
            return new Usuario(
                int.Parse(UsuarioSerializado[0]),
                UsuarioSerializado[1],
                UsuarioSerializado[2],
                UsuarioSerializado[3],
                bool.Parse(UsuarioSerializado[4]),
                bool.Parse(UsuarioSerializado[5])
                );
        }


        /* GETTERS Y SETTERS */
        public int GetDni(){ return this.dni; }
        public String GetNombre() { return this.nombre; }
        public String GetEmail() { return this.email; }
        public String GetPassword() { return this.password; }
        public bool GetEsAdmin() { return this.esAdmin; }
        public bool GetBloqueado() { return this.bloqueado; }


        public void SetNombre(String nombre) { this.nombre = nombre; }
        public void SetEmail(String email) { this.email = email; }
        public void SetPassword(String password) { this.password = password; }
        public void SetBloqueado(bool isBloqueado) { this.bloqueado = isBloqueado; }

    }
}
