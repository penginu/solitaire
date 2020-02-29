using UnityEngine;
using UnityEngine.SceneManagement;
using Const;

public class StartText : MonoBehaviour
{
    public void Clicked()
    {
        SceneManager.LoadScene(SceneConst.GameMainSceneName);
    }
}
