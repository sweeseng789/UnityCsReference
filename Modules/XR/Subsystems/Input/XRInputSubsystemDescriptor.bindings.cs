// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

using System;
using UnityEngine.Bindings;
using UsedByNativeCodeAttribute = UnityEngine.Scripting.UsedByNativeCodeAttribute;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Experimental;

namespace UnityEngine.Experimental.XR
{
    [NativeHeader("Modules/XR/XRPrefix.h")]
    [NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystemDescriptor.h")]
    [UsedByNativeCode]
    [NativeConditional("ENABLE_XR")]
    public class XRInputSubsystemDescriptor : SubsystemDescriptor<XRInputSubsystem>
    {
        [NativeConditional("ENABLE_XR")]
        public extern bool disablesLegacyInput { get; }
    }
}
