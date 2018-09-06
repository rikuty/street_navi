﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public partial class DEFINE_APP {//ApplictionDefine

	public static class UGUI {
		public enum ANCHOR{ 
			UpperLeft	= 0,
			UpperCenter = 1,
			UpperRight	= 2,
			MiddleLeft	= 3,
			MiddleCenter= 4,
			MiddleRight	= 5,
			LowerLeft	= 6,
			LowerCenter	= 7,
			LowerRight	= 8
		}

		public static Dictionary<ANCHOR, Vector2> ANCHOR_VECTOR2 = new Dictionary<ANCHOR, Vector2>(){
			{ANCHOR.UpperLeft,		new Vector2(0.0f,1.0f)},
			{ANCHOR.UpperCenter,	new Vector2(0.5f,1.0f)},
			{ANCHOR.UpperRight,		new Vector2(1.0f,1.0f)},

			{ANCHOR.MiddleLeft,		new Vector2(0.0f,0.5f)},
			{ANCHOR.MiddleCenter,	new Vector2(0.5f,0.5f)},
			{ANCHOR.MiddleRight,	new Vector2(1.0f,0.5f)},

			{ANCHOR.LowerLeft,		new Vector2(0.0f,0.0f)},
			{ANCHOR.LowerCenter,	new Vector2(0.5f,0.0f)},
			{ANCHOR.LowerRight,		new Vector2(1.0f,0.0f)},

		};

	}
}

	
	