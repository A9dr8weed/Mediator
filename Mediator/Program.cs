namespace Mediator
{
    public static class Program
    {
        private static void Main()
        {
            NorthSnackBar leftKitchen = new NorthSnackBar();
            SouthSnackBar rightKitchen = new SouthSnackBar();

            new ConcreteMediator(leftKitchen, rightKitchen);

            leftKitchen.Send("Can you send some popcorn?");
            rightKitchen.Send("Sure thing, Kenny's on his way.");

            rightKitchen.Send("Do you have any extra hot dogs?  We've had a rush on them over here.");
            leftKitchen.Send("Just a couple, we'll send Kenny back with them.");
        }
    }
}