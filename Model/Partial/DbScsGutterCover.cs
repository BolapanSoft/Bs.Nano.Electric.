﻿// Ignore Spelling: Scs Cabel

using Nano.Electric.Enums;

namespace Nano.Electric {

    //[XmlRoot("CaeMaterialUtility")]
    public partial class DbScsGutterCover {
#if InitDbContextEnums
        public ScsBoxMeasureUnit? BoxMeasureUnit { get; set; } = ScsBoxMeasureUnit.IN_SEGMENTS; 
#endif

    }
}
