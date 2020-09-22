using System.Collections.Generic;
using PieShop.Models;
using PieShop.ViewModels;

namespace PieShop.Data
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie GetPieById(int pieId);
        IEnumerable<Pie> GetPieByName(string name);
        Pie Update(Pie updatePie);
        Pie Add(Pie addPie);
        Pie Delete(int pieId);
        int Commit();
    }
}