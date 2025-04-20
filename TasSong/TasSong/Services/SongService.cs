using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasSong.Helper;
using TasSong.Models;

namespace TasSong.Services;

public class SongService
{
    public static List<Song> _songs { get; } = new List<Song>();

    public void AddSong(Song song)
    {
        _songs.Add(song);
    }
    public List<Song> GetAllSongs()
    {
        return _songs;
    }
    public Song GetSongById(int id)
    {
        try
        {
            foreach (var item in _songs)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
        }
        catch
        {
            throw new Exception("An error occurred while retrieving the song.");
        }
        return null;
    }
    public void UpdateSong(int id, Song updatedSong)
    {
        
    }
    public void DeleteSong(int id)
    {
        var song = GetSongById(id);
        if (song != null)
        {
            _songs.Remove(song);
        }
        try
        {
            foreach (var item in _songs)
            {
                if (item.Id == id)
                {
                    _songs.Remove(item);
                }
            }
        }
        catch
        {
            throw new Exception("An error occurred while deleting the song.");
        }
    }

    

    public Song FilterSong(List<string> artistName,string songName, GenreEnum genre)
    {

        foreach (var item in _songs)

        {
            if (item.ArtistName == artistName||item.SongName==songName|| item.Genre==genre)
            {
                return item;
            }
        }
        throw new Exception($"-bu adli artist tapilmadi");
    }


    public void ShowSongInfo(Song song)
    {
        Console.WriteLine($"Name;{song.SongName} janr: {song.Genre} Duration: {song.Duration}");
    }

}
