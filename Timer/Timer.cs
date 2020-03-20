//
// ICT2106 Software Design - Timer exercise
//
// A class representing a timer.
//
using System.Collections.Generic;

namespace Timer
{
    class Timer: iSubject
    {
        private List<iObserver> observerList;
        private List<iObserver> removeQueue;

        // attach observer to the subject
        public void Attach(iObserver observer)
        {
            observerList.Add(observer);
        }

        // notify observer about the change
        public void Notify()
        {
            foreach(var i in observerList) 
            {
                if(i.getSecondCount() == 0)
                {
                    i.Update();
                    removeQueue.Add(i);
                } 
                else 
                {
                    i.decrementSecondCount();
                }
            }
            
            checkRemoveQueue();
        }

        // check the remove queue for list of observer to be detach
        private void checkRemoveQueue()
        {
            foreach(var i in removeQueue) 
            {
                Detach(i);
            }

            removeQueue.Clear();
        }

        // detach observer from the subject
        public void Detach(iObserver observer)
        {
            observerList.Remove(observer);
        }

        // constructor
        public Timer() {
            observerList = new List<iObserver>();
            removeQueue = new List<iObserver>();
        }

        // repeatedly wait one second, exiting after numberOfTicks iterations
        public void Run(int numberOfTicks)
        {
            while (numberOfTicks > 0)
            {
                System.Threading.Thread.Sleep(1000);
                System.Console.WriteLine("Sleeping...");
                Notify();
                numberOfTicks--;
            }
            System.Console.ReadLine();
        }
    }
}
