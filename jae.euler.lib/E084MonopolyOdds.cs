using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E084MonopolyOdds
    {
        class Dice
        {
            public int Sides { get; set; }
            public Random random { get; } 
            public Dice(int sides, Random random)
            {
                this.Sides = sides;
                this.random = random;
            }

            public int GetValue()
            {
               return  random.Next(Sides) + 1;
            }

        }


        class Square
        {
            public int Visits { get; set; }
            public string Number { get; set; }
        }

        const int GO = 0;
        const int CC1 = 2;
        const int CC2 = 17;
        const int CC3 = 33;
        const int JAIL = 10;
        const int G2J = 30;

        const int CH1 = 7;
        const int CH2 = 22;
        const int CH3 = 36;

        const int C1 = 11;
        const int E3 = 24;
        const int H2 = 39;
        const int R1 = 5;
        const int R2 = 15;
        const int R3 = 25;
        const int R4 = 35;
        const int U1 = 12;
        const int U2 = 28;

        Dice[] Dices { get; set; }

        List<Square> Squares;
        int SimulationRuns = 0;


        public bool ConsecutivdoublesActivated { get; set; } = false;
        public bool GotoJailActivated { get; set; } = false;
        public bool CommunityChestActivated { get; set; } = false;

        public bool ChanceActivated { get; set; } = false;
        

         Random random;

        public E084MonopolyOdds(int diceSides)
        {
            random = new Random();

            Dices = new Dice[]
            {
                new Dice(diceSides,random),new Dice(diceSides,random)
            };
            Squares = new List<Square>(40);
            for(int i=0;i<40;i++)
            {
                Squares.Add(new Square() {
                    Number = i<10 ? $"0{i}": $"{i}"
                });
            }




        }

        public void RunSimulation(int runs)
        {
            int currentSquare = 0;

            int consecutivdoubles = 0;

            for (int i=0;i< runs;i++)
            {
                int v1 = Dices[0].GetValue();
                int v2 = Dices[1].GetValue();
       
                if (ConsecutivdoublesActivated) { 
                    if ( v1==v2)
                    {
                        consecutivdoubles++;
                        if (consecutivdoubles==3)
                        {
                            currentSquare = JAIL;
                            consecutivdoubles = 0;
                            Squares[currentSquare].Visits++;
                            continue;
                        }
                    } else
                    {
                        consecutivdoubles = 0;
                    }
                }

                int moves = v1 + v2;

                currentSquare = (currentSquare + moves) % 40;

                if ( GotoJailActivated)
                {
                    if (currentSquare== G2J)
                    {
                        currentSquare = JAIL;
                    }
                }

                if (CommunityChestActivated)
                {
                    currentSquare = CommunityChestHandler(currentSquare);
                }


                if (ChanceActivated)
                {
                    currentSquare = ChanceHandler(currentSquare);
                }



                Squares[currentSquare].Visits++;
            }

            SimulationRuns = runs;
        }

        private int ChanceHandler(int currentSquare)
        {
            if (currentSquare == CH1 || currentSquare == CH2|| currentSquare == CH3)
            {
                var cc = random.Next(16);
                // Advance to GO
                if (cc == 1) { currentSquare = GO; };
                //  Go to JAIL
                if (cc == 2) { currentSquare = JAIL; };
                //  Go to C1
                if (cc == 3) { currentSquare = C1; };
                //  Go to E3
                if (cc == 4) { currentSquare = E3; };
                //  Go to H2
                if (cc == 5) { currentSquare = H2; };
                //  Go to R1
                if (cc == 6) { currentSquare = R1; };
                //   Go to next R(railway company) og  Go to next R
                if (cc == 7|| cc == 8) {

                    if (currentSquare >= 35) currentSquare = R1;
                    else if (currentSquare >= 25) currentSquare = R4;
                    else if (currentSquare >= 15) currentSquare = R3;
                    else if (currentSquare >=5) currentSquare = R2;
                    else currentSquare = R1;

                };

                //  Go to next U(utility company)
                if (cc == 9)
                {

                    if (currentSquare >= 28) currentSquare = U1;
                    else if (currentSquare >= 12) currentSquare = U2;              
                    else currentSquare = U1;

                };

                //   Go back 3 squares.
                if (cc == 10)
                {
                    currentSquare -= 3;
                    if (currentSquare < 0) currentSquare += 40;
                    if (currentSquare == G2J)
                    {
                        currentSquare = JAIL;
                    }
                }






            }

            return currentSquare;
        }

            private int CommunityChestHandler(int currentSquare)
        {
            if (currentSquare == CC1 || currentSquare == CC2 || currentSquare == CC3)
            {
                var cc = random.Next(16);
                if (cc == 1) { currentSquare = GO; };
                if (cc == 2) { currentSquare = JAIL; };
            }

            return currentSquare;
        }





        public string GetPopularSquares()
        {
            var Order = Squares.OrderByDescending(e => e.Visits).Select(e=>e.Number).Take(3);

            String s = String.Join("", Order);

            return s;
        }

        public double GetHighestVisitProbability()
        {
           int maxVistits= Squares.Select(e => e.Visits).Max();
            return 100.0 * maxVistits / SimulationRuns;


         
        }
    }
}
