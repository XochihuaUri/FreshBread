
namespace BakeryFreashBread.models.Interfaces
{
    public interface IBaker
    {
        public List<IBreadOrder> BreadOrders { get; set; }

        public double CalculateTotalPrice();
        public Task PrepareAllOrdersAsync(string officeId);
        public void CreateBaguetteOrder(int quantity);
        public void CreateWhiteBreadOrder(int quantity);
        public void CreateEspecialityOfTheOffice(int quantity);
    }
}
