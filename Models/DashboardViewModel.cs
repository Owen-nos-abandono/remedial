namespace ArroyoSecoGastronomia.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }

    public class DashboardViewModel
    {
        public string UserName { get; set; } = string.Empty;
        public int RestaurantCount { get; set; }
        public int ActiveReservations { get; set; }
        public int PendingCount { get; set; }
        public List<Restaurant> Restaurants { get; set; } = new();
    }
}
