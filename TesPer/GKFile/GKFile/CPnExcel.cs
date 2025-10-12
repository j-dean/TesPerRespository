using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;


namespace GKFile
{
	public class CPnExcel
	{
		[DllImport("user32.dll", SetLastError = true)]
		static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

		private const int DEF_INI_False = -1;
		private Excel.Application	m_excelApp        = null;
		private Excel.Workbook		m_WorkBook        = null;
		private Excel.Worksheet		m_WorkSheet       = null;
		private string				m_strPath       = string.Empty;
		private bool				m_bInitialized	= false;
		private bool				m_bFileExists	= false;
		private int					m_RowCount = 0;
	
		~CPnExcel()
		{
			
		}

		public int RowCount 
		{
			get { return m_RowCount; }
		}


        static private void ReleaseObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);  // 액셀 객체 해제
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();   // 가비지 수집
            }
        }

        public bool Open(string strPath)
		{
			string strDirectoryPath = string.Empty;
			DirectoryInfo directory = null;

			m_strPath        = strPath;
			m_bInitialized   = false;
			strDirectoryPath = Path.GetDirectoryName(strPath);
			directory        = new DirectoryInfo(strDirectoryPath);

			try
			{
				if (directory.Exists == false)
				{
					directory.Create();
				}

				m_excelApp = new Excel.Application();

				if (!File.Exists(strPath))
				{
					m_WorkBook = m_excelApp.Workbooks.Add();

					m_bFileExists = false;
					m_bInitialized = true;
				}
				else
				{
					m_WorkBook = m_excelApp.Workbooks.Open
					(
						m_strPath,
						0,
						false,
						5,
						"",
						"",
						true,
						Excel.XlPlatform.xlWindows,
						"\t",
						false,
						false,
						0,
						true,
						1,
						0
					);

					m_bFileExists	= true;
					m_bInitialized	= true;
				}

				m_WorkSheet = m_WorkBook.Worksheets.get_Item(1) as Excel.Worksheet;
				m_RowCount = m_WorkSheet.UsedRange.Rows.Count;

				return true;
			}
			catch (Exception ex)
			{
				m_bInitialized = false;
				Debug.Assert(condition: false, $"Exception: {ex}");
			}

			return false;
		}

		public void Write()
		{
			if (m_bInitialized)
			{
				try
				{
					if (m_bFileExists)
					{
						m_WorkBook.Save();
					}
					else
					{
						m_WorkBook.SaveAs(m_strPath, Excel.XlFileFormat.xlWorkbookDefault);
					}
				}
				catch (Exception ex)
				{
					Debug.Assert(condition: false, $"Exception: {ex}");
				}
			}
		}

		public void Read(int nRow, int nCol, ref string csData)
		{
			try
			{
				Excel.Range range = m_WorkSheet.UsedRange;    // 사용중인 셀 범위를 가져오기


				csData = (range.Cells[nRow + 1, nCol + 1] as Excel.Range).Value2;
				//csData = m_WorkSheet.Cells[nRow + 1, nCol + 1];
			}
			catch (Exception ex)
			{
				Debug.Assert(condition: false, $"Exception: {ex}");
			}
		}

		public void ReadBool(int nRow, int nCol, ref bool csData)
		{
			try
			{
				Excel.Range range = m_WorkSheet.UsedRange;    // 사용중인 셀 범위를 가져오기


				csData = (bool)(range.Cells[nRow + 1, nCol + 1] as Excel.Range).Value2;

			}
			catch (Exception ex)
			{
				Debug.Assert(condition: false, $"Exception: {ex}");
			}
		}

		public void ReadInt(int nRow, int nCol, ref int csData)
		{
			try
			{
				Excel.Range range = m_WorkSheet.UsedRange;    // 사용중인 셀 범위를 가져오기


				csData = (int)(range.Cells[nRow + 1, nCol + 1] as Excel.Range).Value2;
				//csData = m_WorkSheet.Cells[nRow + 1, nCol + 1];
			}
			catch (Exception ex)
			{
				Debug.Assert(condition: false, $"Exception: {ex}");
			}
		}

		public void ReadDouble(int nRow, int nCol, ref double csData)
		{
			try
			{
				Excel.Range range = m_WorkSheet.UsedRange;    // 사용중인 셀 범위를 가져오기


				csData = (range.Cells[nRow + 1, nCol + 1] as Excel.Range).Value2;

			}
			catch (Exception ex)
			{
				Debug.Assert(condition: false, $"Exception: {ex}");
			}
		}

   

        public bool ReadEnum<TEnum>(int nRow, int nCol, ref TEnum strDefaltValue) where TEnum : struct
		{
			bool bReturn = false;
			TEnum eDefaltValue = strDefaltValue;
			string strData = string.Empty;


			try
			{
				Excel.Range range = m_WorkSheet.UsedRange;    // 사용중인 셀 범위를 가져오기


				strData = (range.Cells[nRow + 1, nCol + 1] as Excel.Range).Value2;

				if (strData != null)
				{
					if (Enum.TryParse(strData.ToString(), out strDefaltValue))
					{
						bReturn = true;
					}
					else
					{
						strDefaltValue = eDefaltValue;
						bReturn = false;
					}
				}
				else
				{
					strDefaltValue = eDefaltValue;
					bReturn = false;
				}

			}
			catch (Exception ex)
			{
				Debug.Assert(condition: false, $"Exception: {ex}");
			}


			return bReturn;
		}

		public void Read()
		{
			List<string> buff = new List<string>();

			try
			{

				buff.Add(m_WorkSheet.Name); // 표시용 데이터 추가

				Excel.Range range = m_WorkSheet.UsedRange;    // 사용중인 셀 범위를 가져오기

				// 가져온 행(row) 만큼 반복
				for (int row = 1; row <= m_RowCount; row++)
				{
					List<string> lstCell = new List<string>();

					// 가져온 열(row) 만큼 반복
					for (int column = 1; column <= range.Columns.Count; column++)
					{
						//object obj = (range.Cells[row, column] as Excel.Range).Value2;
						object obj = (range.Cells[row, column] as Excel.Range).Value2;
						string str = obj.ToString();  // 셀 데이터 가져옴
						lstCell.Add(str); // 리스트에 할당
					}

					buff.Add(string.Join(",", lstCell.ToArray())); // 표시용 데이터 추가
				}

				//object missing = Type.Missing;
				//object noSave = false;
				m_WorkBook.Close(false, Type.Missing, Type.Missing); // 엑셀 웨크북 종료
				m_excelApp.Quit();        // 엑셀 어플리케이션 종료
			}
			finally
			{
				ReleaseObject(m_WorkBook);
			}

		}

		public void Gethering(int nRow, int nCol, string strText)
		{
			m_WorkSheet.Cells[nRow, nCol] = strText;
		}

	
		public void Gethering(List<string> list_strText)
		{
			m_RowCount++;

			for (int nCnt = 0; nCnt < list_strText.Count; nCnt++)
			{
				m_WorkSheet.Cells[m_RowCount, nCnt + 1] = list_strText[nCnt];
			}
		}

		public void SetHeader(List<string> list_strText)
		{
			for (int nCnt = 0; nCnt < list_strText.Count; nCnt++)
			{
				m_WorkSheet.Cells[0, nCnt + 1] = list_strText[nCnt];
			}
		}

		public void Close()
		{
			m_WorkBook.Close(true);
			m_excelApp.Quit();

			ReleaseObject(m_WorkSheet);
			ReleaseObject(m_WorkBook);
			ReleaseObject(m_excelApp);
		}

        private static void PathConform(string strFullName)
        {
            string strPath = Path.GetFileName(strFullName);
            strPath = strFullName.Replace(strPath , "");

            DirectoryInfo directory = new DirectoryInfo(strPath);

            if (directory.Exists == false)
            {
                directory.Create();
            }
        }

        public static void Save(string strFullName , List<string> strItems)
        {
            try
            {
                PathConform(strFullName);

                StringBuilder _StringBuilder = new StringBuilder();

                for (int nCnt = 0 ; nCnt < strItems.Count ; nCnt++)
                {
                    string strItems1 = strItems[nCnt] + ",";
                    _StringBuilder.Append(strItems1);
                }

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(strFullName , true))
                {
                    file.WriteLine(_StringBuilder);
                }
            }
            catch (Exception ex)
            {
                Debug.Assert(false , ex.Message);
            }
        }

        public static void Save(string strFullName , List<List<string>> strItems)
        {
            try
            {
                PathConform(strFullName);

                StringBuilder _StringBuilder = new StringBuilder();

                for (int nRow = 0 ; nRow < strItems.Count ; nRow++)
                {
                    for (int nCol = 0 ; nCol < strItems[nRow].Count ; nCol++)
                    {
                        string strItems1 = strItems[nRow][nCol] + ",";
                        _StringBuilder.Append(strItems1);
                    }

                    _StringBuilder.Append(Environment.NewLine);
                }

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(strFullName , true))
                {
                    file.WriteLine(_StringBuilder);
                }
            }
            catch (Exception ex)
            {
                Debug.Assert(false , ex.Message);
            }

        }

        private static string UnicodeToUTF8(string from)
        {
            var bytes = Encoding.UTF8.GetBytes(from);
            return new string(bytes.Select(b => (char)b).ToArray());
        }

        public void Write(int nRow , int nCol , string csData)
        {
            uint excelProcessId = 0;
            Excel.Application excelApp = null;
            Excel.Workbook wb = null;
            Excel.Worksheet ws = null;

            //try
            //{
            //    excelApp = new Excel.Application();

            //    GetWindowThreadProcessId(new IntPtr(excelApp.Hwnd) , out excelProcessId);

            //    // 엑셀 파일 열기
            //    wb = excelApp.Workbooks.Open(strPath);
            //    //m_WorkBook = excelApp.Workbooks.Open(strPath);
            //    // 첫번째 Worksheet
            //    ws = wb.Worksheets.get_Item(nWorkSheet) as Excel.Worksheet;


            //    Excel.Range range = m_WorkSheet.UsedRange;    // 사용중인 셀 범위를 가져오기

            //    range.Cells[nRow + 1 , nCol + 1].Value = csData;

            //}
            //catch (Exception ex)
            //{
            //    Debug.Assert(condition: false , $"Exception: {ex}");
            //}
        }


        public void XlsxRead(string strPath ,int nWorkSheet, ref System.Data.DataTable dtContent)
        {
            Excel.Application excelApp = null;
            Excel.Workbook wb = null;
            Excel.Worksheet ws = null;
            uint excelProcessId = 0;
            List<string[]> result = new List<string[]>();
            

            m_strPath = strPath;

            try
            {
                // 엑셀 프로그램 실행
                excelApp = new Excel.Application();
                
                GetWindowThreadProcessId(new IntPtr(excelApp.Hwnd) , out excelProcessId);

                // 엑셀 파일 열기
                wb = excelApp.Workbooks.Open(strPath);
                //m_WorkBook = excelApp.Workbooks.Open(strPath);
                // 첫번째 Worksheet
                ws = wb.Worksheets.get_Item(nWorkSheet) as Excel.Worksheet;
            
                Excel.Range rng = ws.UsedRange;

                object[,] data = (object[,])rng.Value;

                for (int r = 1 ; r <= data.GetLength(0) ; r++)
                {
                    int length = Math.Min(data.GetLength(1) , rng.Columns.Count);
                    string[] arr = new string[length];

                    for (int c = 1 ; c <= length ; c++)
                    {
						dtContent.Columns.Add();

                        if (data[r , c] == null)
                        {
                            continue;
                        }
                        else if (data[r , c] is string)
                        {
                            arr[c - 1] = data[r , c] as string;
                        }
                        else
                        {
                            arr[c - 1] = data[r , c].ToString();
                        }
                    }

                    DataRow dtRow = dtContent.NewRow();

                    for (int nCnt = 0 ; nCnt < arr.Length ; nCnt++)
                    {
                        
                        dtRow[nCnt] = arr[nCnt];
                    }

                    dtContent.Rows.Add(dtRow);
       
                }

                wb.Close(false);
                excelApp.Quit();
            }
            catch (Exception ex)
            {
				Debug.Assert(false, ex.Message);
            }
            finally
            {
         
                ReleaseObject(ws);
                ReleaseObject(wb);
                ReleaseObject(excelApp);

                if (excelApp != null && excelProcessId > 0)
                {
                    Process.GetProcessById((int)excelProcessId).Kill();
                }
            }

        }




        public static void XlsxModify(string strPath , int nWorkSheet , ref System.Data.DataTable dtContent)
        {
            uint excelProcessId = 0;
            Excel.Application excelApp = null;
            Excel.Workbook wb = null;
            Excel.Worksheet ws = null;

            List<string[]> result = new List<string[]>();

            try
            {
                // 엑셀 프로그램 실행
                excelApp = new Excel.Application();
                GetWindowThreadProcessId(new IntPtr(excelApp.Hwnd) , out excelProcessId);

                // 엑셀 파일 열기
                wb = excelApp.Workbooks.Open(strPath);

                // 첫번째 Worksheet
                ws = wb.Worksheets.get_Item(nWorkSheet) as Excel.Worksheet;

                // 현재 Worksheet에서 사용된 Range 전체를 선택
                Excel.Range rng = ws.UsedRange;

                object[,] data = (object[,])rng.Value;

                for (int r = 1 ; r <= data.GetLength(0) ; r++)
                {
                    int length = Math.Min(data.GetLength(1) , rng.Columns.Count);
                    string[] arr = new string[length];

                    for (int c = 1 ; c <= length ; c++)
                    {
                        dtContent.Columns.Add();

                        if (data[r , c] == null)
                        {
                            continue;
                        }
                        else if (data[r , c] is string)
                        {
                            arr[c - 1] = data[r , c] as string;
                        }
                        else
                        {
                            arr[c - 1] = data[r , c].ToString();
                        }
                    }

                    DataRow dtRow = dtContent.NewRow();

                    for (int nCnt = 0 ; nCnt < arr.Length ; nCnt++)
                    {

                        dtRow[nCnt] = arr[nCnt];
                    }

                    dtContent.Rows.Add(dtRow);

                }

                wb.Close(false);
                excelApp.Quit();
            }
            catch (Exception ex)
            {
                Debug.Assert(false , ex.Message);
            }
            finally
            {
                // Clean up
                ReleaseObject(ws);
                ReleaseObject(wb);
                ReleaseObject(excelApp);

                if (excelApp != null && excelProcessId > 0)
                {
                    Process.GetProcessById((int)excelProcessId).Kill();
                }
            }

        }


        public static void CSVRead(string strPath , ref System.Data.DataTable dtContent)
        {
            dtContent = new System.Data.DataTable();
			int nLineIdx = -1;

            try
            {
                using (FileStream fs = new FileStream(strPath , FileMode.Open))
                {
					using (StreamReader sr = new StreamReader(fs , Encoding.ASCII , false))
					//using (StreamReader sr = new StreamReader(fs))
					{
                        string lines = null;
                        string[] keys = null;
                        string[] values = null;
                        int nCurrentRow = 0;

                        while ((lines = sr.ReadLine()) != null)
                        {
							nLineIdx++;

                            if (string.IsNullOrEmpty(lines))
                                return;

                            if (lines.Substring(0 , 1).Equals("#"))  // 첫줄에 #이 있을 경우 Key로 처리
                            {
                                keys = lines.Split(',');            // 콤마로 분리
                                keys[0] = keys[0].Replace("#" , ""); // "#"을 ""로 교체

                                for (int i = 0 ; i < keys.Length ; i++)
                                {
                                    Console.Write(keys[i]);
                                    if (i != keys.Length - 1)
                                        Console.Write(", ");
                                }

                                Console.WriteLine();

                                continue;
                            }

                            values = lines.Split(',');  // 콤마로 분리

                            if (nCurrentRow == 0)
                            {
                                nCurrentRow++;

                                for (int nCol = 0 ; nCol < values.Count() ; nCol++)
                                {
                                    dtContent.Columns.Add();
                                }

                                DataRow dtRow1 = dtContent.NewRow();

								string strOutPut = string.Empty;

                                for (int nCnt = 0 ; nCnt < values.Count() ; nCnt++)
                                {
                                    //strOutPut = Encoding.UTF8.GetString(values[nCnt]);
                                    dtRow1[nCnt] = UnicodeToUTF8(values[nCnt]);
                                    //= .ToString();
                                }

                                dtContent.Rows.Add(dtRow1);
                                continue;
                            }


                            //DataTable dTblInspection = new DataTable();
                            DataRow dtRow = dtContent.NewRow();

                            for (int nCnt = 0 ; nCnt < values.Count() ; nCnt++)
                            {
                                dtRow[nCnt] = values[nCnt];
                            }

                            dtContent.Rows.Add(dtRow);

                            //for (int i = 0 ; i < values.Length ; i++)
                            //{
                            //    Console.Write(values[i]);
                            //    if (i != values.Length - 1)
                            //        Console.Write(", ");
                            //}

                            Console.WriteLine();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.Assert(false , e.Message);
                //Console.WriteLine(e.ToString());
            }
        }
    }
}
