using UnityEngine;
using UnityEngine.UI;

public class ScoreInOver : MonoBehaviour
{
    public GameObject AllCube;
    public Text ScoreText;
    private void Update()
    {
        if ((Input.GetMouseButtonDown(0) || Input.touchCount > 0)&&  AllCube != null)
        {
#if !UNITY_EDITOR
            if (Input.GetTouch(0).phase != TouchPhase.Began)
            {
                return;
            }
#endif

            int ChildCount = AllCube.transform.childCount;
            ScoreText.text = "" + ChildCount;
            // ++ChildCount;
        }

    }



}
