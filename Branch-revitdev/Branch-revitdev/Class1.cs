using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace Branch_revitdev
{
    [Transaction(TransactionMode.Manual)]
    public class Class1:IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, 
                              ref string message, 
                              ElementSet elements)
        {
            //UIApplication uiApp = commandData.Application;
            //Application app = uiApp.Application;
            //UIDocument uiDoc = uiApp.ActiveUIDocument;
            //Document doc = uiDoc.Document;

            //**************************************************************
            //************2-18：从setting中取到当前文档的Categories*************
            //*****************************************************************
            //UIApplication uiApp = commandData.Application;
            //Application app = uiApp.Application;
            //UIDocument uiDoc = uiApp.ActiveUIDocument;
            //Document doc = uiDoc.Document;
            //Settings documentSettings = doc.Settings;
            //string prompt = "Numbers of all categories in current Revit document:"+documentSettings.Categories.Size+"\n";
            ////用BuiltInCategory枚举值取到一个对应的Floor_Category,打印其名字。
            //Category floorCategory = documentSettings.Categories.get_Item(BuiltInCategory.OST_Floors);
            //prompt += "Get floor category and show the name:";
            //prompt += floorCategory.Name;
            //TaskDialog.Show("Revit",prompt);
            //return Result.Succeeded;


            //**************************************************************************
            //***********2-3:使用message参数********************************************
            //*************************************************************************
            //message = "message test.";
            //return Result.Failed;


            //*************************************************************************
            //************2-4：使用elements参数*****************************************
            //*************************************************************************
            //message = "Please take attention on the hightlighted Walls!";
            //ElementSet elems = commandData.Application.ActiveUIDocument.Selection.Elements;
            //foreach (Element elem in elems)
            //{
            //    Wall wall = elem as Wall;
            //    if (null != wall)
            //    {
            //        elements.Insert(elem);
            //    }
            //}
            //return Result.Failed;


            //*************************************************************************
            //************2-5：外部命令中Execute*****************************************
            //*************************************************************************
            //try
            //{
            //    UIDocument uiDoc = commandData.Application.ActiveUIDocument;
            //    Document doc = uiDoc.Document;
            //    List<ElementId> selectedElem = new List<ElementId>();
            //    foreach (Element elem in uiDoc.Selection.Elements)
            //    {
            //        selectedElem.Add(elem.Id);
            //    }
            //    Transaction trans = new Transaction(doc,"Delete selectedelems");

            //    TaskDialogResult result = TaskDialog.Show("Revit",
            //                                              "Yes to delete all selection, No to cancel all commands.",
            //                                              TaskDialogCommonButtons.Yes|TaskDialogCommonButtons.No);

            //    if (result == TaskDialogResult.Yes)
            //    {
            //        trans.Start();
            //        doc.Delete(selectedElem);
            //        trans.Commit();
            //        return Result.Succeeded;
            //    }
            //    else if (result == TaskDialogResult.No)
            //    {
            //        message = "Failed to delete selection.";
            //        return Result.Failed;
            //    }
            //    else
            //    {
            //        return Result.Cancelled;
            //    }

            //}
            //catch
            //{
            //    message = "Unexpected Exception is thrown out.";
            //    return Result.Failed;
            //}




        }
    }
}
