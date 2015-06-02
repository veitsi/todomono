using System;
using Gtk;

namespace gtk05
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();

			win.Show ();
			Console.Write("программа запущена \n");
			testTasks();
			//Application.Run ();


		}

		public static void testTasks()
		{
			ToDoList todo = new ToDoList ();
			todo.addTestData ();
			todo.printToDo();
		}

	}
}
