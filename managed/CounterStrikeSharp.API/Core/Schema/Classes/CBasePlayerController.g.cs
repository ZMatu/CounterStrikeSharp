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

public partial class CBasePlayerController : CBaseEntity
{
    public CBasePlayerController (IntPtr pointer) : base(pointer) {}

	// m_nInButtonsWhichAreToggles
	[SchemaMember("CBasePlayerController", "m_nInButtonsWhichAreToggles")]
	public ref UInt64 InButtonsWhichAreToggles => ref Schema.GetRef<UInt64>(this.Handle, "CBasePlayerController", "m_nInButtonsWhichAreToggles");

	// m_nTickBase
	[SchemaMember("CBasePlayerController", "m_nTickBase")]
	public ref UInt32 TickBase => ref Schema.GetRef<UInt32>(this.Handle, "CBasePlayerController", "m_nTickBase");

	// m_hPawn
	[SchemaMember("CBasePlayerController", "m_hPawn")]
	public CHandle<CBasePlayerPawn> Pawn => Schema.GetDeclaredClass<CHandle<CBasePlayerPawn>>(this.Handle, "CBasePlayerController", "m_hPawn");

	// m_bKnownTeamMismatch
	[SchemaMember("CBasePlayerController", "m_bKnownTeamMismatch")]
	public ref bool KnownTeamMismatch => ref Schema.GetRef<bool>(this.Handle, "CBasePlayerController", "m_bKnownTeamMismatch");

	// m_nSplitScreenSlot
	[SchemaMember("CBasePlayerController", "m_nSplitScreenSlot")]
	public ref Int32 SplitScreenSlot => ref Schema.GetRef<Int32>(this.Handle, "CBasePlayerController", "m_nSplitScreenSlot");

	// m_hSplitOwner
	[SchemaMember("CBasePlayerController", "m_hSplitOwner")]
	public CHandle<CBasePlayerController> SplitOwner => Schema.GetDeclaredClass<CHandle<CBasePlayerController>>(this.Handle, "CBasePlayerController", "m_hSplitOwner");

	// m_hSplitScreenPlayers
	[SchemaMember("CBasePlayerController", "m_hSplitScreenPlayers")]
	public NetworkedVector<CHandle<CBasePlayerController>> SplitScreenPlayers => Schema.GetDeclaredClass<NetworkedVector<CHandle<CBasePlayerController>>>(this.Handle, "CBasePlayerController", "m_hSplitScreenPlayers");

	// m_bIsHLTV
	[SchemaMember("CBasePlayerController", "m_bIsHLTV")]
	public ref bool IsHLTV => ref Schema.GetRef<bool>(this.Handle, "CBasePlayerController", "m_bIsHLTV");

	// m_iConnected
	[SchemaMember("CBasePlayerController", "m_iConnected")]
	public ref PlayerConnectedState Connected => ref Schema.GetRef<PlayerConnectedState>(this.Handle, "CBasePlayerController", "m_iConnected");

	// m_iszPlayerName
	[SchemaMember("CBasePlayerController", "m_iszPlayerName")]
	public string PlayerName
	{
		get { return Schema.GetString(this.Handle, "CBasePlayerController", "m_iszPlayerName"); }
		set { Schema.SetStringBytes(this.Handle, "CBasePlayerController", "m_iszPlayerName", value, 128); }
	}

	// m_szNetworkIDString
	[SchemaMember("CBasePlayerController", "m_szNetworkIDString")]
	public string NetworkIDString
	{
		get { return Schema.GetUtf8String(this.Handle, "CBasePlayerController", "m_szNetworkIDString"); }
		set { Schema.SetString(this.Handle, "CBasePlayerController", "m_szNetworkIDString", value); }
	}

	// m_fLerpTime
	[SchemaMember("CBasePlayerController", "m_fLerpTime")]
	public ref float LerpTime => ref Schema.GetRef<float>(this.Handle, "CBasePlayerController", "m_fLerpTime");

	// m_bLagCompensation
	[SchemaMember("CBasePlayerController", "m_bLagCompensation")]
	public ref bool LagCompensation => ref Schema.GetRef<bool>(this.Handle, "CBasePlayerController", "m_bLagCompensation");

	// m_bPredict
	[SchemaMember("CBasePlayerController", "m_bPredict")]
	public ref bool Predict => ref Schema.GetRef<bool>(this.Handle, "CBasePlayerController", "m_bPredict");

	// m_bAutoKickDisabled
	[SchemaMember("CBasePlayerController", "m_bAutoKickDisabled")]
	public ref bool AutoKickDisabled => ref Schema.GetRef<bool>(this.Handle, "CBasePlayerController", "m_bAutoKickDisabled");

	// m_bIsLowViolence
	[SchemaMember("CBasePlayerController", "m_bIsLowViolence")]
	public ref bool IsLowViolence => ref Schema.GetRef<bool>(this.Handle, "CBasePlayerController", "m_bIsLowViolence");

	// m_bGamePaused
	[SchemaMember("CBasePlayerController", "m_bGamePaused")]
	public ref bool GamePaused => ref Schema.GetRef<bool>(this.Handle, "CBasePlayerController", "m_bGamePaused");

	// m_iIgnoreGlobalChat
	[SchemaMember("CBasePlayerController", "m_iIgnoreGlobalChat")]
	public ref ChatIgnoreType_t IgnoreGlobalChat => ref Schema.GetRef<ChatIgnoreType_t>(this.Handle, "CBasePlayerController", "m_iIgnoreGlobalChat");

	// m_flLastPlayerTalkTime
	[SchemaMember("CBasePlayerController", "m_flLastPlayerTalkTime")]
	public ref float LastPlayerTalkTime => ref Schema.GetRef<float>(this.Handle, "CBasePlayerController", "m_flLastPlayerTalkTime");

	// m_flLastEntitySteadyState
	[SchemaMember("CBasePlayerController", "m_flLastEntitySteadyState")]
	public ref float LastEntitySteadyState => ref Schema.GetRef<float>(this.Handle, "CBasePlayerController", "m_flLastEntitySteadyState");

	// m_nAvailableEntitySteadyState
	[SchemaMember("CBasePlayerController", "m_nAvailableEntitySteadyState")]
	public ref Int32 AvailableEntitySteadyState => ref Schema.GetRef<Int32>(this.Handle, "CBasePlayerController", "m_nAvailableEntitySteadyState");

	// m_bHasAnySteadyStateEnts
	[SchemaMember("CBasePlayerController", "m_bHasAnySteadyStateEnts")]
	public ref bool HasAnySteadyStateEnts => ref Schema.GetRef<bool>(this.Handle, "CBasePlayerController", "m_bHasAnySteadyStateEnts");

	// m_steamID
	[SchemaMember("CBasePlayerController", "m_steamID")]
	public ref UInt64 SteamID => ref Schema.GetRef<UInt64>(this.Handle, "CBasePlayerController", "m_steamID");

	// m_iDesiredFOV
	[SchemaMember("CBasePlayerController", "m_iDesiredFOV")]
	public ref UInt32 DesiredFOV => ref Schema.GetRef<UInt32>(this.Handle, "CBasePlayerController", "m_iDesiredFOV");

}
