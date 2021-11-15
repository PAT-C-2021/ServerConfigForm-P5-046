using System;

namespace ServerConfigForm_P5_046
{
    internal class ServiceHost
    {
        private Type type;

        public ServiceHost(Type type)
        {
            this.type = type;
        }

        public object Close { get; internal set; }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}