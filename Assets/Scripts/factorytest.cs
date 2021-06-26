using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factorytest :  MonoBehaviour
{   
    public CubeFactory factory;
    void Start()
    {
        factory.GetNewInstance();
    }
}
