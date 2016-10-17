using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

namespace Chapter_003
{
    [Transaction (TransactionMode.Manual)]
    public class Class1:IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, 
                       ref string message, 
                       ElementSet element)
        {
            UIApplication uiApp = commandData.Application;
            Application app = uiApp.Application;
            UIDocument uiDoc = uiApp.ActiveUIDocument;
            Document doc = uiDoc.Document;
            try
            {
                Selection selectedElem = uiDoc.Selection;
                ElementSet elemSet = selectedElem.Elements;

                if (elemSet.Size == 0)
                {
                    TaskDialog.Show("Revit", "选择元素为空。");
                }
                else
                {
                    string info = "选择的元素类型为：";
                    foreach (Element elem in elemSet)
                    {
                        info += "\t\n" + elem.GetType().ToString();
                    }
                    TaskDialog.Show("Revit", info);
                }
                

            }
            catch (Exception e)
            {
                message = e.Message;
                return Result.Failed;
            }


            return Result.Succeeded;
        }
    }
}
