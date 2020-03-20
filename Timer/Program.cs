//
// ICT2106 Software Design - Timer exercise
//
// Main program.
//

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a clock
            Timer timer = new Timer();

            // create some alarms
            iObserver alarm1 = new TextAlarm(10, "Wake up!");

            // attach the alarms to the clock
            timer.Attach(alarm1);

            // run the clock for thirty seconds
            timer.Run(30);
        }
    }
}
