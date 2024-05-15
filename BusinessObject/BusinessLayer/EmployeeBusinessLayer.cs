using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetAllEmployees()
        {
            //Reads the connection string from web.config file. The connection string name is DBCS
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
     
            //Create List of employees collection object which can store list of employees
            List<Employee> employees = new List<Employee>();

            //Establish the Connection to the database
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //Creating the command object by passing the stored procedure that is used to
                //retrieve all the employess from the tblEmployee table and the connection object
                //on which the stored procedure is going to execute
                SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);

                //Specify the command type as stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                //Open the connection
                con.Open();

                //Execute the command and stored the result in Data Reader as the method ExecuteReader
                //is going to return a Data Reader result set
                SqlDataReader rdr = cmd.ExecuteReader();

                //Read each employee from the SQL Data Reader and stored in employee object
                while (rdr.Read())
                {
                    //Creating the employee object to store employee information
                    Employee employee = new Employee();
                    employee.id = Convert.ToInt32(rdr["id"]);
                    employee.name = rdr["name"].ToString();
                    employee.city = rdr["city"].ToString();
                    employee.address = rdr["address"].ToString();                                        

                    //Adding that employee into List of employees collection object
                    employees.Add(employee);
                }
            }
            //Return the list of employees that is stored in the list collection of employees
            return employees;
        }
    }

}
