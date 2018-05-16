using System;

namespace PatternsExamples.Behavioral.Mediator
{
	public abstract class ColleagueControl
	{
		private readonly Mediator _mediator;
		protected readonly string ControlName;

		protected ColleagueControl(Mediator mediator, string controlName)
		{
			ControlName = controlName;
			_mediator = mediator;
			_mediator.ControlInvokedEvent += ColleagueControlCallback;
		}

		protected void Changed(string text)
		{
			//notify all who subscribed to event
			//attention, you need to comment this part of code
			//if you will uncomment the next line
			_mediator.ControlInvoked(text);

			//uncomment this part to with other commented parts of code
			//in case to able not to notify all but only specified colleagues
			//attention, you will need to comment code on line 22 in this file: _mediator.ControlInvoked(text);
			//_mediator.ControlInvoked(text, this);
		}

		public void ColleagueControlCallback(string text)
		{
			Console.WriteLine("Callback in {0}. {1}", ControlName, text);
		}
	}
}
