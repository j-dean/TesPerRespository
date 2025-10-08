using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKFile
{
	internal class CGKJson
	{
		public int nDatumRowCnt = 0;
		public int nDatumColCnt = 0;
		public double dbDatumPitchX = 0;
		public double dbDatumPitchY = 0;
		//public Rect2d rtRefROI = new Rect2d(1224, 1024, 2100, 1800);
		//public Point2d ptMpPRatio = new Point2d();
		//public _eModeFinerShape eModeFinderShpae = _eModeFinerShape.Cross;
		//public Rect rtImgModelROI = new Rect();

		public double dbRectagleAccuracy = 0;
		public double dbVerticalAngle = 0;
		public double dbHorizonAngle = 0;

		public void LoadData(int nIdx)
		{
			string strProcessPath = "./Data/CPixResolutionInfo" + nIdx.ToString() + ".json";


			if (File.Exists(strProcessPath))
			{
				StreamReader strRead = File.OpenText(strProcessPath);
				string strjsonString = strRead.ReadToEnd();
				CGKJson clsThis = JsonConvert.DeserializeObject<CGKJson>(strjsonString);

				this.nDatumRowCnt = clsThis.nDatumRowCnt;
				this.nDatumColCnt = clsThis.nDatumColCnt;
				this.dbDatumPitchX = clsThis.dbDatumPitchX;
				this.dbDatumPitchY = clsThis.dbDatumPitchY;

				this.dbRectagleAccuracy = clsThis.dbRectagleAccuracy;
				this.dbVerticalAngle = clsThis.dbVerticalAngle;
				this.dbHorizonAngle = clsThis.dbHorizonAngle;
			}
		}

		public void SaveData(int nIdx)
		{
			string strProcessPath = "./Data/CPixResolutionInfo" + nIdx.ToString() + ".json";
			DirectoryInfo directory = new DirectoryInfo(strProcessPath);


			if (directory.Exists == false)
			{
				directory.Create();
			}

			strProcessPath += "CPixResolutionInfo" + nIdx.ToString() + ".json";

			using (StreamWriter swWriter = new StreamWriter(strProcessPath))
			{
				swWriter.Write(JsonConvert.SerializeObject(this));
			}
		}
	}
}
