﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnitTests.Foo
{
    public interface IFoo
    {
        bool DoSomething(string value);
        string ProcessString(string value);
        bool TryParse(string value, out string outputvalue);
        bool Submit(ref Bar bar);
        int GetCount();
        bool Add(int amount);
        string Name { get; set; }
        IBaz SomeBaz { get; }
        int SomeOtherProperty { get; set; }
    }
}
