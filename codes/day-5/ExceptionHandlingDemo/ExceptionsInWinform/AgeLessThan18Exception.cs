using System;

namespace ExceptionsInWinform
{
    public class AgeLessThan18Exception : ApplicationException
    {
        private string _errorMessage;
        public AgeLessThan18Exception()
        {

        }

        public AgeLessThan18Exception(string errorMessage)
        {
            _errorMessage = errorMessage;
        }
        //public AgeLessThan18Exception(string errorMessage)
        //    : base(errorMessage)
        //{

        //}
        public override string Message => _errorMessage;
    }
}
