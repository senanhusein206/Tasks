using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasSong.Exceptions;
using TasSong.Helper;
using TasSong.Models;

namespace TasSong.Services;

public class PlaylistService
{
    private static List<Playlist> Playlists { get; } = [];

    public void AddPlaylist(Playlist playlist)

    {
        if (playlist is null) { 
            throw new Newexception( "Playlist is cannot be null.");

    }

    Playlists.Add(playlist);

Console.WriteLine("Playlist added successfully.");

}


public void AddSongToPlaylist(int id, Song song)

{

    if (song is null)

    {

        throw new Newexception( "Song is cannot be null.");
    }

    foreach (var playlist in Playlists)

    {

        if (playlist.Id == id)

        {

            playlist.Songs.Add(song);

            Console.WriteLine("Song added to playlist successfully.");
                return;
            }

        

    }

}






    public List<Playlist> GetAllPLayLists() 
    {
        return Playlists;
    }
    public void DeleteSongFromPlaylist(int playlistId, int songId)

    {

        foreach (var list  in Playlists)

{

            foreach (var song in list.Songs)

            {

                list.Songs.Remove(song);

                Console.WriteLine("Song deleted from playlist successfully.");

            }

        }

    }

    public void DeletePlaylist(int id)

    {

        foreach (var list  in Playlists)

{

            if (list.Id == id)

            {

                Playlists.Remove(list);

                Console.WriteLine("Playlist deleted successfully.");

            }

        }

    }

    public List<Playlist> GetPlaylists()

    {

        if (Playlists.Count == 0)

        {

            throw new Newexception( "Playlist is empty.");

        }

        return Playlists;

    }


    public Playlist GetPlaylistById(int id)
    {
        foreach (var item in Playlists)
        {

            if (item.Id == id)
            {
                return item;
            }
        }
        throw new Newexception(message: "Playlist does not exist.");

    }




    public Playlist GetPlaylistByName(string name)

    {

        foreach (var list in Playlists)

        {

            if (list.PlaylistName == name)
            {

                return list;

            }
            
        }
        throw new Newexception(message: "Playlist does not exist.");

    }

    public void UpdatePlaylist(int id, Playlist newPlaylist)

{

foreach (var list  in Playlists)

{

if (list.Id == id)

{

list.PlaylistName = newPlaylist.PlaylistName;

list.Songs = newPlaylist.Songs;

}

}

throw new Newexception(message: "Playlist does not exist.");

}


  

    

}
