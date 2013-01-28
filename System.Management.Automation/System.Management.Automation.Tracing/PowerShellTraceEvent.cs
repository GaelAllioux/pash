namespace System.Management.Automation.Tracing
{
    using System;

    public enum PowerShellTraceEvent
    {
        AnalyticTransferEventRunspacePool = 0x2f07,
        AppDomainUnhandledException = 0x8009,
        AppDomainUnhandledExceptionAnalytic = 0x8007,
        AppName = 0x2f02,
        ComputerName = 0x2f03,
        ErrorRecord = 0xb001,
        Exception = 0xb002,
        HostNameResolve = 0x1001,
        Job = 0xb004,
        LoadingPSCustomShellAssembly = 0x8061,
        LoadingPSCustomShellType = 0x8062,
        None = 0,
        OperationalTransferEventRunspacePool = 0x2004,
        PerformanceTrackConsoleStartupStart = 0xa001,
        PerformanceTrackConsoleStartupStop = 0xa002,
        PowerShellObject = 0xb003,
        ReceivedRemotingFragment = 0x8063,
        ReportContext = 0x8053,
        ReportOperationComplete = 0x8054,
        RunspaceConstructor = 0x2001,
        RunspacePoolConstructor = 0x2002,
        RunspacePoolOpen = 0x2003,
        RunspacePort = 0x2f01,
        Scheme = 0x2f04,
        SchemeResolve = 0x1002,
        SentRemotingFragment = 0x8064,
        SerializerDepthOverride = 0x7003,
        SerializerEnumerationFailed = 0x7007,
        SerializerMaxDepthWhenSerializing = 0x700a,
        SerializerModeOverride = 0x7004,
        SerializerPropertyGetterFailed = 0x7006,
        SerializerScriptPropertyWithoutRunspace = 0x7005,
        SerializerSpecificPropertyMissing = 0x700c,
        SerializerToStringFailed = 0x7008,
        SerializerWorkflowLoadFailure = 0x7002,
        SerializerWorkflowLoadSuccess = 0x7001,
        SerializerXmlExceptionWhenDeserializing = 0x700b,
        ServerClientReceiveRequest = 0x8058,
        ServerCloseOperation = 0x8059,
        ServerCreateCommandSession = 0x8055,
        ServerCreateRemoteSession = 0x8052,
        ServerReceivedData = 0x8057,
        ServerSendData = 0x8051,
        ServerStopCommand = 0x8056,
        ShellResolve = 0x1003,
        TestAnalytic = 0x2f05,
        TraceMessage = 0xb005,
        TraceMessage2 = 0xc001,
        TraceMessageGuid = 0xc002,
        TraceWSManConnectionInfo = 0xb006,
        TransportError = 0x8010,
        TransportErrorAnalytic = 0x8008,
        TransportReceivedObject = 0x8001,
        UriRedirection = 0x8025,
        WSManCloseCommand = 0x8021,
        WSManCloseCommandCallbackReceived = 0x8022,
        WSManCloseShell = 0x8013,
        WSManCloseShellCallbackReceived = 0x8014,
        WSManConnectionInfoDump = 0x2f06,
        WSManCreateCommand = 0x8019,
        WSManCreateCommandCallbackReceived = 0x8020,
        WSManCreateShell = 0x8011,
        WSManCreateShellCallbackReceived = 0x8012,
        WSManPluginShutdown = 0x8065,
        WSManReceiveShellOutputExtended = 0x8017,
        WSManReceiveShellOutputExtendedCallbackReceived = 0x8018,
        WSManSendShellInputExtended = 0x8015,
        WSManSendShellInputExtendedCallbackReceived = 0x8016,
        WSManSignal = 0x8023,
        WSManSignalCallbackReceived = 0x8024
    }
}

