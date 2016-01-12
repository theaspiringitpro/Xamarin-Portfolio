using Xamarin.Forms;

namespace FormsMenu
{
    public class App : Application
    {
        public ListView ContactList = null;

        public App()
        {
            MainPage = new NavigationPage(new XFormsMenuPage());

            //Initializes a MasterDetailPageDemo object with working NavBar navigation button.
            //MainPage = new NavigationPage(new MasterDetailPageDemo());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}