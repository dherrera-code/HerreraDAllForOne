using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class ReverseItAlphaService
    {
        public string ReverseItAlpha(string sequence)
        {
            sequence = sequence.Trim();
            if(sequence.Length < 2)
            {
                return "Invalid character count, Please input multiple characters!";
            }

            char[] reverseSequence = new char[sequence.Length];
            for (int i = 0; i < sequence.Length; i++)
            {
                reverseSequence[i] = sequence[sequence.Length - 1 - i];
            }

            string newSequence = string.Join("", reverseSequence);
            return $"You entered {sequence} and the reverse is {newSequence}.";
        }
    }
}