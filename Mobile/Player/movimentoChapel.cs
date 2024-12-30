using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoChapel : MonoBehaviour
{

    // MOVER O CHAPEL COM O TOQUE NA TELA 
    [SerializeField]
    private float speed;


    
    void Update()
    {
        DragTouch();
    }

    private void DragTouch()
    {
        // Input.touchCount (toques na tela)
        if (Input.touchCount > 0  && Input.GetTouch(0).phase == TouchPhase.Moved )
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(touchDeltaPosition.x * speed *Time.deltaTime, 0f,0f);
        }
    }
}
