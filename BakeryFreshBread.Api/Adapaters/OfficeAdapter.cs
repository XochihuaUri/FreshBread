using BakeryFreashBread.models.Services;
using DB;

namespace BakeryFreshBread.Api.Adapaters
{
    public static class OfficeAdapter
    {
        public static Office AdaptMainOfficeToOfficeDB(MainOffice mainOffice)
        {
            Office office = new Office() {
                OfficeId = Guid.NewGuid(),
                OfficeType = OfficeType.MainOffice,
            };
            return office;
        }
        public static Office AdaptSecondOfficeToOfficeDB(SecondOffice secondOffice)
        {
            Office office = new Office()
            {
                OfficeId = Guid.NewGuid(),
                OfficeType = OfficeType.SecondOffice,
            };
            return office;
        }
    }
}
