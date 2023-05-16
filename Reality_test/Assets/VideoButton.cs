using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoButton : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject video;
    public Canvas canvas;
    
    public void PlayVideo()
    {
        if (videoPlayer != null )
        {
            video.SetActive(true);
            canvas.gameObject.SetActive(false);
        }
    }
    public void Pause()
    {
        
        RenderTexture.active = null;
    }
    
    
}