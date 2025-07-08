using Atata;

namespace BookTest.UI.Pages;

using _ = BooksPage;

//[Url("https://books.toscrape.com/")]
public class BooksPage : BasePage<_>
{
    [FindById("messages")]
    //.//div[@id='messages'] = xpath 
    public Text<_> BooksCount { get; private set; }

    [FindByClass("product_pod")]
    public ControlList<BookTile, _> Books { get; private set; }

    public class BookTile : Control<_>
    {
        [FindByXPath(".//h3", TargetName = "title")]
        public Link<_> BookTitle { get; private set; }

        [FindByClass("price_color")]
        public Text<_> Price { get; private set; }

        [FindByClass("instock availability")]
        public Text<_> isAvailable { get; private set; }
    }


    public Link<_> Next { get; private set; }
}