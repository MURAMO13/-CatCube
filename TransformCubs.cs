
using UnityEngine;
using UnityEngine.EventSystems;

public class TransformCubs : MonoBehaviour


{
    Rigidbody RB;
    public float speedY, speedZ;
    public float speedX = -2.5f;
    
   
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }
    void Update()
    {
        transform.Translate(speedX * Time.deltaTime, speedY * Time.deltaTime, speedZ * Time.deltaTime);
        if (transform.position.x > 5f || transform.position.x < -5f)
        {
            speedX = -speedX;
        }
        
        if ((Input.GetMouseButtonDown(0) || Input.touchCount>0) && !EventSystem.current.currentSelectedGameObject) 
        {
#if !UNITY_EDITOR
            if ((Input.GetTouch(0).phase != TouchPhase.Began)&& ! EventSystem.current.currentSelectedGameObject)
            {
                return;
            }
#endif
            RB.useGravity = true;
            speedX = 0;
           

}
    }
}
