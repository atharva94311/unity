using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Logicscript : MonoBehaviour
{
    
    public int playerscore;
    public GameObject gameoverscreen;
    public Text scoretext; 
    [ContextMenu("addscore")]
    public void addscore()
    {playerscore++;
       scoretext.text=playerscore.ToString();
       
    }
    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameover()
    {
        gameoverscreen.SetActive(true);
    }
}
