// See https://aka.ms/new-console-template for more information

using ADONETCOREAPP;
using Microsoft.Data.SqlClient;

Console.WriteLine("** ALL TRAINERS **");

List<Trainer> trainers = new List<Trainer>();

string connectionString =
    "server=.\\sqlexpress; database=arbajadonetdb; integrated security=true;encrypt=false;";

SqlConnection con = new SqlConnection(connectionString);

SqlCommand cmd = new SqlCommand("select * from trainer", con);
con.Open();

SqlDataReader reader= cmd.ExecuteReader();

if (reader.HasRows)
{
    while (reader.Read())
    {
        Trainer t = new Trainer()
        {
            Id = (int)reader["id"],
            Name =  reader["name"].ToString(),
            City =  reader["city"].ToString(),
            experience = (int)reader["experience"]
        };
        trainers.Add(t);
    }
}
else
{
    trainers = null;
}
con.Close();
 


foreach (var item in trainers)
{
    Console.WriteLine($"Id :{item.Id} Name : {item.Name} City :{item.City} Experience :{item.experience}");
}

 


Console.ReadLine(); 