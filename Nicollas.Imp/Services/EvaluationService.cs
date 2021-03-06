﻿
namespace Nicollas.Imp.Services
{
    using Microsoft.EntityFrameworkCore;
    using Nicollas.Core;
    using Nicollas.Core.Entities;
    using Nicollas.Core.Factories;
    using Nicollas.Core.Services;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class EvaluationService : Service<Evaluation, int>, IEvaluationService
    {
        private ISubjectFactory subjectFactory;
        private IDomainFactory domainFactory;

        public EvaluationService(IUnitOfWork unitOfWork,
            ISubjectFactory subjectFactory,
            IDomainFactory domainFactory)
            : base(unitOfWork)
        {
            this.subjectFactory = subjectFactory;
            this.domainFactory = domainFactory;
        }

        public async Task InsertEvaluationDataAsync(IList<Evaluation> evalData)
        {
            var alreadyPersisted = (await this.GetAllQueryableByCriteriaAsync(row => evalData.Any(evl => evl.Id == row.Id))).Select(r => r.Id);
            var toPersist = evalData.Where(row => !alreadyPersisted.Any(id => row.Id == id));

            int commitCountdown = 1000;
            int count = 0;
            
            foreach (var item in toPersist)
            {
                count++;
                item.Subject = await this.subjectFactory.GetSubject(item.Subject.Description);
                item.SubjectId = item.Subject.Id;
                item.Subject = null;

                item.Domain = await this.domainFactory.GetDomain(item.Domain.Description);
                item.DomainId = item.Domain.Id;
                item.Domain = null;

                this.Repository.Add(item);

                if (commitCountdown == count)
                {
                    count = 0;
                    await this.UnitOfWork.CommitAsync();
                }

            }
            await this.UnitOfWork.CommitAsync();
        }
    }
}
