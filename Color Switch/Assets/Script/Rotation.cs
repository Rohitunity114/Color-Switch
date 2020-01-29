using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float Speed = 100f;
   
    void Update()
    {
        transform.Rotate(0f, 0f, Speed * Time.deltaTime);
    }
}
