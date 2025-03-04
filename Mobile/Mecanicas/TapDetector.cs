using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapDetector : MonoBehaviour
{
   
    private bool tapControl;

    private enemy Enemy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DatectTabe();
        Enemy = GetComponent<enemy>();
    }

    private void DatectTabe()
    {
        // touchCount = quantos toques na tela 
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint((Input.GetTouch(0).position)), Vector2.zero);

            if(hit.collider != null)
            {
                TapObject(hit);
                tapControl = false;
            }
        }
    }

    private void TapObject(RaycastHit2D hit)
    {
        if (hit.collider.gameObject.CompareTag("Enemy") && !tapControl)
        {
            hit.collider.gameObject.GetComponent<enemy>().Dead();
            tapControl = true;
            Debug.Log(hit.transform.name); 
        }
    }
}
