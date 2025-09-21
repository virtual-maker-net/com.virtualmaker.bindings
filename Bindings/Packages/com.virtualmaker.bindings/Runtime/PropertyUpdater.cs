using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace VirtualMaker.Bindings
{
    internal class PropertyUpdater
    {
        private BindingContext _context;
        private Action _updateFunc;
        private Func<bool> _doneFunc;
        private Func<Awaitable> _awaitableFunc;

        private Task _task;
        public Task Task => _task;

        public PropertyUpdater(
            BindingContext context,
            Action updateFunc,
            Func<Awaitable> awaitableFunc,
            Func<bool> doneFunc)
        {
            _context = context;
            _updateFunc = updateFunc;
            _doneFunc = doneFunc;
            _awaitableFunc = awaitableFunc;
            _task = RunAsync();
        }

        private async Task RunAsync()
        {
            while (_context.IsValid && (_doneFunc == null || !_doneFunc()))
            {
                try
                {
                    _updateFunc();
                }
                catch (Exception e)
                {
                    Debug.LogException(e);
                }

                await _awaitableFunc();
            }
        }
    }
}