using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LazySinglefloat : MonoBehaviour
{
    private static readonly Lazy<LazySinglefloat> instance =
        new Lazy<LazySinglefloat>(() => new LazySinglefloat());

    public static LazySinglefloat Instance => instance.Value;


    public float FloatValue { get; set; } 

    private LazySinglefloat() { }
}
