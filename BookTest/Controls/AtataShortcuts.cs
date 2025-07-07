using Atata;

namespace BookTest.Controls;

public static class AtataShortcuts
{
    public static TPage On<TPage>()
    {
        if (AtataContext.Current.PageObject is TPage page)
            return page;

        throw new InvalidOperationException($"Current page is not of type {typeof(TPage).Name}");
    }
}
