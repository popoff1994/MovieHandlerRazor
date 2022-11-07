using MovieHandlerRazor.Models;

namespace MovieHandlerRazor.MockData
{
    public class MockMovies
    {
        public static int _nextId = 1;

        public static List<Movies> Data = new List<Movies>
        {
        new Movies { Id = _nextId++, Title = "Den bedste film", Year = 2012, RunningTimeInMins = 98, StudioId = 1 },
        new Movies { Id = _nextId++, Title = "Den dårligeste film", Year = 2014, RunningTimeInMins = 111, StudioId = 2 },
        new Movies { Id = _nextId++, Title = "Den nyeste film", Year = 2022, RunningTimeInMins = 88, StudioId = 3 },
        new Movies { Id = _nextId++, Title = "Den ældste film", Year = 1962, RunningTimeInMins = 67, StudioId = 2 },
        };

        public static List<Movies> GetAllMovies()
        {
            return Data;
        }
    }
}
