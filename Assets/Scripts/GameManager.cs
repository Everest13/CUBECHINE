using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    //Level is success completed
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    //Restart game if game is over
    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            //Debug.Log("Game over");
            Invoke("Restart", 2f);
        }
    }

    //Load current scene for begin
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
