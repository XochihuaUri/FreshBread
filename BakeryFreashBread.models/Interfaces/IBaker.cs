namespace BakeryFreashBread.models.Interfaces
{
    public interface IBaker
    {
        IOrder Order { get; }
        public void ClearTheOrder();
        public double GetOrderPrice();
    }
}
