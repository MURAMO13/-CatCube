 using UnityEngine;


public class ExplodeCubes : MonoBehaviour
{
    public GameObject RestartButton;
    public GameObject ShareButton;
    private bool _collision;
    public GameObject AllCubes;
    public GameObject InsatantionsCubs;
    public GameObject RotateCamera;
    public GameObject ScoreInOverCan;
    public GameObject ScoreInOverText;
    public GameObject Connect;

    
    
        




    private void OnCollisionEnter(Collision collision)
    {

        if (!_collision)
        {
            for (int i = AllCubes.transform.childCount - 1; i >= 0; i--)
            {
                Transform child = AllCubes.transform.GetChild(i);
                //child.gameObject.AddComponent<Rigidbody>();
                child.gameObject.GetComponent<Rigidbody>().AddExplosionForce(70f, Vector3.up, 6f);
                child.SetParent(null);

            }
            InsatantionsCubs.gameObject.SetActive(false);
            RotateCamera.gameObject.GetComponent<Rotatecamera>().enabled = false;
            Camera.main.transform.position -= new Vector3(0, 0, 5f)* Time.deltaTime;
            RestartButton.SetActive(true);
            ShareButton.SetActive(true);
            ScoreInOverText.SetActive(true);
            Destroy(AllCubes);
            var sc = ScoreInOverCan.GetComponent<ScoreInOver>();
            sc.enabled = false;
            Connect.SetActive(true);
            




            Destroy(collision.gameObject);
            _collision = true;

        }

    }
    
}
