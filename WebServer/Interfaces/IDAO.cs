namespace WebServer.Models;

public interface IDAO<T>
{
    void Insert(T t);
    
    //void Update(T t, strig newPassword);

    void Delete(T t);

    List<T> GetAll;

    T GetById(int id);
}