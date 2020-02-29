using UnityEngine;

/// <summary>
/// つけたオブジェクトを点滅させる
/// </summary>
public class BlinkObject : MonoBehaviour
{
    private float nextTime;

    /// <summary>
    /// 点滅周期
    /// </summary>
    public float interval = 0.8f;

    private void Start()
    {
        nextTime = Time.time;
    }

    private void Update()
    {
        if(Time.time > nextTime){
            float alpha = gameObject.GetComponent<CanvasRenderer>().GetAlpha();
            if(alpha == 1.0f)
            {
                gameObject.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
            }
            else
            {
                gameObject.GetComponent<CanvasRenderer>().SetAlpha(1.0f);
            }
            nextTime += interval;
        }
    }
}
