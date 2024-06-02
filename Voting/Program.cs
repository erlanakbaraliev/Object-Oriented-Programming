using TextFile;

namespace Voting
{
    internal class Program
    {
        public class WrongLawTypeException(): Exception { }
        static void Main(string[] args)
        {
            TextFileReader reader = new TextFileReader("input.txt");

            List<Congressmen> cmen = new List<Congressmen>();
            List<Party> parties = new List<Party>();

            reader.ReadLine(out string cmenNames);
            string[] cmenSplit = cmenNames.Split(' ');

            for(int i=0; i<cmenSplit.Length; i+=2)
            {
                string fullName = cmenSplit[i] + " " + cmenSplit[i+1];
                Congressmen c = new Congressmen(fullName);
                cmen.Add(c);
            }

            Parliament parliament = new Parliament(cmen);

            reader.ReadLine(out string partyNames);
            string[] partiesSplit = partyNames.Split(" ");
            
            foreach(string partyName in partiesSplit)
            {
                Party party = new Party(partyName, parliament);
                parties.Add(party);
            }

            reader.ReadLine(out string CmanParty);
            string[] CmanPartySplit = CmanParty.Split(" ");

            for(int i=0; i<CmanPartySplit.Length; i+=3)
            {
                string fullName = CmanPartySplit[i] + " " + CmanPartySplit[i+1];
                foreach(Congressmen c in cmen)
                {
                    if(c.name.Equals(fullName))
                    {
                        string partyName = CmanPartySplit[i+2];
                        foreach(Party p in parties)
                        {
                            if(p.name.Equals(partyName))
                            {
                                c.Enter(p);
                            }
                        }
                    }
                }
            }

            reader.ReadLine(out string cManLeftParty);
            string[] cManLeftPartySplit = cManLeftParty.Split(" ");

            for (int i = 0; i < cManLeftPartySplit.Length; i+=2)
            {
                string fullName = cManLeftPartySplit[i] + " " + cManLeftPartySplit[i+1];

                foreach(Congressmen c in cmen)
                {
                    if(c.name.Equals(fullName))
                    {
                        c.Leave();
                    }
                }
            }

            while (reader.ReadLine(out string law))
            {

                string[] lawSplit = law.Split(" ");

                string lawType = lawSplit[0];
                string lawID = lawSplit[1];
                string lawDate = lawSplit[2];

                if(lawType.Equals("Normal"))
                {
                    DraftLaw normalLaw = new Normal(lawDate, lawID);
                    parliament.Submit(normalLaw);
                }
                else if(lawType.Equals("Cardinal"))
                {
                    DraftLaw cardinalLaw = new Cardinal(lawDate, lawID);
                    parliament.Submit(cardinalLaw);
                }
                else if (lawType.Equals("Constitutional"))
                {
                    DraftLaw constitutionalLaw = new Constitutional(lawDate, lawID);
                    parliament.Submit(constitutionalLaw);
                }
                else
                {
                    throw new WrongLawTypeException();
                }

                int i = 3;
                foreach(Congressmen cm in parliament.cmen)
                {
                    if (lawSplit[i].Equals("yes"))
                    {
                        parliament.Vote(cm, true, lawID);
                    }
                    else if (lawSplit[i].Equals("no"))
                    {
                        parliament.Vote(cm, false, lawID);
                    }
                    i++;
                }
            }

            Console.Write("Invalid Laws: ");
            foreach (string lawID in parliament.ValidLaws())
            {
                Console.Write(lawID + " ");
            };

            Console.WriteLine();

            Console.Write("Abstained count: " + parliament.AbstainCount());

            Console.WriteLine();

            Console.Write("Laws after being rejected: ");
            parliament.Reject();
            foreach(DraftLaw law in parliament.laws)
            {
                Console.Write(law.ID + " ");
            }

            Console.WriteLine();

            bool result = parliament.AbstainParty();
            if(result)
            {
                Console.WriteLine("Yes, every member of a given party has abstained");
            }
            else
            {
                Console.WriteLine("No, not every member of a given party has abstained");
            }
        }
    }
}
