namespace LINQHandsOn
{
  public class OrderHeaderRepository
  {
    public static List<OrderHeader> GetAll()
    {
      return new List<OrderHeader>
      {
        new OrderHeader {
          OrderHeaderId = 4,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Jul  1 2021  4:41PM"),
          PromotionalCode = null
        },
        new OrderHeader {
          OrderHeaderId = 5,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Jul  1 2021  4:49PM"),
          PromotionalCode = "TWENTYPERCENT"
        },
        new OrderHeader {
          OrderHeaderId = 6,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Jul  1 2021  4:50PM"),
          PromotionalCode = "TWENTYPERCENT"
        },
        new OrderHeader {
          OrderHeaderId = 7,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Jul  1 2021  4:52PM"),
          PromotionalCode = "TWENTYPERCENT"
        },
        new OrderHeader {
          OrderHeaderId = 8,
          CustomerId = 2,
          OrderDate = Convert.ToDateTime("Jul  2 2021 11:07AM"),
          PromotionalCode = null
        },
        new OrderHeader {
          OrderHeaderId = 9,
          CustomerId = 2,
          OrderDate = Convert.ToDateTime("Jul  2 2021 11:11AM"),
          PromotionalCode = null
        },
        new OrderHeader {
          OrderHeaderId = 10,
          CustomerId = 2,
          OrderDate = Convert.ToDateTime("Jul  2 2021 11:27AM"),
          PromotionalCode = "ANYTIMETENPERCENT"
        },
        new OrderHeader {
          OrderHeaderId = 11,
          CustomerId = 2,
          OrderDate = Convert.ToDateTime("Jul  2 2021 11:33AM"),
          PromotionalCode = "TWENTYPERCENT"
        },
        new OrderHeader {
          OrderHeaderId = 12,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Jul  2 2021  4:18PM"),
          PromotionalCode = null
        },
        new OrderHeader {
          OrderHeaderId = 13,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Jul 11 2021 12:42PM"),
          PromotionalCode = null
        },
        new OrderHeader {
          OrderHeaderId = 14,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Jul 11 2021 12:43PM"),
          PromotionalCode = null
        },
        new OrderHeader {
          OrderHeaderId = 15,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Jul 11 2021 12:44PM"),
          PromotionalCode = null
        },
        new OrderHeader {
          OrderHeaderId = 16,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Jul 11 2021 12:45PM"),
          PromotionalCode = null
        },
        new OrderHeader {
          OrderHeaderId = 17,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Jul 11 2021 12:45PM"),
          PromotionalCode = null
        },
        new OrderHeader {
          OrderHeaderId = 1013,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Jul 12 2021  7:48AM"),
          PromotionalCode = null
        },
        new OrderHeader {
          OrderHeaderId = 2013,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Jul 18 2021 11:32AM"),
          PromotionalCode = "TWENTYPERCENT"
        },
        new OrderHeader {
          OrderHeaderId = 2014,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Jul 18 2021 11:38AM"),
          PromotionalCode = "TWENTYPERCENT"
        },
        new OrderHeader {
          OrderHeaderId = 2015,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Jul 19 2021  8:13AM"),
          PromotionalCode = null
        },
        new OrderHeader {
          OrderHeaderId = 2016,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Jul 19 2021  8:15AM"),
          PromotionalCode = null
        },
        new OrderHeader {
          OrderHeaderId = 2017,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Jul 19 2021  8:15AM"),
          PromotionalCode = null
        },
        new OrderHeader {
          OrderHeaderId = 2018,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Jul 19 2021 10:10AM"),
          PromotionalCode = null
        },
        new OrderHeader {
          OrderHeaderId = 2019,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Jul 19 2021 10:56AM"),
          PromotionalCode = null
        },
        new OrderHeader {
          OrderHeaderId = 2020,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Jul 19 2021 11:26AM"),
          PromotionalCode = null
        },
        new OrderHeader {
          OrderHeaderId = 2021,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Jul 24 2021 12:16PM"),
          PromotionalCode = null
        },
        new OrderHeader {
          OrderHeaderId = 3021,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Jul 29 2021  9:21AM"),
          PromotionalCode = null
        },
        new OrderHeader {
          OrderHeaderId = 3022,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Aug  4 2021  9:09AM"),
          PromotionalCode = null
        },
        new OrderHeader {
          OrderHeaderId = 4022,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Aug 10 2021  9:04AM"),
          PromotionalCode = "TWENTYPERCENT"
        },
        new OrderHeader {
          OrderHeaderId = 4023,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Aug 10 2021  2:23PM"),
          PromotionalCode = null
        },
        new OrderHeader {
          OrderHeaderId = 4024,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Aug 10 2021  2:25PM"),
          PromotionalCode = null
        },
        new OrderHeader {
          OrderHeaderId = 4025,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Aug 10 2021  3:40PM"),
          PromotionalCode = null
        },
        new OrderHeader {
          OrderHeaderId = 5022,
          CustomerId = 1,
          OrderDate = Convert.ToDateTime("Aug 30 2021 12:56PM"),
          PromotionalCode = null
        }
      };
    }
  }
}
