namespace OOPS4B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DecksOfCards myDeckofCards = new DecksOfCards();
            Console.WriteLine("-----------------------Deck before shuffling-----------------------------");
            myDeckofCards.displayDeck();

            myDeckofCards.shuffle();
            Console.WriteLine("-----------------------Deck After Shuffling------------------------------");
            myDeckofCards.displayDeck();

            Console.WriteLine("-----------------------53 calls to dealOndeCard()------------------------");
            for (int i = 0; i < 53; i++)
            {
                Card result = myDeckofCards.dealOneCard();
                if (result == null)
                {
                    Console.WriteLine("null");
                }
                else
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}