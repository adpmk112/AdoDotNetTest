using crudTest.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace crudTest.Services
{
    public class ContentDao : Utils.SqlUtils
    {
        public ContentDao() : base()
        {
        }

        public ContentDao(IConfiguration configuration) : base(configuration) { }

        public List<Content> selectContentList()
        {
            List<Content> contents = new List<Content>();
            using (SqlConnection con = this.OpenConnection())
            {
                var cmd = con.CreateCommand();
                cmd.CommandText = "Select * from content with (nolock)";

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Content content = new Content();
                        content.id = GetValue<int>(reader["id"]);
                        content.name = GetValue<string>(reader["name"]);
                        content.airDate = GetValue<string>(reader["air_date"]);
                        content.genre = GetValue<string>(reader["genre"]);
                        content.recommendedFor = GetValue<string>(reader["recommended_for"]);
                        content.rating = GetValue<string>(reader["rating"]);
                        content.nbVoting = GetValue<string>(reader["nb_voting"]);
                        content.photo = GetValue<string>(reader["photo"]);
                        content.link = GetValue<string>(reader["link"]);
                        contents.Add(content);
                    }
                    reader.Close();
                }
                con.Close();
            }

            return contents;
        }
    }
}
