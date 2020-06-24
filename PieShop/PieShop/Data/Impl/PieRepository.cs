using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PieShop.Models;

namespace PieShop.Data.Impl
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> AllPies => _appDbContext.Pies.Include(pie => pie.Category);

        public IEnumerable<Pie> PiesOfTheWeek =>
            _appDbContext.Pies.Include(pie => pie.Category).Where(pie => pie.IsPieOfTheWeek);

        public Pie GetPieById(int pieId) => _appDbContext.Pies.FirstOrDefault(pie => pie.PieId == pieId);
    }
}