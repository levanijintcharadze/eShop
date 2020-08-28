using System;
using System.Collections.Generic;
using System.Transactions;
using MediatR;

namespace Domain
{
    public interface IDomainEvent : INotification
    {
        DateTime CreatedAt { get; }
    }

    public interface IDomainEventContext
    {
        IEnumerable<BaseDomain> GetDomainEvents();
    }

    public abstract class BaseDomain : IDomainEvent
    {
        public DateTime CreatedAt { get; }
    }
}
