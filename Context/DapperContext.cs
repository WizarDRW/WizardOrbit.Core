using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace WizardOrbit.Core.Context
{
    public class DapperContext : IDisposable
    {
        public static IDbConnection OpenConn(string _conn)
        {
            return new OracleConnection(_conn);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}