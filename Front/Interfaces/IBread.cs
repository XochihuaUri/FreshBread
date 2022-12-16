namespace BakeryFreashBread.models.Interfaces
{
    public interface IBread
    {
        double Price { get; set; }
        int Flour { get; set; }
        int Water { get; set; }
        int Salt { get; set; }
        int Yeast { get; set; }
        double CookingTime { get; set; }
        double RestingTime { get; set; }
        double FermentTime { get; set; }
        double CookingTemperature { get; set; }
        public void Prepare(int quantity);
    }
}
