using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using E_voting.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_voting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoterController : ControllerBase
    {
        private SqlConnection con;
        private SqlCommand com;

        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["getconn"].ToString();
            con = new SqlConnection(constr);

        }
        public string AddVoter(Voter voter)
        {
            connection();
            com = new SqlCommand("InsertData", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@FName", voter.FirstName);
            com.Parameters.AddWithValue("@Lname", voter.LastName);
            com.Parameters.AddWithValue("@Nic", voter.VoterNIC);
            com.Parameters.AddWithValue("@Address", voter.Address);
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return "New Employee Added Successfully";

            }
            else
            {
                return "Employee Not Added";

            }
        }
    }
}