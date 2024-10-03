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

public partial class CPlayerSprayDecal : CModelPointEntity
{
    public CPlayerSprayDecal (IntPtr pointer) : base(pointer) {}

	// m_nUniqueID
	[SchemaMember("CPlayerSprayDecal", "m_nUniqueID")]
	public ref Int32 UniqueID => ref Schema.GetRef<Int32>(this.Handle, "CPlayerSprayDecal", "m_nUniqueID");

	// m_unAccountID
	[SchemaMember("CPlayerSprayDecal", "m_unAccountID")]
	public ref UInt32 AccountID => ref Schema.GetRef<UInt32>(this.Handle, "CPlayerSprayDecal", "m_unAccountID");

	// m_unTraceID
	[SchemaMember("CPlayerSprayDecal", "m_unTraceID")]
	public ref UInt32 TraceID => ref Schema.GetRef<UInt32>(this.Handle, "CPlayerSprayDecal", "m_unTraceID");

	// m_rtGcTime
	[SchemaMember("CPlayerSprayDecal", "m_rtGcTime")]
	public ref UInt32 RtGcTime => ref Schema.GetRef<UInt32>(this.Handle, "CPlayerSprayDecal", "m_rtGcTime");

	// m_vecEndPos
	[SchemaMember("CPlayerSprayDecal", "m_vecEndPos")]
	public Vector EndPos => Schema.GetDeclaredClass<Vector>(this.Handle, "CPlayerSprayDecal", "m_vecEndPos");

	// m_vecStart
	[SchemaMember("CPlayerSprayDecal", "m_vecStart")]
	public Vector Start => Schema.GetDeclaredClass<Vector>(this.Handle, "CPlayerSprayDecal", "m_vecStart");

	// m_vecLeft
	[SchemaMember("CPlayerSprayDecal", "m_vecLeft")]
	public Vector Left => Schema.GetDeclaredClass<Vector>(this.Handle, "CPlayerSprayDecal", "m_vecLeft");

	// m_vecNormal
	[SchemaMember("CPlayerSprayDecal", "m_vecNormal")]
	public Vector Normal => Schema.GetDeclaredClass<Vector>(this.Handle, "CPlayerSprayDecal", "m_vecNormal");

	// m_nPlayer
	[SchemaMember("CPlayerSprayDecal", "m_nPlayer")]
	public ref Int32 Player => ref Schema.GetRef<Int32>(this.Handle, "CPlayerSprayDecal", "m_nPlayer");

	// m_nEntity
	[SchemaMember("CPlayerSprayDecal", "m_nEntity")]
	public ref Int32 DecalEntity => ref Schema.GetRef<Int32>(this.Handle, "CPlayerSprayDecal", "m_nEntity");

	// m_nHitbox
	[SchemaMember("CPlayerSprayDecal", "m_nHitbox")]
	public ref Int32 Hitbox => ref Schema.GetRef<Int32>(this.Handle, "CPlayerSprayDecal", "m_nHitbox");

	// m_flCreationTime
	[SchemaMember("CPlayerSprayDecal", "m_flCreationTime")]
	public ref float CreationTime => ref Schema.GetRef<float>(this.Handle, "CPlayerSprayDecal", "m_flCreationTime");

	// m_nTintID
	[SchemaMember("CPlayerSprayDecal", "m_nTintID")]
	public ref Int32 TintID => ref Schema.GetRef<Int32>(this.Handle, "CPlayerSprayDecal", "m_nTintID");

	// m_nVersion
	[SchemaMember("CPlayerSprayDecal", "m_nVersion")]
	public ref byte Version => ref Schema.GetRef<byte>(this.Handle, "CPlayerSprayDecal", "m_nVersion");

	// m_ubSignature
	[SchemaMember("CPlayerSprayDecal", "m_ubSignature")]
	public Span<byte> Signature => Schema.GetFixedArray<byte>(this.Handle, "CPlayerSprayDecal", "m_ubSignature", 128);

}
