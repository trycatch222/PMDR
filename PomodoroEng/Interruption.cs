using System;

namespace PomodoroEng
{
	/// <summary>
	/// Diescribe an interruption in a pomodoro
	/// </summary>
	public class Interruption
	{
		public Interruption ()
		{
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
		/// Gets or sets the description of the interruption.
		/// </summary>
		/// <value>The description.</value>
		public string Description {
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the duration.
		/// </summary>
		/// <value>The duration.</value>
		public int Duration {
			get;
			set;
		}
	}
}

