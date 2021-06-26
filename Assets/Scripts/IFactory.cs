using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFactory : MonoBehaviour
{
   public virtual MonoBehaviour GetNewInstance(MonoBehaviour gameObjectInstance)
   {
       return  Instantiate(gameObjectInstance);
   }
}
