namespace Polymorphism
{
    class Date
    {
        public string DateString { get; set; }

        public Date(string dateString)
        {
            DateString = dateString;
        }

        public override string ToString()
        {
            return DateString;
        }
    }
}
