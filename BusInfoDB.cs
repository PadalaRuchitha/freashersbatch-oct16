using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.EnterpriseServices;

namespace Assignment_2.Models
{
    public class BusInfoDB
    {
        public bool Insertbusinfo(BusInfo busdetails)
        {
            using(SqlConnection con = new SqlConnection("data source=.;database=ASP.NET Assignments;integrated security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand("insertbusinfo",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BoardingPoint",busdetails.BoardingPoint);
                cmd.Parameters.AddWithValue("@Traveldate",busdetails.TravelDate);
                cmd.Parameters.AddWithValue("@Amount",busdetails.Amount);
                cmd.Parameters.AddWithValue("@Rating",busdetails.Rating);

                SqlParameter outputparameter = new SqlParameter();
                outputparameter.ParameterName = "@busid";
                outputparameter.SqlDbType = SqlDbType.Int;
                outputparameter.Direction= ParameterDirection.Output;
              
                cmd.Parameters.Add(outputparameter);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                string j = outputparameter.Value.ToString();
                busdetails.BusId = Convert.ToInt32(j);
                if (i >= 1)
                    return true;
                else
                    return false;

            }
        }
        public List<BusInfo> businfos()
        {
            List<BusInfo> buslist = new List<BusInfo>();
            using (SqlConnection con = new SqlConnection("data source=.;database=ASP.NET Assignments;integrated security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand("select * from BusInfo", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt= new DataTable();
              
                con.Open();
                da.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    buslist.Add(
                        new BusInfo
                        {
                            BusId = Convert.ToInt32(dr["BusId"]),
                            BoardingPoint = Convert.ToString(dr["BoardingPoint"]),
                            TravelDate = Convert.ToDateTime(dr["TravelDate"]),
                            Amount= Convert.ToDouble(dr["Amount"]),
                            Rating = Convert.ToInt32(dr["Rating"])
                        });

                }
                return buslist;
            }
        }

        public List<BusInfo> businfosbyamount()
        {
            List<BusInfo> buslist = new List<BusInfo>();
            using (SqlConnection con = new SqlConnection("data source=.;database=ASP.NET Assignments;integrated security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand("businfobyamount", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                con.Open();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    buslist.Add(
                        new BusInfo
                        {
                           
                            BoardingPoint = Convert.ToString(dr["BoardingPoint"]),
                            TravelDate = Convert.ToDateTime(dr["TravelDate"]),
                            Amount = Convert.ToDouble(dr["Amount"]),
                          
                        });

                }
                return buslist;
            }
        }
        public List<BusInfo> businfosbyrating()
        {
            List<BusInfo> buslist = new List<BusInfo>();
            using (SqlConnection con = new SqlConnection("data source=.;database=ASP.NET Assignments;integrated security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand("Bus_View", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                con.Open();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    buslist.Add(
                        new BusInfo
                        {
                            BusId = Convert.ToInt32(dr["BusId"]),
                            BoardingPoint = Convert.ToString(dr["BoardingPoint"]),
                            Rating = Convert.ToInt32(dr["Rating"])
                        });

                }
                return buslist;
            }
        }
        public List<BusInfo> businfosbydate()
        {
            List<BusInfo> buslist = new List<BusInfo>();
            using (SqlConnection con = new SqlConnection("data source=.;database=ASP.NET Assignments;integrated security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand("businfobydate", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                con.Open();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    buslist.Add(
                        new BusInfo
                        {
                            BusId = Convert.ToInt32(dr["BusId"]),
                            BoardingPoint = Convert.ToString(dr["BoardingPoint"]),
                            TravelDate = Convert.ToDateTime(dr["TravelDate"]),
                           
                        });

                }
                return buslist;
            }
        }
        public List<BusInfo> businfosbyboardingpoint()
        {
            List<BusInfo> buslist = new List<BusInfo>();
            using (SqlConnection con = new SqlConnection("data source=.;database=ASP.NET Assignments;integrated security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand("businfobyboardingpoint", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                con.Open();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    buslist.Add(
                        new BusInfo
                        {
                            BusId = Convert.ToInt32(dr["BusId"]),
                            BoardingPoint = Convert.ToString(dr["BoardingPoint"]),
                            TravelDate = Convert.ToDateTime(dr["TravelDate"]),
                            Amount = Convert.ToDouble(dr["Amount"]),
                            Rating = Convert.ToInt32(dr["Rating"])
                        });

                }
                return buslist;
            }
        }

    }
}