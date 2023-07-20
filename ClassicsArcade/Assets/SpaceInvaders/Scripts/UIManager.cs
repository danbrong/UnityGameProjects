using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private TextMeshProUGUI ScoreText;
    

    private int scoreBoard = -1;
    private int playerLife = 6;
    bool playonce = true;



    private void Awake()
    {
        ScoreText = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        PlayerScoreing();
        PlayerLife();
        Score();
        
        
    }
    private void Update()
    {
        GameOver();
        
    }


    public void PlayerScoreing()
    {
        if(this.gameObject.name == "Score")
        {
            scoreBoard++;
            ScoreText.text = "Score: " + scoreBoard;
        }
    }

    public void PlayerLife()
    {
        if (this.gameObject.name == "Lifes")
        {
            playerLife--;
            ScoreText.text = "Lives: " + playerLife;
        }
    }

    void Score()
    {
        UIManager score = GameObject.Find("Score").GetComponent<UIManager>();

        if (score.gameObject.name == "ScoreText")
        {
            ScoreText.text = "Score:" + score;
        }
    }

 
    public void GameOver()
    {
        if (playerLife == 0)
        {
            // Referencing the Object 
            SpaceInvaders_SpawnManager Spawning = GameObject.Find("SpawnManager").GetComponent<SpaceInvaders_SpawnManager>();
            GameObject Enemy = GameObject.FindGameObjectWithTag("Obstacle");
            SpaceInvaders_Player Player = GameObject.Find("Player").GetComponent<SpaceInvaders_Player>();
            SceneLoader LoadScene = GameObject.Find("SceneLoader").GetComponent<SceneLoader>();

            // Destory Enemy GameObjects
            Destroy(Enemy);
            // stop player
            Player.transform.position = new Vector3(0f, -4f, 0);
            if (playonce)
            {
                // stop enemy spawning 
                Spawning.spawning = false;
                // stop firing 
                Player.fire = false;
                // Play Lose Sound
                SpaceInvaders_AudioManager.Instance.DisableMusic();
                SpaceInvaders_AudioManager.Instance.PlayLose();
                // Load Credit scene
                LoadScene.LoadSceneName("SpaceInvaders_CreditScene");
                playonce = false;
            }
        }
    }


}
