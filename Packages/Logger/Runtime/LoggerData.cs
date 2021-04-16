using UnityEngine;

namespace Dankann.Logger
{
    [CreateAssetMenu(fileName = "Logger Data", menuName = "Logger/Data")]
    public class LoggerData : ScriptableObject
    {
        [SerializeField] private LogType _logType;
        [SerializeField] private bool _internalLog;

        public LogType LogType => _logType;
        public bool InternalLog => _internalLog;
    }
}