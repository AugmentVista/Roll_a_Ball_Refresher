using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    public int count;
    public int ActiveAmmoType;
    public int ActiveAmmoCount;


    private void Start()
    {
         ActiveAmmoCount = 0;
    }
}