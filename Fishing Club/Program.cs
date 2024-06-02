using System;
using System.Net.Http.Headers;
using TextFile;

namespace Fishing_Club
{
    internal class Program
    {
        public class WrongFishTypeException: Exception { };
        static void Main(string[] args)
        {
            try
            {
                Club club = new Club();

                TextFileReader reader1 = new TextFileReader("input.txt");

                reader1.ReadLine(out string names);
                string[] namesSplit = names.Split(' ');
                foreach(string name in namesSplit)
                {
                    Angler angler = new Angler(name);

                    club.Join(angler);
                }

                while (reader1.ReadString(out string contestFileName))
                {
                    TextFileReader contest1Reader = new TextFileReader(contestFileName);
                    contest1Reader.ReadString(out string contestLoc);

                    Contest contest = club.Organize(contestLoc);

                    while (contest1Reader.ReadString(out string name) && contest1Reader.ReadString(out string fishType) && contest1Reader.ReadDouble(out double weight))
                    {
                        foreach (Angler angler in club.members)
                        {
                            if (angler.Name == name)
                            {
                                contest.Register(angler);

                                if (fishType.Equals("bream"))
                                {
                                    angler.Catch(Bream.bream, (float)weight, contest);
                                }
                                else if (fishType.Equals("catfish"))
                                {
                                    angler.Catch(CatFish.catFish, (float)weight, contest);
                                }
                                else if (fishType.Equals("carp"))
                                {
                                    angler.Catch(Carp.carp, (float)weight, contest);
                                }
                                else
                                {
                                    throw new WrongFishTypeException();
                                }
                            }
                        }
                    }
                }

                club.Best();
            }
            catch(WrongFishTypeException ex)
            {
                Console.WriteLine("Wrong Fish Type " + ex.Message);
            }
        }
    }
}
