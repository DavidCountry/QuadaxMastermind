using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    public class MasterClass
    {
        private readonly Random _RandomDigit;
        private string _CurrentNumber;
        public string FirstLine { get;  }
        public string SecondLine { get;  }

        public MasterClass()
        {
            _RandomDigit = new Random();
            FirstLine = @"++++";
            SecondLine = @"----";
        }
        public int GetDigit(int start=1, int end=7)
        {
            return _RandomDigit.Next(start, end);
        }

        public string GetRandomNumber(int start = 1, int end = 7)
        {
            _CurrentNumber = String.Format("{0}{1}{2}{3}", GetDigit(start, end), GetDigit(start, end)
                , GetDigit(start, end), GetDigit(start, end));
            return _CurrentNumber;
        }

        public string CompareNumber(string number)
        {
            
            if ( String.Compare(_CurrentNumber, number)== 0 ) return SecondLine;
            StringBuilder retVal = new StringBuilder();
            var index = 0;
            foreach(var digit in number)
            {
                retVal.Append(_CurrentNumber[index++] == digit ? '-' : '+');
            }
            return retVal.ToString();
        }

         

    }
}
