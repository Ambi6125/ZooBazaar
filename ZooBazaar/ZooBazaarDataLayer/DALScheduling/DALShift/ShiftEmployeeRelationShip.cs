using EasyTools.MySqlDatabaseTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarDataLayer.DALScheduling.DALShift
{
    public class ShiftEmployeeRelationShip : IDataProvider
    {
        private readonly int _employeeId;
        private readonly int _shiftId;

        public int EmployeeId => _employeeId;
        public int ShiftId => _shiftId;

        public ShiftEmployeeRelationShip(int employeeId, int shiftId)
        {
            _employeeId = employeeId;
            _shiftId = shiftId;
        }

        public IParameterValueCollection GetParameterArgs()
        {
            var args = new ParameterValueCollection
            {
                { "shiftId", _shiftId },
                { "employeeId", _employeeId }
            };

            return args;
        }
    }
}
