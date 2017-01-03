namespace Polymorphism
{
    class DateInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a DateTime in a Date only field. This fired an error!";
        }
    }
}
