using System;
using System.Collections.Generic;
using System.Text;


public class Song
{
    private string artistName;
    private string songName;
    private string length;

    public Song(string artistName, string songName, string length)
    {
        this.ArtistName = artistName;
        this.SongName = songName;
        this.Length = length;
    }

    public string ArtistName
    {
        get { return artistName; }
        set { if (value.Length < 3 || value.Length > 20) throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
            artistName = value; }
    }
    
    public string SongName
    {
        get { return songName; }
        set {if (value.Length < 3 || value.Length > 30) throw new ArgumentException("Song name should be between 3 and 30 symbols.");
            songName = value; }
    }
    
    public string Length
    {
        get { return length; }
        set
        {
            string[] str = value.Split(':');
            int mins = int.Parse(str[0]);
            int secs = int.Parse(str[1]);
            if (mins < 0 || mins > 14) throw new ArgumentException("Song minutes should be between 0 and 14.");
            if (secs < 0 || secs > 59)
            {
                throw new ArgumentException("Song seconds should be between 0 and 59.");
                
            }
            length = value;
        }
    }

    




}
