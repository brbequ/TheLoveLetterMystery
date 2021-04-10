using System.Text;
using System;

class Solution
{
    // James found a love letter that his friend Harry has written to
    // his girlfriend. James is a prankster, so he decides to meddle
    // with the letter. He changes all the words in the letter into
    // palindromes.

    // To do this, he follows two rules:
    // 1 - He can only reduce the value of a letter by 1, i.e . he can
    //     change d to c, but he cannot change c to d or d to b.
    // 2 - The letter a may not be reduced any further.
    
    // Each reduction in the value of any letter is counted as a single
    // operation. Find the minimum number of operations required to
    // convert a given string into a palindrome.

    // Example
    // s = cde
    // The following two operations are performed: cde → cdd → cdc.
    // Return 2.

    // Complete the theLoveLetterMystery function below.
    static int theLoveLetterMystery(string s)
    {
        StringBuilder palindrome = new StringBuilder(s);
        int changes = 0;

        // Walk the string from both directions building the palindrome
        for (int fidx = 0, ridx = palindrome.Length - 1; fidx < ridx; fidx++, ridx--)
        {
            while (palindrome[fidx] > palindrome[ridx])
            {
                palindrome[fidx]--;
                changes++;
            }
            while (palindrome[fidx] < palindrome[ridx])
            {
                palindrome[ridx]--;
                changes++;
            }
        }

        return changes;
    }

    static void Main(string[] args)
    {
        string[] testcases = new string[]
        {
            "abc",      // 2
            "abcba",    // 0
            "abcd",     // 4
            "cba",      // 2
        };

        foreach (string testcase in testcases)
        {
            int result = theLoveLetterMystery(testcase);

            Console.WriteLine(result);
        }
    }
}
