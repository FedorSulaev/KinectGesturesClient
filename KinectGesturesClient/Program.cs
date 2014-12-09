using System;
using KinectGestures;

namespace KinectGesturesClient
{
	class Program
	{
		static void Main(string[] args)
		{
			KinectService service = new KinectService();
			Console.WriteLine(service.GetKinectStatus().ToString());
			if (service.GetKinectStatus() == KinectStatus.Connected)
			{
				service.StartKinect();
				service.GestureEvent += service_GestureEvent;
			}
			while (true)
			{
				
			}
		}

		static void service_GestureEvent(object sender, KinectGesture e)
		{
			Console.WriteLine(e.ToString());
		}
	}
}
