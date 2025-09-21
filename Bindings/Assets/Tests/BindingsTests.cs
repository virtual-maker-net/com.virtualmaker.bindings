using NUnit.Framework;
using System;
using System.Threading.Tasks;
using UnityEngine;
using VirtualMaker.Bindings;

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

    private static async Task DoSomethingAsync(Action action)
    {
        await Task.Delay(100);
        action();
    }

    [Test]
    public async void TestAsyncTaskFuncs()
    {
        var go = new GameObject();
        var button = go.AddComponent<UnityEngine.UI.Button>();

        bool thingHappened = false;

        Bindings.Bind(button.onClick, () => DoSomethingAsync(() => thingHappened = true));

        button.onClick.Invoke();

        await Task.Delay(200);
        Assert.IsTrue(thingHappened);
    }
}