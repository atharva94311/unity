using UnityEngine;
using UnityEngine.UI;
public class Logicscript : MonoBehaviour
{
    public int playerscore;
    public Text scoretext; 
    [ContextMenu("addscore")]
    public void addscore()
    {playerscore++;
       scoretext.text=playerscore.ToString();
       
    }
}
