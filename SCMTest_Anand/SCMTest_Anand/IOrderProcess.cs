using System;
using System.Collections.Generic;
using System.Text;

namespace SCMTest_Anand
{
    public interface IOrderProcess <T>
    {
        List<T> ValidateRules(List<string> OrderPaymentTypes);
    }
}
