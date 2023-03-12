using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EndlessRunner.Abstracts.Movements
{
    public interface IMover
    {
        void FixedTick(float direction);
    }
}


