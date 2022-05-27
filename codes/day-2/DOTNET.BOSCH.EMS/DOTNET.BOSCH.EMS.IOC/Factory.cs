using System;

namespace DOTNET.BOSCH.EMS.IOC
{
    public class Factory
    {
        private static Factory _factory;
        private Factory()
        {

        }
        public static Factory Create()
        {
            if (_factory == null)
                _factory = new Factory();

            return _factory;
        }
        public TInterface Resolve<TInterface, TClass>()
        {
            Type clsMetadata = typeof(TClass);
            object obj = Activator.CreateInstance(clsMetadata);
            return (TInterface)obj;
        }
    }
}
