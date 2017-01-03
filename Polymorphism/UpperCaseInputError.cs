namespace Polymorphism
{
    class UpperCaseInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use an UPPERCASE text input in a lowercase text only field. This fired an error!";
        }
    }
}
