using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resoorse
{

    [SerializeField] Dictionary<> name = new Dictionary<>();
    static Resoorse() { }

    private Resoorse() { }

    private static readonly Resoorse instance = new Resoorse();

    public static ResoorsBank Instance
    {
        get => instance;
    }




    public void DebugResouse()
    {
        Debug.Log("2");
    }
}
