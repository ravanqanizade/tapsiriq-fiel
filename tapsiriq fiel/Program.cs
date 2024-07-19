using System;

class Point
{
    public int x { get; set; }
    public int y { get; set; }

    public Point() 
    {
        x = 0;
        y = 0;
    }

    public Point(int x, int y) 
    {
        this.x = x;
        this.y = y;
    }

    public void ShowData()
    {
        Console.WriteLine($"x: {x}, y: {y}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point defaultPoint = new Point();
        defaultPoint.ShowData();

        Point paramPoint = new Point(5, 10);
        paramPoint.ShowData();
    }
}
