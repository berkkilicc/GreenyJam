using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectManager : MonoBehaviour
{
    public List<GameObject> trashList = new List<GameObject>();
    public Transform collectPoint;
    
    public int trashLimit =5;

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "trash":
                Debug.Log("dokundu");
                collision.gameObject.SetActive(false);
                break;
              
        }
    }
}
