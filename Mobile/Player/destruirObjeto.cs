using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruirObjeto : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Destroyer"))
        {
            Destroy(this.gameObject);
        }
    }
}
