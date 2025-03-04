using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Inimigo: FORMIGA

    // controla a velocidade da formiga e da animação
    public float speed;
    private Animator MyAnimator;

    [SerializeField] private GameObject[] sprites;

    void Start()
    {
        MyAnimator = GetComponent<Animator>();

        sprites[0] = this.transform.GetChild(0).gameObject;
        sprites[1] = this.transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Moviment();
        AnimationSpeed();
    }
    private void Moviment()
    {
        transform.Translate(Vector2.down * (speed * Time.deltaTime));
    }

    private void AnimationSpeed()
    {
        MyAnimator.SetFloat("Speed",speed);
    }

    public void Dead()
    {
        // controlar as imagens (esmagar a formiga)
        speed = 0f;
        sprites[0].gameObject.SetActive(false);
        sprites[1].gameObject.SetActive(true);
        Destroy(this.gameObject, Random.Range(2.5f, 5f));
    }
}
