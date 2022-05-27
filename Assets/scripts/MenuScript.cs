using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public bool isFullscreen = false; //Полноэкранный режим
    public Slider slider;
    public Text valueCount;
    public Toggle toggle;
    public void PlayPressed()
    {
        SceneManager.LoadScene("Game");
    }
    private void Start()
    {
        Screen.fullScreen = true;
        toggle.isOn = false;
    }
    public void Update()
    {
        valueCount.text = slider.value.ToString();
        AudioListener.volume = slider.value;
    }
    public void ScreenMode()
    {
        Screen.fullScreen = !toggle.isOn;
    }
    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }
}