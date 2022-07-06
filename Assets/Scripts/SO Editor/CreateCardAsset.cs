using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

static class CreateCardAsset
{
	[MenuItem("Assets/Create/CardAsset")]
	public static void CreateYourScriptableObject1()
	{
		ScriptableObjectUtility.CreateAsset<CardAsset>();
	}
}

