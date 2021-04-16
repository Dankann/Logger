using System;
using UnityEngine;

namespace Dankann.Logger
{
    public static class Logger
    {
        public static LoggerSettings Settings
        {
            get
            {
                if (!settings)
                    settings = Resources.Load<LoggerSettings>(nameof(LoggerSettings));
                return settings;
            }
        }

        private static LoggerSettings settings;

        public static void LogFormat(LogType logType, LogOption logOptions, UnityEngine.Object context, string format, params UnityEngine.Object[] args)
        {
            if (!settings.LoggerData.LogType.HasFlag(logType))
            {
                return;
            }

            UnityEngine.LogType convertLogType = (UnityEngine.LogType)(int)Mathf.Log((int)logType, 2);

            Debug.LogFormat(convertLogType, logOptions, context, format, args);
        }

        public static void Log(UnityEngine.Object message, UnityEngine.Object context)
        {
            if (!settings.LoggerData.LogType.HasFlag(LogType.Log))
            {
                return;
            }

            Debug.Log(message, context);
        }

        public static void Log(UnityEngine.Object message)
        {
            if (!settings.LoggerData.LogType.HasFlag(LogType.Log))
            {
                return;
            }

            Debug.Log(message);
        }

        public static void LogFormat(UnityEngine.Object context, string format, params UnityEngine.Object[] args)
        {
            if (!settings.LoggerData.LogType.HasFlag(LogType.Log))
            {
                return;
            }

            Debug.LogFormat(context, format, args);
        }

        public static void LogFormat(string format, params UnityEngine.Object[] args)
        {
            if (!settings.LoggerData.LogType.HasFlag(LogType.Log))
            {
                return;
            }

            Debug.LogFormat(format, args);
        }

        public static void LogAssertion(UnityEngine.Object message, UnityEngine.Object context)
        {
            if (!settings.LoggerData.LogType.HasFlag(LogType.Assert))
            {
                return;
            }

            Debug.LogAssertion(message, context);
        }

        public static void LogAssertion(UnityEngine.Object message)
        {
            if (!settings.LoggerData.LogType.HasFlag(LogType.Assert))
            {
                return;
            }

            Debug.LogAssertion(message);
        }

        public static void LogAssertionFormat(UnityEngine.Object context, string format, params UnityEngine.Object[] args)
        {
            if (!settings.LoggerData.LogType.HasFlag(LogType.Assert))
            {
                return;
            }

            Debug.LogAssertionFormat(context, format, args);
        }

        public static void LogAssertionFormat(string format, params UnityEngine.Object[] args)
        {
            if (!settings.LoggerData.LogType.HasFlag(LogType.Assert))
            {
                return;
            }

            Debug.LogAssertionFormat(format, args);
        }

        public static void LogError(UnityEngine.Object message)
        {
            if (!settings.LoggerData.LogType.HasFlag(LogType.Error))
            {
                return;
            }

            Debug.LogError(message);
        }

        public static void LogError(UnityEngine.Object message, UnityEngine.Object context)
        {
            if (!settings.LoggerData.LogType.HasFlag(LogType.Error))
            {
                return;
            }

            Debug.LogError(message, context);
        }

        public static void LogErrorFormat(string format, params UnityEngine.Object[] args)
        {
            if (!settings.LoggerData.LogType.HasFlag(LogType.Error))
            {
                return;
            }

            Debug.LogErrorFormat(format, args);
        }

        public static void LogErrorFormat(UnityEngine.Object context, string format, params UnityEngine.Object[] args)
        {
            if (!settings.LoggerData.LogType.HasFlag(LogType.Error))
            {
                return;
            }

            Debug.LogErrorFormat(context, format, args);
        }

        public static void LogException(Exception exception)
        {
            if (!settings.LoggerData.LogType.HasFlag(LogType.Exception))
            {
                return;
            }

            Debug.LogException(exception);
        }
        
        public static void LogException(Exception exception, UnityEngine.Object context)
        {
            if (!settings.LoggerData.LogType.HasFlag(LogType.Exception))
            {
                return;
            }

            Debug.LogException(exception, context);
        }

        public static void LogWarning(UnityEngine.Object message, UnityEngine.Object context)
        {
            if (!settings.LoggerData.LogType.HasFlag(LogType.Warning))
            {
                return;
            }

            Debug.LogWarning(message, context);
        }
        
        public static void LogWarning(UnityEngine.Object message)
        {
            if (!settings.LoggerData.LogType.HasFlag(LogType.Warning))
            {
                return;
            }

            Debug.LogWarning(message);
        }

        public static void LogWarningFormat(UnityEngine.Object context, string format, params UnityEngine.Object[] args)
        {
            if (!settings.LoggerData.LogType.HasFlag(LogType.Warning))
            {
                return;
            }

            Debug.LogWarningFormat(context, format, args);
        }

        public static void LogWarningFormat(string format, params UnityEngine.Object[] args)
        {
            if (!settings.LoggerData.LogType.HasFlag(LogType.Warning))
            {
                return;
            }

            Debug.LogWarningFormat(format, args);
        }
    }
}