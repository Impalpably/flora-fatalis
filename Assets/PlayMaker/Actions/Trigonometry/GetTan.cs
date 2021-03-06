// (c) Copyright HutongGames, LLC 2010-2012. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Trigonometry)]
	[Tooltip("Get the Tangent. You can use degrees, simply check on the DegToRad conversion")]
	public class GetTan : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The angle. Note: You can use degrees, simply check DegtoRad if the angle is expressed in degrees.")]
		public FsmFloat angle;
		
		[Tooltip("Check on if the angle is expressed in degrees.")]
		public FsmBool DegToRad;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The angle tan")]
		public FsmFloat result;
		
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		public override void Reset()
		{
			angle = null;
			DegToRad = true;
			everyFrame = false;
			result = null;
		}

		public override void OnEnter()
		{
			DoTan();
			
			if (!everyFrame)
			{
				Finish();
			}
		}

		public override void OnUpdate()
		{
			DoTan();
		}
		
		void DoTan()
		{
			float _angle = angle.Value;
			if (DegToRad.Value)
			{
				_angle = _angle*Mathf.Deg2Rad;
			}
			result.Value = Mathf.Tan(_angle);
		}
	}
}