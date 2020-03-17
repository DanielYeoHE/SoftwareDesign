//
// ICT2106 Software Design - 2D array example
//
// Concrete row-major iterator for two-dimensional arrays.
//
// Author: Nicholas Sheppard
//
using System;

namespace TwoDArray
{
    class TwoDReverseIteratorGeneric<T> : ITwoDIterator<T>
    {
        // the collection being iterated through
        TwoDArrayGeneric<T> collection;

        // counters
        private int i, j;
        private bool reversed = false;

        // constructor
        public TwoDReverseIteratorGeneric(TwoDArrayGeneric<T> collectionIn)
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
            if (reversed) {
                j --;

                if (j < 0) {
                    j = 0;
                    i ++;
                    reversed = false;
                }

            } else {
                j ++;

                if (j >= collection.Columns()) {
                    j = collection.Columns() - 1;
                    i ++;
                    reversed = true;
                }
            }
        }

        // test whether or not the iteration has finished
        public bool IsDone()
        {
            return i >= collection.Rows();
        }
    }
}
