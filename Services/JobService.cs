﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Interfaces;

namespace Services
{
    public class JobService : IJobService
    {
        private IRepository<Job> jobRepository;

        public JobService(IRepository<Job> jobRepository)
        {
            this.jobRepository = jobRepository;
        }

        public IEnumerable<Job> GetJobs()
        {
            return jobRepository.GetAll;
        }

        public Job GetJob(long id)
        {
            return jobRepository.GetById(id);
        }

        public void InsertJob(Job person)
        {
            jobRepository.Insert(person);
        }

        public void UpdateJob(Job person)
        {
            jobRepository.Update(person);
        }

        public void DeleteJob(Job job)
        {
            jobRepository.Delete(job);
        }

    }
}
