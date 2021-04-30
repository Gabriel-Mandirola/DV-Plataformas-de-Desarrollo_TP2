using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaDeAlojamientos.Helpers
{
    class Response
    {
        private bool response;
        private String mensaje;

        public Response(bool response, String mensaje)
        {
            this.response = response;
            this.mensaje = mensaje;
        }

        public bool GetResponse()
        {
            return this.response;
        }
        public String GetMensaje()
        {
            return this.mensaje;
        }
    }
}
