using MovieHandlerRazor.Models;

namespace MovieHandlerRazor.MockData
{
    public class MockStudios
    {
        public static List<Studios> Studios = new List<Studios>
        {
            new Studios{Id = 1, Name = "Fox", HQCity= "New York", NoOfEmployers = 244},
            new Studios{Id = 1, Name = "ABC", HQCity= "Los Angelos", NoOfEmployers = 322},
            new Studios{Id = 1, Name = "Discorery", HQCity= "Washington DC", NoOfEmployers = 225},
            new Studios{Id = 1, Name = "Viaplay Group", HQCity= "København", NoOfEmployers = 244}
        };
        public static List<Studios> GetAllStudios()
        {
            return Studios;
        }
    }
}
