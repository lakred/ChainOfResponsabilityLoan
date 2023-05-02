namespace ChainOfResponsabilityLoanLibrary
{
    public abstract class Checker
    {
        protected Checker _successor;

        public void SetSuccessor(Checker successor)
        {
            _successor = successor;
        }

        public abstract (bool, string) ProcessInput(string input);
    }
}