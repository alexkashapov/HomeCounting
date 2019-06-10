using HomeCounting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCounting.Repository
{
    class OperationRepository
    {
        private static List<Operation> operations = new List<Operation>();
        
        public static void addOperation(Operation operation)
        {
            operations.Add(operation);
        }

        public static void removeOperation(int index)
        {
            operations.RemoveAt(index);
        }

        public static void editOperation(Operation operation)
        {

        }

        public static List<Operation> getOperationByAccountName(String name)
        {
            List<Operation> result = new List<Operation>();
            operations.ForEach(op => { if (op.From.Equals(name)) result.Add(op); });
            return result;
        }
    }
}
