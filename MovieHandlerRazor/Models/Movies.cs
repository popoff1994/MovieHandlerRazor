namespace MovieHandlerRazor.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int RunningTimeInMins { get; set; }
        public int StudioId { get; set; }

        public Movies()
        {

        }

        public Movies(int id, string title, int year, int runningTimeInMins, int studioId)
        {
            Id = id;
            Title = title;
            Year = year;
            RunningTimeInMins = runningTimeInMins;
            StudioId = studioId;
        }
    }
}
