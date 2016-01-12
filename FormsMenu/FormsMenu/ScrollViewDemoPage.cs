using Xamarin.Forms;

namespace FormsMenu
{
    public class ScrollViewDemoPage : ContentDemoPage
    {
        //View
        public ScrollViewDemoPage()
        {
            var scrollLabel = new Label
            {
                Text = "ScrollView",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 50,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic
            };

            var scrollView = new ScrollView
            {
                Content = new Label
                {
                    Text =
                        "Sometimes page content fits entirely on the page. That's very convienient. But on many occasions, the content of the page is much too " +
                        "large for the page, or only becomes available at runtime.\n" +
                        "\nFor cases such as these, the ScrollView provides a solution. Simply set its Content property to your content -- in this case a Label but in " +
                        "general case very likely a Layout derivative with multiple children -- and the ScrollView provides scrolling with the distinctive look and touch " +
                        "familiar to the user.\n" +
                        "\nThe ScrollView is also capable of horizontal scrolling, and while that's usually not as common as vertical scrolling, sometimes it comes in handy.\n" +
                        "\nMost often, the conten of a ScrollView is a StackLayout.  Whenever you're using a StackLayout with the number of items determined only at runtime, " +
                        "you should probably put it in a StackLayout just to be sure your stuff doesn't go running off the bottom of the screen.\n" +
                        "\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Donec quis scelerisque ex. Integer molestie eget dolor et pretium. " +
                        "Donec blandit tortor id quam tincidunt porttitor. Maecenas in lorem ut quam porta maximus. Donec placerat mauris commodo sem lacinia, " +
                        "non egestas ligula vehicula. Curabitur consequat molestie quam, vitae hendrerit diam scelerisque eget. Suspendisse in orci sit amet risus " +
                        "congue vulputate.\n" +
                        "\nMaecenas a sodales mauris, pellentesque ultrices nisl. Nam mi tellus, egestas sit amet augue vel, pulvinar mattis orci. Nullam id egestas " +
                        "orci. Curabitur velit velit, tempor sed enim at, fermentum volutpat sem. Nunc imperdiet, ipsum ut viverra vehicula, enim augue bibendum diam, " +
                        "eget tempor tortor leo id massa. Morbi egestas tincidunt lectus eget vulputate. Nam eu ex libero. Cras pharetra et velit in rutrum. Integer tincidunt " +
                        "ornare nulla, eu feugiat mauris dignissim nec. Morbi cursus dictum nunc, et hendrerit sem molestie ut. Mauris dignissim magna in arcu viverra, et laoreet " +
                        "dolor vestibulum. Praesent non iaculis velit, et hendrerit nisi. Quisque lacinia tincidunt libero vel tincidunt. Vestibulum dignissim ac velit non pulvinar. " +
                        "Proin aliquam est vel tortor suscipit congue. Proin a quam luctus, ultricies risus et, malesuada dui.\n" +
                        "\nProin sapien lectus, luctus a sem ac, ultrices lobortis lectus. Duis massa nisl, consequat nec laoreet sit amet, sagittis ac erat. Suspendisse quis aliquet " +
                        "magna. Donec vitae ligula sed dui auctor viverra vitae et erat. Integer imperdiet vestibulum euismod. Curabitur vel iaculis dui. Suspendisse placerat fermentum " +
                        "sem, sed dapibus augue tempor id. Aliquam eget feugiat ipsum, sed laoreet turpis. Morbi vel dui non tortor egestas dapibus a non erat. Donec eu ultrices nulla. Nam " +
                        "velit arcu, dictum ut eros eu, imperdiet mollis nisl. Nulla pellentesque facilisis massa, et ullamcorper nulla cursus vitae. Pellentesque vestibulum erat in magna " +
                        "fringilla, vel dictum nulla viverra. Nulla dictum bibendum dolor ac ornare. Pellentesque nunc lacus, sollicitudin sit amet purus ut, vestibulum efficitur lectus.\n" +
                        "\nInteger vitae tortor quis est posuere bibendum ut vitae velit. Integer porttitor dui in nisi congue faucibus. Integer aliquam dolor enim, quis dictum turpis laoreet " +
                        "vitae. Phasellus mollis enim sed nulla tristique, in hendrerit sem vulputate. Phasellus egestas sem neque, ac suscipit enim vehicula a. Morbi eget nibh elementum, blandit " +
                        "ligula in, lacinia nunc. Duis a ipsum scelerisque, elementum neque eget, finibus ligula. Phasellus et pellentesque dui. Suspendisse mattis aliquet est, quis sagittis mauris " +
                        "ultrices sit amet. Nullam luctus, ex sit amet congue porttitor, enim mi commodo ipsum, eu ultricies mi purus non odio. Suspendisse ultricies nisi ut nunc tincidunt fringilla " +
                        "vitae sit amet ex. Praesent quis consectetur nisl. Etiam arcu neque, sagittis eget convallis vel, mattis eu lacus. Sed varius ornare quam vitae auctor. Proin at molestie nibh.\n" +
                        "\nSed nec dignissim lectus. Fusce ut eros non orci pretium pulvinar. Etiam nisl risus, bibendum sit amet molestie varius, rutrum sit amet leo. Vestibulum rutrum gravida leo, " +
                        "placerat tempus dui dignissim quis. Curabitur vestibulum metus quis placerat pretium. Suspendisse arcu augue, eleifend ultrices urna ut, hendrerit tincidunt est. Mauris sit \n" +
                        "\namet finibus ipsum. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam suscipit ullamcorper sollicitudin. Cras accumsan justo id augue feugiat hendrerit." +
                        "Donec blandit tortor id quam tincidunt porttitor. Maecenas in lorem ut quam porta maximus. Donec placerat mauris commodo sem lacinia, " +
                        "non egestas ligula vehicula. Curabitur consequat molestie quam, vitae hendrerit diam scelerisque eget. Suspendisse in orci sit amet risus " +
                        "congue vulputate.\n" +
                        "\nMaecenas a sodales mauris, pellentesque ultrices nisl. Nam mi tellus, egestas sit amet augue vel, pulvinar mattis orci. Nullam id egestas " +
                        "orci. Curabitur velit velit, tempor sed enim at, fermentum volutpat sem. Nunc imperdiet, ipsum ut viverra vehicula, enim augue bibendum diam, " +
                        "eget tempor tortor leo id massa. Morbi egestas tincidunt lectus eget vulputate. Nam eu ex libero. Cras pharetra et velit in rutrum. Integer tincidunt " +
                        "ornare nulla, eu feugiat mauris dignissim nec. Morbi cursus dictum nunc, et hendrerit sem molestie ut. Mauris dignissim magna in arcu viverra, et laoreet " +
                        "dolor vestibulum. Praesent non iaculis velit, et hendrerit nisi. Quisque lacinia tincidunt libero vel tincidunt. Vestibulum dignissim ac velit non pulvinar. " +
                        "Proin aliquam est vel tortor suscipit congue. Proin a quam luctus, ultricies risus et, malesuada dui.\n" +
                        "\nProin sapien lectus, luctus a sem ac, ultrices lobortis lectus. Duis massa nisl, consequat nec laoreet sit amet, sagittis ac erat. Suspendisse quis aliquet " +
                        "magna. Donec vitae ligula sed dui auctor viverra vitae et erat. Integer imperdiet vestibulum euismod. Curabitur vel iaculis dui. Suspendisse placerat fermentum " +
                        "sem, sed dapibus augue tempor id. Aliquam eget feugiat ipsum, sed laoreet turpis. Morbi vel dui non tortor egestas dapibus a non erat. Donec eu ultrices nulla. Nam " +
                        "velit arcu, dictum ut eros eu, imperdiet mollis nisl. Nulla pellentesque facilisis massa, et ullamcorper nulla cursus vitae. Pellentesque vestibulum erat in magna " +
                        "fringilla, vel dictum nulla viverra. Nulla dictum bibendum dolor ac ornare. Pellentesque nunc lacus, sollicitudin sit amet purus ut, vestibulum efficitur lectus.\n" +
                        "\nInteger vitae tortor quis est posuere bibendum ut vitae velit. Integer porttitor dui in nisi congue faucibus. Integer aliquam dolor enim, quis dictum turpis laoreet " +
                        "vitae. Phasellus mollis enim sed nulla tristique, in hendrerit sem vulputate. Phasellus egestas sem neque, ac suscipit enim vehicula a. Morbi eget nibh elementum, blandit " +
                        "ligula in, lacinia nunc. Duis a ipsum scelerisque, elementum neque eget, finibus ligula. Phasellus et pellentesque dui. Suspendisse mattis aliquet est, quis sagittis mauris " +
                        "ultrices sit amet. Nullam luctus, ex sit amet congue porttitor, enim mi commodo ipsum, eu ultricies mi purus non odio. Suspendisse ultricies nisi ut nunc tincidunt fringilla " +
                        "vitae sit amet ex. Praesent quis consectetur nisl. Etiam arcu neque, sagittis eget convallis vel, mattis eu lacus. Sed varius ornare quam vitae auctor. Proin at molestie nibh.\n" +
                        "\nSed nec dignissim lectus. Fusce ut eros non orci pretium pulvinar. Etiam nisl risus, bibendum sit amet molestie varius, rutrum sit amet leo. Vestibulum rutrum gravida leo, " +
                        "placerat tempus dui dignissim quis. Curabitur vestibulum metus quis placerat pretium. Suspendisse arcu augue, eleifend ultrices urna ut, hendrerit tincidunt est. Mauris sit " +
                        "amet finibus ipsum. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam suscipit ullamcorper sollicitudin. Cras accumsan justo id augue feugiat hendrerit.",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof (Label))
                }
            };

            Content = new StackLayout
            {
                Children =
                {
                    scrollLabel,
                    scrollView
                }
            };
        }
    }
}