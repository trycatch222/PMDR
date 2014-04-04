using System;
using PMDREng;
using SQLite;

namespace PMDREng
{
	public class Database : SQLiteConnection
	{
		#if NETFX_CORE
		   private static readonly string Path = "Database.db";
		#elif NCRUNCH
		   private static readonly string Path = System.IO.Path.GetTempFileName();
		#else
		private static readonly string Path = System.IO.Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments), "Pomodo.db");
		#endif

		public Database ()
			: base(Path, true)
		{
		}


		public static SQLiteConnection GetConnection ()
		{
			return new SQLiteConnection (Path, true);
		}

		public static void Initialize ()
		{
			CreateDatabase (GetConnection ());
		}

		private static void CreateDatabase (SQLiteConnection connection)
		{
			//Create the tables
			CreateTables ();
		}

		private static void CreateTables ()
		{
			using (var conn = GetConnection ()) {
				conn.CreateTable<PomodoroTask> ();
				conn.CreateTable<Pomodoro> ();
				conn.CreateTable<Interruption> ();
			}
		}
	}
}

