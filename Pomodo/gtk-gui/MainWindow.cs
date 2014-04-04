
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action FileAction;
	private global::Gtk.Action ReportAction;
	private global::Gtk.Action DailyAction;
	private global::Gtk.VBox vbox2;
	private global::Gtk.MenuBar menubar2;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Label label1;
	private global::Gtk.Button button3;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, null);
		this.ReportAction = new global::Gtk.Action ("ReportAction", global::Mono.Unix.Catalog.GetString ("Report"), null, null);
		this.ReportAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Report");
		w1.Add (this.ReportAction, null);
		this.DailyAction = new global::Gtk.Action ("DailyAction", global::Mono.Unix.Catalog.GetString ("Daily"), null, null);
		this.DailyAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Daily");
		w1.Add (this.DailyAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar2'><menu name='FileAction' action='FileAction'/><menu name='ReportAction' action='ReportAction'><menuitem name='DailyAction' action='DailyAction'/></menu></menubar></ui>");
		this.menubar2 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar2")));
		this.menubar2.Name = "menubar2";
		this.vbox2.Add (this.menubar2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.menubar2]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.Xpad = 1;
		this.label1.Ypad = 1;
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("LabelTime");
		this.hbox1.Add (this.label1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label1]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.button3 = new global::Gtk.Button ();
		this.button3.CanFocus = true;
		this.button3.Name = "button3";
		this.button3.UseUnderline = true;
		this.button3.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
		this.hbox1.Add (this.button3);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button3]));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		this.vbox2.Add (this.hbox1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		this.Add (this.vbox2);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 445;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
