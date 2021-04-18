using UnityEngine;

namespace Dankann.Debug
{
    [CreateAssetMenu(fileName = "Debug Data", menuName = "Dankann/Debug/Data")]
    public class DebugData : ScriptableObject
    {
        public LogType LogType => _logType;
        public bool InternalLog => _internalLog;
        public DebugTag[] DebugTags => _debugTags;

        [SerializeField] private LogType _logType;
        [SerializeField] private bool _internalLog;
        [SerializeField] private DebugTag[] _debugTags;
    }
}
