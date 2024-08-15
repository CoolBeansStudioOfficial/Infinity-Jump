using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject canvas;
    public GameObject platform;
    public GameObject player;

    GameObject currentPlatform;
    public float deathHeight = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartGame()
    {
        canvas.SetActive(false);
        currentPlatform = Instantiate(platform);
    }

    public void GeneratePlatform()
    {
        currentPlatform = Instantiate(platform, currentPlatform.transform.position + new Vector3(Random.Range(-8, 9), Random.Range(3, 5), 0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (deathHeight != 0)
        {
            if (player.transform.position.y < deathHeight)
            {
                GameObject cam = GameObject.Find("Main Camera");
                cam.transform.parent = null;

                Invoke("Reset", 1f);
            }
        }
    }

    void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
