using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace online_coffee.Models
{
    public class BlogEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public BlogEntity(MySqlDataReader reader) {
            this.Title = reader.GetString("title");
            this.Description = reader.GetString("short_desc");
            this.Id = reader.GetInt32("id");
        }
    }
}