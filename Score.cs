using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text Scoretext;
    public GameObject AllCube;
    int ChildCount;
    private void Start()
    {
        ChildCount = AllCube.transform.childCount;
        Scoretext.text = PlayerPrefs.GetInt("score") + "\n" + ChildCount;
    }
    private void Update()
    {
        
      
        if ((Input.GetMouseButtonDown(0) || Input.touchCount > 0) && AllCube != null && !EventSystem.current.currentSelectedGameObject)
        {
#if !UNITY_EDITOR
            if ((Input.GetTouch(0).phase != TouchPhase.Began)&& !EventSystem.current.currentSelectedGameObject)
            {
                return;
            }
#endif

            if (PlayerPrefs.GetInt("score") < ChildCount)
            {
                PlayerPrefs.SetInt("score", ChildCount);
            }
            Scoretext.text = PlayerPrefs.GetInt("score") + "\n" + ChildCount;
            ++ChildCount;
        }  
    }

}
