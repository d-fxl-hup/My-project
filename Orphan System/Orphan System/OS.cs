using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Orphan_System
{
    class OS
    {
        public string emp_id { get; set; }
        public string emp_name { get; set; }
        public string emp_phone { get; set; }
        public string Email { get; set; }
        public string emp_pass { get; set; }
        public string care_id { get; set; }
        public string care_name { get; set; }
        public string care_phone { get; set; }
        public string care_permission { get; set; }
        public string state { get; set; }
        public string area { get; set; }
        public string major { get; set; }
        public string cop_id { get; set; }
        public string cop_name { get; set; }
        public string cop_master { get; set; }
        public string cop_phone { get; set; }
        public string sup_id { get; set; }
        public string sup_name { get; set; }
        public string card_num { get; set; }
        public string sup_phone { get; set; }
        public string sherif_id { get; set; }
        public string sherif_name { get; set; }
        public string street { get; set; }
        public string orphan_id { get; set; }
        public string orphan_name { get; set; }
        public string death_date { get; set; }
        public string age { get; set; }
        public string blood_type { get; set; }
        public string genetic_diseases { get; set; }
        public string lost_id { get; set; }
        public string lost_name { get; set; }
        public string found_date { get; set; }
        public string found_place { get; set; }
        public string force_id { get; set; }
        public string force_name { get; set; }
        public string general_health { get; set; }
        public string force_type { get; set; }
        public string force_place { get; set; }
        public string force_discripe { get; set; }
        public string event_id { get; set; }
        public string event_name { get; set; }
        public string arrest_date { get; set; }
        public string danger_level { get; set; }
        public string crime_type { get; set; }
        public string crime_description { get; set; }


        private const string selectQuery = "Select emp_id as emp_id , emp_pass as emp_pass from OS";



        public static DataTable GetUsers()
        {
            DataTable datatable = new DataTable();
            using (SqlConnection con = new SqlConnection(DBconnection.sqlServerConnString))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(selectQuery, con))
                {

                    Console.Write(selectQuery);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            return datatable;
        }
    }
}
