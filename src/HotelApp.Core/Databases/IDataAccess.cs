
namespace HotelApp.Core.Databases;

public interface IDataAccess
{
    List<T> LoadData<T, U>(string sql, U parameters);
    List<T> LoadData<T, U>(string sql, U parameters, Action<DataAccessOptions> options);
    List<T> LoadData<T, U>(string sql, U parameters, Action<DataAccessOptions> options, string connStringName);
    void SaveData<T>(string sql, T parameters);
    void SaveData<T>(string sql, T parameters, Action<DataAccessOptions> options);
    void SaveData<T>(string sql, T parameters, Action<DataAccessOptions> options, string connStringName);
}