using BookTest.Configuration.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTest;

public class TestContext
{
    static TestContext()
    {
        Config = BookTestConfiguration.Instance;
    }

    public static BookTestConfiguration Config { get; }
}
