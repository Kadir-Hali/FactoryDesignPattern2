using FactoryDesignPattern2;

internal class Program
{
    private static void Main(string[] args)
    {
        Creator creator = new Creator();

        Screen screenWindows = creator.ScreenFactory(ScreenModel.Windows);
        Screen screenWeb = creator.ScreenFactory(ScreenModel.Web);
        Screen screenMobile = creator.ScreenFactory(ScreenModel.Mobile);

        screenMobile.Draw();
        screenWeb.Draw();
        screenWindows.Draw();
    }
}