using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppV3withDatabaseIntegration.Models
{
    public interface ITodoStorage
    {
        void Add(Todo todo);
        List<Todo> GetAll();
    }
}
