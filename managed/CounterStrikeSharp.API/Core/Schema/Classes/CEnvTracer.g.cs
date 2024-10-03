// <auto-generated />
#nullable enable
#pragma warning disable CS1591

using System;
using System.Diagnostics;
using System.Drawing;
using CounterStrikeSharp;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Modules.Entities;
using CounterStrikeSharp.API.Modules.Memory;
using CounterStrikeSharp.API.Modules.Utils;
using CounterStrikeSharp.API.Core.Attributes;

namespace CounterStrikeSharp.API.Core;

public partial class CEnvTracer : CPointEntity
{
    public CEnvTracer (IntPtr pointer) : base(pointer) {}

	// m_vecEnd
	[SchemaMember("CEnvTracer", "m_vecEnd")]
	public Vector End => Schema.GetDeclaredClass<Vector>(this.Handle, "CEnvTracer", "m_vecEnd");

	// m_flDelay
	[SchemaMember("CEnvTracer", "m_flDelay")]
	public ref float Delay => ref Schema.GetRef<float>(this.Handle, "CEnvTracer", "m_flDelay");

}
