using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingolTonComponent : MonoBehaviour
{
    public static SingolTonComponent Instance
    {
        get;
        private set;
    }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }
        Destroy(gameObject);
    }

    public void DebugSinglTomComonrnt()
    {
        Debug.Log("");
    }
}
