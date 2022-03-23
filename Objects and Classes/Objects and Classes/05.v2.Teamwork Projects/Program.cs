using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.v2.Teamwork_Projects
{
    class Team
    {
        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Users { get; set; } 
        public static bool Select { get; internal set; }

        public Team(string teamName, string creatorName)
        {
            Users = new List<string>();
            this.TeamName = teamName;
            this.CreatorName = creatorName;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = AddTeam(numberOfTeams);
            DisplayTeams(teams);
        }

        static List<Team> AddTeam(int numOfTeams)
        {
            List<Team> teams = new List<Team>();
            for (int i = 0; i < numOfTeams; i++)
            {

                string[] tokens = Console.ReadLine().Split("-");
                string creatorToCreate = tokens[0];
                string teamToCreate = tokens[1];

                if (!teams.Select(x => x.TeamName).Contains(teamToCreate))
                {
                    if (!teams.Select(x => x.CreatorName).Contains(creatorToCreate))
                    {
                        Team newTeam = new Team(teamToCreate, creatorToCreate);
                        teams.Add(newTeam);
                        Console.WriteLine($"Team {teamToCreate} has been created by {creatorToCreate}!");
                    }
                    else
                    {
                        Console.WriteLine($"{creatorToCreate} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamToCreate} was already created!");
                }      
            }
            teams = AddMembers(teams).ToList();
            return teams;
        }

        static List<Team> AddMembers(List<Team> teams) 
        {
            string input = Console.ReadLine();
            while (input != "end of assignment")
            {
                string[] tokens = input.Split("->",StringSplitOptions.RemoveEmptyEntries);
                string memberToAdd = tokens[0];
                string teamToAddInto = tokens[1];

                if (!teams.Select(team => team.TeamName).Contains(teamToAddInto))
                {
                    Console.WriteLine($"Team {teamToAddInto} does not exist!");
                }
                else if (teams.Select(team => team.CreatorName).Contains(memberToAdd) ||
                        teams.Select(team => team.Users).Any(n=>n.Contains(memberToAdd)))
                { 
                    Console.WriteLine($"Member {memberToAdd} cannot join team {teamToAddInto}!");
                }
                else
                {
                    int creatorIndex = teams.FindIndex(i => i.TeamName == teamToAddInto);
                    teams[creatorIndex].Users.Add(memberToAdd);
                }

                input = Console.ReadLine();
            }
            return teams;
        }
        static void DisplayTeams(List<Team> teams)
        {
            var disbandList = teams.OrderBy(x => x.TeamName).Where(x => x.Users.Count == 0);

            teams = teams.OrderByDescending(x => x.Users.Count)
                .ThenBy(x => x.TeamName)
                .Where(x => x.Users.Count > 0)
                .ToList();

            foreach (var team in teams.Where(t => t.Users.Count > 0))
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.CreatorName}");

                foreach (var member in team.Users.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var member in disbandList)
            {
                Console.WriteLine($"{member.TeamName}");
            }
        }
    }
}
