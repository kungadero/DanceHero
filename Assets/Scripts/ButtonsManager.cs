using UnityEngine;
using System.Collections;

public class ButtonsManager : MonoBehaviour
{
 [SerializeField]
 private Animator[] songButtons;
 [SerializeField]
 private Animator closeButton;
 [SerializeField]
 private float timeBetweenButtons = 0.1f;
 [SerializeField]
 private string showAnimationName = "Show";
 [SerializeField]
 private string hideAnimatioName = "Hide";

 public void ShowSongButtons()
    {
        StopAllCoroutines();
        StartCoroutine(AnimateButtons(showAnimationName));
    }
public void HideSongButtons()
   {
        StopAllCoroutines();
        StartCoroutine(AnimateButtons(showAnimationName));
    }  
private IEnumerator AnimateButtons(string animationName)
    {
        foreach (Animator button in songButtons)
        {
            button.Play(animationName);
            yield return new WaitForSeconds(timeBetweenButtons);
        }
    }
public void ShowCloseButton()
    {
        closeButton.Play(showAnimationName);
    }
public void HideCloseButton()
    {
        closeButton.Play(hideAnimatioName);
    }    
}
