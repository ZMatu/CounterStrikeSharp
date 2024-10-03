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

public partial class CMotorController : NativeObject
{
    public CMotorController (IntPtr pointer) : base(pointer) {}

	// m_speed
	[SchemaMember("CMotorController", "m_speed")]
	public ref float Speed => ref Schema.GetRef<float>(this.Handle, "CMotorController", "m_speed");

	// m_maxTorque
	[SchemaMember("CMotorController", "m_maxTorque")]
	public ref float MaxTorque => ref Schema.GetRef<float>(this.Handle, "CMotorController", "m_maxTorque");

	// m_axis
	[SchemaMember("CMotorController", "m_axis")]
	public Vector Axis => Schema.GetDeclaredClass<Vector>(this.Handle, "CMotorController", "m_axis");

	// m_inertiaFactor
	[SchemaMember("CMotorController", "m_inertiaFactor")]
	public ref float InertiaFactor => ref Schema.GetRef<float>(this.Handle, "CMotorController", "m_inertiaFactor");

}
