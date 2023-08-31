using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Button : NetworkBehaviour
{
	[SerializeField] public Axes axis;
	[SerializeField] public float value;
	[SerializeField] public KeyCode linkedButton;
	void OnMouseDown()
	{
		CustomInput.SetAxis(axis, CustomInput.GetAxis(axis) + value);
	}
	void OnMouseUp()
	{
		CustomInput.SetAxis(axis, CustomInput.GetAxis(axis) - value);
	}
	void Update()
	{
		if(Input.GetKeyDown(linkedButton))
			OnMouseDown();
		if(Input.GetKeyUp(linkedButton))
			OnMouseUp();
	}
}
