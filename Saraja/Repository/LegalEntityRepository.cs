using Microsoft.EntityFrameworkCore;
using Saraja.Models;
using Saraja.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Saraja.Repository
{
    public class LegalEntityRepository : ILegalEntityRepository
    {
        private SarajaContext context;

        public LegalEntityRepository(SarajaContext context)
        {
            this.context = context;
        }

        public void DeleteLegalEntity(int legalEntityID)
        {
            LegalEntity legalEntity = context.LegalEntity.Find(legalEntityID);
            context.LegalEntity.Remove(legalEntity);
        }

        public async Task<ICollection<LegalEntity>> GetEntities()
        {
            return await context.LegalEntity.ToListAsync();
        }

        public async Task<LegalEntity>  GetLegalEntityByID(int entityId)
        {
            return await context.LegalEntity.FindAsync(entityId);
        }

        public void InsertEntity(LegalEntity legalEntity)
        {
            context.LegalEntity.Add(legalEntity);
        }

        public void UpdateLegalEntity(LegalEntity legalEntity)
        {
            context.Entry(legalEntity).State = EntityState.Modified;
        }
    }
}
