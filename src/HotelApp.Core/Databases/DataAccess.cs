using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Core.Databases;

public class DataAccess
{
    private readonly IConfiguration config;
    public DataAccess(IConfiguration config)
    {
        this.config = config;
    }

    public List<T> LoadData<T, U>(string sql, U parameters, Action<DataAccessOptions> options, string connStringName)
    {
        var dataAccessOptions = new DataAccessOptions();
        options.Invoke(dataAccessOptions);

        string? connectionString = config.GetConnectionString(connStringName);
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new ApplicationException("Invalid configuration provided");
        }
        
        using IDbConnection connection = new SqlConnection(connectionString);
        var commandType = CommandType.Text;
        if (dataAccessOptions.IsStoredProcesure == true)
        {
            commandType = CommandType.StoredProcedure;
        }

        List<T> rows = connection.Query<T>(sql, parameters, commandType: commandType).ToList();
        return rows;
    }

    public List<T> LoadData<T, U>(string sql, U parameters, Action<DataAccessOptions> options)
    {
        return LoadData<T, U>(sql, parameters, options, "Default");
    }

    public List<T> LoadData<T, U>(string sql, U parameters)
    {
        return LoadData<T, U>(sql, parameters, x => { x.IsStoredProcesure = false; }, "Default");
    }

    public void SaveData<T>(string sql, T parameters, string connectionString, dynamic options)
    {

    }
}
