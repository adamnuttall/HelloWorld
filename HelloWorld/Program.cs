using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
  public class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine(CreateMessage());
    }

    public static string CreateMessage()
    {
      return "Hello World";
    }
  }
}
