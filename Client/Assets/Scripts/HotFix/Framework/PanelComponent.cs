﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotFix
{
    public interface IPanelEntity
    {

    }

    public class PanelComponent : BaseComponent<IPanelEntity>
    {
        public override void InitComponent()
        {
            
        }
    }
}