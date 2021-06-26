public interface IFactory<T>
{
    T GetNewInstance();
    T CreateSingleton();
}
