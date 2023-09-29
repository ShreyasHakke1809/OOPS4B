namespace OOPS4B
{
    internal class Card
    {
        private String faceName, suit;

        /**
         * The constructor initializes the instance variables.
         * @param faceName
         * @param suit
         * @param value
         */
        public Card(String faceName, String suit)
        {
            this.faceName = faceName;
            this.suit = suit;
        }
        /**
         *@return a String representation of the Card
         */
        public override String ToString()
        {
            return faceName + " of " + suit;
        }
    }
}
