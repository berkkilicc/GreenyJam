using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDoorManager : MonoBehaviour
{
    
    private void Update()
    {
      
    }

    public void OnCollisionEnter(Collision collision)
    {

        

        if (collision.gameObject.tag == "Player")
        {
            

            if (collision.gameObject.GetComponent<playerInventory>().NumberOfPlastic==1 )
            {
                
                Destroy(gameObject);
 
            }
            else if (collision.gameObject.tag == "1.level")
            {
                StartCoroutine(nextScene());
            }
        }
    }

    IEnumerator nextScene()
    {
       
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }
}
