using System;

namespace Singlton
{
    public class Singlton
    {
        private static volatile Singlton _instance;
        private static readonly object _lockObj = new object();

        private Singlton()
        {
            Console.WriteLine("Instance created");
        }

        public static Singlton Instance
        {
            get
            {
                Console.WriteLine("Instance returned");
                if (_instance == null)
                {
                    lock (_lockObj)
                    {
                        if (_instance == null)
                            _instance = new Singlton();
                    }
                }
                return _instance;
            }
        }
    }
}
