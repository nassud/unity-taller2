using UnityEngine;

public class Navegacion : MonoBehaviour
{
    
    public void Load(int level){
        UnityEngine.SceneManagement.SceneManager.LoadScene(level);
    }

}
