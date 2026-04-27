using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public static Color SelectedColor = Color.white;
    public void ChooseRed() { SelectedColor = Color.red; }
    public void ChooseBlue() { SelectedColor = Color.blue; }
    public void ChooseGreen() { SelectedColor = Color.green; }
    public void PlayLabirint()
    {
        SceneManager.LoadScene("LabirintGame"); 
    }
    public void Restart()
    {
        SceneManager.LoadScene("LabirintGame");
    }
    public void PlayMinigame()
    {
        SceneManager.LoadScene("MiniGame"); 
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}