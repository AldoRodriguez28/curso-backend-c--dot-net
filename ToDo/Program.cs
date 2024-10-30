using System;
using System.Collections.Generic;

namespace ToDo;
    internal class Program
    {
        public static List<string> TaskList { get; set; } = new List<string>();

        static void Main(string[] args)
        {
            int menuSelected = 0;
            do
            {
                menuSelected = ShowMainMenu();
                if ((Menu)menuSelected == Menu.Add)
                {
                    ShowMenuAdd();
                }
                else if ((Menu)menuSelected == Menu.Remove)
                {
                    ShowMenuRemove();
                }
                else if ((Menu)menuSelected == Menu.List)
                {
                    ShowMenuTaskList();
                }
            } while ((Menu)menuSelected != Menu.Exit);
        }
        public static int ShowMainMenu()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Ingrese la opción a realizar: ");
            Console.WriteLine("1. Nueva tarea");
            Console.WriteLine("2. Remover tarea");
            Console.WriteLine("3. Tareas pendientes");
            Console.WriteLine("4. Salir");

            string responseUser = Console.ReadLine();
            return Convert.ToInt32(responseUser);
        }

        public static void ShowMenuRemove()
        {
            try
            {
                Console.WriteLine("Ingrese el número de la tarea a remover: ");
                // Show current taks
                imprimirListaDeTareas();

                string responseUser = Console.ReadLine();
                // Remove one position because the array starts in 0
                int indexToRemove = Convert.ToInt32(responseUser) - 1;

                if(indexToRemove > (TaskList.Count + 1) || indexToRemove < 0 ){
                    Console.WriteLine("Numero de tarea seleccionado invalido");
                }else{
                    if (indexToRemove > -1 && TaskList.Count > 0)
                        {
                                string task = TaskList[indexToRemove];
                                TaskList.RemoveAt(indexToRemove);
                                Console.WriteLine($"Tarea {task} eliminada");
                        }
                }

              
            }
            catch (Exception)
            {
            }
        }

        public static void ShowMenuAdd()
        {
            try
            {
                Console.WriteLine("Ingrese el nombre de la tarea: ");
                string newTask = Console.ReadLine();
                TaskList.Add(newTask);
                Console.WriteLine("Tarea registrada");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al agregar tarea");

            }
        }

        public static void ShowMenuTaskList()
        {
            if (TaskList?.Count > 0)
            {
               imprimirListaDeTareas();

            } 
            else
            {
                Console.WriteLine("No hay tareas por realizar");
            }
        }
        public static void imprimirListaDeTareas(){
            Console.WriteLine("----------------------------------------");
            var indexTask=1;
            TaskList.ForEach(p=> Console.WriteLine($"{indexTask++} .  {p}"));
            Console.WriteLine("----------------------------------------");
        }

    }
    public enum Menu{
        Add = 1,
        Remove,
        List,
        Exit
    }
