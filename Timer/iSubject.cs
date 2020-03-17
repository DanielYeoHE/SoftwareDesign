
namespace Timer
{
    interface iSubject
    {
        void Attach(iObserver observer);

        void Detach(iObserver observer);
        
        void Notify();
    }
}