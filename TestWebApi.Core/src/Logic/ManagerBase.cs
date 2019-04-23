using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebApi.Core.Logic
{
    public abstract class ManagerBase
    {
        protected IMapper ManagerMapper { get; }

        protected ManagerBase(IMapper mapper)
        {
            ManagerMapper = mapper;
        }
    }
}
