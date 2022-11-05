using TMPro;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public Rigidbody2D target;
    private float[] targetSize = {0,0};

    private float randomPosX;
    private float randomPosY;
    private float minX, maxX, minY, maxY;

    private float spawnCountDown = 0;
    private const float waitTime = 2f;

    private float timerCountDown = 10f;
    private bool gameOver = false;

    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;


    private int score = 0;

    private void Start()
    {
        target = GetComponent<Rigidbody2D>();
      
        targetSize[0] = target.GetComponent<Renderer>().bounds.size.x;
        targetSize[1] = target.GetComponent<Renderer>().bounds.size.y;       
        SetMinAndMax();

        PlayerPrefs.SetInt("highScore", 0);

    }

    // Update is called once per frame
    void Update()
    {

        if (gameOver) return;

        if (spawnCountDown > 0)
        {
            spawnCountDown -= Time.deltaTime;
        }
        else
        {
            randomPosX = Random.Range(minX, maxX);
            randomPosY = Random.Range(minY, maxY);

            target.position = new Vector3(randomPosX, randomPosY, 0);
            spawnCountDown = waitTime;
        }

        timerCountDown -= Time.deltaTime;
        timerText.text = ((int)timerCountDown).ToString();
        if (timerCountDown < 0)
        {
            if (score > PlayerPrefs.GetInt("highScore", 0))
                PlayerPrefs.SetInt("highScore", score);

            highScoreText.text = "HI: " + PlayerPrefs.GetInt("highScore", 0).ToString();
            gameOver = true;

        }

    }
    private void OnMouseDown()
    {
        if (gameOver) return;

        score += 10;
        scoreText.text = "Score: " + score.ToString();
        spawnCountDown = 0f;
    }

    private void SetMinAndMax()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        minX = -bounds.x + targetSize[0] / 2f;
        maxX =  bounds.x - targetSize[0] / 2f;
        minY = -bounds.y + targetSize[1] / 2f;
        maxY =  bounds.y - targetSize[1] / 2f;
    }


   

}
