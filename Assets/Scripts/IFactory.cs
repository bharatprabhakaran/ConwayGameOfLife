using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFactory : MonoBehaviour
{
   public virtual MonoBehaviour GetNewInstance(MonoBehaviour gameObjectInstance)
   {
       return  Instantiate( gameObjectInstance );
   }

   public virtual MonoBehaviour GetNewInstance(MonoBehaviour gameObjectInstance,Vector3 position, Quaternion rotation)
   {
       return  Instantiate( gameObjectInstance, position,  rotation );
   }
}
