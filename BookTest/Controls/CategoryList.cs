using Atata;

namespace BookTest.Pages;

public class CategoryList<TOwner> : Control<TOwner>
    where TOwner : PageObject<TOwner>
{
    public Link<TOwner> GetByText(string category) =>
       Controls.Create<Link<TOwner>>(
           name: null, // Provide a null name as the first argument 
           new FindByXPathAttribute($"//a[normalize-space(text())='{category}']"));
}