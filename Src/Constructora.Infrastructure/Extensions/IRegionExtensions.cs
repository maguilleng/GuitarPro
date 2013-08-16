using System;
using Microsoft.Practices.Prism.Regions;

namespace Constructora.Infrastructure
{
    public static class IRegionExtensions
    {
        public static void ClearActiveViews(this IRegion region)
        {
            foreach (var v in region.ActiveViews)
            {
                region.Deactivate(v);
            }
        }
    }
}
