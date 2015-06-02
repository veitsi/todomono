using System;

namespace gtk05

{

//	public class ToDoList{
//		System.Collections.Generic.List<Task> todolist = new System.Collections.Generic.List<Task>();
//	}

	public class Task
	{
		public Task (string text)
		{
			this.text = text;
			this.completed = false;
		}
		public void AddSubTask(string text)
		{
			subs.Add(new SubTask(text));
		}
		public DateTime date;
		public string text;
		public string category;
		public bool completed;
		System.Collections.Generic.List<SubTask> subs = new System.Collections.Generic.List<SubTask>();

		public override string ToString(){
			string s = this.text+"[";
			foreach (SubTask st in this.subs)
				s += st.text+" ";
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
