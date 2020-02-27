using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicatingBetweenControls
{
    public sealed class Mediator
    {
		private Mediator(){}

        private static readonly Mediator _instance = new Mediator();

		public static Mediator GetMediatorInstance
        {
            get
			{
                return _instance;
			}
        }

        //Instance functionality
        public event EventHandler<JobChangedeventArgs> JobChanged;

        public void OnJobChanged(object sender, Job job)
		{

		}
	}
}
