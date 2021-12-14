using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    private void SetValue() 
    {
        LazySinglefloat.Instance.FloatValue = 42f;
    }

    private void PrintValue() 
    {
        Debug.Log(LazySinglefloat.Instance.FloatValue.ToString());
    }



    // Start is called before the first frame update
    void Awake()
    {
        SetValue();
        PrintValue();
    }
}
