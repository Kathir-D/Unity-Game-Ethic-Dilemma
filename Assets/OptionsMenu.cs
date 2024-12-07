using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
   public AudioMixer audioMixer;
   public void SetVolume(float volume)
   {
      audioMixer.SetFloat("volume", volume);
   }
   public void setFullScreen(bool isFullScreen)
   {
      Screen.fullScreen = isFullScreen;
   }
}