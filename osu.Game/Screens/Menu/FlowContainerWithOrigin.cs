﻿using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using OpenTK;

namespace osu.Game.Screens.Menu
{
    /// <summary>
    /// A flow container with an origin based on one of its contained drawables.
    /// </summary>
    public class FlowContainerWithOrigin : FlowContainer
    {
        /// <summary>
        /// A target drawable which this flowcontainer should be centered around.
        /// This target should be a direct child of this FlowContainer.
        /// </summary>
        public Drawable CentreTarget;

        public override Anchor Origin => Anchor.Custom;

        public override Vector2 OriginPosition
        {
            get
            {
                if (CentreTarget == null)
                    return base.OriginPosition;

                return CentreTarget.DrawPosition + CentreTarget.DrawSize / 2;
            }
        }
    }
}
