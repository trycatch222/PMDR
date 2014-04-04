using System;
using SQLite;

namespace PMDREng
{
	/// <summary>
	/// Describe a task to do unsing the pomodoro teechnique
	/// </summary>
	public class PomodoroTask
	{
		public PomodoroTask ()
		{
		}

		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		[PrimaryKey, AutoIncrement]
		public int Id {
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the create on.
		/// </summary>
		/// <value>The create on.</value>
		public DateTime CreateOn {
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>The description.</value>
		public string Description {
			get;
			set;
		}

		/// <summary>
		/// Estimated pomodoro count to complete the task
		/// </summary>
		/// <value>The estimated p.</value>
		public int EstimatedP {
			get;
			set;
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="PomodoroEng.PomodoroTask"/> is unplanned.
		/// </summary>
		/// <value><c>true</c> if unplanned; otherwise, <c>false</c>.</value>
		public bool Unplanned {
			get;
			set;
		}
	}
}

