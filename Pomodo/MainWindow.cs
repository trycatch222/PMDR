using System;
using Gtk;
using PMDREng;

public partial class MainWindow: Gtk.Window
{

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();

		Database.Initialize ();

	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;


	}
}
