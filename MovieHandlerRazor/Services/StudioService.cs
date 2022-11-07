using MovieHandlerRazor.MockData;
using MovieHandlerRazor.Models;

namespace MovieHandlerRazor.Services
{
    public class StudioService
    {
        public List<Models.Studios> Studios { get; set; }


        public StudioService()
        {
            Studios = MockStudios.GetAllStudios();
        }

        public List<Studios> GetAllStudios()
        {
            return Studios;
        }
    }
}
