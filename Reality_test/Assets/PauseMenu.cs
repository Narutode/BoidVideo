using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class PauseMenu : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject pausePanel;
    public GameObject Menucanvas;
    public GameObject QCM;
    public VideoPlayer videoPlayer;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                Pause();
            }
        }
        
    }

    public void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
        videoPlayer.Pause();
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
        videoPlayer.Play();
    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
        Menucanvas.SetActive(true);
    }
    
    private void Start()
    {
        videoPlayer.loopPointReached += OnVideoPlayerFinished;
    }

    private void OnDestroy()
    {
        videoPlayer.loopPointReached -= OnVideoPlayerFinished;
    }

    private void OnVideoPlayerFinished(VideoPlayer vp)
    {
        pausePanel.SetActive(false);
        QCM.SetActive(true);
    }
}
