using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EndlessRunner.Abstracts.Controllers
{
    public abstract class MyCharacterController : MonoBehaviour
    {
         private float moveBoundary = 4.5f;
         private float moveSpeed = 10f;
         
         public float MoveSpeed => moveSpeed;
         public float MoveBoundary => moveBoundary;
    }    
}


