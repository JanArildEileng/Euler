using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E098AnagramicSquares
    {

        class subStruct
        {
            public long value { get; set; }
            public List<int> selected { get; set; }


            public Dictionary<char, Mapping> mapping { get; set; }

        }

        class Mapping
        {
            public char c { get; set; }
            public int value { get; set; }
        }


        class WordStruct
        {
            public string OrgWord { get; set; }
            public string ShortDistinctWord { get; set; }
        }



        public long GetLargestSqureNumber(List<string> words)
        {
            long maxSquareNumber = 0;

            Func<string, string> f = (w) =>
            {
                var a = w.ToCharArray().Distinct().OrderBy(e => e);
                StringBuilder builder = new StringBuilder();
                a.ToList().ForEach(e => builder.Append(e));
                return builder.ToString();
            };

            foreach (var word in words)
            {
                var shortWord = f(word);
                List<subStruct> subStructListe = GetSubStruct(word);

                foreach (var word2 in words)
                {
                    var shortWord2 = f(word2);
                    if (!word2.Equals(word) && shortWord.StartsWith(shortWord2))
                    {
                        {
                            var charArray = word2.ToCharArray();

                            foreach (subStruct substruct in subStructListe)
                            {
                                var mapping = substruct.mapping;

                                StringBuilder builder = new StringBuilder();
                                charArray.Select(c => mapping[c].value).ToList().ForEach(a => builder.Append(a));
                                var s = builder.ToString();
                                if (s.StartsWith('0') || s.Length < 2) continue;

                                long value2 = long.Parse(s);
                                if (IsSquare(value2))
                                {
                                    var value = substruct.value;
                                    long max1 = Math.Max(value, value2);
                                    maxSquareNumber = Math.Max(maxSquareNumber, max1);

                                    if (maxSquareNumber == 152448409)
                                    {
                                        var d = 1;
                                    }


                                }
                            }
                        }


                    }
                }



            }

            return maxSquareNumber;
        }



        public long GetLargestSqureNumber2(List<string> words)
        {
            long maxSquareNumber = 0;
            Func<string, string> f = (w) =>
               {
                   var a = w.ToCharArray().Distinct().OrderBy(e => e);
                   StringBuilder builder = new StringBuilder();
                   a.ToList().ForEach(e => builder.Append(e));
                   return builder.ToString();
               };

            var wordstructs = words.Select(w => new WordStruct { OrgWord = w, ShortDistinctWord = f(w) });

            var wordgroups = wordstructs.GroupBy(e => e.ShortDistinctWord).Where(g => g.Count() > 1).OrderByDescending(g => g.Key.Length); ;

            //       var keys = wordgroups.Select(g => g.Key).ToList();



            ////       foreach (var key in keys)
            //           foreach (var g in wordgroups)
            //           {
            //           var key = g.Key;

            //           var sublist = keys.Where(k =>!k.Equals(key) &&  key.StartsWith(k)).ToList();
            //           if (sublist.Count >0)
            //           {
            //               var a =1;


            //           }


            //       }










            foreach (var g in wordgroups)
            {
                var key = g.Key;
                //if (key.Equals("EGSTU"))
                {
                    for (int i = 0; i < (g.Count() - 1); i++)
                    {
                        var orgWord = g.ElementAt(i).OrgWord;

                        List<subStruct> subStructListe = GetSubStruct(orgWord);


                        //test de andre ordene i samme gruppe
                        /*
                        foreach (var wordStruct in g.Skip(i + 1))
                        {
                            var charArray = wordStruct.OrgWord.ToCharArray();

                            foreach (subStruct substruct in subStructListe)
                            {
                                var mapping = substruct.mapping;

                                StringBuilder builder = new StringBuilder();
                                charArray.Select(c => mapping[c].value).ToList().ForEach(a => builder.Append(a));
                                var s = builder.ToString();
                                if (s.StartsWith('0')) continue;

                                long value2 = long.Parse(s);
                                if (IsSquare(value2))
                                {
                                    var value = substruct.value;
                                    long max1 = Math.Max(value, value2);
                                    maxSquareNumber = Math.Max(maxSquareNumber, max1);

                                    if (maxSquareNumber == 8311689)
                                    {
                                        var d = 1;
                                    }


                                }
                            }
                        } */ 
                        
                    //samme gruppe
                          //test sub grupps

                        foreach (var word in words)
                        {
                            var shortWord = f(word);
                            if (!shortWord.Equals(key) && key.StartsWith(shortWord))
                            {
                                {
                                    var charArray = word.ToCharArray();

                                    foreach (subStruct substruct in subStructListe)
                                    {
                                        var mapping = substruct.mapping;

                                        StringBuilder builder = new StringBuilder();
                                        charArray.Select(c => mapping[c].value).ToList().ForEach(a => builder.Append(a));
                                        var s = builder.ToString();
                                        if (s.StartsWith('0')  || s.Length<2)  continue;

                                        long value2 = long.Parse(s);
                                        if (IsSquare(value2))
                                        {
                                            var value = substruct.value;
                                            long max1 = Math.Max(value, value2);
                                            maxSquareNumber = Math.Max(maxSquareNumber, max1);

                                            if (maxSquareNumber == 152448409)
                                            {
                                                var d = 1;
                                            }


                                        }
                                    }
                                }


                            }
                        }


                        /*
                        foreach (var g2 in wordgroups)
                        {
                            var key2 = g2.Key;
                            if (!key2.Equals(key) && key.StartsWith(key2))
                            {
                                var aaaa = 1;
                                foreach (var wordStruct in g2)
                                {
                                    var charArray = wordStruct.OrgWord.ToCharArray();

                                    foreach (subStruct substruct in subStructListe)
                                    {
                                        var mapping = substruct.mapping;

                                        StringBuilder builder = new StringBuilder();
                                        charArray.Select(c => mapping[c].value).ToList().ForEach(a => builder.Append(a));
                                        var s = builder.ToString();
                                        if (s.StartsWith('0')) continue;

                                        long value2 = long.Parse(s);
                                        if (IsSquare(value2))
                                        {
                                            var value = substruct.value;
                                            long max1 = Math.Max(value, value2);
                                            maxSquareNumber = Math.Max(maxSquareNumber, max1);

                                            if (maxSquareNumber == 8311689)
                                            {
                                                var d = 1;
                                            }


                                        }
                                    }
                                }
                            }
                        }  //g2
                        */

                    }




                }  //acer


            }




            return maxSquareNumber;
        }





        private List<subStruct> GetSubStruct(string word)
        {
            List<subStruct> SquareNumbers = new List<subStruct>();
            var warray = word.ToCharArray();
            IEnumerable<char> wordDistinct = warray.Distinct();


            Action<subStruct> action = (a) =>
            {
                SquareNumbers.Add(a);
            };


            //  int[] intvalues = Enumerable.Range(1,11).ToArray();
            int[] intvalues = Enumerable.Range(0, 10).ToArray();

            Recursive(intvalues.ToList(), new List<int>(), warray, wordDistinct, action);
            return SquareNumbers;
        }





        private void Recursive(List<int> canddates, List<int> selected, char[] word, IEnumerable<char> wordDistinct, Action<subStruct> action)
        {
            if (selected.Count == wordDistinct.Count())
            {
                int i = 0;
                var mapping = wordDistinct.Select(c => new Mapping { c = c, value = selected[i++] }).ToDictionary(e => e.c);

                StringBuilder builder = new StringBuilder();
                word.Select(c => mapping[c].value).ToList().ForEach(a => builder.Append(a));

                var s = builder.ToString();

                if (s.StartsWith('0')) return;

                try
                {
                    long value = long.Parse(s);
                    if (IsSquare(value))
                    {
                        action(new subStruct { value = value, selected = selected, mapping = mapping });
                    }
                }
                catch (Exception)
                {

                    throw;
                }

                return;
            }


            int skip = 0;
            if (selected.Count() == 0) skip = 1;

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
