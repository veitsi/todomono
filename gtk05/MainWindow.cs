using System;
using Gtk;

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
	public void TreeBuild()
	{
		//textview.Buffer.Text = "Загрузили список задач\n";
	
		Gtk.TreeViewColumn artistColumn = new Gtk.TreeViewColumn ();
		artistColumn.Title = "Task description";

		Gtk.CellRendererText artistNameCell = new Gtk.CellRendererText ();

		artistColumn.PackStart (artistNameCell, true);

		Gtk.TreeViewColumn songColumn = new Gtk.TreeViewColumn ();
		songColumn.Title = "заметки";

		Gtk.CellRendererText songTitleCell = new Gtk.CellRendererText ();
		songColumn.PackStart (songTitleCell, true);

		tree.AppendColumn (artistColumn);
		tree.AppendColumn (songColumn);

		artistColumn.AddAttribute (artistNameCell, "text", 0);
		songColumn.AddAttribute (songTitleCell, "text", 1);

		Gtk.TreeStore musicListStore = new Gtk.TreeStore (typeof (string), typeof (string));

		Gtk.TreeIter iter = musicListStore.AppendValues ("Binary studio task");
		musicListStore.AppendValues (iter, "поставить нужно ПО", "");
		musicListStore.AppendValues (iter, "прочитать книжку", "");


		iter = musicListStore.AppendValues ("Выучить английский");
		musicListStore.AppendValues (iter, "записаться на курсы", "");
		musicListStore.AppendValues (iter, "найти с кем пообщатся на английском", "");

		tree.Model = musicListStore;
	}
}
