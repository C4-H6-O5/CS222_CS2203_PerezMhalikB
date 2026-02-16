using System;

public class Song
{
    public string title;
    public string artist;
    public double duration;
    public Song(string title = "Unknown", string artist = "Unknown", double duration = 0.00)
    {
        this.title = title;
        this.artist = artist;
        this.duration = duration;
    }
    public void Display()
    {
        Console.WriteLine($"{title,-20} {artist,-15} {duration, 6:F2}");
    }
    static void Main()
    {
        double totalDuration = 0;

        Console.Write("Songs to add: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Song[] playlist = new Song[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Song #{i + 1}");
            Console.Write("Title: ");
            string title = Console.ReadLine()!;

            Console.Write("Artist: ");
            string artist = Console.ReadLine()!;

            Console.Write("Duration (minutes): ");
            string duration = Console.ReadLine()!;

            if (string.IsNullOrEmpty(artist) && string.IsNullOrEmpty(title) && string.IsNullOrEmpty(duration))
            {
                playlist[i] = new Song();
            } 
            else if (string.IsNullOrWhiteSpace(duration))
            {
                playlist[i] = new Song(title, artist);
            }
            else
            {
                double realDuration = double.Parse(duration);
                playlist[i] = new Song(title, artist, realDuration);
            }
        }
        Console.WriteLine();
        Console.WriteLine("=== || MY PLAYLIST || ===");
        Console.WriteLine($"{"Title",-20} {"Artist",-15} {"Time", 6}");
        Console.WriteLine("----------------------------------------------");

        foreach (Song song in playlist)
        {
            song.Display();
            totalDuration += song.duration;
        }

        Console.WriteLine();
        Console.WriteLine($"\nTotal Duration: {totalDuration:F2} mins");
        Console.WriteLine($"Average Duration: {totalDuration / n:F2} mins");
    }
}