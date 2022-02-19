using Saraja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Saraja.Repository.IRepository
{
    public interface ILegalEntityRepository
    {

        Task<ICollection<LegalEntity>> GetEntities();
        Task<LegalEntity> GetLegalEntityByID(int entityId);
        void InsertEntity(LegalEntity legalEntity);
        void DeleteLegalEntity(int legalEntityID);
        void UpdateLegalEntity(LegalEntity legalEntity);
    }
}
