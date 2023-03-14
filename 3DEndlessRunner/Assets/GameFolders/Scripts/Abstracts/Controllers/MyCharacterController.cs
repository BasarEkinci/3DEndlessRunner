using UnityEngine;

namespace EndlessRunner.Abstracts.Controllers
{
    public abstract class MyCharacterController : MonoBehaviour
    {
         public float moveBoundary = 4.5f;
         public float moveSpeed = 10f;
         
         public float MoveSpeed => moveSpeed;
         public float MoveBoundary => moveBoundary;
    }    
}


