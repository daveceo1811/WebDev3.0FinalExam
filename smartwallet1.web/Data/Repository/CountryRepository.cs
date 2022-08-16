using Microsoft.EntityFrameworkCore;
using WalletPlusInc.web.Data.Entities;
using WalletPlusInc.web.Data.Repository.Interface;
using WalletPlusInc.Web.Data.Repositories;

namespace WalletPlusInc.web.Data.Repository
{
    public class CountryRepository : Repository<Country, Guid>
    {
        public CountryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
