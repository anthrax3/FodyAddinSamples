﻿using System.Diagnostics;
using Mixins.Fody;
using NUnit.Framework;

public interface IAddedFunc
{
    string Func();
}

public class AddedFunc : IAddedFunc
{
    public string Func()
    {
        return "String from Mixin";
    }
}

[Mixin(typeof(AddedFunc))]
public class Target 
{
}


[TestFixture]
public class Sample
{
    [Test]
    public void Run()
    {
        var target = (IAddedFunc)new Target();
        Debug.WriteLine(target.Func());
    }
}