using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLimites : MonoBehaviour
{

    // criar os limites onde o player pode passar (n�o sair da tela)
    private float minX, maxX;
    [SerializeField]
    private float minDistance, maxDistance;
    void Start()
    {
        SetMinAndMaxX();
    }

    
    void Update()
    {
        SetPlayerPosition();
    }

    private void SetMinAndMaxX()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.safeArea.width, 0f,0f));
        maxX = bounds.x - maxDistance;
        minX = -bounds.x + minDistance;
    }

    private void SetPlayerPosition()
    {
        if (transform.position.x < minX)
        {
            Vector3 temp = transform.position;
            temp.x = minX;
            transform.position = temp;
        }
        else if (transform.position.x > maxX)
        {
            Vector3 temp = transform.position;
            temp.x = maxX;
            transform.position = temp;
        }
    }
}
