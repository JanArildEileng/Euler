using System;
using System.Collections.Generic;
using System.Linq;

namespace jae.euler.lib
{
    public class E098AnagramicSquares
    {

        private class SquareNumberSubstitution
        {
            public long number { get; set; }
            public Dictionary<char, int> substitutionMapping { get; set; }
        }

        public long GetLargestSqureNumber(List<string> words)
        {
            long maxSquareNumber = 0;
            Func<string, string> stringToSortetString = (w) => { return String.Join("", w.ToCharArray().OrderBy(e => e)); };

            var anagramGroups = words.GroupBy(e => stringToSortetString(e)).Where(g => g.Count() > 1).OrderByDescending(g => g.Key.Length); ;

            foreach (var anagram in anagramGroups)
            {
                for (int i = 0; i < (anagram.Count() - 1); i++)
                {
                     List<SquareNumberSubstitution> squareNumberSubstitutionListe = GetSubStruct(anagram.ElementAt(i));

                    //test de andre ordene i samme gruppe

                    foreach (var anagramMember in anagram.Skip(i + 1))
                    {               
                        foreach (var squareNumberSubstitution in squareNumberSubstitutionListe)
                        {                                        
                            string s = String.Join("", anagramMember.ToCharArray().Select(c => squareNumberSubstitution.substitutionMapping[c]).ToArray());
                            if (s.StartsWith('0')) continue;

                            long value2 = long.Parse(s);
                            if (IsSquare(value2))
                            {                        
                                 maxSquareNumber=(new List<long>{ squareNumberSubstitution.number, value2, maxSquareNumber }).Max();
                            }
                        }
                    }

                    //samme gruppe
                } ///i
            } //anagram

            return maxSquareNumber;
        }

        private List<SquareNumberSubstitution> GetSubStruct(string word)
        {
            List<SquareNumberSubstitution> SquareNumbers = new List<SquareNumberSubstitution>();
            var warray = word.ToCharArray();
            IEnumerable<char> wordDistinct = warray.Distinct();

            Action<SquareNumberSubstitution> action = (a) =>
            {
                SquareNumbers.Add(a);
            };
       
            Recursive(Enumerable.Range(0, 10).ToList(), new List<int>(), warray, wordDistinct, action);
            return SquareNumbers;
        }


        private void Recursive(List<int> canddates, List<int> selected, char[] word, IEnumerable<char> wordDistinct, Action<SquareNumberSubstitution> action)
        {
            if (selected.Count == wordDistinct.Count())
            {
                int i = 0;
                var substitutionMapping = wordDistinct.Select(c => new { c, value = selected[i++] }).ToDictionary(e => e.c, e => e.value);

                string s = String.Join("", word.Select(c => substitutionMapping[c]).ToArray());
                if (s.StartsWith('0')) return;

                long number = long.Parse(s);
                if (IsSquare(number))
                {
                    action(new SquareNumberSubstitution { number = number, substitutionMapping = substitutionMapping });
                }

                return;
            }


            int skip = selected.Count() == 0?1:0;
       
            foreach (var candiate in canddates.Skip(skip))
            {
                var a = selected.ToList();
                a.Add(candiate);
                var subcanddates = canddates.Except(new List<int> { candiate }).ToList();
                Recursive(subcanddates, a, word, wordDistinct, action);
            }
        }



        private bool IsSquare(long number)
        {
            long a = (long)Math.Sqrt(number);
            return (a * a == number);
        }
    }
}
