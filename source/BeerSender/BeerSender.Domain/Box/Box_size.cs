﻿namespace BeerSender.Domain.Box;

public class Box_size
{
    public int Number_of_bottles { get; }

    private Box_size(int number_of_bottles)
    {
        Number_of_bottles = number_of_bottles;
    }

    public static Box_size Create(int number_of_bottles)
    {
        switch (number_of_bottles)
        {
            case 6:
            case 12:
            case 24:
                return new(number_of_bottles);
        }

        throw new Exception("Invalid number of bottles.");
    }
}