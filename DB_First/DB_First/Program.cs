using System;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace DB_First
{
    class Program
    {
        static void Main(string[] args)
        {

            var cc = ModelCreator.CreateNewModel();

            var context = new MonitoringEntities();

            CRUD crud = new CRUD();
            foreach (var item in crud.GetJobTitlesAndCompany())
            {
                Console.WriteLine(item);
            }

            if (crud.DeleteGitHubProfileByID(12))
            {
                Console.WriteLine("Succsess!!!");
            }
            else
            {
                Console.WriteLine("Faild");
            }

            if (crud.UpdateGitHubProfileUserName("sebas252", "Narlennnnnnnnbbbbbbbbbbbnn"))
            {
                Console.WriteLine("Succsess2!!!");
            }
            else
            {
                Console.WriteLine("Faild2");
            }

        }
    }
}
