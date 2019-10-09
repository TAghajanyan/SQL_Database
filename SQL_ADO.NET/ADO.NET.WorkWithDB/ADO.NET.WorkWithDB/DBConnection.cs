﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.WorkWithDB
{
    class DBConnection
    {
        string connectionString;
        public DBConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool GetInfoFromDB(out List<GithubProfileModel> profiles)
        {
            profiles = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "select * from GithubProfile";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            profiles = new List<GithubProfileModel>();
                            while (reader.Read())
                            {
                                int row = reader.GetOrdinal("id");
                                profiles.Add(
                                    new GithubProfileModel
                                    {
                                        Id = reader.GetSqlInt32(row).Value,
                                        UserName = (string)GetValue(reader, "UserName"),
                                        Url = (string)GetValue(reader, "Url"),
                                        Company = (string)GetValue(reader, "Company"),
                                        Name = (string)GetValue(reader, "Name"),
                                        Bio = (string)GetValue(reader, "Bio"),
                                        Location = (string)GetValue(reader, "Location"),
                                        Email = (string)GetValue(reader, "Email"),
                                        BlogOrWebsite = (string)GetValue(reader, "BlogOrWebsite"),
                                        StarsCount = reader.GetInt32(reader.GetOrdinal("StarsCount")),
                                        ImageUrl = (string)GetValue(reader, "ImageUrl"),
                                        LastUpdate = (DateTime?)GetValue(reader, "LastUpdate"),
                                    }
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception e) when (e is InvalidOperationException || e is SqlException)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public static object GetValue(SqlDataReader reader, string index)
        {
            if (reader[index] is DBNull)
                return null;
            return reader[index];
        }

        public bool WriteInTable(List<GithubProfileModel> profiles)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "create table NewGithubProfile([Id] int NOT NULL, UserName nvarchar(450) NOT NULL, Url nvarchar(max) NULL, Company nvarchar(max) NULL," +
                                   "Name nvarchar(max) NULL, Bio nvarchar(max) NULL, Location nvarchar(max) NULL, Email nvarchar(max) NULL, BlogOrWebsite nvarchar(max) NULL," +
                                   "StarsCount int NOT NULL, ImageUrl varchar(max) NULL, LastUpdate datetime NULL,)";

                    //using (SqlCommand command = new SqlCommand(query, connection))
                    //{
                    //    command.ExecuteNonQuery();
                    //}


                    foreach (var item in profiles)
                    {
                        query = $"Insert into NewGithubProfile Values({item.Id}, {item.UserName}, @{item.Url}, {item.Company}, {item.Name}, {item.Bio}, {item.Location}, {item.Email}, {item.BlogOrWebsite}, {item.StarsCount}, @{item.ImageUrl}, {item.LastUpdate})";

                        using (SqlCommand commandX = new SqlCommand(query, connection))
                        {
                            commandX.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
    }
}


