using System;
using Conceitos_POO.NotificationContext;

namespace Conceitos_POO.ShareContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }

}