using System;
using System.Collections.Generic;
using System.Text;

namespace IrpfApp.BLL
{
    public class IrpfException : Exception
    {

        public IrpfException(Exception ex)
        {
            ErrorMessage = "IRPF ERROR " + ex.Message;
        }

        public IrpfException(String msg)
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
