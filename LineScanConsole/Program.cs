﻿using Hanbo.Camera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LineScanConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			long w = 10000;
			long h = 2000;
			bool isPEGMode = true;
			var lineScan = new LineScan(w, h, isPEGMode);

			//lineScan.SetPEGMode(w, h);
			lineScan.On_RunningMessage += lineScan_On_RunningMessage;
			lineScan.StartGrab();
			string msg = "";
			while ((msg = Console.ReadLine()) != "")
			{
				Thread.Sleep(100);
				break;
			}
			//lineScan.StartGrab();
		}

		static void lineScan_On_ErrorOccured(object sender, GrabImageEventArgs e)
		{
			Console.WriteLine(e.Message);
		}

		static void lineScan_On_RunningMessage(object sender, GrabImageEventArgs e)
		{
			Console.WriteLine(e.Message);
		}
	}
}
