using PieShop.Data;
using Xunit;

namespace PieShop.Test
{
    public class UnitTest1
    {
        [Fact]
        public void BeInexperiencedWhenNew()
        {
            var pieRepository = new MockPieRepository();
            var pie = pieRepository.GetPieById(3);

            Assert.True(pie != null);
        }

        [Fact]
        public void CalculateFullCategoryName()
        {
            var pieRepository = new MockPieRepository();
            pieRepository.FirstCategoryName = "Sernik";
            pieRepository.LastCategoryName = "Mango";

            Assert.Equal("Sernik Mango", pieRepository.FullCategoryName);
        }

        [Fact]
        public void CalculateFullCategoryNameWithTitleCase()
        {
            var pieRepository = new MockPieRepository();
            pieRepository.FirstCategoryName = "Sernik";
            pieRepository.LastCategoryName = "Mango";

            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", pieRepository.FullCategoryName);
        }

        [Fact]
        public void StartWithDefaultPrice()
        {
            var pieRepository = new MockPieRepository();
            var pie = pieRepository.GetPieById(3);

            Assert.Equal(15.95M, pie.Price);
        }
    }
}
