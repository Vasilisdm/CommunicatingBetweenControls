using System;
using CommunicatingBetweenControls.Model;

namespace CommunicatingBetweenControls
{
	public class JobChangedEvntArgs : EventArgs
	{
		public Job job { get; set; }
	}
}