using System.Data;

namespace ApiTarefas2.Data
{
    public class TarefasContext
    {
        public delegate Task<IDbConnection> GetConnection();
    }
}
