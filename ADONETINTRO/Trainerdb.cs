using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETINTRO
{
    public class Trainerdb
    {
        //1.select all trainers
        public void Alltrainers(out List<Trainer>trainers,out List<student>students)
        {
            #region select record from one table
            //List<Trainer> trainers = new List<Trainer>();

            //string connectionString = "server =.\\sqlexpress;database=arbajadonetdb;" +
            //    " integrated security=true;";

            ////SqlConnection con = new SqlConnection();
            ////con.ConnectionString = connectionString;

            //SqlConnection con=new SqlConnection(connectionString);
            //con.Open();

            //string cmdText = " select id,name,city,experience from trainer";

            //SqlCommand cmd = new SqlCommand(cmdText, con);

            //SqlDataReader reader= cmd.ExecuteReader();

            //if(reader.HasRows)
            //{
            //    while(reader.Read())
            //    {
            //        Trainer t = new Trainer();
            //        t.Id =(int)reader["Id"];
            //        t.Name = reader["Name"].ToString();
            //        t.City = reader["City"].ToString();
            //        t.Experience = (int)reader["Experience"];

            //        trainers.Add(t);
            //    }

            //}
            //con.Close();
            //return trainers;
            #endregion select record from one table


            #region select record from two table
            //trainers=new List<Trainer>();
            //students=new List<student>();

            //string connectionString =
            //    "server=.\\sqlexpress;database=arbajadonetdb;integrated security=true;";

            //SqlConnection con=new SqlConnection(connectionString);

            //con.Open();
            //string cmdText ="select id,name,city,experience from trainer; select Rollnumber, Name, Gender, Trainerid from student";

            //SqlCommand cmd = new SqlCommand(cmdText, con);
            ////con.Open();

            //SqlDataReader reader = cmd.ExecuteReader();

            //while (reader.Read())
            //{
            //    Trainer t = new Trainer();
            //{ 
            //    t.Id = (int)reader["Id"];
            //    t.Name = reader["Name"].ToString();
            //    t.City = reader["City"].ToString();
            //    t.Experience = (int)reader["Experience"];
            //};

            //    trainers.Add(t);
            //}
            //reader.NextResult(); // it will point to next resultset

            //while (reader.Read())
            //{
            //    student s = new student()
            //    {
            //        Rollnumber = (int)reader["RollNumber"],
            //        Name = reader["Name"].ToString(),
            //        Gender = reader["Gender"].ToString(),
            //        Trainerid = (int)reader["TrainerId"]
            //    };

            //    students.Add(s);
            //}
            //con.Close();
            #endregion select record from two table

            #region select record from two table using SqlDataAdapter

            trainers= new List<Trainer>();
            students= new List<student>();

            string connectionString=
                "server=.\\sqlexpress; database=arbajadonetdb;integrated security=true;";

            SqlConnection con=new SqlConnection(connectionString);

            string cmdText = "select id,name,city,experience from trainer; select Rollnumber, Name, Gender, Trainerid from student";

            SqlDataAdapter adapter=
                new SqlDataAdapter(cmdText, con);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if(ds !=null && ds.Tables.Count > 0)
                if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        var row = ds.Tables[0].Rows[i];
                        Trainer t = new Trainer()
                        {
                            Id = (int)row["Id"],
                            Name = row["Name"].ToString(),
                            City = row["City"].ToString(),
                            Experience = (int)row["Experience"]
                        };

                        trainers.Add(t);
                    }
                }
            if (ds.Tables[1] != null && ds.Tables[1].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                {
                    var row = ds.Tables[1].Rows[i];

                    student s = new student()
                    {
                        Rollnumber = (int)row["RollNumber"],
                        Name = row["Name"].ToString(),
                        Gender = row["Gender"].ToString(),
                        Trainerid = (int)row["TrainerId"]
                    };

                    students.Add(s);
                }
            }




            #endregion select record from two table using SqlDataAdapter
        }
    }
}
