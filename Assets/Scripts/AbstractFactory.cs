using System;
using UnityEngine;
using Object = UnityEngine.Object;


public abstract class AbstractFactory<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField]
    public T prefab;
    public System.Object Instance => LazyInstance.Value;
    public readonly Lazy<System.Object> LazyInstance = new Lazy<System.Object>(CreateSingleton);

    public virtual T GetNewInstance()
    {
        return Instantiate(prefab);
    }

    public virtual T GetNewInstance(Vector3 position, Quaternion rotation)
    {
        return Instantiate(prefab, position, rotation);
    }


    public static System.Object CreateSingleton()
    {
        var instance = Activator.CreateInstance((typeof(T)));
        return instance;
    }
}
