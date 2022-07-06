using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

static class CreateSOAsset
{
	[MenuItem("Assets/Create/CardAsset")]
	public static void CreateYourScriptableObject1()
	{
		ScriptableObjectUtility.CreateAsset<CardAsset>();
	}
	[MenuItem("Assets/Create/MonsterAsset")]
	public static void CreateYourScriptableObject2()
	{
		ScriptableObjectUtility.CreateAsset<MonsterAsset>();
	}
}

