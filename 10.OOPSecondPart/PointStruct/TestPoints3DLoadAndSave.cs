using System;
using System.Linq;

namespace PointStruct
{
    class TestPoints3DLoadAndSave
    {
        static void Main()
        {
            //initialize some points in the Path
            Path p = new Path();
            p.AddPoint(new Point3D(1, 2, 3));
            p.AddPoint(new Point3D(5, 2, 6));
            p.AddPoint(new Point3D(1, 3, 5));
            p.AddPoint(new Point3D(-5, 2, 3));
            p.AddPoint(new Point3D(-2, -10, 3));

            PathStorage.SavePath(p); //Save path in file savedPaths.txt
            Path final = PathStorage.LoadPath(); //loading from the file savedPaths.txt

            final.PrintPathList(); //printing the loaded path
        }
    }
}
