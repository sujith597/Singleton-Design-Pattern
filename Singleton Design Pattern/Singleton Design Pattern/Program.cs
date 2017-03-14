using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonLoadBalancer balancer1 = SingletonLoadBalancer.GetLoadInstance();
            SingletonLoadBalancer balancer2 = SingletonLoadBalancer.GetLoadInstance();

            if (balancer1 == balancer2) {
                Console.WriteLine("Both are having same instance");
            }

            for (int i = 0; i < 10; i++) {
                string server = balancer1.server;
                Console.WriteLine("Called server is : " + server);
            }

            Console.ReadKey();
        }
    }

    class SingletonLoadBalancer
    {
        private static SingletonLoadBalancer _loadBalancer;
        private List<string> _servers = new List<string>();
        private Random _random = new Random();

        private static object _lock = new object();

        protected SingletonLoadBalancer()
        {
            _servers.Add("Server I");
            _servers.Add("Server II");
            _servers.Add("Server III");
        }


        public static SingletonLoadBalancer GetLoadInstance() {
            if (_loadBalancer == null)
            {
                lock (_lock) {
                    _loadBalancer = new SingletonLoadBalancer();
                }
            }
            return _loadBalancer;
        }

        public string server {
            get {
                int r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }
    }
}
