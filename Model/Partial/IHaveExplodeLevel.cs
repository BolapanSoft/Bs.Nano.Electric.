﻿using Nano.Electric.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano.Electric {
    public interface IHaveExplodeLevel {
        /// <summary>
        /// Наличие взрывозащиты
        /// </summary>
        public EnvExplSafeBoolEnum? IsExplSafe { get; set; }
        /// <summary>
        /// Id ExplodeSafeLevel
        /// </summary>
        public int? ExplodeLevel { get; set; }
    }
    public interface IHaveSafeDegree {
        public int? DbSafeDegree { get; set; }
    }
    public interface IHaveDbClimate {
        public int? DbClimate { get; set; }
    }
}
