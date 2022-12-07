namespace BakeryFreashBread.models.Interfaces
{
    public interface IBreadOrder
    {
        int Quantity { get; set; }
        IBread Bread { get; set; }
        double OrderPrice { get; set; }
    }
}
