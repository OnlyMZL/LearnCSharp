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
            //*****************************************************************
            //************2-30：通过过滤器取到元素********************************
            //*****************************************************************
            UIApplication uiApp = commandData.Application;
            Application app = uiApp.Application;
            UIDocument uiDoc = uiApp.ActiveUIDocument;
            Document doc = uiDoc.Document;
            try
            {
                //创建一个类过滤器，取得FamilyInstance
                ElementClassFilter elementClassFilter = new ElementClassFilter(typeof(FamilyInstance));
                //创建一个类别过滤器，取得BuiltInCategory为OST_Door的元素
                ElementCategoryFilter elementCategoryFilter = new ElementCategoryFilter(BuiltInCategory.OST_Doors);
                //创建一个逻辑过滤器，取得所有的Door元素
                LogicalAndFilter elementLogicalFilter = new LogicalAndFilter(elementClassFilter,elementCategoryFilter);
                FilteredElementCollector collector = new FilteredElementCollector(doc);
                ICollection<Element> doors = collector.WherePasses(elementLogicalFilter).ToElements();
                string info = "Doors' name:";
                foreach (Element door in doors)
                {
                    info += "\t\n"+door.Name.ToString();
                }
                TaskDialog.Show("Filter", info);
            }
            catch (Exception e)
            {
                message = e.Message;
                return Result.Failed;
            }
            return Result.Succeeded;





            //*****************************************************************
            //************2-29：在外部命令运行过程中选择元素********************************
            //*****************************************************************
            //UIApplication uiApp = commandData.Application;
            //Application app = uiApp.Application;
            //UIDocument uiDoc = uiApp.ActiveUIDocument;
            //Document doc = uiDoc.Document;
            //try
            //{
            //    Reference pickedElemRef = uiDoc.Selection.PickObject(ObjectType.Element);
            //    Element elem = uiDoc.Document.GetElement(pickedElemRef);
            //    string info = "The picked element type is: \t\n" + elem.GetType().ToString();
            //    TaskDialog.Show("Selection", info);
            //}
            //catch (Exception e)
            //{
            //    message = e.Message;
            //    return Result.Failed;
            //}
            //return Result.Succeeded;




            //*****************************************************************
            //************2-22：使用Assimilate方法********************************
            //*****************************************************************
            //UIApplication uiApp = commandData.Application;
            //Application app = uiApp.Application;
            //UIDocument uiDoc = uiApp.ActiveUIDocument;
            //Document doc = uiDoc.Document;
            //CompoundOperation(doc);
            //return Result.Succeeded;




            //********************************************************************
            //************2-28：先选择元素后执行命令********************************
            //*********************************************************************
            //UIApplication uiApp = commandData.Application;
            //Application app = uiApp.Application;
            //UIDocument uiDoc = uiApp.ActiveUIDocument;
            //Document doc = uiDoc.Document;
            //try
            //{
            //    //在执行此命令之前，先选择一些元素。
            //    Selection selectionElems = uiDoc.Selection;
            //    ElementSet elemsCollection = selectionElems.Elements;
            //    if (elemsCollection.Size == 0)
            //    {
            //        TaskDialog.Show("Warning", "Please pick some objections.");
            //    }
            //    else
            //    {
            //        string info = "The elements you have picked are:";
            //        foreach (Element elem in elemsCollection)
            //        {
            //            info += "\t\n"+elem.GetType().ToString();
            //        }
            //        TaskDialog.Show("Selections",info);
            //    }
            //}
            //catch(Exception e)
            //{
            //    message = e.Message;
            //    return Result.Failed;
            //}
            //return Result.Succeeded;







            //*****************************************************************
            //************2-21：使用事务创建元素********************************
            //*****************************************************************
            //UIApplication uiApp = commandData.Application;

            ////调用CreatingSketch方法
            //CreatingSketch(uiApp);

            //return Result.Succeeded;


            //*****************************************************************
            //************2-19：使用Category Id***********************************
            //*****************************************************************
            #region
            //UIApplication uiApp = commandData.Application;
            //Application app = uiApp.Application;
            //UIDocument uiDoc = uiApp.ActiveUIDocument;
            //Document doc = uiDoc.Document;
            //Element selectedElem = null;
            //foreach (Element elem in uiDoc.Selection.Elements)
            //{
            //    selectedElem = elem;
            //    break;
            //}
            ////Get current element's category.
            //Category category = selectedElem.Category;
            //BuiltInCategory enumCategory = (BuiltInCategory)category.Id.IntegerValue;
            //TaskDialog.Show("Revit",enumCategory.ToString());
            //return Result.Succeeded;
            #endregion


            //*****************************************************************
            //************2-18：从setting中取到当前文档的Categories*************
            //*****************************************************************
            #region
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
            #endregion

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
            #region
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
            #endregion



        }
        #region CreatingSketch方法
        public void CreatingSketch(UIApplication uiApplication)
        {
            Document document = uiApplication.ActiveUIDocument.Document;
            Application application = uiApplication.Application;

            //创建一些几何线，这些线是临时的，所以不需要放到事务里。
            XYZ p1 = XYZ.Zero;
            XYZ p2 = new XYZ(10,0,0);
            XYZ p3 = new XYZ(10, 10, 0);
            XYZ p4 = new XYZ(0, 10, 0);

            Line geomline1 = Line.CreateBound(p1,p2);
            Line geomline2 = Line.CreateBound(p4,p3);
            Line geomline3 = Line.CreateBound(p1,p4);

            //这个平面也是临时的，不需要事务。
            XYZ origin = XYZ.Zero;
            XYZ normal = new XYZ(0,0,1);
            Plane geomPlane = application.Create.NewPlane(normal,origin);

            //为了创建SketchPlane，我们需要一个事务，因为这个会修改Revit文档模型。

            //任何Transaction要放在 using 中创建
            //来保证它被正确的结束，而不会影响到其他地方。
            using (Transaction trans = new Transaction(document, "Create model curves."))
            {
                if (trans.Start() == TransactionStatus.Started)
                {
                    //在当前文档中创建一个SketchPlane
                    SketchPlane sketch = SketchPlane.Create(document,geomPlane);

                    //使用SketchPlane和几何线来创建一个ModelLine
                    ModelLine line1 = document.Create.NewModelCurve(geomline1, sketch) as ModelLine;
                    ModelLine line2 = document.Create.NewModelCurve(geomline2, sketch) as ModelLine;
                    ModelLine line3 = document.Create.NewModelCurve(geomline3, sketch) as ModelLine;

                    //询问用户这个修改是否提交
                    TaskDialogResult result = TaskDialog.Show("Revit",
                                                              "Click OK to commit, or Cancle to roll back.",
                                                              TaskDialogCommonButtons.Ok|TaskDialogCommonButtons.Cancel);
                    if (result == TaskDialogResult.Ok)
                    {
                        //trans.Commit()==TransactionStatus.Commited

                        //如果修改或创建的模型不正确
                        //这个Trans可能不会被正确提交
                        //或者如果trans被用户取消或是失败了
                        //那么返回的状态不是Commited
                        if (trans.Commit() != TransactionStatus.Committed)
                        {
                            TaskDialog.Show("Failure!", "Transaction could not be commited");
                        }
                    }
                    else
                    {
                        trans.RollBack();
                    }
                }
            }
        }
        #endregion

        //CreateLevle方法
        public bool CreateLevel(Document document, double elevation)
        {
            using (Transaction trans = new Transaction(document, "Create level"))
            {
                if (TransactionStatus.Started == trans.Start())
                {
                    if (null != document.Create.NewLevel(elevation))
                    {
                        return (TransactionStatus.Committed==trans.Commit());
                    }
                    trans.RollBack();

                }

            }
            return false;
        }

        //CreateGrid方法
        public bool CreateGrid(Document document, XYZ p1, XYZ p2)
        {
            using (Transaction trans = new Transaction(document, "Create grid"))
            {
                if (trans.Start() == TransactionStatus.Started)
                {
                    Line gridLine = Line.CreateBound(p1, p2);
                    if ((null != gridLine) && (null != document.Create.NewGrid(gridLine)))
                    {
                       return (trans.Commit() == TransactionStatus.Committed);
                    }
                    trans.RollBack();

                }

            }
            return false;
        }

        //CompoundOperation方法
        public void CompoundOperation(Document doc)
        {
            using (TransactionGroup transGroup = new TransactionGroup(doc, "Level and Grid"))
            {
                if (transGroup.Start() == TransactionStatus.Started)
                {
                    if (CreateLevel(doc, 25) && CreateGrid(doc, new XYZ(0, 0, 0), new XYZ(10, 0, 0)))
                    {
                        transGroup.Assimilate();
                    }
                }
                else
                    transGroup.RollBack();
            }
        }
    }
}
