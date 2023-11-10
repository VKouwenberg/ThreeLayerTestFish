using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLogicFish.Models;
using DataAccessFish.Repositories;

namespace CoreLogicFish.Services;

public class FishService
{
    private FishRepo repository = new();

    public void FishCommands()
    {
        string command = "";
        Console.WriteLine("Enter ADDFISH to add a fish");
        Console.WriteLine("Enter LISTFISH to see all fish");
        try
        {
            command = Convert.ToString(Console.ReadLine());
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Error. Please enter a fish!");
            Console.ResetColor();
        }
        switch (command)
        {
            case ("ADDFISH"):
                repository.CreateNewFish();
                break;
            case ("LISTFISH"):
                ListAllFish();
                break;
        }
    }

    public void ListAllFish()
    {

    }
    /*public List<Fish> GetAllFish() 
    {
    }*/
}
