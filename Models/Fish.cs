using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CoreLogicFish.Models;

public class Fish
{
    public string Name { get; private set; }
    public int Caught { get; private set; }
    public Fish(string name, int caught)
    {
        Name = name;
        Caught = caught;
    }
}