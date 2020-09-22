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

        public Pie Add(Pie newPie)
        {
            newPie.PieId = _appDbContext.Pies.Max(p => p.PieId) + 1;
            _appDbContext.Pies.Add(newPie);

            return newPie;
        }

        public int Commit()
        {
            return _appDbContext.SaveChanges();
        }

        public Pie Delete(int pieId)
        {
            var pie = GetPieById(pieId);
            if (pie != null)
            {
                _appDbContext.Pies.Remove(pie);
            }

            return pie;
        }

        public Pie GetPieById(int pieId) => _appDbContext.Pies.Find(pieId);

        public IEnumerable<Pie> GetPieByName(string name = null)
        {
            return _appDbContext.Pies.Where(p => string.IsNullOrEmpty(name) || p.Name.StartsWith(name))
                .OrderBy(p => p.Name).Select(p => p).ToList();
        }

        public Pie Update(Pie updatePie)
        {
            var entity = _appDbContext.Pies.Attach(updatePie);
            entity.State = EntityState.Modified;

            return updatePie;
        }
    }
}