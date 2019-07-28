using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBindingHomework.Models
{
    public static class VehicleDB
    {
        public static void Apply(Vehicle v)
        {
            //throw new NotImplementedException();

            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Vehicle;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            SqlCommand addcmd = new SqlCommand();
            addcmd.Connection = con;
            addcmd.CommandText = "INSERT INTO Rental(FullName, Make, Model, MakeYear, Miles) " +
                            "VALUES(@fullname, @make, @model ,@year, @miles)";
            addcmd.Parameters.AddWithValue("fullname", v.FullName);
            addcmd.Parameters.AddWithValue("make", v.Make);
            addcmd.Parameters.AddWithValue("model", v.Model);
            addcmd.Parameters.AddWithValue("year", v.Year);
            addcmd.Parameters.AddWithValue("miles", v.Miles);

            try
            {
                con.Open();
                addcmd.ExecuteNonQuery();
            }
            finally {
                con.Close();
            }
        }
    }
}
