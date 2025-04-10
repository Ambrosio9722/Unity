using UnityEngine;

public class spawner : MonoBehaviour
{
    private float minX, maxX, nextSpawn;

    [SerializeField] private float minDistance, maxDistance, spawTime;
    [SerializeField] private GameObject[] enemies;

    private GameController gameControler;

    void Start()
    {
        nextSpawn = Time.time;
        SetminAndMaxX();

        gameControler = FindAnyObjectByType<GameController>();
    }

    
    void Update()
    {
        if (gameControler.jogoComecou == true)
        {
           Spawn(); 
        }
        else
        {
            print("Não");
        }
       
    }

    private void SetminAndMaxX()
    {
        Vector3 bound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.safeArea.width, 0f, 0f));
        minX = -bound.x + minDistance;
        maxX = bound.x + maxDistance;
    }

    private void Spawn()
    {
        if (Time.time > nextSpawn && gameControler.jogoComecou == true)
        {
            Vector2 position = new Vector2(Random.Range(minX,maxX), transform.position.y);
           GameObject tempEnemy =  Instantiate(enemies[Random.Range(0, enemies.Length)], new Vector2(position.x, position.y), Quaternion.Euler(0f, 0f,0f));
            tempEnemy.transform.parent = gameControler.allEnemiesParents;
            nextSpawn = Time.time + spawTime;
        }
    }
}
