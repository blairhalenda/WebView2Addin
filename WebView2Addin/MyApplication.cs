using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace WebView2Addin
{
    public class MyApplication
    {
        
        public Excel.Application Application { get; }
        public static Microsoft.Office.Tools.CustomTaskPane TaskPane { get; set; }



        public MyApplication(Excel.Application application)
        {
            Application = application;
        }


        public static void OpenTaskPane()
        {
            
            if(TaskPane == null)
            {
                CustomTaskPane customTaskPane = new CustomTaskPane();
                TaskPane = Globals.ThisAddIn.CustomTaskPanes.Add(customTaskPane, "WebView2 Task Pane");
            }
            TaskPane.Visible = true;
            
        }

    }
}
