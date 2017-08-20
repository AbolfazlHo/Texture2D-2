using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(EditorTest))]
public class EditorEditor : Editor {
	
	public override void OnInspectorGUI ()
	{
		EditorTest b = (EditorTest)base.target;
		b.myTexture = (Texture2D)EditorGUILayout.ObjectField ("Texture2D", b.myTexture, typeof(Texture2D), false);
	}
}
