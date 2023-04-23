using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new VidzyDbContext())
            {
                var genres = context.Genres.ToList();

                for (byte i = 1; i < 4; i++)
                {
                    var v = new Video();

                    v.Name = "video" + Convert.ToString(i);
                    v.ReleaseDate = DateTime.Now;
                    v.GenreId = genres.FirstOrDefault().Id;
                    v.Classification = Classification.GOLD;

                    context.AddVideo(v.Name, v.ReleaseDate, v.GenreId,Convert.ToByte(Classification.GOLD));
                }
            }
        }
    }
}
