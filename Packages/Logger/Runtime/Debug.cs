using System;
using System.Linq;
using UnityEngine;

namespace Dankann.Debug
{
    public static class Debug
    {
        public static DebugSettings Settings
        {
            get
            {
                if (!_settings)
                {
                    _settings = Resources.Load<DebugSettings>(nameof(DebugSettings));
                }

                return _settings;
            }
        }

        private static DebugSettings _settings;

        public static void LogFormat(LogType logType, LogOption logOptions, UnityEngine.Object context, string format, DebugTag debugTag = null, params object[] args)
        {
            if (debugTag != null && !HasTag(debugTag))
            {
                return;
            }

            if (!Settings.LoggerData.LogType.HasFlag(logType))
            {
                return;
            }

            UnityEngine.LogType convertLogType = (UnityEngine.LogType)(int)Mathf.Log((int)logType, 2);

            UnityEngine.Debug.LogFormat(convertLogType, logOptions, context, format, args);
        }

        public static void Log(object message, UnityEngine.Object context, DebugTag debugTag = null)
        {
            if (debugTag != null && !HasTag(debugTag))
            {
                return;
            }

            if (!Settings.LoggerData.LogType.HasFlag(LogType.Log))
            {
                return;
            }

            UnityEngine.Debug.Log(message, context);
        }

        public static void Log(object message, DebugTag debugTag = null)
        {
            if (!Settings.LoggerData.LogType.HasFlag(LogType.Log))
            {
                return;
            }

            UnityEngine.Debug.Log(message);
        }

        public static void LogFormat(UnityEngine.Object context, string format, DebugTag debugTag = null, params object[] args)
        {
            if (debugTag != null && !HasTag(debugTag))
            {
                return;
            }

            if (!Settings.LoggerData.LogType.HasFlag(LogType.Log))
            {
                return;
            }

            UnityEngine.Debug.LogFormat(context, format, args);
        }

        public static void LogFormat(string format, DebugTag debugTag = null, params object[] args)
        {
            if (debugTag != null && !HasTag(debugTag))
            {
                return;
            }

            if (!Settings.LoggerData.LogType.HasFlag(LogType.Log))
            {
                return;
            }

            UnityEngine.Debug.LogFormat(format, args);
        }

        public static void LogAssertion(object message, UnityEngine.Object context, DebugTag debugTag = null)
        {
            if (debugTag != null && !HasTag(debugTag))
            {
                return;
            }

            if (!Settings.LoggerData.LogType.HasFlag(LogType.Assert))
            {
                return;
            }

            UnityEngine.Debug.LogAssertion(message, context);
        }

        public static void LogAssertion(object message, DebugTag debugTag = null)
        {
            if (debugTag != null && !HasTag(debugTag))
            {
                return;
            }

            if (!Settings.LoggerData.LogType.HasFlag(LogType.Assert))
            {
                return;
            }

            UnityEngine.Debug.LogAssertion(message);
        }

        public static void LogAssertionFormat(UnityEngine.Object context, string format, DebugTag debugTag = null, params object[] args)
        {
            if (debugTag != null && !HasTag(debugTag))
            {
                return;
            }

            if (!Settings.LoggerData.LogType.HasFlag(LogType.Assert))
            {
                return;
            }

            UnityEngine.Debug.LogAssertionFormat(context, format, args);
        }

        public static void LogAssertionFormat(string format, DebugTag debugTag = null, params object[] args)
        {
            if (debugTag != null && !HasTag(debugTag))
            {
                return;
            }

            if (!Settings.LoggerData.LogType.HasFlag(LogType.Assert))
            {
                return;
            }

            UnityEngine.Debug.LogAssertionFormat(format, args);
        }

        public static void LogError(object message, DebugTag debugTag = null)
        {
            if (debugTag != null && !HasTag(debugTag))
            {
                return;
            }

            if (!Settings.LoggerData.LogType.HasFlag(LogType.Error))
            {
                return;
            }

            UnityEngine.Debug.LogError(message);
        }

        public static void LogError(object message, UnityEngine.Object context, DebugTag debugTag = null)
        {
            if (debugTag != null && !HasTag(debugTag))
            {
                return;
            }

            if (!Settings.LoggerData.LogType.HasFlag(LogType.Error))
            {
                return;
            }

            UnityEngine.Debug.LogError(message, context);
        }

        public static void LogErrorFormat(string format, DebugTag debugTag = null, params object[] args)
        {
            if (debugTag != null && !HasTag(debugTag))
            {
                return;
            }

            if (!Settings.LoggerData.LogType.HasFlag(LogType.Error))
            {
                return;
            }

            UnityEngine.Debug.LogErrorFormat(format, args);
        }

        public static void LogErrorFormat(UnityEngine.Object context, string format, DebugTag debugTag = null, params object[] args)
        {
            if (debugTag != null && !HasTag(debugTag))
            {
                return;
            }

            if (!Settings.LoggerData.LogType.HasFlag(LogType.Error))
            {
                return;
            }

            UnityEngine.Debug.LogErrorFormat(context, format, args);
        }

        public static void LogException(Exception exception, DebugTag debugTag = null)
        {
            if (debugTag != null && !HasTag(debugTag))
            {
                return;
            }

            if (!Settings.LoggerData.LogType.HasFlag(LogType.Exception))
            {
                return;
            }

            UnityEngine.Debug.LogException(exception);
        }
        
        public static void LogException(Exception exception, UnityEngine.Object context, DebugTag debugTag = null)
        {
            if (debugTag != null && !HasTag(debugTag))
            {
                return;
            }

            if (!Settings.LoggerData.LogType.HasFlag(LogType.Exception))
            {
                return;
            }

            UnityEngine.Debug.LogException(exception, context);
        }

        public static void LogWarning(object message, UnityEngine.Object context, DebugTag debugTag = null)
        {
            if (debugTag != null && !HasTag(debugTag))
            {
                return;
            }

            if (!Settings.LoggerData.LogType.HasFlag(LogType.Warning))
            {
                return;
            }

            UnityEngine.Debug.LogWarning(message, context);
        }
        
        public static void LogWarning(object message, DebugTag debugTag = null)
        {
            if (debugTag != null && !HasTag(debugTag))
            {
                return;
            }

            if (!Settings.LoggerData.LogType.HasFlag(LogType.Warning))
            {
                return;
            }

            UnityEngine.Debug.LogWarning(message);
        }

        public static void LogWarningFormat(UnityEngine.Object context, string format, DebugTag debugTag = null, params object[] args)
        {
            if (debugTag != null && !HasTag(debugTag))
            {
                return;
            }

            if (!Settings.LoggerData.LogType.HasFlag(LogType.Warning))
            {
                return;
            }

            UnityEngine.Debug.LogWarningFormat(context, format, args);
        }

        public static void LogWarningFormat(string format, DebugTag debugTag = null, params object[] args)
        {
            if (debugTag != null && !HasTag(debugTag))
            {
                return;
            }

            if (!Settings.LoggerData.LogType.HasFlag(LogType.Warning))
            {
                return;
            }

            UnityEngine.Debug.LogWarningFormat(format, args);
        }

        private static bool HasTag(DebugTag debugTag)
        {
            return Settings.LoggerData.DebugTags.Contains(debugTag);
        }
    }
}
