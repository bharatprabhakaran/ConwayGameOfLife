using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFactory : AbstractFactory<CubeObject>
{
    public override Object GetNewInstance(  )
    {
       return base.GetNewInstance();
    }
}
