using NUnit.Framework;
using System;
using VirtualMaker.Bindings;
using VirtualMaker.Bindings.Reflection;

public class BindingsTests
{
    private class Pokeable
    {
        public event Action OnPoked;

        public void Poke()
        {
            OnPoked?.Invoke();
        }
    }

    private Bindings _bindings;

    [SetUp]
    public void SetUp()
    {
        _bindings = new();
    }

    [TearDown]
    public void TearDown()
    {
        _bindings.Reset();
    }

    [Test]
    public void Test1()
    {
        var pokeable = new Pokeable();
        var pokeCount = 0;

        _bindings.On(pokeable, nameof(Pokeable.OnPoked), () => pokeCount++);

        pokeable.Poke();
        pokeable.Poke();
        pokeable.Poke();

        _bindings.Reset();

        pokeable.Poke();

        Assert.AreEqual(3, pokeCount);
    }
}