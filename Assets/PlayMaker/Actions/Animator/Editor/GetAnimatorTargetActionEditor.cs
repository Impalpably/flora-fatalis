// (c) Copyright HutongGames, LLC 2010-2016. All rights reserved.

using UnityEngine;
using HutongGames.PlayMaker.Actions;

namespace HutongGames.PlayMakerEditor
{
    [CustomActionEditor(typeof(GetAnimatorTarget))]
    public class GetAnimatorTargetActionEditor : OnAnimatorUpdateActionEditorBase
    {

        public override bool OnGUI()
        {
            EditField("gameObject");
            EditField("targetPosition");
            EditField("targetRotation");
            EditField("targetGameObject");

            bool changed = EditEveryFrameField();

            return GUI.changed || changed;
        }

    }
}
