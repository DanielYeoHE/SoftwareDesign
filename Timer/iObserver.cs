
namespace Timer
{
    interface iObserver
    {
        int getSecondCount();

        void decrementSecondCount();

        void Update();
    }
}