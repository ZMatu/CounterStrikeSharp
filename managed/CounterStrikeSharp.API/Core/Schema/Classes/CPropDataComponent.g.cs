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

public partial class CPropDataComponent : CEntityComponent
{
    public CPropDataComponent (IntPtr pointer) : base(pointer) {}

	// m_flDmgModBullet
	[SchemaMember("CPropDataComponent", "m_flDmgModBullet")]
	public ref float DmgModBullet => ref Schema.GetRef<float>(this.Handle, "CPropDataComponent", "m_flDmgModBullet");

	// m_flDmgModClub
	[SchemaMember("CPropDataComponent", "m_flDmgModClub")]
	public ref float DmgModClub => ref Schema.GetRef<float>(this.Handle, "CPropDataComponent", "m_flDmgModClub");

	// m_flDmgModExplosive
	[SchemaMember("CPropDataComponent", "m_flDmgModExplosive")]
	public ref float DmgModExplosive => ref Schema.GetRef<float>(this.Handle, "CPropDataComponent", "m_flDmgModExplosive");

	// m_flDmgModFire
	[SchemaMember("CPropDataComponent", "m_flDmgModFire")]
	public ref float DmgModFire => ref Schema.GetRef<float>(this.Handle, "CPropDataComponent", "m_flDmgModFire");

	// m_iszPhysicsDamageTableName
	[SchemaMember("CPropDataComponent", "m_iszPhysicsDamageTableName")]
	public string PhysicsDamageTableName
	{
		get { return Schema.GetUtf8String(this.Handle, "CPropDataComponent", "m_iszPhysicsDamageTableName"); }
		set { Schema.SetString(this.Handle, "CPropDataComponent", "m_iszPhysicsDamageTableName", value); }
	}

	// m_iszBasePropData
	[SchemaMember("CPropDataComponent", "m_iszBasePropData")]
	public string BasePropData
	{
		get { return Schema.GetUtf8String(this.Handle, "CPropDataComponent", "m_iszBasePropData"); }
		set { Schema.SetString(this.Handle, "CPropDataComponent", "m_iszBasePropData", value); }
	}

	// m_nInteractions
	[SchemaMember("CPropDataComponent", "m_nInteractions")]
	public ref Int32 Interactions => ref Schema.GetRef<Int32>(this.Handle, "CPropDataComponent", "m_nInteractions");

	// m_bSpawnMotionDisabled
	[SchemaMember("CPropDataComponent", "m_bSpawnMotionDisabled")]
	public ref bool SpawnMotionDisabled => ref Schema.GetRef<bool>(this.Handle, "CPropDataComponent", "m_bSpawnMotionDisabled");

	// m_nDisableTakePhysicsDamageSpawnFlag
	[SchemaMember("CPropDataComponent", "m_nDisableTakePhysicsDamageSpawnFlag")]
	public ref Int32 DisableTakePhysicsDamageSpawnFlag => ref Schema.GetRef<Int32>(this.Handle, "CPropDataComponent", "m_nDisableTakePhysicsDamageSpawnFlag");

	// m_nMotionDisabledSpawnFlag
	[SchemaMember("CPropDataComponent", "m_nMotionDisabledSpawnFlag")]
	public ref Int32 MotionDisabledSpawnFlag => ref Schema.GetRef<Int32>(this.Handle, "CPropDataComponent", "m_nMotionDisabledSpawnFlag");

}
