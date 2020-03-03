using CommunicatingBetweenControls.Model;
using System;

namespace CommunicatingBetweenControls
{
	public class JobChangedEvntArgs : EventArgs
	{
		public Job Job { get; set; }
	}
}