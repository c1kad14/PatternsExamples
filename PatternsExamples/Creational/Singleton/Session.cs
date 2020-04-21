using System;

namespace PatternsExamples.Creational.Singleton
{
    public sealed class Session
    {
        private static Session _instance;
        public Guid SessionId { get; private set; }
        private Session()
        {
            SessionId = Guid.NewGuid();
        }

        public static Session Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Session();
                }

                return _instance;
            }
        }
    }
}