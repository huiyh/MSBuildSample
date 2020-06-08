using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTask
{
    public interface ITask
    {
        IBuildEngine BuildEngine { get; set; }
        ITaskHost HostObject { get; set; }
        bool Execute();
    }
}
