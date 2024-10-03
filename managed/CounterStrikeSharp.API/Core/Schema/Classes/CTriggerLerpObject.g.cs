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

public partial class CTriggerLerpObject : CBaseTrigger
{
    public CTriggerLerpObject (IntPtr pointer) : base(pointer) {}

	// m_iszLerpTarget
	[SchemaMember("CTriggerLerpObject", "m_iszLerpTarget")]
	public string IszLerpTarget
	{
		get { return Schema.GetUtf8String(this.Handle, "CTriggerLerpObject", "m_iszLerpTarget"); }
		set { Schema.SetString(this.Handle, "CTriggerLerpObject", "m_iszLerpTarget", value); }
	}

	// m_hLerpTarget
	[SchemaMember("CTriggerLerpObject", "m_hLerpTarget")]
	public CHandle<CBaseEntity> HLerpTarget => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CTriggerLerpObject", "m_hLerpTarget");

	// m_iszLerpTargetAttachment
	[SchemaMember("CTriggerLerpObject", "m_iszLerpTargetAttachment")]
	public string IszLerpTargetAttachment
	{
		get { return Schema.GetUtf8String(this.Handle, "CTriggerLerpObject", "m_iszLerpTargetAttachment"); }
		set { Schema.SetString(this.Handle, "CTriggerLerpObject", "m_iszLerpTargetAttachment", value); }
	}

	// m_flLerpDuration
	[SchemaMember("CTriggerLerpObject", "m_flLerpDuration")]
	public ref float LerpDuration => ref Schema.GetRef<float>(this.Handle, "CTriggerLerpObject", "m_flLerpDuration");

	// m_bLerpRestoreMoveType
	[SchemaMember("CTriggerLerpObject", "m_bLerpRestoreMoveType")]
	public ref bool LerpRestoreMoveType => ref Schema.GetRef<bool>(this.Handle, "CTriggerLerpObject", "m_bLerpRestoreMoveType");

	// m_bSingleLerpObject
	[SchemaMember("CTriggerLerpObject", "m_bSingleLerpObject")]
	public ref bool SingleLerpObject => ref Schema.GetRef<bool>(this.Handle, "CTriggerLerpObject", "m_bSingleLerpObject");

	// m_vecLerpingObjects
	[SchemaMember("CTriggerLerpObject", "m_vecLerpingObjects")]
	public NetworkedVector<lerpdata_t> LerpingObjects => Schema.GetDeclaredClass<NetworkedVector<lerpdata_t>>(this.Handle, "CTriggerLerpObject", "m_vecLerpingObjects");

	// m_iszLerpEffect
	[SchemaMember("CTriggerLerpObject", "m_iszLerpEffect")]
	public string LerpEffect
	{
		get { return Schema.GetUtf8String(this.Handle, "CTriggerLerpObject", "m_iszLerpEffect"); }
		set { Schema.SetString(this.Handle, "CTriggerLerpObject", "m_iszLerpEffect", value); }
	}

	// m_iszLerpSound
	[SchemaMember("CTriggerLerpObject", "m_iszLerpSound")]
	public string LerpSound
	{
		get { return Schema.GetUtf8String(this.Handle, "CTriggerLerpObject", "m_iszLerpSound"); }
		set { Schema.SetString(this.Handle, "CTriggerLerpObject", "m_iszLerpSound", value); }
	}

	// m_bAttachTouchingObject
	[SchemaMember("CTriggerLerpObject", "m_bAttachTouchingObject")]
	public ref bool AttachTouchingObject => ref Schema.GetRef<bool>(this.Handle, "CTriggerLerpObject", "m_bAttachTouchingObject");

	// m_hEntityToWaitForDisconnect
	[SchemaMember("CTriggerLerpObject", "m_hEntityToWaitForDisconnect")]
	public CHandle<CBaseEntity> EntityToWaitForDisconnect => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CTriggerLerpObject", "m_hEntityToWaitForDisconnect");

	// m_OnLerpStarted
	[SchemaMember("CTriggerLerpObject", "m_OnLerpStarted")]
	public CEntityIOOutput OnLerpStarted => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CTriggerLerpObject", "m_OnLerpStarted");

	// m_OnLerpFinished
	[SchemaMember("CTriggerLerpObject", "m_OnLerpFinished")]
	public CEntityIOOutput OnLerpFinished => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CTriggerLerpObject", "m_OnLerpFinished");

}
