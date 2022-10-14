using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResoorsBank
{
    #region One


    /*
    private static ResoorsBank instance;
   
    public static ResoorsBank Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new ResoorsBank();
            }
            return instance;
        }
    }
    */
    #endregion
    #region Two
    
    static ResoorsBank() { }

    private ResoorsBank() { }

    private static readonly ResoorsBank instance = new ResoorsBank();

    public static ResoorsBank Instance
    {
        get => instance;
    }
    
    #endregion

   
    public void DebugResouse()
    {
        Debug.Log("2");
    }
}