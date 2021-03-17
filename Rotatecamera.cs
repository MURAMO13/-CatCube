using UnityEngine;
using UnityEngine.EventSystems;

public class Rotatecamera : MonoBehaviour
{
    
    public float speed;
    private Transform rot;
    

    private void Start()
     
    {
        rot = GetComponent<Transform>();
    }
    private void Update()
    {
        
        rot.Rotate(0, speed * Time.deltaTime, 0);
        if ((Input.GetMouseButtonDown(0) || Input.touchCount > 0)&& !EventSystem.current.currentSelectedGameObject  )
        {
#if !UNITY_EDITOR
            if ((Input.GetTouch(0).phase != TouchPhase.Began)&& ! EventSystem.current.currentSelectedGameObject)
            {
                return;
            }
#endif

            rot.transform.position = rot.transform.position + new Vector3(0, 0.3f, 0);
            //rot.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(transform.position.x, transform.position.y + 3f, transform.position.z), 3 * Time.deltaTime);
            
        }
    }

    

}
   
