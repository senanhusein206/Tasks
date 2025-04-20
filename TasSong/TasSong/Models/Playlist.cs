using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasSong.Models;

public class Playlist
{
   public int Id { get; set; }
   public string PlaylistName { get; set; }
    public  List<Song> Songs { get; set; }
    public Playlist(int id, string playlistName, List<Song> songs)
    {
        Id = id;
        PlaylistName = playlistName;
        Songs = songs;
    }
}

