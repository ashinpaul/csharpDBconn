using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connstr = "server=localhost;
            user = root;
            database = sys;
            port = 3306;
            password=rajagiri";
            MySqlConnection conn = new MySqlConnection(connstr);
            try
            {
                Console.WriteLine("Connection to sql");
                conn.Open();
            }
        }
    }
}
