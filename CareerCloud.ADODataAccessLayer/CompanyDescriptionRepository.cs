﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyDescriptionRepository : IDataRepository<CompanyDescriptionPoco>
    {
        public void Add(params CompanyDescriptionPoco[] items)
        {
            string CS = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (CompanyDescriptionPoco item in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Company_Descriptions]
                        ([Id],[Company],[LanguageID],[Company_Name],[Company_Description])
                        VALUES
                         (@Id,@Company,@LanguageID,@Company_Name,@Company_Description)";

                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Company", item.Company);
                    cmd.Parameters.AddWithValue("@LanguageID", item.LanguageId);
                    cmd.Parameters.AddWithValue("@Company_Name", item.CompanyName);
                    cmd.Parameters.AddWithValue("@Company_Description", item.CompanyDescription);
                    //cmd.Parameters.AddWithValue("@Time_Stamp", item.TimeStamp);
                    conn.Open();
                    int rowEffected = cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyDescriptionPoco> GetAll(params Expression<Func<CompanyDescriptionPoco, object>>[] navigationProperties)
        {
            string CS = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"Select [Id],[Company],[LanguageID],[Company_Name],[Company_Description],[Time_Stamp]
                                       FROM [JOB_PORTAL_DB].[dbo].[Company_Descriptions]";
                conn.Open();

                int x = 0;

                SqlDataReader rdr = cmd.ExecuteReader();
                CompanyDescriptionPoco[] appPocos = new CompanyDescriptionPoco[1000];
                while (rdr.Read())
                {
                    CompanyDescriptionPoco poco = new CompanyDescriptionPoco();
                    poco.Id = rdr.GetGuid(0);
                    poco.Company = rdr.GetGuid(1);
                    poco.LanguageId = rdr.GetString(2);
                    poco.CompanyName = rdr.GetString(3);
                    poco.CompanyDescription = rdr.GetString(4);
                    poco.TimeStamp = (byte[])rdr[5];

                    appPocos[x] = poco;
                    x++;
                }

                return appPocos.Where(a => a != null).ToList();

            }
        }

        public IList<CompanyDescriptionPoco> GetList(Expression<Func<CompanyDescriptionPoco, bool>> where, params Expression<Func<CompanyDescriptionPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyDescriptionPoco GetSingle(Expression<Func<CompanyDescriptionPoco, bool>> where, params Expression<Func<CompanyDescriptionPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyDescriptionPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params CompanyDescriptionPoco[] items)
        {
            string CS = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                foreach (CompanyDescriptionPoco item in items)
                {
                    cmd.CommandText = $"DELETE from Company_Descriptions WHERE Id= @ID";
                    cmd.Parameters.AddWithValue("@ID", item.Id);
                    conn.Open();
                    int rowEffected = cmd.ExecuteNonQuery();
                    conn.Close();

                }

            }
        }

        public void Update(params CompanyDescriptionPoco[] items)
        {
            string CS = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (CompanyDescriptionPoco item in items)
                {
                    cmd.CommandText = @"Update [dbo].[Company_Descriptions]
                    SET [Company]= @Company
                       ,[LanguageID]=@LanguageID
                       ,[Company_Name]=@Company_Name
                       ,[Company_Description] = @Company_Description
                                           
                       
                    Where [Id]= @Id";

                    cmd.Parameters.AddWithValue("@Company", item.Company);
                    cmd.Parameters.AddWithValue("@LanguageID", item.LanguageId);
                    cmd.Parameters.AddWithValue("@Company_Name", item.CompanyName);
                    cmd.Parameters.AddWithValue("@Company_Description", item.CompanyDescription);
                    cmd.Parameters.AddWithValue("@Id", item.Id);

                    conn.Open();

                    int rowEffected = cmd.ExecuteNonQuery();
                    conn.Close();


                }

            }
        }
    }
}
