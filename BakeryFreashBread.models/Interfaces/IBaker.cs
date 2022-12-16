using BakeryFreashBread.models.Models;

namespace BakeryFreashBread.models.Interfaces
{
    public interface IBaker
    {
        public List<IBreadOrder> BreadOrders { get; set; }

        public double CalculateTotalPrice();
        public void ClearTheOrder();
        public void PrepareAllOrders(string officeId);
        public void CreateBaguetteOrder(int quantity);
        public void CreateWhiteBreadOrder(int quantity);
        public void CreateEspecialityOfTheOffice(int quantity);
    }
}
