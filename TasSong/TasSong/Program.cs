using TasSong.Models;
using TasSong.Services;
using TasSong.Enums;



PlaylistService playlistService = new PlaylistService();
SongService songService = new SongService();
Song song = new Song();


do
{
    Console.WriteLine("1.Musiqi Elave et");
    Console.WriteLine("2.Musiqi Sil");
    Console.WriteLine("3.Musiqi Melumatlari");
    Console.WriteLine("4.Musiqi Yenile");
    Console.WriteLine("5.Musiqi axtar");

    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("id daxil edin");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Musiqi adi daxil edin:");
            string songName = Console.ReadLine();
            Console.WriteLine("Musiqi ifaçisini daxil edin:");
            string artist = Console.ReadLine();
            Console.WriteLine("Musiqi janrini daxil edin:");
            Console.WriteLine("1.Pop");
            Console.WriteLine("2.Rock");
             Console.WriteLine("3.Jazz");
          

            int genreChoice = Convert.ToInt32(Console.ReadLine());
            GenreEnum genre = GenreEnum.Pop;
            switch (genreChoice)
            {
                case 1:
                    genre = GenreEnum.Pop;
                    break;
                case 2:
                    genre = GenreEnum.Rock;
                    break;
                case 3:
                    genre = GenreEnum.Jazz;
                    break;
                
                default:
                    Console.WriteLine("Yanlis secim etdiniz.");
                    break;
            }
            Console.WriteLine("Musiqi müddətini daxil edin (saniyə):");
            int duration = Convert.ToInt32(Console.ReadLine());
            Song newSong = new Song(id, songName, new List<string> { artist }, genre, duration);
            songService.AddSong(newSong);
            var songs = songService.GetAllSongs();
            foreach (var item in songs)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Musiqi elave edildi.");




            break;
        case 2:
            Console.WriteLine("Silmek istediyiniz musiqinin id-sini daxil edin:");
            int deleteId = Convert.ToInt32(Console.ReadLine());
            songService.DeleteSong(deleteId);
            Console.WriteLine("Silindi");

            break;
        case 3:
            Console.WriteLine("Melumatlar:");
            
            song.ToString();

            break;
        case 4:
            Console.WriteLine("Yenilemek istediyiniz musiqinin id-sini daxil edin:");
            int updateId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yeni musiqi adini daxil edin:");
            string newSongName = Console.ReadLine();
            Console.WriteLine("Yeni musiqi ifaçisini daxil edin:");
            string newArtist = Console.ReadLine();
            Console.WriteLine("Yeni musiqi janrini daxil edin:");
            Console.WriteLine("1.Pop");
            Console.WriteLine("2.Rock");
            Console.WriteLine("3.Jazz");
       
            int newGenreChoice = Convert.ToInt32(Console.ReadLine());
            GenreEnum newGenre = GenreEnum.Pop;

            switch (newGenreChoice)
            {
                case 1:
                    newGenre = GenreEnum.Pop;
                    break;
                case 2:
                    newGenre = GenreEnum.Rock;
                    break;
                case 3:
                    newGenre = GenreEnum.Jazz;
                    break;
               
                default:
                    Console.WriteLine("Yanlis secim etdiniz.");
                    break;
            }
            Console.WriteLine("Yeni musiqi müddətini daxil edin (saniyə):");
            int newDuration = Convert.ToInt32(Console.ReadLine());
            Song updatedSong = new Song(updateId, newSongName, new List<string> { newArtist }, newGenre, newDuration);
            songService.UpdateSong(updateId, updatedSong);
            Console.WriteLine("Musiqi yenilendi.");
            break;
        //case 5:
        //    Console.WriteLine("1.Artist adi ile");
        //    Console.WriteLine("2.Musiqi adi ile");
        //    Console.WriteLine("3.Janr ile");
        //    int searchChoice = Convert.ToInt32(Console.ReadLine());
        //    switch (searchChoice) 
        //    {
        //      case 1:
        //            Console.WriteLine("Artist adini daxil edin:");
        //            string artistName = Console.ReadLine();
                    
        //                Console.WriteLine(artistName);
                    
        //            break;
        //        case 2:
        //            Console.WriteLine("Musiqi adini daxil edin:");
        //            string songName1 = Console.ReadLine();
        //            try
        //            {
        //                Song song1 = playlistService.GetSongbyname(songName1);
        //                songService.ShowSongInfo(song1);

        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //            }



                //        break;
                //case 3:
                //    Console.WriteLine("Janr daxil edin");
                //    Enum.TryParse<GenreEnum>(Console.ReadLine(), out GenreEnum genreSearch);
                //    Song songsByGenre = new Song(genreSearch);
                   
                //        Console.WriteLine(songsByGenre);
                    
                    
                    
            //        break;
            //}

            //break;
         

        default:
            Console.WriteLine("Yanlis secim etdiniz.");
            break;
    }

}
while (true);
