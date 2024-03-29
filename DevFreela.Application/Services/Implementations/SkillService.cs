﻿using Dapper;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Infra.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace DevFreela.Application.Services.Implementations
{
    public class SkillService : ISkillService
    {
        private readonly DevFreelaDbContext _dbContext;
        private readonly string _connectionString;
        public SkillService(DevFreelaDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _connectionString = configuration.GetConnectionString("DevFreelaCs");
        }
        public List<SkillViewModel> GetAll()
        {
            //dapper
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                var script = "Select Id, Description FROM Skills";

                return sqlConnection.Query<SkillViewModel>(script).ToList();
            }

            //entity frameworkcore
            //var skills = _dbContext.Skills;

            //var skillsViewModel = skills.Select(s => new SkillViewModel(s.Id, s.Description)).ToList();

            //return skillsViewModel;
        }
    }
}
