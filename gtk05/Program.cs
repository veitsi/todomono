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
			todo.AddTask ("binary studio test");
			todo.tasks[0].AddSubTask("установить нужное ПО");
			todo.tasks[0].AddSubTask("Поискать контакты менторов");
			todo.tasks[0].AddSubTask("поискать сообщества по .нет");

			todo.AddTask ("выучить английский");
			Console.Write (todo.tasks[0]);
			Console.Write (todo);

		}

	}
}
