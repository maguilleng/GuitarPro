﻿using System;
using System.Net;
using System.ComponentModel.Composition;

namespace Constructora.Infrastructure
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    [MetadataAttribute]
    public class ViewExportAttribute : ExportAttribute, IViewRegionRegistration
    {
        public ViewExportAttribute()
            : base(typeof(object))
        { }

        public ViewExportAttribute(string viewName)
            : base(viewName, typeof(object))
        { }

        public string RegionName { get; set; }

        private bool isActiveByDefault = true;
        public bool IsActiveByDefault
        {
            get
            {
                return this.isActiveByDefault;
            }
            set
            {
                this.isActiveByDefault = value;
            }
        }
    }
}
