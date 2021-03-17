using UnityEngine;
using UnityEngine.UI;

public class MusicButomAndRandomSwitchMusic : MonoBehaviour
{
    private bool SoundCheker;
    public Sprite SpriteOn, SpriteOff;
    public GameObject ButtonSound;



    
    private void Start()
    {
        SoundCheker = PlayerPrefs.GetInt("Status", 1) == 1;
       // SoundCheker = !SoundCheker;
        AudioListener.pause = SoundCheker;
        ButtonSound.GetComponent<Image>().sprite = SpriteOff;
    }
    
    public void ChangeSound() 
    {
        
        SoundCheker = !SoundCheker;
        AudioListener.pause = SoundCheker;
        PlayerPrefs.SetInt("Status", SoundCheker ? 1 : 0 ) ;
        if (SoundCheker == true)
        {
            ButtonSound.GetComponent<Image>().sprite = SpriteOn;
        }
        else 
        {
            ButtonSound.GetComponent<Image>().sprite = SpriteOff;
        }



    }
}
