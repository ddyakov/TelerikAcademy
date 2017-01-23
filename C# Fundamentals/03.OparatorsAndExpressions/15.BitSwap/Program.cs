using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.BitSwap
{
    class BitSwap
    {
        static void Main(string[] args)
        {
            long inputNum = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            
            var bitsDictionary = new Dictionary<int, int>();
            for (byte i = 0; i < k; i++, p++, q++)
            {
                bitsDictionary.Add(p, q);
            }
            
            foreach (KeyValuePair<int, int> entry in bitsDictionary)
            {
                int bitToReplace = entry.Key;
                int replacingBitPos = entry.Value;
    
                long replacingBitVal = 1 & (inputNum >> replacingBitPos);
                long bitToReplaceVal = 1 & (inputNum >> bitToReplace);
        
                inputNum = ModifyBitAtPosition(inputNum, replacingBitVal, bitToReplace);
                
                inputNum = ModifyBitAtPosition(inputNum, bitToReplaceVal, replacingBitPos);
            }
            Console.WriteLine(inputNum);
        }

        static long ModifyBitAtPosition(long input, long bitVal, int bitPos)
        {
            int mask = 0;
            if (bitVal == 1)
            {
                mask = 1 << bitPos;
                input = input | mask;
            }
            else
            {
                mask = ~(1 << bitPos);
                input = input & mask;
            }

            return input;
        }
    }
}

