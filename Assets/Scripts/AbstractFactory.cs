using System;
using UnityEngine;
using Object = UnityEngine.Object;


public abstract class AbstractFactory <T>: MonoBehaviour where T : Object 
{
    [SerializeField]
    public T prefab;
    public  System.Object Instance => LazyInstance.Value;
    public  readonly Lazy<System.Object> LazyInstance = new Lazy<System.Object>(CreateSingleton);

    public virtual Object GetNewInstance()
    {
       return  Instantiate( prefab );
    }

    public virtual Object GetNewInstance( Vector3 position, Quaternion rotation ) 
    {
       return  Instantiate( prefab, position,  rotation );
    }

    public static System.Object CreateSingleton()
    {
        var instance = Activator.CreateInstance( (typeof(T)) );
        return instance;
    }
}
