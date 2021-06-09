using DevFreela.Domain.Entities;
using System;
using System.Collections.Generic;

namespace DevFreela.Infra.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto 1", "descrição projeto 1", 1, 1, 10000),
                new Project("Meu projeto 2", "descrição projeto 2", 1, 1, 20000),
                new Project("Meu projeto 3", "descrição projeto 3", 1, 1, 30000)

            };
            Users = new List<User>
            {
                new User("Pedro Mariano", "dev@dev.com", new DateTime(1994, 11, 21)),
                new User("Cleytinho", "cleyton@ocleyton.com", new DateTime(1999, 12, 12))
            };
            Skills = new List<Skill>
            {
                new Skill(".NET"),
                new Skill("Angular"),
                new Skill("React")
            };
        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}
