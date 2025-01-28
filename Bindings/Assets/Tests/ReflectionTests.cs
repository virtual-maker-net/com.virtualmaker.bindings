using NUnit.Framework;
using System;
using VirtualMaker.Bindings;
using VirtualMaker.Bindings.Reflection;

public class ReflectionTests
{
    private Bindings _bindings;
    private int _pokeCount;

    [SetUp]
    public void SetUp()
    {
        _bindings = new();
        _pokeCount = 0;
    }

    [TearDown]
    public void TearDown()
    {
        _bindings.Reset();
    }

    [Test]
    public void Test1()
    {
        var pokeable = new ClassA();
        _bindings.OnEventMember<Action>(pokeable, nameof(ClassA.OnPoked), HandlePoked);

        pokeable.Poke();
        pokeable.Poke();
        pokeable.Poke();

        _bindings.Reset();

        pokeable.Poke();

        Assert.AreEqual(3, _pokeCount);
    }

    private void HandlePoked()
    {
        _pokeCount++;
    }
}

public struct ClassA
{
    public event Action OnPoked;

    public void Poke()
    {
        OnPoked?.Invoke();
    }
}