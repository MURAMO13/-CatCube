using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class InsatantionsCubs : MonoBehaviour
{
    public  GameObject Cubs ;
    public GameObject Parents;
    


    public float y=0 ;
    public int MassOfCub = 300;
    


   

    IEnumerator AfterTime()
    {
        
        yield return new WaitForSeconds(1);

        GameObject newCube = Instantiate(Cubs,Cubs.transform.position + new Vector3(0, y += 0.3f, 0), Quaternion.identity)as GameObject;
        float RandomNumber = UnityEngine. Random.Range(0f,1.0f);
        float RandomNumber1 = UnityEngine.Random.Range(0f, 1.0f);
        float RandomNumber2 = UnityEngine.Random.Range(0f, 1.0f);
        float RandomNumber3 = UnityEngine.Random.Range(0f, 1.0f);


        newCube.gameObject.GetComponent<Renderer>().material.color =   new Color(RandomNumber, RandomNumber1, RandomNumber2, RandomNumber3);



         newCube.transform.SetParent(Parents.transform);
      
        //newCube.transform.localPosition = new Vector3(x, y, z);
        
        int i = Parents.transform.childCount - 1;
        Transform ChildOfParents = Parents.transform.GetChild(i);
        Rigidbody RigidbodyOfChild = ChildOfParents.gameObject.GetComponent<Rigidbody>();
        if (MassOfCub > 6)
        {
            MassOfCub -= 3;
        }
        else 
        {
            MassOfCub = 6;
        }
        RigidbodyOfChild.mass = MassOfCub ;
        RigidbodyOfChild.useGravity = false;

        


    }
    

    void Update()
    {
       
        if ((Input.GetMouseButtonDown(0) || Input.touchCount > 0) && ! EventSystem.current.currentSelectedGameObject)
        {
#if !UNITY_EDITOR
            if ((Input.GetTouch(0).phase != TouchPhase.Began) && ! EventSystem.current.currentSelectedGameObject)
            {
                return;
            }
#endif
            StartCoroutine(AfterTime());
            
        }
        

    }
}


