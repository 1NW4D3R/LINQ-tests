namespace LINQHandsOn
{
  public class CustomerRepository
  {
    public static List<Customer> GetAll()
    {
      return new List<Customer>
      {
        new Customer {
          CustomerId = 1,
          FirstName = "John",
          LastName = "Smith",
          EmailAddress = "j.smith@jsmith.com",
          Phone = "(615) 123-4567"
        },
        new Customer {
          CustomerId = 2,
          FirstName = "Sally",
          LastName = "Jones",
          EmailAddress = "sallyj@jonesinc.com",
          Phone = "(714) 339-9382"
        },
        new Customer {
          CustomerId = 3,
          FirstName = "Joe",
          LastName = "Schmoe",
          EmailAddress = "js@acme.com",
          Phone = "(800) 988-1267"
        },
        new Customer {
          CustomerId = 4005,
          FirstName = "John",
          LastName = "Bean",
          EmailAddress = "Johnb@abccorp.com",
          Phone = "(408) 399-9923"
        },
        new Customer {
          CustomerId = 4006,
          FirstName = "Jean",
          LastName = "Ruton",
          EmailAddress = "Jeanr@abccorp.com",
          Phone = "(403) 399-3323"
        },
        new Customer {
          CustomerId = 4007,
          FirstName = "Tom",
          LastName = "Pordon",
          EmailAddress = "Tom.Pordon@xyzcorp.com",
          Phone = "(949) 838-9321"
        },
        new Customer {
          CustomerId = 4008,
          FirstName = "Jaques",
          LastName = "Bloom",
          EmailAddress = "JBloom@bloomsinc.com",
          Phone = "(619) 388-0009"
        },
        new Customer {
          CustomerId = 4009,
          FirstName = "Jane",
          LastName = "Wale",
          EmailAddress = "Jane.Wale@xyzcorp.com",
          Phone = "(949) 838-2342"
        },
        new Customer {
          CustomerId = 4010,
          FirstName = "James",
          LastName = "Berger",
          EmailAddress = "jamesberger@mortco.com",
          Phone = "(312) 234-1111"
        },
        new Customer {
          CustomerId = 4011,
          FirstName = "Carl",
          LastName = "Frans",
          EmailAddress = "carlfrans@mortco.com",
          Phone = "(312) 234-3484"
        },
        new Customer {
          CustomerId = 4012,
          FirstName = "Wendy",
          LastName = "Chung",
          EmailAddress = "wendychung@mortco.com",
          Phone = "(312) 234-3847"
        },
        new Customer {
          CustomerId = 4013,
          FirstName = "John",
          LastName = "Big",
          EmailAddress = "Johnb@bigent.com",
          Phone = "(310) 665-9993"
        },
        new Customer {
          CustomerId = 4014,
          FirstName = "Thomas",
          LastName = "Randell",
          EmailAddress = "Thomasr@bigent.com",
          Phone = "(310) 665-0923"
        },
        new Customer {
          CustomerId = 4015,
          FirstName = "Ed",
          LastName = "Fitz",
          EmailAddress = "Ed.Fitz@diy.com",
          Phone = "(949) 933-9991"
        },
        new Customer {
          CustomerId = 4016,
          FirstName = "Denielle",
          LastName = "Ingo",
          EmailAddress = "Denielle.Ingo@diy.com",
          Phone = "(949) 933-2239"
        },
        new Customer {
          CustomerId = 4017,
          FirstName = "Sara",
          LastName = "Winston",
          EmailAddress = "Sara.Winston@diy.com",
          Phone = "(949) 933-9239"
        },
        new Customer {
          CustomerId = 4018,
          FirstName = "Tim",
          LastName = "Rankell",
          EmailAddress = "Tim@bigboatco.com",
          Phone = "(412) 398-9399"
        },
        new Customer {
          CustomerId = 4019,
          FirstName = "Juan",
          LastName = "Vente",
          EmailAddress = "jvente@fruitgrowco.com",
          Phone = "(323) 773-3999"
        },
        new Customer {
          CustomerId = 4020,
          FirstName = "Win",
          LastName = "Vu",
          EmailAddress = "wvu@fruitgrowco.com",
          Phone = "(323) 773-7472"
        },
        new Customer {
          CustomerId = 4021,
          FirstName = "Jake",
          LastName = "Peterson",
          EmailAddress = "Jake.Peterson@bigrockco.com",
          Phone = "(653) 393-9382"
        },
        new Customer {
          CustomerId = 4022,
          FirstName = "Bruno",
          LastName = "Smith",
          EmailAddress = "Bruno.Smith@bigrockco.com",
          Phone = "(653) 393-2345"
        },
        new Customer {
          CustomerId = 4023,
          FirstName = "Sally",
          LastName = "Smith",
          EmailAddress = "Sally.Smith@bigrockco.com",
          Phone = "(653) 393-2334"
        },
        new Customer {
          CustomerId = 4024,
          FirstName = "Manny",
          LastName = "More",
          EmailAddress = "Mannym@musicco.com",
          Phone = "(234) 993-3893"
        }
      };
    }
  }
}
