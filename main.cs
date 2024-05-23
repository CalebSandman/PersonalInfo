using System;

class Program {
  public static void Main (string[] args) {
    //creating the arrays containing personal information
    string [] person0 = {"Caleb Sandman", "04/14/2004", "813-847-4265", "813-847-4265"};
    string [] person1 = {"Lucinda Potter", "06/24/1992", "000-000-0101", "000-000-0189"};
    string [] person2 = {"John Smith", "08/15/1978", "000-111-0101", "000-111-0189"};
    string [] person3 = {"Chris Johnson", "12/01/1987", "000-222-1010", "000-222-0189"};
    string [] person4 = {"Robert Hall", "02/27/1949", "000-444-0101", "000-444-0189"};

    //writes out the info for each person then a blank line between each person
    for(int i = 0; i < person1.Length; i++)
    {
      Console.WriteLine(person1[i]);
    }
    Console.WriteLine("");

    for(int i = 0; i < person2.Length; i++)
    {
      Console.WriteLine(person2[i]);
    }
    Console.WriteLine("");

    for(int i = 0; i < person3.Length; i++)
    {
      Console.WriteLine(person3[i]);
    }
    Console.WriteLine("");

    for(int i = 0; i < person4.Length; i++)
    {
      Console.WriteLine(person4[i]);
    }
  }
}