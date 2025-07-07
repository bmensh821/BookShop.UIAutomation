//Functions related to the Books page in the BookTest project.

using Atata;

namespace BookTest.UI.Pages;

public static class BooksPageExtensions
{
    public static BooksPage.BookTile? GetBookByTitle(this BooksPage page, string title)
    {
        return page.Books
        .ToList()
        .FirstOrDefault(b => string.Equals(b.BookTitle.Content, title, StringComparison.OrdinalIgnoreCase));
    }

    public static string? GetBookPrice(this BooksPage page, string title)
    {
        var book = page.GetBookByTitle(title);
        return book?.Price?.Value;
    }

    public static bool IsBookInStock(this BooksPage page, string title)
    {
        var book = page.GetBookByTitle(title);
        return book?.isAvailable?.Content?.Contains("In stock") ?? false;
    }

    public static BooksPage.BookTile? GetBookByTitlePaged(this BooksPage page, string title)
    {
        while (true)
        {
            var book = page.Books.FirstOrDefault(b => b.BookTitle.Content.Value.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (book.IsPresent)
                return book;

            // If "Next" button exists and is clickable, go to next page
            if (page.Next.IsPresent && page.Next.IsVisible && !page.Next.IsEnabled)
            {
                page.Next.Click();
                //page = Go.To<BooksPage>();
            }
            else
            {
                return null; // Not found and no more pages
            }
        }
    }
}
