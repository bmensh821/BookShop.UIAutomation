using Atata;

namespace BookTest.Pages;

[Url("https://books.toscrape.com/")]
public class BooksPage : BasePage<BooksPage>
{
    [FindByClass("product_pod")]
    public ControlList<BookTile, BooksPage> Books { get; private set; }

    public class BookTile : Control<BooksPage>
    {
        [FindByXPath(".//h3")]
        public Link<BooksPage> BookTitle { get; private set; }

        [FindByClass("price_color")]
        public Text<BooksPage> Price { get; private set; }
    }
}