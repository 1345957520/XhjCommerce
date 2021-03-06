﻿using Chj.Web.Framework.Mvc;

namespace Chj.Web.Models.Catalog
{
    public partial class ProductSpecificationModel : BaseNopModel
    {
        public int SpecificationAttributeId { get; set; }

        public string SpecificationAttributeName { get; set; }

        public string SpecificationAttributeOption { get; set; }

        //this value is already HTML encoded
        public string ValueRaw { get; set; }
    }
}