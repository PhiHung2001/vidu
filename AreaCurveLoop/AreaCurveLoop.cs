using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCurveLoop
{
    public class AreaCurveLoop
    {
        public double AreaFromListCurveLoop(IList<CurveLoop> curveLoopList)
        {
            double area = 0.0;
            SolidOptions options = new SolidOptions(ElementId.InvalidElementId, ElementId.InvalidElementId);

            Solid solid = GeometryCreationUtilities.CreateExtrusionGeometry(curveLoopList, XYZ.BasisZ, 1.0, options);

            Face face = solid.Faces.get_Item(0) as Face;

            return face.Area/10.763;
        }
        
    }

}
