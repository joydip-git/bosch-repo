using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET.BOSCH.EMS.CustomExceptions.BusinessExceptions
{
    public class BusinessObjectException : ApplicationException
    {
        private string _errorMessage;
        private Exception _actualException;

        public BusinessObjectException()
        {

        }
        public BusinessObjectException(string errorMessage, Exception actualException)
        {
            this._errorMessage = errorMessage;
            this._actualException = actualException;
        }
        public override string Message => this._errorMessage;
        public Exception ActualException => this._actualException;
    }
}
