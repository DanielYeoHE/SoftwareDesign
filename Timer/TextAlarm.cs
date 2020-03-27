//
// ICT2106 Software Design - Timer exercise
//
// A class that prints a message to the screen every time it receives a notification.
//

using System;

namespace Timer
{
    class TextAlarm : iObserver
    {
       // the message to be printed
        private string message;
        private int secondsCount { set; get; }

        // constructor
        public TextAlarm(int count, string messageIn)
        {
            // save the message for later
            message = messageIn;
            secondsCount = count;
        }
		
		// to be invoked when the alarm is triggered
		public void Update()
		{
			Console.WriteLine(message);
		}

        // get the value of second count
        public int getSecondCount()
        {
            return secondsCount;
        }

        // decrement the value of second count
        public void decrementSecondCount()
        {
            secondsCount --;
        }
    }
}
