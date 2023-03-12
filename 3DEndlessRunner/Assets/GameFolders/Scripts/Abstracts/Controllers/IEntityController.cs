using UnityEngine;

namespace EndlessRunner.Abstracts.Controllers
{
    public interface IEntityController
    {
        Transform Transform { get; }
        float MoveSpeed { get; }
        float MoveBoundary { get; }
    }
}


