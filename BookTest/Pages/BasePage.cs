using Atata;

namespace BookTest.Pages;

public class BasePage<TOwner> : Page<TOwner>
    where TOwner : BasePage<TOwner>
{
    [FindByClass("side-menu")]
    public CategoryList<TOwner> SideBar { get; private set; }

    public TOwner ClickCategory(string category)
    {
        SideBar.GetByText(category).Click();
        return Owner;
    }
}
