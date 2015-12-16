namespace KinectCam
{
    using System;
    using System.Collections.Generic;

    internal sealed class KinectCamSettigns
    {

        private static KinectCamSettigns defaultInstance = new KinectCamSettigns();

        public static KinectCamSettigns Default
        {
            get
            {
                return defaultInstance;
            }
        }

        public bool Mirrored
        {
            get;
			set;
		}

		public bool Zoom
		{
			get;
			set;
		}
		public bool TrackHead
		{
			get;
			set;
		}
		public bool Desktop
        {
            get;
            set;
        }
    }
}
