using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppV3MySqlIntegration.Models
{
    public interface ITodoRepository
    {
        void AddTodoItem(string todo);
        void RemoveTodoItem(int id);
        List<string> GetTodoItems();
    }
}
