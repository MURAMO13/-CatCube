using UnityEngine;

public class Ui : MonoBehaviour
{
    public GameObject[] UiElements;
    bool Chec;
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
#if !UNITY_EDITOR
            if (Input.GetTouch(0).phase != TouchPhase.Began)
            {
                return;
            }
#endif
            if (!Chec)
            {
                Chec = true;
                foreach (GameObject i in UiElements)
                {
                    i.SetActive(false);
                }
            }
        }
    }
}
