namespace LINQHandsOn
{
  public class ProductRepository
  {
    public static List<Product> GetAll()
    {
      return new List<Product>
      {
        new Product {
          ProductId = 2,
          ProductName = "FRAM Engine Air Filter",
          Category = "Engine Air Filters",
          Price = 15.49M,
          YearBegin = 1992,
          YearEnd = 2015
        },
        new Product {
          ProductId = 3,
          ProductName = "K&N Engine Air Filter",
          Category = "Engine Air Filters",
          Price = 84.99M,
          YearBegin = 2016,
          YearEnd = 2021
        },
        new Product
        {
          ProductId = 4,
          ProductName = "Autolite Iridium Iridium XP Spark Plug",
          Category = "Spark Plugs",
          Price = 7.99M,
          YearBegin = 1992,
          YearEnd = 2015
        },
        new Product
        {
          ProductId = 5,
          ProductName = "Champion Copper Plus Spark Plug",
          Category = "Spark Plugs",
          Price = 2.79M,
          YearBegin = 2016,
          YearEnd = 2021
        },
        new Product
        {
          ProductId = 6,
          ProductName = "DieHard Gold Battery",
          Category = "Batteries",
          Price = 169.99M,
          YearBegin = 1992,
          YearEnd = 2015
        },
        new Product
        {
          ProductId = 7,
          ProductName = "Autocraft Silver Battery",
          Category = "Batteries",
          Price = 149.99M,
          YearBegin = 2016,
          YearEnd = 2021
        },
        new Product
        {
          ProductId = 8,
          ProductName = "Carquest Premium Alternator",
          Category = "Alternators",
          Price = 199.99M,
          YearBegin = 1992,
          YearEnd = 2015
        },
        new Product
        {
          ProductId = 9,
          ProductName = "ACDelco Alternator",
          Category = "Alternators",
          Price = 182.99M,
          YearBegin = 2016,
          YearEnd = 2021
        },
        new Product
        {
          ProductId = 10,
          ProductName = "Carquest Premium Water Pump",
          Category = "Water Pumps",
          Price = 134.99M,
          YearBegin = 1992,
          YearEnd = 2015
        },
        new Product
        {
          ProductId = 11,
          ProductName = "ACDelco Engine Water Pump",
          Category = "Water Pumps",
          Price = 188.99M,
          YearBegin = 2016,
          YearEnd = 2021
        },
        new Product
        {
          ProductId = 12,
          ProductName = "Beck/Arnley Cylinder Head Gasket Set",
          Category = "Gaskets",
          Price = 199.99M,
          YearBegin = 1992,
          YearEnd = 2015
        },
        new Product
        {
          ProductId = 13,
          ProductName = "DongA Mfg. Corp. DongA Cylinder Head Gasket Set",
          Category = "Gaskets",
          Price = 112.84M,
          YearBegin = 2016,
          YearEnd = 2021
        },
        new Product
        {
          ProductId = 14,
          ProductName = "Carquest Premium Radiator",
          Category = "Radiator",
          Price = 208.99M,
          YearBegin = 1992,
          YearEnd = 2015
        },
        new Product
        {
          ProductId = 15,
          ProductName = "ACDelco GM Original Equipment Radiator",
          Category = "Radiator",
          Price = 268.36M,
          YearBegin = 2016,
          YearEnd = 2021
        },
        new Product
        {
          ProductId = 16,
          ProductName = "Autel Tire Sensor",
          Category = "Tires",
          Price = 42.99M,
          YearBegin = 1992,
          YearEnd = 2015
        },
        new Product
        {
          ProductId = 17,
          ProductName = "Schrader Tire Pressure Monitoring System",
          Category = "Tires",
          Price = 46.99M,
          YearBegin = 2016,
          YearEnd = 2021
        },
        new Product
        {
          ProductId = 18,
          ProductName = "Carquest Premium Gold Ceramic Brake Pads",
          Category = "Brake Pads",
          Price = 53.99M,
          YearBegin = 1992,
          YearEnd = 2015
        },
        new Product
        {
          ProductId = 19,
          ProductName = "ACDelco Ceramic Front Disc Brake Pad Set",
          Category = "Brake Pads",
          Price = 62.99M,
          YearBegin = 2016,
          YearEnd = 2021
        },
        new Product
        {
          ProductId = 20,
          ProductName = "PurolatorBOSS Air Filter",
          Category = "Cabin Air Filter",
          Price = 27.99M,
          YearBegin = 1992,
          YearEnd = 2015
        },
        new Product
        {
          ProductId = 21,
          ProductName = "Carquest Premium Cabin Air Filter",
          Category = "Cabin Air Filter",
          Price = 18.99M,
          YearBegin = 2016,
          YearEnd = 2021
        },
        new Product
        {
          ProductId = 22,
          ProductName = "Dorman - Help Interior Door Handle",
          Category = "Door Handles",
          Price = 63.99M,
          YearBegin = 1992,
          YearEnd = 2015
        },
        new Product
        {
          ProductId = 23,
          ProductName = "AutoCraft Interior Door Handle",
          Category = "Door Handles",
          Price = 23.99M,
          YearBegin = 2016,
          YearEnd = 2021
        },
        new Product
        {
          ProductId = 24,
          ProductName = "AutoCraft Car & SUV Floor Mat",
          Category = "Floor Mats",
          Price = 26.49M,
          YearBegin = 1992,
          YearEnd = 2015
        },
        new Product
        {
          ProductId = 25,
          ProductName = "Dee Zee All Season Floor Mats",
          Category = "Floor Mats",
          Price = 34.99M,
          YearBegin = 2016,
          YearEnd = 2021
        },
        new Product
        {
          ProductId = 26,
          ProductName = "AutoCraft Car & SUV Seat Cover",
          Category = "Seat Cover",
          Price = 17.95M,
          YearBegin = 1992,
          YearEnd = 2015
        },
        new Product
        {
          ProductId = 28,
          ProductName = "Bell Automotive Sunset Blanket Seat Cover",
          Category = "Seat Cover",
          Price = 21.45M,
          YearBegin = 2016,
          YearEnd = 2021
        },
        new Product
        {
          ProductId = 29,
          ProductName = "Meguiar's Gold Class Car Wash & Wax",
          Category = "Car Wash",
          Price = 10.99M,
          YearBegin = 1992,
          YearEnd = 2015
        },
        new Product
        {
          ProductId = 30,
          ProductName = "Armor All Ultra Shine Wash & Wax",
          Category = "Car Wash",
          Price = 5.99M,
          YearBegin = 2016,
          YearEnd = 2021
        },
        new Product
        {
          ProductId = 31,
          ProductName = "Turtlewax 1-Step Wax and Dry",
          Category = "Wax",
          Price = 7.79M,
          YearBegin = 1992,
          YearEnd = 2015
        },
        new Product
        {
          ProductId = 33,
          ProductName = "Meguiar's Smooth Surface Clay Kit",
          Category = "Wax",
          Price = 24.99M,
          YearBegin = 2016,
          YearEnd = 2021
        },
        new Product
        {
          ProductId = 34,
          ProductName = "Meguiar's Hot Rims Wheel Cleaner",
          Category = "Tire Cleaner",
          Price = 6.99M,
          YearBegin = 1992,
          YearEnd = 2015
        },
        new Product
        {
          ProductId = 35,
          ProductName = "Eagle One All Wheel & Tire Triple Cleaning Foam",
          Category = "Tire Cleaner",
          Price = 6.99M,
          YearBegin = 2016,
          YearEnd = 2021
        },
        new Product
        {
          ProductId = 36,
          ProductName = "Dorman - Help Real License Plate Bracket",
          Category = "License Plate",
          Price = 31.99M,
          YearBegin = 1992,
          YearEnd = 2015
        },
        new Product
        {
          ProductId = 37,
          ProductName = "Keystone Collision License Plate Frame",
          Category = "License Plate",
          Price = 19.99M,
          YearBegin = 2016,
          YearEnd = 2021
        }
      };
    }
  }
}
