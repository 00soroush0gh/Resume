using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.Models;

public class RePresentiveSample
{
    private readonly IRepresentiveOptions _options;
    private readonly RePresentationWay _way;
    //i'll complete this later.
    //its 4am...
    //none of these are worth it...
    //i should've chose the plan B...
}
public interface IRepresentiveOptions
{
    public void GetRepresentiveOptions(int _RePresentationWay)
    {
        switch (_RePresentationWay)
        {
            case 0:
                // a void that handles links
                break;
            case 1:
                //a void that uploads directly from employee's device to a database
                break;
            case 2:
                //a void that adds employee's git account to it's account.
                break;
            default:
                break;
        }
    }
}
public enum RePresentationWay
{ 
    ByLink,
    ByUpload,
    ByGit
}
public enum UploadFormat
{
    PDF,
    Bitmap_Image,
    TextFile,
    RTF_Text,
    Doc,
    DocX,
    XLS,
    XLSX,
    PPT,
    PPTX,
    Wav,
    dae, //Collada
    abc, //Alembic
    usd, //Universal scene description
    SVG, //Graese Pencil setup
    obj, //wavefront
    ply, //Standford PLY
    stl, //STL
    bvh, //Motion Capture
    svg, //Scalable vector Graphics
    fbx, //FBX
    glb,gltf, //glTF 2.0
    x3d,wrl //X3D Extensible 3D
}

