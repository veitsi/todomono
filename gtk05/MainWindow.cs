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
		textview.Buffer.Text += "clicked\n";
	}
	public void TreeBuild()
	{
		textview.Buffer.Text = "Let's make our tree\n";
	
		Gtk.TreeViewColumn artistColumn = new Gtk.TreeViewColumn ();
		artistColumn.Title = "Artist";

		Gtk.CellRendererText artistNameCell = new Gtk.CellRendererText ();

		artistColumn.PackStart (artistNameCell, true);

		Gtk.TreeViewColumn songColumn = new Gtk.TreeViewColumn ();
		songColumn.Title = "Song Title";

		Gtk.CellRendererText songTitleCell = new Gtk.CellRendererText ();
		songColumn.PackStart (songTitleCell, true);

		tree.AppendColumn (artistColumn);
		tree.AppendColumn (songColumn);

		artistColumn.AddAttribute (artistNameCell, "text", 0);
		songColumn.AddAttribute (songTitleCell, "text", 1);

		Gtk.TreeStore musicListStore = new Gtk.TreeStore (typeof (string), typeof (string));

		Gtk.TreeIter iter = musicListStore.AppendValues ("Dance");
		musicListStore.AppendValues (iter, "Fannypack", "Nu Nu (Yeah Yeah) (double j and haze radio edit)");

		iter = musicListStore.AppendValues ("Hip-hop");
		musicListStore.AppendValues (iter, "Nelly", "Country Grammer");

		tree.Model = musicListStore;
	}
}
