using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EndlessRunner.Abstracts.Inputs
{
    public interface IInputReader
    {
        float Horizontal { get; }
        bool IsJump { get; }
    }
}


