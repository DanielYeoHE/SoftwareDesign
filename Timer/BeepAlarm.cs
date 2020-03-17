//
// ICT2106 Software Design - Timer exercise
//
// A class that beeps every time it receives a notification.
//

using System;

namespace Timer
{
    class BeepAlarm: iObserver
    {

        private int secondsCount { set; get; }

        // constructor
        public BeepAlarm(int seconds)
        {
            secondsCount = seconds;
        }

        // to be invoked when the alarm is triggered
        public void Update()
		{
			Console.Beep();
		}

        // decrement the value of second count
        public void decrementSecondCount()
        {
            secondsCount --;
        }
        // get the value of second count
        public int getSecondCount()
        {
           return secondsCount;
        }
    }
}
