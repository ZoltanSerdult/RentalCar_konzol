using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RentalCar_konzol
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "rentalcar";
            sb.CharacterSet = "utf8";
            MySqlConnection con = new MySqlConnection(sb.ConnectionString);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT `id`,`rendszam`,`marka`,`model`,`ar` FROM `auto` WHERE 1";
            int legkisebb = 1000000;
            
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                Console.WriteLine("A gépjárművek éves bevétele:");
                while (dr.Read())
                {
                    Auto auto = new Auto(dr.GetInt32("id"), dr.GetString("rendszam"), dr.GetString("marka"), dr.GetString("model"), dr.GetDouble("ar"));
        
                    if (legkisebb > (int)auto.Ar)
                    {
                        legkisebb = (int)auto.Ar;
                    }
                    
                    
                    Console.WriteLine("\t"+auto.Rendszam +" bevétele: " + auto.Ar);
                }
                Console.WriteLine("\nLegkisebb napi kölcsönzési dija a rendszámú\nautónak van /" + legkisebb.ToString() + " Ft /");
                
                
            }
            con.Close();
            Console.ReadLine();
        }
    }
}
