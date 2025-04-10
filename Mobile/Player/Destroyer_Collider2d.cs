using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private GameController gamecontroler;
    private uiController Uicontroler;

    private void Start()
    {
        gamecontroler = FindAnyObjectByType<GameController>();
        Uicontroler = FindAnyObjectByType<uiController>();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            gamecontroler.enemyCount++;
            if (gamecontroler.enemyCount<5)
            {
                Uicontroler.imagensLife[gamecontroler.enemyCount-1].gameObject.SetActive(false);
            }
            else
            {
                Uicontroler.imagensLife[gamecontroler.enemyCount - 1].gameObject.SetActive(false);
                gamecontroler.SaveScore();
                Debug.Log("Game Over!");
                gamecontroler.gameOver();
                
            }
            Destroy(col.gameObject);
        }
    }
}
