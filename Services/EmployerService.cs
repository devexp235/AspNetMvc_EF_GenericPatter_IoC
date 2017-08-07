﻿using System.Collections.Generic;
using DTO;
using DAL;
using Services.Interfaces;

namespace Services
{
    public class EmployerService : IEmployerService
    {
        private readonly IRepository<Employer> employerRepository = null;

        public EmployerService(IRepository<Employer> employerRepository)
        {
            this.employerRepository = employerRepository;
        }

        public void Delete(Employer entity)
        {
            employerRepository.Delete(entity);
        }

        public Employer GetById(int id)
        {
            return employerRepository.GetById(id);
        }

        public void Insert(Employer entity)
        {
            employerRepository.Insert(entity);
        }

        public IEnumerable<Employer> List()
        {
            return employerRepository.GetAll;
        }

        public void Update(Employer entity)
        {
            employerRepository.Update(entity);
        }
    }
}
