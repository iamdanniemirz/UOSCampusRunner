
// File:			GAFAssetPostProcessor.cs
// Version:			5.2
// Last changed:	2017/3/31 09:57
// Author:			Nikitin Nikolay, Nikitin Alexey
// Copyright:		© 2017 GAFMedia
// Project:			GAF Unity plugin


using UnityEditor;
using UnityEngine;

using System.IO;
using System.Linq;

using GAF.Assets;
using GAFInternal.Reader;

using GAFEditorInternal.Assets;
using GAFEditorInternal.Tracking;

namespace GAFEditor.Assets
{
	public class GAFAssetPostProcessor : AssetPostprocessor
	{
		private static GAFAnimationAsset	asset		= null;
		private static bool					findAsset	= true;

		public static void OnPostprocessAllAssets(
			  string[] importedAssets
			, string[] deletedAssets
			, string[] movedAssets
			, string[] movedFromAssetPaths)
		{
			foreach (string assetName in importedAssets)
			{
				if (assetName.EndsWith(".gaf"))
				{
					byte[] fileBytes = null;
					using (BinaryReader freader = new BinaryReader(File.OpenRead(assetName)))
					{
						fileBytes = freader.ReadBytes((int)freader.BaseStream.Length);
					}

					if (fileBytes.Length > sizeof(int))
					{
						int header = System.BitConverter.ToInt32(fileBytes.Take(4).ToArray(), 0);
						if (GAFHeader.isCorrectHeader((GAFHeader.CompressionType)header))
						{
							var path = Path.GetDirectoryName(assetName) + "/" + Path.GetFileNameWithoutExtension(assetName) + ".asset";
							asset = AssetDatabase.LoadAssetAtPath(path, typeof(GAFAnimationAsset)) as GAFAnimationAsset;
							if (asset == null)
							{
								asset = ScriptableObject.CreateInstance<GAFAnimationAsset>();
								AssetDatabase.CreateAsset(asset, path);
								asset = AssetDatabase.LoadAssetAtPath(path, typeof(GAFAnimationAsset)) as GAFAnimationAsset;

								findAsset = false;
							}

							var assetDir = Path.GetDirectoryName(path);
							assetDir = assetDir == "Assets" ? string.Empty : assetDir.Substring("Assets/".Length, assetDir.Length - "Assets/".Length);

							asset.name = Path.GetFileNameWithoutExtension(assetName);
							asset.initialize(fileBytes, AssetDatabase.AssetPathToGUID(path), assetDir == string.Empty ? assetDir : assetDir + "/");

							EditorUtility.SetDirty(asset);
							AssetDatabase.SaveAssets();

							GAFResourceManagerInternal.instance.createResources<GAFTexturesResource>(asset);
							GAFResourceManagerInternal.instance.defineAudioResources(asset);

							EditorUtility.SetDirty(asset);
							AssetDatabase.SaveAssets();
						}
					}
				}
				else if (assetName.EndsWith(".asset"))
				{
					if (findAsset)
					{
						asset = AssetDatabase.LoadAssetAtPath<GAFAnimationAsset>(assetName);
						if (asset != null) findAsset = false;

						if (asset != null && ((asset.resourcesPaths == null || asset.resourcesPaths.Count == 0) || (asset.audioResources.Count == 0 && asset.sharedData.audioClips.Count > 0)))
						{
							GAFResourceManagerInternal.instance.createResources<GAFTexturesResource>(asset);
							GAFResourceManagerInternal.instance.defineAudioResources(asset);

							EditorUtility.SetDirty(asset);
							AssetDatabase.SaveAssets();
						}
					}
				}
			}
		}
    }
}