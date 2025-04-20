using TasSong.Helper;

namespace TasSong.Models
{
    public class Song
    {

        public int Id { get; set; }
        public string SongName { get; set; }
        public List<string> ArtistName { get; set; }
        public GenreEnum Genre { get; set; }
        public int Duration { get; set; }

        public Song(int id,string songName,List<string> artistName,GenreEnum genre,int duration)
        {
            Id = id;
            SongName = songName;
            ArtistName = artistName;
            Genre = genre;
            Duration = duration;
                

        }
        public Song()
        {
            
        }
        //}

        public  string ToString()
        {
            return $"Id: {Id}, Song Name: {SongName}, Artist Name: {string.Join(", ", ArtistName)}, Genre: {Genre}, Duration: {Duration}";
        }
    }
}