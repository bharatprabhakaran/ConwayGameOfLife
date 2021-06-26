public interface IFactory 
{
    UnityEngine.Object GetNewInstance();
    System.Object CreateSingleton();
}
