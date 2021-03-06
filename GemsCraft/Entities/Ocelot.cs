﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GemsCraft.AppSystem.Types;
using GemsCraft.Entities.Metadata;

namespace GemsCraft.Entities
{
    public class Ocelot: TameableAnimal // Meow
    {
        /// <summary>
        /// 0 = untames,
        /// 1 = tuxedo,
        /// 2 = tabby,
        /// 3 = siamese
        /// </summary>
        public EntityMetadata Type = new EntityMetadata(
            15,
            EntityMetadataType.VarInt,
            (VarInt) 0
        );
    }
}
