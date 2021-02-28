namespace Mediator
{
    /// <summary>
    /// The Concrete Mediator class, which implement the send message method and keep track of all participants in the conversation.
    /// </summary>
    public class ConcreteMediator : IMediator
    {
        /// <summary>
        /// Reference to component.
        /// </summary>
        private readonly NorthSnackBar _northSnackBar;

        /// <summary>
        /// Reference to component.
        /// </summary>
        private readonly SouthSnackBar _southSnackBar;

        public ConcreteMediator(NorthSnackBar northSnackBar, SouthSnackBar southSnackBar)
        {
            _northSnackBar = northSnackBar;
            _northSnackBar.SetMediator(this);

            _southSnackBar = southSnackBar;
            _southSnackBar.SetMediator(this);
        }

        public void SendMessage(string message, SnackBar snackBar)
        {
            if (snackBar == _northSnackBar)
            {
                _southSnackBar.Notify(message);
            }
            else
            {
                _northSnackBar.Notify(message);
            }
        }
    }
}