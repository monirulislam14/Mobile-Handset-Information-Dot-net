using MobileHandsetInformation.BLL;
using MobileHandsetInformation.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MobileHandsetInformation.DAL
{
    public class MobileHandsetGateway
    {

        string connectionString = @"Server=DESKTOP-EP20VEN\SQLEXPRESS2014;Database=MobileHandsetInfo;Integrated Security=true;";
        public bool SaveMobileInfo(MobileHandset mobile)
        {
          
            SqlConnection connection = new SqlConnection(connectionString);
          
            string query = "INSERT INTO" +
                " MobileHandset(MobileModelName,MobileIMEI,MobilePrice)" +
                "Values('"+mobile.MobileModelName+"'," +
                "'"+mobile.MobileIMEI+"','"+mobile.MobilePrice+"')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
         int rowEffect = command.ExecuteNonQuery();
            connection.Close();
            if (rowEffect > 0)
            {
                return true;
            }
          
             return false;
            

        }
       
        internal bool GetExistMobileHandset(MobileHandset mobile)
        {
       
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM MobileHandset where MobileIMEI='"+mobile.MobileIMEI+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            MobileHandset aMobile = null;
            while (reader.Read())
            {
                // aStudent = new Student();
                int mobielId = (int)reader["MobileId"];
                string modelName = reader["MobileModelName"].ToString();
                string mobileImei = reader["MobileIMEI"].ToString();
               
                int price = (int)reader["MobilePrice"];
                aMobile = new MobileHandset( modelName, mobileImei, price);



            }
            reader.Close();
            connection.Close();

            if (aMobile != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public List<MobileHandset> GetAllMobileAutoLoad()
        {
            List<MobileHandset> mobileList = new List<MobileHandset>();
           
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from MobileHandset ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int mobileId = (int)reader["MobileId"];
                string modelName = reader["MobileModelName"].ToString();
                string imei = reader["MobileIMEI"].ToString();
                int price = (int)reader["MobilePrice"];
                MobileHandset mobile = new MobileHandset(modelName, imei, price);
                mobile.MobileId = mobileId;
                mobileList.Add(mobile);
            }
            reader.Close();
            connection.Close();
            return mobileList;
        }
        public List<MobileHandset> GetAllMobileByPrice(int price1,int price2)
        {
            List<MobileHandset> mobileList = new List<MobileHandset>();
          
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from MobileHandset where MobilePrice>="+price1+"And MobilePrice<="+price2+"";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
          
            while (reader.Read())
            {
                int mobileId = (int)reader["MobileId"];
                string modelName = reader["MobileModelName"].ToString();
                string imei = reader["MobileIMEI"].ToString();
                int price = (int)reader["MobilePrice"];
                MobileHandset mobile = new MobileHandset(modelName, imei, price);
                mobile.MobileId = mobileId;
                mobileList.Add(mobile);
            }
            reader.Close();
            connection.Close();
            return mobileList;
        }
        public List<MobileHandset> GetAllMobileByImei(string searchImei)
        {
            List<MobileHandset> mobileList = new List<MobileHandset>();
          
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from MobileHandset where MobileIMEI='"+searchImei+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int mobileId = (int)reader["MobileId"];
                string modelName = reader["MobileModelName"].ToString();
                string imei = reader["MobileIMEI"].ToString();
                int price = (int)reader["MobilePrice"];
                MobileHandset mobile = new MobileHandset(modelName, imei, price);
                mobile.MobileId = mobileId;
                mobileList.Add(mobile);
            }
            reader.Close();
            connection.Close();
            return mobileList;
        }

    }
}