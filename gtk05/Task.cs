using System;

namespace gtk05
{
	public class ToDoList
	{
		public System.Collections.Generic.List<Task> tasks = new System.Collections.Generic.List<Task>();
		public System.Collections.Generic.List<string> categories = new System.Collections.Generic.List<string>();

		public void AddTask (string text)
		{
			this.tasks.Add(new Task(text));
		}

		public void AddCategory(string text)
		{
			this.categories.Add(text);
		}

		public void printToDo(){
			foreach (Task t in tasks) {
				Console.Write(t.text);
				if (t.categoryIndex > -1) Console.Write (" @" + this.categories [t.categoryIndex]+" ");
				if (t.subs.Count > 0) {
					Console.Write ("[" + t.subs [0].text);
					for (int i=1; i<t.subs.Count; i++)
						Console.Write ("," + t.subs [i].text);
				}
				Console.Write ("]\n");
			}
		}

		public void addTestData(){
			this.AddCategory ("default");
			this.AddCategory ("Job");
			this.AddCategory ("Study");
			this.AddCategory ("Family");

			this.AddTask ("code todolist in C#");
			this.tasks[0].AddSubTask("install IDE for C# on linux");
			this.tasks[0].AddSubTask("to find what is REST");
			this.tasks[0].AddSubTask("make js-client on angularJS");
			this.tasks[0].AddSubTask("find free hosting for ASP.NET");

			this.AddTask ("Study Suomi language");
			this.tasks[1].AddSubTask("visit Finland");
			this.tasks[1].AddSubTask("to find Yolopukki dress");
			this.tasks[1].AddSubTask("to get driver license");
			this.tasks[1].AddSubTask("install LinguaLeo app");
			this.tasks[1].AddSubTask("find local finn");
		}
	}


	public class TodoDao{
		public static void txtSave(){
		}
	}


	public class Task
	{
		public Task (string text)
		{
			this.text = text;
			this.completed = false;
		}
		public System.Collections.Generic.List<SubTask> subs = new System.Collections.Generic.List<SubTask>();

		public void AddSubTask(string text)
		{
			subs.Add(new SubTask(text));
		}

		public DateTime date;
		public string text;
		public int categoryIndex;
		public bool completed;

		public override string ToString(){
			string s = this.text+"["+subs[0].text;
			for (int i=1; i<subs.Count; i++)
				s += "," + subs [i].text;
 			return s+"]";

		}		
	}

	public class SubTask
	{
		public string text;
		public SubTask (string text)
		{
			this.text = text;
			this.completed = false;
		}
		public bool completed;
	}
}
