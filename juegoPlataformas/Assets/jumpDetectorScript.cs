using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpDetectorScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("ground"))
        {
            transform.parent.GetComponent<playerScript>().CanJump(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("ground"))
        {
            transform.parent.GetComponent<playerScript>().CanJump(false);
        }
    }

}
