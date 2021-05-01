using System;
using System.Collections.Generic;
using System.Text;
using AgenciaDeAlojamientos.Helpers;
using AgenciaDeAlojamientos.Interfaces;

namespace AgenciaDeAlojamientos.Models
{
    internal class Usuario
    {
        private int dni;
        private String nombre;
        private String email;
        private String password;
        private bool isAdmin;
        private bool bloqueado;

        public Usuario(int dni, String nombre, String email,String password, bool isAdmin, bool bloqueado = false)
        {
            this.SetDni(dni);
            this.SetNombre(nombre);
            this.SetEmail(email);
            this.SetPassword(password);
            this.SetIsAdmin(isAdmin);
            this.SetBloqueado(bloqueado);
        }

        
        /* METODOS DE INTERFACES */
        public static Usuario Deserializar(String UsuarioSerializado)
        {
            String[] usuarioArray = Utils.StringToArray(UsuarioSerializado);
            return new Usuario(
                int.Parse(usuarioArray[0]),
                usuarioArray[1],
                usuarioArray[2],
                usuarioArray[3],
                bool.Parse(usuarioArray[4]),
                bool.Parse(usuarioArray[5])
                );
        }

        /* ToString */
        public override string ToString()
        {
            String objetoSerializado = "";
            objetoSerializado += this.GetDni().ToString() + ",";
            objetoSerializado += this.GetNombre() + ",";
            objetoSerializado += this.GetEmail() + ",";
            objetoSerializado += this.GetPassword() + ",";
            objetoSerializado += this.GetIsAdmin().ToString() + ",";
            objetoSerializado += this.GetBloqueado().ToString();
            return objetoSerializado;
        }

        #region GETTERS Y SETTERS
        public int GetDni(){ return this.dni; }
        public String GetNombre() { return this.nombre; }
        public String GetEmail() { return this.email; }
        public String GetPassword() { return this.password; }
        public bool GetIsAdmin() { return this.isAdmin; }
        public bool GetBloqueado() { return this.bloqueado; }

        public void SetDni(int dni) { this.dni = dni; }
        public void SetNombre(String nombre) { this.nombre = nombre; }
        public void SetEmail(String email) { this.email = email; }
        public void SetPassword(String password) { this.password = password; }
        public void SetIsAdmin(bool isAdmin) { this.isAdmin = isAdmin; }
        public void SetBloqueado(bool bloqueado) { this.bloqueado = bloqueado; }
        #endregion
    
    }
}
