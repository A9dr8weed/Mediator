namespace Mediator
{
    /// <summary>
    /// The Component class, representing an entity involved in the conversation which should receive messages.
    /// </summary>
    public class SnackBar
    {
        /// <summary>
        /// Reference to the mediator object, but works with it only through the abstract interface of mediators.
        /// </summary>
        protected IMediator _mediator;

        protected SnackBar(IMediator mediator = null)
        {
            _mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}