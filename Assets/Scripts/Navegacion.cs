using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;




public class Navegacion : MonoBehaviour
{
    
    public void OnLevelWasLoaded(int level){
        SceneManager.LoadScene(level);

        
    }

}
