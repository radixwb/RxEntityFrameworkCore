using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rx.EntityFrameworkCore.Attributes
{
    [AttributeUsage(AttributeTargets.Parameter)]
    internal sealed class NotNullAttribute : Attribute
    {
    }
}
