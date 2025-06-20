using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompositeController : ControllerBase
    {
        /// <summary>
        /// Demonstrates the Composite pattern with a file/folder structure.
        /// </summary>
        [HttpGet("structure")]
        public IActionResult Structure()
        {
            var root = new DesignPatternsDemo.Composite.Directory("Root");
            var file1 = new DesignPatternsDemo.Composite.File("File1.txt");
            var file2 = new DesignPatternsDemo.Composite.File("File2.txt");
            var subDir = new DesignPatternsDemo.Composite.Directory("SubFolder");
            subDir.Add(new DesignPatternsDemo.Composite.File("SubFile.txt"));
            root.Add(file1);
            root.Add(file2);
            root.Add(subDir);
            var sb = new StringBuilder();
            void CaptureDisplay(DesignPatternsDemo.Composite.IFileSystemItem item, string indent = "")
            {
                if (item is DesignPatternsDemo.Composite.Directory dir)
                {
                    sb.AppendLine($"{indent}+ {dir.Name}");
                    var children = dir.GetType().GetField("_children", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(dir) as System.Collections.IEnumerable;
                    foreach (var child in children)
                        CaptureDisplay((DesignPatternsDemo.Composite.IFileSystemItem)child, indent + "  ");
                }
                else if (item is DesignPatternsDemo.Composite.File f)
                {
                    sb.AppendLine($"{indent}- {f.Name}");
                }
            }
            CaptureDisplay(root);
            return Ok(new { Pattern = "Composite", Structure = sb.ToString() });
        }
    }
}
