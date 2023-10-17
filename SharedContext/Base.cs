using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balta.NotificationContext;

namespace Balta.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid(); //SPOF (Single Point Of Fail)
        }
        public Guid Id { get; set; }
    }
}