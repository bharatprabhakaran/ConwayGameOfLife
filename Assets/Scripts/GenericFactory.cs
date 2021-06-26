using System.ComponentModel;
using System;
using UnityEngine;

/// <summary>
/// Factory design pattern ;
/// </summary>
public class GenericFactory : IFactory
{
    // Reference to prefab of whatever type.
    [SerializeField]
    private MonoBehaviour prefab;

    /// <summary>
    /// Creating new instance of prefab.
    /// </summary>
    /// <returns>New instance of prefab.</returns>

    public override MonoBehaviour GetNewInstance(MonoBehaviour gameObjectInstance)
    {
       return base.GetNewInstance(gameObjectInstance);
    }

    /// <summary>
    /// Creating new instance of prefab at specified rotation and position by overloading
    /// </summary>
    /// <returns>New instance of prefab.</returns>


    public override MonoBehaviour GetNewInstance(MonoBehaviour gameObjectInstance,Vector3 position, Quaternion rotation)
    {
        return base.GetNewInstance(gameObjectInstance);
    }

    /// <summary>
    /// Creating new instance of class at specified like an instance factory
    /// useful for creating instances by lazy intialization , useful for threadsafe applications
    /// and creating instances of networked objects
    /// </summary>
    /// <returns> New instance of type .</returns>

   

    public System.Object Instance => LazyInstance.Value;

    private  readonly Lazy<System.Object> LazyInstance = new Lazy<System.Object>(CreateSingleton);

    private static System.Object CreateSingleton()
    {

        var instance = Activator.CreateInstance( (typeof(System.Object) ));
        return instance;
    }
}