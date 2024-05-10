namespace _05.TeamworkProjects
{
    class Team
    {
        public string Name { get; }
        public string Creator { get; }
        public List<string> Members { get; }

        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new List<string>();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        { 
        int n = int.Parse(Console.ReadLine());

        var teamsList = new List<Team>();

            for (int i = 0; i<n; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string creator = input[0];
                string teamName = input[1];

                if (teamsList.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teamsList.Any(t => t.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                 Team team = new Team(teamName, creator);
                 teamsList.Add(team);
                 Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

        string joinInput;
        while ((joinInput = Console.ReadLine()) != "end of assignment")
            {
                string[] joinArgs = joinInput.Split("->");
                string user = joinArgs[0];
                string teamName = joinArgs[1];

                Team team = teamsList.FirstOrDefault(t => t.Name == teamName);

                if (team == null)
                 {
                     Console.WriteLine($"Team {teamName} does not exist!");
                     continue;
                 }

                if (teamsList.Any(t => t.Members.Contains(user) || t.Creator == user))
                 {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                 }

                team.Members.Add(user);
            }

            List<Team> validTeamsList = teamsList
                    .Where(t => t.Members.Count > 0)
                    .OrderByDescending(t => t.Members.Count)
                    .ThenBy(t => t.Name).ToList();

            foreach (var validTeam in validTeamsList)
            {
                 Console.WriteLine($"{validTeam.Name}\n- {validTeam.Creator}\n-- {string.Join("\n-- ", validTeam.Members.OrderBy(m => m))}");
            }

            List<Team> disbandedTeamsList = teamsList
            .Where(t => t.Members.Count == 0)
            .OrderBy(t => t.Name).ToList();

            Console.WriteLine("Teams to disband:");
            foreach (var disbandedTeam in disbandedTeamsList)
            {
                 Console.WriteLine(disbandedTeam.Name);
            }
        }
    }   
}
/*
2
John-PowerPuffsCoders 
Tony-Tony is the best
Peter->PowerPuffsCoders 
Tony->Tony is the best 
end of assignment
 */