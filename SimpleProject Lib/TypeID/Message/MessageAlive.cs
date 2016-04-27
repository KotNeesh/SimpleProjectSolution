﻿using System;


namespace SimpleProject
{
    using TypeID = Byte;
    public sealed class MessageAlive : MessageBase
    {
        public override TypeID Type
        {
            get
            {
                return (TypeID)HelperTypeID.Alive;
            }
        }
    };
}
