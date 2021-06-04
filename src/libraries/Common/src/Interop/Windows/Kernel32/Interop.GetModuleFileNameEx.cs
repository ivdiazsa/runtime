// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

internal static partial class Interop
{
    internal static partial class Kernel32
    {
        [GeneratedDllImport(Libraries.Kernel32, CharSet = CharSet.Unicode, SetLastError = true, EntryPoint = "K32GetModuleFileNameExW")]
        internal static partial int GetModuleFileNameEx(SafeProcessHandle processHandle, IntPtr moduleHandle, [Out] char[] baseName, int size);
    }
}
