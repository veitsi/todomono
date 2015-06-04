using System;
using Gtk;
using gtk05;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton2Clicked (object sender, EventArgs e)
	{
		//textview.Buffer.Text += "сохраняем...\n";
	}

	private void TreeInit ()
	{
		Gtk.TreeViewColumn taskColumn = new Gtk.TreeViewColumn ();
		taskColumn.Title = "Task description";
		Gtk.CellRendererText taskTextCell = new Gtk.CellRendererText ();
		taskColumn.PackStart (taskTextCell, true);

		Gtk.TreeViewColumn statusColumn = new Gtk.TreeViewColumn ();
		statusColumn.Title = "status";
		Gtk.CellRendererToggle statusCell = new Gtk.CellRendererToggle ();
		statusColumn.PackStart (statusCell, true);

		tree.AppendColumn (taskColumn);
		tree.AppendColumn (statusColumn);
		taskColumn.AddAttribute (taskTextCell, "text", 0);
		statusColumn.AddAttribute (statusCell, "text", 1);
	}

	public void TreeBuild (ToDoList todo)
	{
		//textview.Buffer.Text = "Загрузили список задач\n";
		this.TreeInit ();

		Gtk.TreeStore todoListStore = new Gtk.TreeStore (typeof(string), typeof(string));
		Gtk.TreeIter iter;
		foreach (Task t in todo.tasks) {
			iter=todoListStore.AppendValues (t.text);
			if (t.subs.Count > 0) {
				foreach (SubTask s in t.subs)
					todoListStore.AppendValues (iter, s.text, "");
			}
		}

		tree.Model = todoListStore;
	}
}
