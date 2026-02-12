using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class ReverseItNumService
    {
        public string ReverseItNums(string sequence)
        {
            if(sequence.Length < 2) return "Invalid Input: Please enter a number with more than one digit!";
            if(!long.TryParse(sequence, out long numbers))
            {
                return "Invalid Input: Please enter a sequence of numbers only";
            }
            char[] reverseSequence = new char[sequence.Length];
            for(int i = 0; i < sequence.Length; i++)
            {
                reverseSequence[i] = sequence[sequence.Length - 1 - i];
            }
            string newSequence = string.Join("", reverseSequence);
            return $"You entered {sequence} and the reverse is {newSequence}";
        }
    }
}