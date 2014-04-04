using System;
using System.Collections.Generic;
using SQLite;

namespace PMDREng
{
	/// <summary>
	/// Describe a pomodoro cycle of a task
	/// </summary>
	public class Pomodoro
	{
		public Pomodoro ()
		{
		}

		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		[PrimaryKey, AutoIncrement]
		public int id {
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the task identifier.
		/// </summary>
		/// <value>The task identifier.</value>
		public int TaskId {
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the started at time of the pomodoro cycle.
		/// </summary>
		/// <value>The started at.</value>
		public DateTime StartedAt {
			get;
			set;
		}


		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="PomodoroEng.Pomodoro"/> is interrupted.
		/// Meanning we don't end up the 25 minutes of the pomodoro time
		/// </summary>
		/// <value><c>true</c> if interrupted; otherwise, <c>false</c>.</value>
		public bool Interrupted {
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the real duration of the pomodoro 25 miniutes if completed, less if cancel due to big interruption.
		/// </summary>
		/// <value>The duration.</value>
		public int Duration {
			get;
			set;
		}
	}
}



