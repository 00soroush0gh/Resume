using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjLoader.Loader.Loaders;

namespace Resume.Domain.FormatLoaders;

public class ObjLoader
{
    public void LoadObjFile(string filePath)
    {
        var objLoaderFactory = new ObjLoaderFactory();
        var objLoader = objLoaderFactory.Create();

        using (var fileStream = new FileStream(filePath, FileMode.Open))
        {
            var result = objLoader.Load(fileStream);

            // Access the loaded model data if needed to load directly in site

            //foreach (var vertex in result.Vertices)
            //{
            //    // Process vertex data (X, Y, Z coordinates)
            //    Console.WriteLine($"Vertex: {vertex.X}, {vertex.Y}, {vertex.Z}");
            //}
        }
    }
}
