using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EndlessRunner.Abstracts.Movements
{
    public interface IJump
    {
        void FixedTick(float jumpForce);
    }    
}

