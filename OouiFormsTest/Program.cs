using Ooui;
using Xamarin.Forms;

namespace OouiFormsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize Xamarin.Forms
            Forms.Init();

            // Create the UI
            var page = new TestPage {BindingContext = new TestViewModel()};

            // Publish a root element to be displayed
            UI.Publish("/", page.GetOouiElement());
        }
    }
}
