using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows.Forms;

namespace TestForm
{
    [Transaction(TransactionMode.Manual)]
    public class Command:IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet element)
        {
            Document doc = commandData.Application.ActiveUIDocument.Document;
            GetElemType elem = new GetElemType(doc);
            Form1 form = new Form1(elem);
            form.Show();
            

            return Result.Succeeded;
        }
    }

    public class GetElemType
    {
        private int elemId;
        public int ElemId
        {
            get { return elemId; }
            set { elemId = value; }
        }

        private Element elem;
        public Element Elem
        {
            get { return elem; }
            set { elem = value; }
        }

        public GetElemType(Document doc)
        {
            ElementId elemid = new ElementId(elemId);
            elem=doc.GetElement(elemid);
        }

    }
}
