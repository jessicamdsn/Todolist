﻿using Todolist.Models;
// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("welcome to the To do list program!\n" + "what would you like to do?");

// Instancia a classe List, já com os valores obtidos anteriormente
List list = new List();

bool showMenu = true;

// Realiza o loop do menu
while (showMenu)
{
    Console.Clear();
    Console.WriteLine("choose an option:");
    Console.WriteLine("Enter 1 to add a task to the list.");
    Console.WriteLine("Enter 2 to remove a task from the list.");
    Console.WriteLine("Enter 3 to view the list.");
    Console.WriteLine("Enter 0 to exit the program.");

    switch (Console.ReadLine())
    {
        case "1":
            list.AddTask();
            break;

        case "2":
            list.RemoveTask();
            break;

        case "3":
            list.listTasks();
            break;

        case "0":
            showMenu = false;
            break;

        default:
            Console.WriteLine("this is not an option");
            break;
    }

    Console.WriteLine("Press ENTER to continue");
    Console.ReadLine();
}

Console.WriteLine("The program it's closed");