using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaDeAlojamientos.Helpers
{
    internal class Response
    {
        private bool response;
        private String message;

        public Response(bool response, String message)
        {
            this.response = response;
            this.message = message;
        }

        public bool GetResponse()
        {
            return this.response;
        }
        public String GetMessage()
        {
            return this.message;
        }
    }
}
