using System.Runtime.CompilerServices;
using System.Diagnostics;
using System;
using System.Globalization;
class Box
{
    // member variables
    private int length = 3;
    private int height;
    private int width;
    private int volume;

    // public int Width { get; set; }

    public int Volume
    {
        get
        {
            return this.length * this.height * this.width;
        }
    }

    public int Width
    {
        get
        {
            return this.width;
        }
        set
        {
            this.width = value;
        }
    }

    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            height = value;
        }
    }

    public Box(int length, int height, int width)
    {
        this.length = length;
        this.height = height;
        Width = width;
    }

    public void SetLength(int length)
    {
        if (length < 0)
        {
           throw new Exception("Length should be higher than zero");
        }
        this.length = length;
    }

    public int GetLength()
    {
        return this.length;
    }

    public int GetVolume()
    {
        return this.length * this.height * this.width;
    }

    public void DisplayInfo()
    {
        System.Console.WriteLine($"Length is going to be: {length}. Height is going to be: {height}. width is going to be {this.Width}. volume is: {volume = length * this.Width * height}");
    }
}