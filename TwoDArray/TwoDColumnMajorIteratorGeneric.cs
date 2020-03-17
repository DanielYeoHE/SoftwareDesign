//
// ICT2106 Software Design - 2D array example
//
// Concrete row-major iterator for two-dimensional arrays.
//
// Author: Nicholas Sheppard
//
namespace TwoDArray
{
    class TwoDColumnMajorIteratorGeneric<T> : ITwoDIterator<T>
    {
        // the collection being iterated through
        TwoDArrayGeneric<T> collection;

        // counters
        private int i, j;

        // constructor
        public TwoDColumnMajorIteratorGeneric(TwoDArrayGeneric<T> collectionIn)
        {
            collection = collectionIn;
            i = 0;
            j = 0;
        }

        // get the current element of the iteration
        public T Current()
        {
            return collection.Get(i, j);
        }

        // move to the next element of the iteration
        public void Next()
        {
            i++;
            if (i >= collection.Rows())
            {
                i = 0;
                j++;
            }
        }

        // test whether or not the iteration has finished
        public bool IsDone()
        {
            return j >= collection.Columns();
        }
    }
}
