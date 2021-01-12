using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpdateText : MonoBehaviour
{
	
	public Text text;
	public Slider slider;
    
	public void UpdateNow()
	{
		text.text = ""+slider.value*100f;
	}
}
