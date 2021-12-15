using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentor
{
    public interface INewPatientView
    {
        string nameText { get; set; }
        string surnameText { get; set; }
        string sexText { get; set; }
        string dateOfBirthText { get; set; }
        
    }
}
