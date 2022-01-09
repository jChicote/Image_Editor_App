using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Image_Editor.Models;

namespace Image_Editor.Data
{
    public class ImageDB_EditorContext : DbContext
    {
        public ImageDB_EditorContext (DbContextOptions<ImageDB_EditorContext> options)
            : base(options)
        {
        }

        public DbSet<Image_Editor.Models.Image> Image { get; set; }
    }
}
