using System;
using UnityEngine;

namespace Dankann.Debug
{
    public class DebugSettings : ScriptableObject
    {
        public DebugData LoggerData
        {
            get
            {
                if (_useUniversal)
                {
                    return _universal;
                }

                if (_loggerDatas == null)
                {
                    _loggerDatas = new DebugData[]
                    {
                        _osXEditor,
                        _osXPlayer,
                        _windowsPlayer,
                        _osXWebPlayer,
                        _osXDashboardPlayer,
                        _windowsWebPlayer,
                        null,
                        _windowsEditor,
                        _iPhonePlayer,
                        _ps3,
                        _xbox360,
                        _android,
                        _naCl,
                        _linuxPlayer,
                        null,
                        _flashPlayer,
                        _linuxEditor,
                        _webGLPlayer,
                        _metroWSAPlayerX86,
                        _metroWSAPlayerX64,
                        _metroWSAPlayerARM,
                        _wp8Player,
                        _bb10BlackBerryPlayer,
                        _tizenPlayer,
                        _psp2,
                        _ps4,
                        _psm,
                        _xboxOne,
                        _samsungTVPlayer,
                        null,
                        _wiiU,
                        _tvOS,
                        _switch,
                        _lumin,
                        _stadia,
                        _cloudRendering,
                        _gameCoreScarlettXboxSeries,
                        _gameCoreXboxOne,
                        _ps5,
                    };
                }

                return _loggerDatas[(int)Application.platform];
            }
        }

        [SerializeField] private DebugData _universal;
        [SerializeField] private bool _useUniversal = true;
        [SerializeField] private DebugData _osXEditor;
        [SerializeField] private DebugData _osXPlayer;
        [SerializeField] private DebugData _windowsPlayer;
        [SerializeField] private DebugData _osXWebPlayer;
        [SerializeField] private DebugData _osXDashboardPlayer;
        [SerializeField] private DebugData _windowsWebPlayer;
        [SerializeField] private DebugData _windowsEditor;
        [SerializeField] private DebugData _iPhonePlayer;
        [SerializeField] private DebugData _ps3;
        [SerializeField] private DebugData _xbox360;
        [SerializeField] private DebugData _android;
        [SerializeField] private DebugData _naCl;
        [SerializeField] private DebugData _linuxPlayer;
        [SerializeField] private DebugData _flashPlayer;
        [SerializeField] private DebugData _linuxEditor;
        [SerializeField] private DebugData _webGLPlayer;
        [SerializeField] private DebugData _metroWSAPlayerX86;
        [SerializeField] private DebugData _playerX86;
        [SerializeField] private DebugData _metroWSAPlayerX64;
        [SerializeField] private DebugData _metroWSAPlayerARM;
        [SerializeField] private DebugData _wp8Player;
        [SerializeField] private DebugData _bb10BlackBerryPlayer;
        [SerializeField] private DebugData _tizenPlayer;
        [SerializeField] private DebugData _psp2;
        [SerializeField] private DebugData _ps4;
        [SerializeField] private DebugData _psm;
        [SerializeField] private DebugData _xboxOne;
        [SerializeField] private DebugData _samsungTVPlayer;
        [SerializeField] private DebugData _wiiU;
        [SerializeField] private DebugData _tvOS;
        [SerializeField] private DebugData _switch;
        [SerializeField] private DebugData _lumin;
        [SerializeField] private DebugData _stadia;
        [SerializeField] private DebugData _cloudRendering;
        [SerializeField] private DebugData _gameCoreScarlettXboxSeries;
        [SerializeField] private DebugData _gameCoreXboxOne;
        [SerializeField] private DebugData _ps5;

        private DebugData[] _loggerDatas;
    }
}
