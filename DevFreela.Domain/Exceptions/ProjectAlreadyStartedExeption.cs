using System;

namespace DevFreela.Domain.Exceptions
{
    public class ProjectAlreadyStartedExeption : Exception
    {
        public ProjectAlreadyStartedExeption() : base("Project is already in Started status")
        {
                
        }


    }
}
