using UnityEngine;
using System.Collections;
using UnityEditor;

public class PackAssets : MonoBehaviour
{
	[MenuItem("PackAsset/AutoPackAsset")]
	public static void AutoPackAsset ()
	{
		Object[] ojbs = Selection.objects;
		int count = ojbs.Length;
		AssetBundleBuild[] builds = new AssetBundleBuild[count];
		for (int i = 0; i<count; i++) {
			string packPath = AssetDatabase.GetAssetPath (ojbs [i]);
			builds [i].assetBundleName = "packed" + ojbs [i].name;

			string[] assetsNames = new string[1];
			assetsNames [0] = packPath;

			builds [i].assetNames = assetsNames;
		}

		BuildPipeline.BuildAssetBundles (Application.dataPath + "/PackedAssets", builds);
	}

	[MenuItem("PackAsset/AutoPackAsset", true)]
	public static bool AutoPackIsVaild ()
	{
		return Selection.objects.Length != 0;
	}


}
