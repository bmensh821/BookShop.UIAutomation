using Atata;
using BookTest.Pages;

namespace BookTest.UI.Pages;

public class BasePage<TOwner> : Page<TOwner>
    where TOwner : BasePage<TOwner>
{
    [FindByClass("side_categories")]
    public CategoryList<TOwner> SideBar { get; private set; }

    public TOwner ClickCategory(string category)
    {
        SideBar.GetByText(category).Click();
        return Owner;
    }
}
