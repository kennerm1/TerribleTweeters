using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] string _nextLevelName;

    public void StartGame()
    {
        SceneManager.LoadScene(_nextLevelName);
    }
}
