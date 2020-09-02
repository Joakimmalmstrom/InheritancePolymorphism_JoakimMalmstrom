namespace Inheritance_JoakimMalmstrom
{
    internal class InvalidCharacterError : UserError
    {
        public InvalidCharacterError()
        {
        }

        public override string UEMessage()
        {
            return "You entered invalid characters in the text field. This fired an error!";
        }
    }
}