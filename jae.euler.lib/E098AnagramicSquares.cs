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


           public Dictionary<char,Mapping> mapping { get; set; }

        }

        class Mapping
        {
            public char c  { get; set; }
            public int value  { get; set; }
        }


        public long GetLargestSqureNumber(List<string> words)
        {
            long maxSquareNumber = 0;

            foreach(var word in words)
            {
                long max = GetSquareNumber(word, words);

                if (max > maxSquareNumber)
                    maxSquareNumber = max;
            }
            return maxSquareNumber;

        }

        public long GetSquareNumber(string word, List<string> words)
        {


            long maxSquareNumber = 0;
            List<subStruct> SquareNumbers=new List<subStruct>();
            var warray = word.ToCharArray();

            Action<subStruct> action = (a) =>
            {
                SquareNumbers.Add(a);
            };



            int[] intvalues = Enumerable.Range(1,11).ToArray();

            Recursive(intvalues.ToList(), new List<int>(), warray, action);



            //int i = 0;
            //var darray = warray.Distinct().Select(c => new { a = c, b = intvalues[i++] }).ToDictionary(e => e.a);


            //long value = 0;

            //int[] s =warray.Select(c => darray[c].b).ToArray();

            //StringBuilder builder = new StringBuilder();
            //warray.Select(c => darray[c].b).ToList().ForEach(a => builder.Append(a));


            //value= long.Parse(builder.ToString());

            //if (IsSquare(value))
            //    return value;

            foreach (var testword in words)
            {

                if (testword.Equals(word)) continue;

                var w2 = testword.ToCharArray();
                var w2d = w2.Distinct().Count();

                foreach (var sub in SquareNumbers)
                {
                    bool isMatch = true;
                    if (sub.selected.Count != w2d) break;
                        //Action<subStruct> action2 = (a) =>
                        //{
                        //    isMatch = true; ;
                        //};


                        //if (sub.selected.Count == w2d)
                        //    Recursive(null, sub.selected, w2, action2);



                        if (isMatch)
                    {

                        try
                        {
                            StringBuilder builder = new StringBuilder();
                            w2.Select(c => sub.mapping[c].value).ToList().ForEach(a => builder.Append(a));

                            long value = long.Parse(builder.ToString());
                            if (IsSquare(value))
                            {
                                maxSquareNumber = Math.Max(value, sub.value);

                            }



                        }
                        catch (Exception)
                        {

                            break;
                        }
                     
                    }

                }


            }


        



         
            return maxSquareNumber;
          
        }


        private  void Recursive(List<int> canddates, List<int> selected,char[] word, Action<subStruct> action)
        {
            if (selected.Count == word.Distinct().Count())
            {

              



                int i =0;
                var mapping = word.Distinct().Select(c => new Mapping { c = c, value = selected[i++] }).ToDictionary(e => e.c);

                long value = 0;

          

                StringBuilder builder = new StringBuilder();
                word.Select(c => mapping[c].value).ToList().ForEach(a => builder.Append(a));

                try
                {
                    value = long.Parse(builder.ToString());
                }
                catch (Exception)
                {

            //        throw;
                }
             



                if (IsSquare(value))
                {
                    action(new subStruct {value=value,selected= selected ,mapping= mapping });

                }

                    return;
            }
                


            foreach(var candiate in canddates)
            {
                var a = selected.ToList();
                a.Add(candiate);
                var subcanddates = canddates.Except(new List<int> { candiate }).ToList();
                Recursive(subcanddates, a, word,action);
            }


        }






        private bool IsSquare(long number)
        {
            long a = (long)Math.Sqrt(number);
            return (a * a == number);

        }
    }
}
