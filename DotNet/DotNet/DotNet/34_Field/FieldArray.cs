﻿using System;

class Schedule
{
    private string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
    public void PrintWeekDays()
    {
        foreach (var day in weekDays)
        {
            Console.Write($"{day}\t");
        }
        Console.WriteLine();
    }
}

class FieldArray
{
    static void Main()
    {
        Schedule schedule = new Schedule();
        schedule.PrintWeekDays();
    }
}