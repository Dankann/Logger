using Dankann.Debug;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = Dankann.Debug.Debug;

public class LoggerTest : MonoBehaviour
{
    DebugTag asd;
       // Start is called before the first frame update
       [ContextMenu("Start")]
    void Start()
    {
        //UnityEngine.Debug.LogFormat(UnityEngine.LogType.Log, LogOption.None, this, "asd{0}, asd {1}", asd, name);
        Debug.LogFormat(Dankann.Debug.LogType.Log, LogOption.None, this, "asd{0}, asd {1}", null, name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
