using System;

namespace Constructora.Infrastructure
{
    public interface IViewRegionRegistration
    {
        string RegionName { get; }
        bool IsActiveByDefault { get; }
    }
}
