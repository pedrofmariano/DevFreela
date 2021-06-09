using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class ProjectViewModel
    {
        public ProjectViewModel(string title, DateTime creaatedAt)
        {
            Title = title;
            CreaatedAt = creaatedAt;
        }

        public string Title { get; private set; }
        public DateTime CreaatedAt { get; private set; }
    }
}
