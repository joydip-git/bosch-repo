using System;

namespace DOTNET.BOSCH.EMS.CustomExceptions.DaoExceptions
{
    public class DaoException : ApplicationException
    {
        private string _errorMessage;
        private Exception _actualException;

        public DaoException()
        {

        }
        public DaoException(string errorMessage, Exception actualException)
        {
            this._errorMessage = errorMessage;
            this._actualException = actualException;
        }
        public override string Message => this._errorMessage;
        public Exception ActualException => this._actualException;
    }
}
