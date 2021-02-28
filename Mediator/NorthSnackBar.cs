using System;

namespace Mediator
{
    /// <summary>
    /// Concrete colleague classes that communicate with each other via the IMediator object.
    /// </summary>
    public class NorthSnackBar : SnackBar
    {
        public void Send(string message)
        {
            Console.WriteLine($"North snack bar Stand sends message: {message}");
            _mediator.SendMessage(message, this);
            Console.WriteLine();
        }

        public void Notify(string message)
        {
            Console.WriteLine($"North snack bar Stand gets message: {message}");
            Console.WriteLine();
        }
    }
}