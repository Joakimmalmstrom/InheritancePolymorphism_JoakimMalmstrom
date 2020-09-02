namespace Inheritance_JoakimMalmstrom
{
    internal class SpecialCharacterError : UserError
    {
        public SpecialCharacterError()
        {
        }

        public override string UEMessage()
        {
            return "You have special characters in the text field. This fired an error!";
        }
    }
}