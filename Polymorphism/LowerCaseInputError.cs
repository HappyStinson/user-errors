namespace Polymorphism
{
    class LowerCaseInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a lowercase text input in an UPPERCASE text only field. This fired an error!";
        }
    }
}
