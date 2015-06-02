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
			Application.Run ();


		}

		public static void testTasks()
		{
			System.Collections.Generic.List<Task> todo = new System.Collections.Generic.List<Task>();
			todo.Add (new Task ("binary studio test"));
			todo [0].AddSubTask ("установить нужное ПО");
			todo [0].AddSubTask ("Поискать контакты менторов");
			todo [0].AddSubTask ("поискать сообщества по .нет");

			todo.Add (new Task ("выучить английский"));
			Console.Write (todo[0]);
			Console.Write (todo);



		}

	}
}
