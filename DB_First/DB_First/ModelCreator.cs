using System.Collections.Generic;
using System.Linq;

namespace DB_First
{
    class ModelCreator
    {
        public static List<dynamic> CreateNewModel()
        {
            MonitoringEntities monitoring = new MonitoringEntities();
            var newModel = new List<dynamic>();

            foreach (var item in monitoring.GithubLinkedinCrossTables)
            {
                if (monitoring.GithubProfiles.Select(x => x.Id).Contains(item.GithubUserId))
                    newModel.Add(new { Id = item.Id, GitUserName = monitoring.GithubProfiles.FirstOrDefault(x => x.Id == item.GithubUserId).UserName,
                                                     LinkUserName = monitoring.LinkedinProfiles.FirstOrDefault(x => x.Id == item.LinkedinUserId).Username });
            }

            return newModel;
        }
    }
}
