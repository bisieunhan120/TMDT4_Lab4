using System.ComponentModel;
namespace TMDT_Lab4.Helper
{
    public enum SortCriteria
    {
        [Description("Relevance")]
        Relevance = 0,
        [Description("Price: Low to High")]
        PriceLowToHigh = 1,
        [Description("Price: High to Low")]
        PriceHighToLow = 2
    }
}