using System;
using UnityEngine;

namespace Dankann.Logger
{
    public class LoggerSettings : ScriptableObject
    {
        public LoggerData LoggerData
        {
            get
            {
                if (_useUniversal)
                {
                    return _universal;
                }

                if (_loggerDatas == null)
                {
                    _loggerDatas = new LoggerData[]
                    {
                        _OSXEditor,
                        _OSXPlayer,
                        _WindowsPlayer,
                        _OSXWebPlayer,
                        _OSXDashboardPlayer,
                        _WindowsWebPlayer,
                        null,
                        _WindowsEditor,
                        _IPhonePlayer,
                        _PS3,
                        _XBOX360,
                        _Android,
                        _NaCl,
                        _LinuxPlayer,
                        null,
                        _FlashPlayer,
                        _LinuxEditor,
                        _WebGLPlayer,
                        _MetroWSAPlayerX86,
                        _MetroWSAPlayerX64,
                        _MetroWSAPlayerARM,
                        _WP8Player,
                        _BB10BlackBerryPlayer,
                        _TizenPlayer,
                        _PSP2,
                        _PS4,
                        _PSM,
                        _XboxOne,
                        _SamsungTVPlayer,
                        null,
                        _WiiU,
                        _tvOS,
                        _Switch,
                        _Lumin,
                        _Stadia,
                        _CloudRendering,
                        _GameCoreScarlettXboxSeries,
                        _GameCoreXboxOne,
                        _PS5,
                    };
                }

                return _loggerDatas[(int)Application.platform];
            }
        }

        [SerializeField] private LoggerData _universal;
        [SerializeField] bool _useUniversal = true;
        [SerializeField] private LoggerData _OSXEditor;
        [SerializeField] private LoggerData _OSXPlayer;
        [SerializeField] private LoggerData _WindowsPlayer;
        [SerializeField] private LoggerData _OSXWebPlayer;
        [SerializeField] private LoggerData _OSXDashboardPlayer;
        [SerializeField] private LoggerData _WindowsWebPlayer;
        [SerializeField] private LoggerData _WindowsEditor;
        [SerializeField] private LoggerData _IPhonePlayer;
        [SerializeField] private LoggerData _PS3;
        [SerializeField] private LoggerData _XBOX360;
        [SerializeField] private LoggerData _Android;
        [SerializeField] private LoggerData _NaCl;
        [SerializeField] private LoggerData _LinuxPlayer;
        [SerializeField] private LoggerData _FlashPlayer;
        [SerializeField] private LoggerData _LinuxEditor;
        [SerializeField] private LoggerData _WebGLPlayer;
        [SerializeField] private LoggerData _MetroWSAPlayerX86;
        [SerializeField] private LoggerData _PlayerX86;
        [SerializeField] private LoggerData _MetroWSAPlayerX64;
        [SerializeField] private LoggerData _MetroWSAPlayerARM;
        [SerializeField] private LoggerData _WP8Player;
        [SerializeField] private LoggerData _BB10BlackBerryPlayer;
        [SerializeField] private LoggerData _TizenPlayer;
        [SerializeField] private LoggerData _PSP2;
        [SerializeField] private LoggerData _PS4;
        [SerializeField] private LoggerData _PSM;
        [SerializeField] private LoggerData _XboxOne;
        [SerializeField] private LoggerData _SamsungTVPlayer;
        [SerializeField] private LoggerData _WiiU;
        [SerializeField] private LoggerData _tvOS;
        [SerializeField] private LoggerData _Switch;
        [SerializeField] private LoggerData _Lumin;
        [SerializeField] private LoggerData _Stadia;
        [SerializeField] private LoggerData _CloudRendering;
        [SerializeField] private LoggerData _GameCoreScarlettXboxSeries;
        [SerializeField] private LoggerData _GameCoreXboxOne;
        [SerializeField] private LoggerData _PS5;

        private LoggerData[] _loggerDatas;
    }
}