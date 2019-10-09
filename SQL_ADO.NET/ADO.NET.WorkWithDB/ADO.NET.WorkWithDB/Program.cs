using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.WorkWithDB
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=DESKTOP-1E9TT7S\SQLEXPRESS2017;Initial Catalog=Monitoring;Integrated Security=True;";
            DBConnection connection = new DBConnection(conStr);
            List<GithubProfileModel> profiles;
            connection.GetInfoFromDB(out profiles);
            connection.WriteInTable(profiles);
        }
    }
}
