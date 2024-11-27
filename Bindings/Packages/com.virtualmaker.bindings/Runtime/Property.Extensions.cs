#if BINDINGS_ADDRESSABLES && BINDINGS_UTIL_ASYNC && BINDINGS_UTIL_EXTENSIONS

using System;
using System.Threading.Tasks;
using UnityEngine.ResourceManagement.AsyncOperations;
using Utilities.Extensions;

namespace VirtualMaker.Bindings
{
    public static class PropertyExtensions
    {
        public static Task<T> AwaitBindProgress<T>(this AsyncOperationHandle<T> operation, Property<float> progress, bool autoRelease = true)
        {
            return operation.AwaitWithProgress(new Progress<float>((value) => progress.Value = value), autoRelease);
        }

        public static Task AwaitBindProgress(this AsyncOperationHandle operation, Property<float> progress, bool autoRelease = true)
        {
            return operation.AwaitWithProgress(new Progress<float>((value) => progress.Value = value), autoRelease);
        }
    }
}

#endif