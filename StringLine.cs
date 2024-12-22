using System;
using System.Collections.Generic;
using System.Linq;

public class StringLine : IComparable<StringLine>
{
    public string value;

    public StringLine(string value)
    {
        this.value = value;
    }

    private List<string> ToSortedList(StringLine element)
    {
        List<string> list = element.value.Split(' ').OrderBy(w => w.Length).ToList();
        return list;
    }

    public int CompareTo(StringLine y)
    {
        List<string> wordsX = ToSortedList(this);
        List<string> wordsY = ToSortedList(y);

        for (int i = 0; i < Math.Min(wordsX.Count, wordsY.Count); i++)
        {
            if (wordsX[i].Length != wordsY[i].Length)
            {
                return wordsX[i].Length.CompareTo(wordsY[i].Length);
            }
        }

        return wordsX.Count.CompareTo(wordsY.Count);
    }
}