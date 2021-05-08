
// File:			GAFAnimationAssetEditor.cs
// Version:			5.2
// Last changed:	2017/3/31 09:57
// Author:			Nikitin Nikolay, Nikitin Alexey
// Copyright:		© 2017 GAFMedia
// Project:			GAF Unity plugin


using UnityEditor;

using GAF.Assets;
using GAF.Core;

using GAFEditorInternal.Assets;
using UnityEngine;

using System.Linq;

using UnityEditor.Animations;

namespace GAFEditor.Assets
{
	[CanEditMultipleObjects]
	[CustomEditor(typeof(GAFAnimationAsset))]
	public class GAFAnimationAssetEditor : GAFAnimationAssetInternalEditor<GAFTexturesResource>
	{
		#region Implementation

		protected override void drawCreationMenu(int _TimelineID, ClipCreationOptions _Option)
		{
			switch(_Option)
			{
				case ClipCreationOptions.NotBakedMovieClip:
					drawCreateClip<GAFMovieClip>(_TimelineID, false, false);
					break;

				case ClipCreationOptions.BakedMovieClip:
					drawCreateClip<GAFBakedMovieClip>(_TimelineID, true, false);
					break;
			}
		}
		#endregion // Implementation
	}
}