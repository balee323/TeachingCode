using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops
{
    class FindDuplicateNumbers
    {
        private List<int> _numArray;

        //constructor
        public FindDuplicateNumbers()
        {
            CreateIntegerArray();
        }

        //constructor
        public FindDuplicateNumbers(int[] numberArray)
        {
            _numArray = numberArray.ToList<int>();
        }


        public int[] Start()
        {
            int[] duplicateNumbers = new int[10];

            int duplicateElement = 0;

            for(int i = 0; i < _numArray.Count; i++)
            {
                ; //for breakpoint
                for(int j = i + 1; j < _numArray.Count; j++)
                {
                    ; //for breakpoint
                    if(_numArray[i] == _numArray[j])
                    {
                        Console.WriteLine("Duplicate Found, number added to duplicate array");
                        duplicateNumbers[duplicateElement] = _numArray[j];
                        duplicateElement++;
                    }
                }
            }

            return duplicateNumbers;
        }


        //use built-in int array if one isn't passed in.
        private void CreateIntegerArray()
        {
            _numArray = new List<int>();
            _numArray[0] = 12;
            _numArray[1] = 22;
            _numArray[2] = 9;
            _numArray[3] = 2;
            _numArray[4] = 45;
            _numArray[5] = 12;
            _numArray[6] = 22;
            _numArray[7] = 6;
            _numArray[8] = 13;
            _numArray[9] = 9;
        }

    }
}
