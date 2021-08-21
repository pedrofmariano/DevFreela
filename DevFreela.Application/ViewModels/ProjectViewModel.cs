using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class ProjectViewModel
    {
        public ProjectViewModel(int id, string title, DateTime creaatedAt)
        {
            Id = id;
            Title = title;
            CreaatedAt = creaatedAt;
        }

        public int Id { get; set; }
        public string Title { get; private set; }
        public DateTime CreaatedAt { get; private set; }
    }
}
