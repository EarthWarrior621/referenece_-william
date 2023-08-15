namespace referenece__william
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sedan myFirstSedan = new Sedan(0);
            IAutomobile myAutomobile = myFirstSedan;

            Sedan myOtherSedan = new Sedan(0);

            myFirstSedan.IncreasseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myAutomobile.Speed);
            Console.WriteLine(myFirstSedan.Equals(myAutomobile));

            myOtherSedan.IncreasseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myOtherSedan.Speed);
            Console.WriteLine(myFirstSedan.Equals(myOtherSedan));

            trucks mytrucks = new trucks(50, 500, "Mytruck");

            myFirstSedan.Stringify();
            myAutomobile.Stringify();
            myOtherSedan.Stringify();
            mytrucks.Stringify();
        }
    }
}