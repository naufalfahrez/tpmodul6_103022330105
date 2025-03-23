using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count > 0)
        {
            this.playCount += count;
        }
        else
        {
            Console.WriteLine("Jumlah play count harus lebih besar dari 0.");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {this.id}");
        Console.WriteLine($"Title: {this.title}");
        Console.WriteLine($"Play Count: {this.playCount}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Naufal Fahreza");

        video.PrintVideoDetails();

        video.IncreasePlayCount(10);

        video.PrintVideoDetails();
    }
}