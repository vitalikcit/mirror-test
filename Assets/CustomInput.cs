using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CustomInput
{
    private static Dictionary<Axes,float> _axis = new Dictionary<Axes,float>();

    public static float GetAxis(Axes axis)
    {
    	if(!_axis.ContainsKey(axis))
    		_axis.Add(axis,0);

    	return _axis[axis];
    }
    public static void SetAxis(Axes axis,float value)
    {
    	if(!_axis.ContainsKey(axis))
    		_axis.Add(axis,value);
    	else
    		_axis[axis] = value;
    }
}

public enum Axes
{
	Vertical,
	Horizontal,
    Jump,
}
