using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public ProjectDetailsViewModel(int id, string title, string description, decimal totalCoast, DateTime? startedAt, DateTime? finishedAt, string clientFullName, string freelancerFullName)
        {
            Id = id;
            Title = title;
            Description = description;
            TotalCoast = totalCoast;
            StartedAt = startedAt;
            FinishedAt = finishedAt;
            ClientFullName = clientFullName;
            FreelancerFullName = freelancerFullName;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; set; }
        public decimal TotalCoast { get; private set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? FinishedAt { get; private set; }
        public string ClientFullName { get; set; }
        public string FreelancerFullName { get; set; }

    }
}
