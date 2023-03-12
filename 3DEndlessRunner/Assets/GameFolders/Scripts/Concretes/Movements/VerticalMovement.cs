using EndlessRunner.Abstracts.Controllers;
using EndlessRunner.Abstracts.Movements;
using UnityEngine;

namespace EndlessRunner.Movements
{
    public class VerticalMovement : IMover
    {
        IEntityController _entityController;

        public VerticalMovement(IEntityController entityController)
        {
            _entityController = entityController;
        }

        public void FixedTick(float vertical = 1)
        {
            _entityController.transform.Translate(Vector3.back *
                                                  (vertical * _entityController.MoveSpeed * Time.deltaTime));
        }
    }
}


