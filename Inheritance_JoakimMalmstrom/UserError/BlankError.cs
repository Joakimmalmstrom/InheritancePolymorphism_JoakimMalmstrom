namespace Inheritance_JoakimMalmstrom
{
    internal class BlankError : UserError
    {
        public BlankError()
        {
        }

        public override string UEMessage()
        {
            return "You left the box empty. This fired an error!";
        }
    }
}