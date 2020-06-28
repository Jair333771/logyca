using com.prueba.jair.Core.interfaces;
using com.prueba.jair.DAL.context;
using com.prueba.jair.DAL.entities;
using System.Collections.Generic;
using System.Linq;

namespace com.prueba.jair.DAL.Repository
{
    public class CodeRepository : AppRepository<Code>, IRepository<Code>
    {
        public CodeRepository(ApiDbContext context) : base(context)
        {
            this.context = context;
        }

        public List<Code> GetAllByOwnerId(int ownerid)
        {
            var list = context.Code
                .Join(context.Code, e => e.Id, c => c.OwnerId, (E, C) => new { E, C })
                .Where(x => x.E.Id == ownerid)
                .Select(r => r.C).ToList();

            return list;
        }

        public Enterprise GetEnterpriseByCodeId(int codeid)
        {
            var obj = context.Enterprises
                .Join(context.Code, e => e.Id, c => c.OwnerId, (E, C) => new { E, C })
                .Where(x => x.C.Id == codeid)
                .Select(r => r.E).FirstOrDefault();

            return obj;
        }
    }
}
