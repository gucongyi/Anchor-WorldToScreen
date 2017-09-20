using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldToScreenTest : MonoBehaviour
{
    public Transform TransLeftTop;
    public Transform TransLeftBottom;
    public Transform TransCenter;
    public Transform TransRightTop;
    public Transform TransRightBottom;

    public Canvas canvas;
    public Image image;
    // Use this for initialization
    void Start ()
    {
        float factor = canvas.scaleFactor;
        Vector3 posLeftTop=Camera.main.WorldToScreenPoint(TransLeftTop.position);
        Vector3 posLeftBottom = Camera.main.WorldToScreenPoint(TransLeftBottom.position);
        Vector3 posCenter = Camera.main.WorldToScreenPoint(TransCenter.position);
        Vector3 posRightTop = Camera.main.WorldToScreenPoint(TransRightTop.position);
        Vector3 posRightBottom = Camera.main.WorldToScreenPoint(TransRightBottom.position);
        Debug.Log("factor:"+ factor);
        Debug.Log("posLeftTop:" + posLeftTop);
        Debug.Log("posLeftBottom:" + posLeftBottom);
        Debug.Log("posCenter:" + posCenter);
        Debug.Log("posRightTop:" + posRightTop);
        Debug.Log("posRightBottom:" + posRightBottom);
        image.rectTransform.anchoredPosition = posLeftTop/ factor;//一定要是锚点位置 并且锚点在左下角
        //四方块中锚点表示锚定谁，锚定那个位置 所以锚定点设置在左下角
        //自己种的圆圈表示那个点去和锚定点计算锚定的距离。自己的圆圈可以在任何位置。
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
