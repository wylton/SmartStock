using System;

namespace SmartMvc.SharedKernel.Events.Contracts
{
    public interface IDomainEvent
    {
        DateTime DateOccurred { get; }
    }
}
