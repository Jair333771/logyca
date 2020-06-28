using com.prueba.jair.Core.interfaces;
using com.prueba.jair.DAL.context;
using com.prueba.jair.DAL.entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace com.prueba.jair.DAL.Repository
{
    public class EnterpriseRepository : AppRepository<Enterprise>, IRepository<Enterprise>
    {
        public EnterpriseRepository(ApiDbContext context) : base(context)
        {
            this.context = context;
        }

        public Enterprise GetByNit(decimal nit)
        {
            var obj = context.Enterprises
                 .Where(x => x.Id == nit)
                 .Include(x => x.CodeList).ToList()
                 .FirstOrDefault();

            return obj;
        }
    }
}
