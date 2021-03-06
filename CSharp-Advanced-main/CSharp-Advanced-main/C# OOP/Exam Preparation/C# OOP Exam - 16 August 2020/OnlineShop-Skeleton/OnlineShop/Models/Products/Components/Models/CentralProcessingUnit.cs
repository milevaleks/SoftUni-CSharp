namespace OnlineShop.Models.Products.Components.Models
{
    public class CentralProcessingUnit : Component
    {
        public CentralProcessingUnit(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation) 
            : base(id, manufacturer, model, price, overallPerformance, generation)
        {

        }
        public override double OverallPerformance => base.OverallPerformance * 1.25;
    }
}
