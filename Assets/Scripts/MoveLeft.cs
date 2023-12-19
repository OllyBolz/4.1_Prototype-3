using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private Rigidbody thisRb;

    private float speed = 5000f;

    public bool isBarrel = false;
    private float barrelSpin;

    void Update() //I changed some things to get rolling barrels :)
    {
        if (transform.position.x < -20f)
        {
            Destroy(gameObject);
            return;
        }
        if (thisRb != null)
        {
            if (isBarrel)
            {
                barrelSpin += -90f * Time.deltaTime;
                thisRb.velocity = Vector3.left * Time.deltaTime * speed * 1.5f;
                thisRb.rotation = Quaternion.Euler(barrelSpin, 90f, 90f);
                return;
            }
            else
            {
                thisRb.velocity = Vector3.left * Time.deltaTime * speed;
                return;
            }
        }
        else
        {
            thisRb = GetComponent<Rigidbody>();
        }
    }
}
