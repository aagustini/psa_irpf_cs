using System;
using System.Collections.Generic;
using System.Text;

namespace IrpfApp.BLL
{
    class DAOException : Exception
    {
        public DAOException(Exception ex)
        {
            ErrorMessage = "IRPF ERROR " + ex.Message;
        }

        public DAOException(String msg)
        {
            ErrorMessage = msg;
        }


        private String ErrorMessage { get; set; }

        public override String Message
        {
            get { return ErrorMessage; }
        }
    }
}
