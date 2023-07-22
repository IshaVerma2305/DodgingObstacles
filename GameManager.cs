
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gamehasended =  false;
    public float restartDelay = 1f;
public GameObject completeLevelUI;
public void CompleteLevel()
{
  // Debug.Log("LEVEL WON");
  completeLevelUI.SetActive(true);
 // Invoke("Restart", restartDelay);
}

   public void EndGame()
   {
    if(gamehasended == false)
    {
    gamehasended = true;
    Debug.Log("GAME OVER");
    Invoke("Restart", restartDelay);
    }
   }
   void Restart()
   {
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
