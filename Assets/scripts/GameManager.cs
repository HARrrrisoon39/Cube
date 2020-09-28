using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    // Start is called before the first frame update
    public GameObject CompleteLevelUI;

    public void CompleteLevel(){
        // Debug.Log("end the game");
        CompleteLevelUI.SetActive(true);

    }
    
    public void EndGame () {

        // Debug.Log ("ended");
        Invoke ("Restart", 7f);
        Restart ();
    }
    void Restart () {

        SceneManager.LoadScene (SceneManager.GetActiveScene ().name);

    }
}