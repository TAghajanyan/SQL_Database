using System.Collections.Generic;
using System.Linq;

namespace DB_First
{
    public class CRUD
    {
        public List<string> GetJobTitlesAndCompany()
        {
            return new MonitoringEntities().Jobs.Select<Job, string>(x => x.Company.Name + " --> " + x.Title).ToList();
        }

        public bool UpdateGitHubProfileUserName(string userName, string newName)
        {
            MonitoringEntities monitoring = new MonitoringEntities();
            GithubProfile profile = monitoring.GithubProfiles.Select(x => x).FirstOrDefault(x => x.UserName == userName);

            if (profile is null)
                return false;

            profile.Name = newName;
            monitoring.SaveChanges();
            return true;
        }

        public bool DeleteGitHubProfileByID(int Id)
        {
            MonitoringEntities monitoring = new MonitoringEntities();
            GithubProfile profile = monitoring.GithubProfiles.FirstOrDefault(x => x.Id == Id);

            if (profile is null)
                return false;

            monitoring.GithubProfiles.Remove(profile);
            monitoring.SaveChanges();
            return true;
        }

        
    }
}
