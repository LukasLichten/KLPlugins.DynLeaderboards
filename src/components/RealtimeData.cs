﻿using KLPlugins.DynLeaderboards.ksBroadcastingNetwork;
using KLPlugins.DynLeaderboards.ksBroadcastingNetwork.Structs;
using System;

namespace KLPlugins.DynLeaderboards.src.ksBroadcastingNetwork.Structs {
    public class RealtimeData {
        public RealtimeUpdate NewData { get; private set; }
        public RealtimeUpdate OldData { get; private set; }
        public int EventIndex => NewData.EventIndex;
        public int SessionIndex => NewData.SessionIndex;
        public SessionPhase Phase => NewData.Phase;
        public TimeSpan SessionRunningTime => NewData.SessionRunningTime;
        public TimeSpan RemainingTime => NewData.RemainingTime;
        public TimeSpan SystemTime => NewData.SystemTime;
        public LapInfo BestSessionLap => NewData.BestSessionLap;
        public ushort BestLapCarIndex => NewData.BestLapCarIndex;
        public ushort BestLapDriverIndex => NewData.BestLapDriverIndex;
        public int FocusedCarIndex => NewData.FocusedCarIndex;
        public TimeSpan SessionEndTime => NewData.SessionEndTime;
        public TimeSpan SessionRemainingTime => NewData.SessionRemainingTime;
        public RaceSessionType SessionType => NewData.SessionType;
        public byte AmbientTemp => NewData.AmbientTemp;
        public byte TrackTemp => NewData.TrackTemp;

        public bool IsNewSession { get; private set; }
        public bool IsSessionStart { get; private set; }
        public bool IsFocusedChange { get; private set; }
        public bool IsSession { get; private set; }
        public bool IsPreSession { get; private set; }
        public bool IsPostSession { get; private set; }
        public bool IsRace { get; private set; }
        public TimeSpan SessionTotalTime { get; private set; } = TimeSpan.Zero;

        public RealtimeData(RealtimeUpdate update) {
            OldData = update;
            NewData = update;
        }

        public void OnRealtimeUpdate(RealtimeUpdate update) {
            OldData = NewData;
            NewData = update;

            IsRace = NewData.SessionType == RaceSessionType.Race;
            IsSession = NewData.Phase == SessionPhase.Session;
            IsPreSession = !IsSession && (NewData.Phase == SessionPhase.Starting || NewData.Phase == SessionPhase.PreFormation || NewData.Phase == SessionPhase.FormationLap || NewData.Phase == SessionPhase.PreSession);
            IsPostSession = !IsSession && (NewData.Phase == SessionPhase.SessionOver || NewData.Phase == SessionPhase.PostSession || NewData.Phase == SessionPhase.ResultUI);

            IsSessionStart = OldData.Phase != SessionPhase.Session && IsSession;
            IsFocusedChange = NewData.FocusedCarIndex != OldData.FocusedCarIndex;
            IsNewSession = OldData.SessionType != NewData.SessionType || NewData.SessionIndex != OldData.SessionIndex || OldData.Phase == SessionPhase.Session && IsPreSession;

            if (SessionTotalTime == TimeSpan.Zero) SessionTotalTime = SessionRunningTime + SessionRemainingTime;
        }

    }
}
