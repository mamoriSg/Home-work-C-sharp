using System;

namespace project;

struct Book
{
    private string title, avtor, intor;

    private short pages;

    public void setValues(string title, string avtor)
    {
        this.title = title;
        this.avtor = avtor;
    }

    public void print()
    {
        Console.WriteLine(this.avtor + " wrote the book: <<" + this.title + ">>");
    }
}

