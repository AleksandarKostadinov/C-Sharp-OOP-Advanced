using System;

public class Rectangle : IDrawable
{
    private int height;
    private int width;

    public Rectangle(int height, int width)
    {
        this.Height = height;
        this.Width = width;
    }
    public int Width
    {
        get { return width; }
        private set { width = value; }
    }

    public int Height
    {
        get { return height; }
        private set { height = value; }
    }


    public void Draw()
    {
        DrawLine(this.Width, '*', '*');
        for (int i = 1; i < this.Height - 1; i++)
        {
            DrawLine(this.Width, '*', ' ');
        }

       DrawLine(this.Width, '*', '*');
    }

    private void DrawLine(int width, char end, char middle)
    {
        Console.Write(end);
        for (int i = 1; i < width - 1; i++)
        {
            Console.Write(middle);
        }

        Console.WriteLine(end);
    }
}
