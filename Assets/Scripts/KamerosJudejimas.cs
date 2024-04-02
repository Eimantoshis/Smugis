using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamerosJudejimas : MonoBehaviour
{
    public Transform ziuretiKur;
    public float ribosX = 0.15f;
    public float ribosY = 0.15f;
    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;
        float deltaX = ziuretiKur.position.x - transform.position.x;
        if (deltaX > ribosX || deltaX < -ribosX)
        {
            if (transform.position.x < ziuretiKur.position.x)
            {
                delta.x = deltaX - ribosX;
            }
            else
            {
                delta.x = deltaX + ribosX;
            }
        }
     
    float deltaY = ziuretiKur.position.y - transform.position.y;
        if (deltaY > ribosY || deltaY < -ribosY)
        {
            if (transform.position.y < ziuretiKur.position.y)
            {
                delta.y = deltaY - ribosY;
            }
            else
{
    delta.y = deltaY + ribosY;
}
        }
        transform.position+=new Vector3(delta.x, delta.y, 0);
    }
}
