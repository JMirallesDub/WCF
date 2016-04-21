using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TestService
{
    class MyService : IMyService
    {
        string cstring = "Data Source = (localdb)\\ProjectsV12; Initial Catalog = Pollens; Integrated Security = True";

        
        public List<City> GetAllCities()
        {
            List<City> LC = new List<City>();
            SqlConnection cn = new SqlConnection(cstring);

            SqlCommand cmd = new SqlCommand("SELECT DISTINCT  CIUDAD FROM[dbo].[polenes]", cn);
            cn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                City c = new City();
                c.ciudad = Convert.ToString(dr[0]);
                LC.Add(c);
            }

            return LC;
        }

        public List<Pollens> GetAllPollens()
        {
            List<Pollens> LP = new List<Pollens>();
            SqlConnection cn = new SqlConnection(cstring);

            SqlCommand cmd = new SqlCommand("Select polen, nombre_grafico from nombre_polenes", cn);

            cn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Pollens p = new Pollens();
                p.polen = Convert.ToString(dr[0]);
                p.nombre_grafico = Convert.ToString(dr[1]);                
                LP.Add(p);
            }

            return LP;
        }

        public string GetData()
        {
            return "JEMiralles";
        }

        public int GetNumber(int a, int b)
        {
            return a * b;
        }

        public List<Pollen> GetPollens(string initial_date, string final_date, string city, string name_pollen)
        {
            List<Pollen> LP = new List<Pollen>();
            string ConnectionString = "Data Source = (localdb)\\ProjectsV12; Initial Catalog = Pollens; Integrated Security = True";

            SqlConnection cn = new SqlConnection(ConnectionString);

            SqlCommand cmd = new SqlCommand("Select fecha, ciudad," + name_pollen + " from polenes where fecha between '" + initial_date + "' and '" + final_date + "'  and " + "ciudad like '" + city + "'", cn);

            cn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Pollen p = new Pollen();
                p.date = Convert.ToString(dr[0]);
                p.city = Convert.ToString(dr[1]);
                p.name_pollen = dr[2].ToString();
                LP.Add(p);
            }

            return LP;
        }


    }
}
