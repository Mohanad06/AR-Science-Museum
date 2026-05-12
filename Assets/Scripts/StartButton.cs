using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void OnStartPressed()
    {
        SceneManager.LoadScene("ARScene");
        Debug.Log("Start button pressed, loading ARScene...");
    }
}