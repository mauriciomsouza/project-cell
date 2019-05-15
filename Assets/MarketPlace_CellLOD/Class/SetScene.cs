using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScene : MonoBehaviour {

    [SerializeField]
    GameObject[] goArr;
    GameObject go; 

    IEnumerator Wait(){ 
        yield return new WaitForSeconds(3);
    }

    IEnumerator Start(){
        for (int i = 0; i < goArr.Length; i++)
        {
            if (go != null)
                go.SetActive(false);
            go = goArr[i];
            go.SetActive(true);
            
            yield return StartCoroutine("Wait");
        }
    }
}
