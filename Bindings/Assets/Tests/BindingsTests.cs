using NUnit.Framework;
using System;
using System.Threading.Tasks;
using UnityEngine;
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

    private static async Task DoSomethingAsync(Action action)
    {
        await Task.Delay(100);
        action();
    }

    [Test]
    public async void AsyncTest()
    {
        var go = new GameObject();
        var button = go.AddComponent<UnityEngine.UI.Button>();

        bool thingHappened = false;

        _bindings.On(button.onClick, () => DoSomethingAsync(() => thingHappened = true));

        button.onClick.Invoke();

        await Task.Delay(200);
        Assert.IsTrue(thingHappened);
    }
}